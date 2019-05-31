using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.AddDialogs
{
    public partial class AddDialogProductListForm : Form
    {
        public AddDialogProductListForm()
        {
            InitializeComponent();

            using (PharmacyEntities db = new PharmacyEntities())
            {
                foreach (var item in db.MedicalPreparations)
                {
                    medicalPreparationsComboBox.Items.Add(item.NamePreparation);
                }
                foreach (var item in db.PointsOfSale)
                {
                    pointsOfSaleComboBox.Items.Add(item.AddressOfPoint);
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e) 
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                ProductList buff = new ProductList();

                try
                {
                    buff.ProductID = Convert.ToInt32(idTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверно введенные данные!");
                    return;
                }

                foreach (var item in db.MedicalPreparations)
                {
                    if (medicalPreparationsComboBox.Text == item.NamePreparation)
                    {
                        buff.ProductID = item.id;
                        break;
                    }
                }

                foreach (var item in db.PointsOfSale)
                {
                    if (pointsOfSaleComboBox.Text == item.AddressOfPoint)
                    {
                        buff.PointOfSaleID = item.id;
                        break;
                    }
                }

                buff.shelfLife = dateTimePicker1.Value;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("ID не должен повторяться!");
                    return;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

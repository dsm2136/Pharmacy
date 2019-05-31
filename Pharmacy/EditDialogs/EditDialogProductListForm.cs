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

namespace Pharmacy.EditDialogs
{
    public partial class EditDialogProductListForm : Form
    {
        private int id;

        public EditDialogProductListForm(int id)
        {
            InitializeComponent();

            using (PharmacyEntities db = new PharmacyEntities())
            {
                idTextBox.Text = db.ProductList.Find(id).id.ToString();

                foreach (var item in db.MedicalPreparations)
                {
                    medicalPreparationsComboBox.Items.Add(item.NamePreparation);
                }
                foreach (var item in db.PointsOfSale)
                {
                    pointsOfSaleComboBox.Items.Add(item.AddressOfPoint);
                }

                dateTimePicker.Value = db.ProductList.Find(id).shelfLife;
            }

            

            this.id = id;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                try
                {
                    db.ProductList.Find(id).id = Convert.ToInt32(idTextBox.Text);
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
                        db.ProductList.Find(id).ProductID = item.id;
                    }
                }

                foreach (var item in db.PointsOfSale)
                {
                    if (pointsOfSaleComboBox.Text == item.AddressOfPoint)
                    {
                        db.ProductList.Find(id).PointOfSaleID = item.id;
                    }
                }

                db.ProductList.Find(id).shelfLife = dateTimePicker.Value;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Ошибка");
                    return;
                }
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

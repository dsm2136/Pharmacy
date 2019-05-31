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
    public partial class AddDialogMedicalPreparationsForm : Form
    {
        public AddDialogMedicalPreparationsForm()
        {
            InitializeComponent();

            using (PharmacyEntities db = new PharmacyEntities())
            {
                foreach (var item in db.Manufactures)
                {
                    manufacturesComboBox.Items.Add(item.NameManufacture);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                MedicalPreparations buff = new MedicalPreparations();

                try
                {
                    buff.id = Convert.ToInt32(idTextBox.Text);
                    buff.NamePreparation = nameTextBox.Text;
                    
                    foreach (var item in db.Manufactures)
                    {
                        if (manufacturesComboBox.Text == item.NameManufacture)
                        {
                            buff.ManufactureID = item.id;
                            break;
                        }
                    }

                    buff.Price = Convert.ToDouble(priceTextBox.Text);
                    buff.CountInPackage = Convert.ToInt32(countTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверно введенные данные!");
                    return;
                }

                db.MedicalPreparations.Add(buff); 

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

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

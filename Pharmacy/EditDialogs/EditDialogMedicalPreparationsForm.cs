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
    public partial class EditDialogMedicalPreparationsForm : Form
    {
        private int id;

        public EditDialogMedicalPreparationsForm(int id)
        {
            InitializeComponent();

            using (PharmacyEntities db = new PharmacyEntities()) 
            {
                nameTextBox.Text = db.MedicalPreparations.Find(id).NamePreparation;

                foreach (var items in db.Manufactures) 
                {
                    manufacturesComboBox.Items.Add(items.NameManufacture);
                }

                priceTextBox.Text = db.MedicalPreparations.Find(id).Price.ToString();

                countTextBox.Text = db.MedicalPreparations.Find(id).CountInPackage.ToString();

                this.id = id;
            }
        }
        
        private void editButton_Click_1(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                db.MedicalPreparations.Find(id).NamePreparation = nameTextBox.Text;

                foreach (var item in db.Manufactures)
                {
                    if (manufacturesComboBox.Text == item.NameManufacture)
                    {
                        db.MedicalPreparations.Find(id).ManufactureID = item.id;
                        break;
                    }
                }

                try
                {
                    db.MedicalPreparations.Find(id).Price = Convert.ToDouble(priceTextBox.Text);
                    db.MedicalPreparations.Find(id).CountInPackage = Convert.ToInt32(countTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверно введенные данные!");
                    return;
                }

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("ID не должен повторяться!");
                    return;
                }

                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
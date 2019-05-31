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
    public partial class EditDialogManufacturesForm : Form
    {
        private int id;
        public EditDialogManufacturesForm(int id)
        {
            InitializeComponent();

            using (PharmacyEntities db = new PharmacyEntities())
            {
                nameTextBox.Text = db.Manufactures.Find(id).NameManufacture; 
            }

            this.id = id;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                db.Manufactures.Find(this.id).NameManufacture = nameTextBox.Text;

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

        public static implicit operator EditDialogManufacturesForm(AddDialogManufactureForm v)
        {
            throw new NotImplementedException();
        }
    }
}

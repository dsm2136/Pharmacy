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
    public partial class EditDialogPointsOfSaleForm : Form
    {
        private int id;

        public EditDialogPointsOfSaleForm(int id)
        {
            InitializeComponent();

            using (PharmacyEntities db = new PharmacyEntities())
            {
                adressTexBox.Text = db.PointsOfSale.Find(id).AddressOfPoint;

                this.id = id;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                db.PointsOfSale.Find(id).AddressOfPoint = adressTexBox.Text;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Ошибка!");
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

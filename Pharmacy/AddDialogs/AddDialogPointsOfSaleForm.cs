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
    public partial class AddDialogPointsOfSaleForm : Form
    {
        public AddDialogPointsOfSaleForm()
        {
            InitializeComponent();
        }
        private void addButton_Click_1(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                PointsOfSale buff = new PointsOfSale();

                try
                {
                    buff.id = Convert.ToInt32(idTextBox.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверно введенные данные!");
                    return;
                }

                buff.AddressOfPoint = adressTexBox.Text;
                db.PointsOfSale.Add(buff);

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
            Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

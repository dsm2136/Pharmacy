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

namespace Pharmacy
{
    public partial class AddDialogManufactureForm : Form
    {
        public AddDialogManufactureForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        { 
            using (PharmacyEntities db = new PharmacyEntities())
            {
                Manufactures buff = new Manufactures();

                try
                {
                    buff.id = Convert.ToInt32(idTextBox.Text);
                    buff.NameManufacture = nameTextBox.Text;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неверно введённые данные!");
                    return;
                }

                db.Manufactures.Add(buff);

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

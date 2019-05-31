using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Opacity = 0;

            LogInForm logform = new LogInForm();
        LogInForm:
            if (logform.ShowDialog()==DialogResult.OK)
            {

                if (logform.txtPassword.Text == "1234" && logform.txtUsername.Text == "admin")
                {
                    logform.Close();
                    this.Opacity = 100;
                }
                else
                {
                    MessageBox.Show("Неверный пароль!");
                    goto LogInForm;
                }

            }

            dataGridView.MultiSelect = false;

            using (PharmacyEntities db = new PharmacyEntities())
            {
                foreach(var item in db.PointsOfSale)
                {
                    toolStripComboBox1.Items.Add(item.AddressOfPoint);
                }
            }
        }

        private void TablesToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeRows();
        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            switch (tablesToolStripComboBox.SelectedIndex)
            {
                case 0:
                    using (AddDialogManufactureForm addDialog = new AddDialogManufactureForm())
                    {
                        addDialog.ShowDialog();
                    }
                    
                    InitializeRows();
                    break;
                case 1:
                    using (AddDialogs.AddDialogMedicalPreparationsForm addDialog = new AddDialogs.AddDialogMedicalPreparationsForm())
                    {
                        addDialog.ShowDialog();
                    }

                    InitializeRows();
                    break;
                case 2:
                    using (AddDialogs.AddDialogPointsOfSaleForm addDialog = new AddDialogs.AddDialogPointsOfSaleForm())
                    {
                        addDialog.ShowDialog();
                    }

                    InitializeRows();
                    break;
                case 3:
                    using (AddDialogs.AddDialogProductListForm addDialog = new AddDialogs.AddDialogProductListForm())
                    {
                        addDialog.ShowDialog();
                    }

                    InitializeRows();
                    break;
            }
        }

        private void EditToolStripButton_Click(object sender, EventArgs e)
        {
            switch (tablesToolStripComboBox.SelectedIndex)
            {
                case 0:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (EditDialogs.EditDialogManufacturesForm editDialog = new EditDialogs.EditDialogManufacturesForm((int)(item as DataGridViewRow).Cells[0].Value))
                            {
                                editDialog.ShowDialog();
                            }
                            break;
                        }
                    }

                    InitializeRows();  
                    break;
                case 1:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected) 
                        {
                            using (EditDialogs.EditDialogMedicalPreparationsForm editDialog = new EditDialogs.EditDialogMedicalPreparationsForm((int)(item as DataGridViewRow).Cells[0].Value))
                            {
                                editDialog.ShowDialog(); 
                            }
                            break;
                        }
                    }

                    InitializeRows();
                    break;
                case 2:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (EditDialogs.EditDialogPointsOfSaleForm editDialog = new EditDialogs.EditDialogPointsOfSaleForm((int)(item as DataGridViewRow).Cells[0].Value))
                            {
                                editDialog.ShowDialog();
                            }
                            break;
                        }
                    }
                    break;
                case 3:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (EditDialogs.EditDialogProductListForm editDialog = new EditDialogs.EditDialogProductListForm((int)(item as DataGridViewRow).Cells[0].Value))
                            {
                                editDialog.ShowDialog();
                            }
                            break;
                        }
                    }
                    break; 
            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            switch (tablesToolStripComboBox.SelectedIndex)
            {
                case 0:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (PharmacyEntities db = new PharmacyEntities())
                            {
                                var buff = db.Manufactures.Find((int)(item as DataGridViewRow).Cells[0].Value);
                                db.Manufactures.Remove(buff);

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

                            break;
                        }
                    }

                    InitializeRows();
                    break;
                case 1:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (PharmacyEntities db = new PharmacyEntities())
                            {
                                var buff = db.MedicalPreparations.Find((int)(item as DataGridViewRow).Cells[0].Value);
                                db.MedicalPreparations.Remove(buff);

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

                            break;
                        }
                    }

                    InitializeRows();
                    break;
                case 2:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (PharmacyEntities db = new PharmacyEntities())
                            {
                                var buff = db.PointsOfSale.Find((int)(item as DataGridViewRow).Cells[0].Value);
                                db.PointsOfSale.Remove(buff);

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

                            break;
                        }
                    }

                    InitializeRows();
                    break;
                case 3:
                    foreach (var item in dataGridView.Rows)
                    {
                        if ((item as DataGridViewRow).Selected)
                        {
                            using (PharmacyEntities db = new PharmacyEntities())
                            {
                                var buff = db.ProductList.Find((int)(item as DataGridViewRow).Cells[0].Value);
                                db.ProductList.Remove(buff);

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

                            break;
                        }
                    }

                    InitializeRows();
                    break;
            }
        }

        private void InitializeRows()
        {
            dataGridView.DataSource = null;
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            using (PharmacyEntities db = new PharmacyEntities())
            {
                switch (tablesToolStripComboBox.SelectedIndex)
                {
                    case 0:
                        db.Manufactures.Load();
                        dataGridView.DataSource = db.Manufactures.Local;

                        dataGridView.Columns[0].HeaderText = "ID Производителя";
                        dataGridView.Columns[0].Width = 125;
                        dataGridView.Columns[1].HeaderText = "Производитель";
                        dataGridView.Columns[2].Visible = false;
                        break;
                    case 1:
                        db.MedicalPreparations.Load();
                        dataGridView.DataSource = db.MedicalPreparations.Local;

                        dataGridView.Columns[0].HeaderText = "ID препарата";
                        dataGridView.Columns[0].Width = 125;
                        dataGridView.Columns[1].HeaderText = "Препарат";
                        dataGridView.Columns[2].HeaderText = "Производитель";
                        dataGridView.Columns[3].HeaderText = "Цена";
                        dataGridView.Columns[4].HeaderText = "Штук в упаковке";
                        dataGridView.Columns[4].Width = 125;
                        dataGridView.Columns[5].Visible = false;
                        dataGridView.Columns[6].Visible = false;
                        break;
                    case 2:
                        db.PointsOfSale.Load();
                        dataGridView.DataSource = db.PointsOfSale.Local;
                        dataGridView.Columns[2].Visible = false;
                        break;
                    case 3:
                        db.ProductList.Load();
                        dataGridView.DataSource = db.ProductList.Local;
                        dataGridView.Columns[4].Visible = false;
                        dataGridView.Columns[5].Visible = false;
                        break;
                }
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                foreach (var item in db.ProductList)
                {
                    if (toolStripComboBox1.Text.ToString() == item.PointsOfSale.AddressOfPoint)
                    {
                        db.ProductList.Load();
                        dataGridView.DataSource = db.ProductList.Local.Where(items => items.PointOfSaleID == item.PointsOfSale.id).ToList();

                        dataGridView.Columns[4].Visible = false;
                        dataGridView.Columns[5].Visible = false;
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (PharmacyEntities db = new PharmacyEntities())
            {
                db.ProductList.RemoveRange(db.ProductList.Where(items => items.shelfLife < DateTime.Now));
                db.SaveChanges();

                InitializeRows();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            {
                using (PharmacyEntities db = new PharmacyEntities())
                {
                    db.MedicalPreparations.Load();
                    dataGridView.DataSource = db.MedicalPreparations.Local.Where(items => items.CountInPackage >= 100).ToList();

                    dataGridView.Columns[0].HeaderText = "ID препарата";
                    dataGridView.Columns[0].Width = 125;
                    dataGridView.Columns[1].HeaderText = "Препарат";
                    dataGridView.Columns[2].HeaderText = "Производитель";
                    dataGridView.Columns[3].HeaderText = "Цена";
                    dataGridView.Columns[4].HeaderText = "Штук в упаковке";
                    dataGridView.Columns[4].Width = 125;
                    dataGridView.Columns[5].Visible = false;
                    dataGridView.Columns[6].Visible = false;
                }
            }
        }
    }
}
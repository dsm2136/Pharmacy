namespace Pharmacy.EditDialogs
{
    partial class EditDialogProductListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pointsOfSaleComboBox = new System.Windows.Forms.ComboBox();
            this.medicalPreparationsComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(137, 86);
            this.dateTimePicker.Name = "dateTimePicker1";
            this.dateTimePicker.Size = new System.Drawing.Size(264, 20);
            this.dateTimePicker.TabIndex = 43;
            // 
            // pointsOfSaleComboBox
            // 
            this.pointsOfSaleComboBox.FormattingEnabled = true;
            this.pointsOfSaleComboBox.Location = new System.Drawing.Point(137, 59);
            this.pointsOfSaleComboBox.Name = "pointsOfSaleComboBox";
            this.pointsOfSaleComboBox.Size = new System.Drawing.Size(264, 21);
            this.pointsOfSaleComboBox.TabIndex = 42;
            // 
            // medicalPreparationsComboBox
            // 
            this.medicalPreparationsComboBox.FormattingEnabled = true;
            this.medicalPreparationsComboBox.Location = new System.Drawing.Point(137, 32);
            this.medicalPreparationsComboBox.Name = "medicalPreparationsComboBox";
            this.medicalPreparationsComboBox.Size = new System.Drawing.Size(264, 21);
            this.medicalPreparationsComboBox.TabIndex = 41;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(137, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(264, 20);
            this.idTextBox.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Срок годности";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Точка продажи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Препарат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID:";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(326, 141);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(245, 141);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 34;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // EditDialogProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 176);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pointsOfSaleComboBox);
            this.Controls.Add(this.medicalPreparationsComboBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.editButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDialogProductListForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EditDialogProductListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox pointsOfSaleComboBox;
        private System.Windows.Forms.ComboBox medicalPreparationsComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button editButton;
    }
}
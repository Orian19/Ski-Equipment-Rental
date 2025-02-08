namespace Ski_Equipment_Rental.UI
{
    partial class Form_Payment
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
            this.Exit_panel = new System.Windows.Forms.Panel();
            this.Headline_label = new System.Windows.Forms.Label();
            this.Exit_label = new System.Windows.Forms.Label();
            this.ReturnDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RentDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ReturnDate_label = new System.Windows.Forms.Label();
            this.RentDate_label = new System.Windows.Forms.Label();
            this.Price_label = new System.Windows.Forms.Label();
            this.AmountPaid_textBox = new System.Windows.Forms.TextBox();
            this.AmountPaid_label = new System.Windows.Forms.Label();
            this.IDnum_Label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.PriceNum_label = new System.Windows.Forms.Label();
            this.TaxNum_label = new System.Windows.Forms.Label();
            this.Tax_label = new System.Windows.Forms.Label();
            this.FinalPriceNum_label = new System.Windows.Forms.Label();
            this.FinalPrice_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Confirm_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pay_button = new System.Windows.Forms.Button();
            this.Exit_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_panel
            // 
            this.Exit_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Exit_panel.Controls.Add(this.Headline_label);
            this.Exit_panel.Controls.Add(this.Exit_label);
            this.Exit_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit_panel.Location = new System.Drawing.Point(0, 0);
            this.Exit_panel.Name = "Exit_panel";
            this.Exit_panel.Size = new System.Drawing.Size(284, 35);
            this.Exit_panel.TabIndex = 78;
            // 
            // Headline_label
            // 
            this.Headline_label.AutoSize = true;
            this.Headline_label.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline_label.ForeColor = System.Drawing.Color.Black;
            this.Headline_label.Location = new System.Drawing.Point(106, 3);
            this.Headline_label.Name = "Headline_label";
            this.Headline_label.Size = new System.Drawing.Size(73, 29);
            this.Headline_label.TabIndex = 92;
            this.Headline_label.Text = "תשלום";
            // 
            // Exit_label
            // 
            this.Exit_label.AutoSize = true;
            this.Exit_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit_label.Location = new System.Drawing.Point(12, 5);
            this.Exit_label.Name = "Exit_label";
            this.Exit_label.Size = new System.Drawing.Size(23, 25);
            this.Exit_label.TabIndex = 3;
            this.Exit_label.Text = "x";
            this.Exit_label.Click += new System.EventHandler(this.Exit_label_Click);
            // 
            // ReturnDate_dateTimePicker
            // 
            this.ReturnDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate_dateTimePicker.Location = new System.Drawing.Point(23, 72);
            this.ReturnDate_dateTimePicker.MaxDate = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.ReturnDate_dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ReturnDate_dateTimePicker.Name = "ReturnDate_dateTimePicker";
            this.ReturnDate_dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.ReturnDate_dateTimePicker.TabIndex = 79;
            this.ReturnDate_dateTimePicker.Value = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            // 
            // RentDate_dateTimePicker
            // 
            this.RentDate_dateTimePicker.Enabled = false;
            this.RentDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.RentDate_dateTimePicker.Location = new System.Drawing.Point(23, 46);
            this.RentDate_dateTimePicker.MaxDate = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.RentDate_dateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.RentDate_dateTimePicker.Name = "RentDate_dateTimePicker";
            this.RentDate_dateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.RentDate_dateTimePicker.TabIndex = 80;
            this.RentDate_dateTimePicker.Value = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            // 
            // ReturnDate_label
            // 
            this.ReturnDate_label.AutoSize = true;
            this.ReturnDate_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDate_label.Location = new System.Drawing.Point(143, 69);
            this.ReturnDate_label.Name = "ReturnDate_label";
            this.ReturnDate_label.Size = new System.Drawing.Size(104, 23);
            this.ReturnDate_label.TabIndex = 82;
            this.ReturnDate_label.Text = "תאריך החזרה";
            // 
            // RentDate_label
            // 
            this.RentDate_label.AutoSize = true;
            this.RentDate_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentDate_label.Location = new System.Drawing.Point(128, 43);
            this.RentDate_label.Name = "RentDate_label";
            this.RentDate_label.Size = new System.Drawing.Size(119, 23);
            this.RentDate_label.TabIndex = 81;
            this.RentDate_label.Text = "תאריך ההשכרה";
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(149, 182);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(107, 23);
            this.Price_label.TabIndex = 83;
            this.Price_label.Text = "סכום לתשלום";
            // 
            // AmountPaid_textBox
            // 
            this.AmountPaid_textBox.Location = new System.Drawing.Point(32, 263);
            this.AmountPaid_textBox.Name = "AmountPaid_textBox";
            this.AmountPaid_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AmountPaid_textBox.Size = new System.Drawing.Size(99, 20);
            this.AmountPaid_textBox.TabIndex = 85;
            this.AmountPaid_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // AmountPaid_label
            // 
            this.AmountPaid_label.AutoSize = true;
            this.AmountPaid_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaid_label.Location = new System.Drawing.Point(157, 260);
            this.AmountPaid_label.Name = "AmountPaid_label";
            this.AmountPaid_label.Size = new System.Drawing.Size(99, 23);
            this.AmountPaid_label.TabIndex = 86;
            this.AmountPaid_label.Text = "סכום ששולם";
            // 
            // IDnum_Label
            // 
            this.IDnum_Label.AutoSize = true;
            this.IDnum_Label.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDnum_Label.Location = new System.Drawing.Point(104, 20);
            this.IDnum_Label.Name = "IDnum_Label";
            this.IDnum_Label.Size = new System.Drawing.Size(18, 20);
            this.IDnum_Label.TabIndex = 90;
            this.IDnum_Label.Text = "0";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(201, 17);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(46, 23);
            this.ID_label.TabIndex = 89;
            this.ID_label.Text = "מזהה";
            // 
            // PriceNum_label
            // 
            this.PriceNum_label.AutoSize = true;
            this.PriceNum_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceNum_label.Location = new System.Drawing.Point(82, 182);
            this.PriceNum_label.Name = "PriceNum_label";
            this.PriceNum_label.Size = new System.Drawing.Size(49, 23);
            this.PriceNum_label.TabIndex = 84;
            this.PriceNum_label.Text = "₪0.00";
            // 
            // TaxNum_label
            // 
            this.TaxNum_label.AutoSize = true;
            this.TaxNum_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxNum_label.Location = new System.Drawing.Point(82, 208);
            this.TaxNum_label.Name = "TaxNum_label";
            this.TaxNum_label.Size = new System.Drawing.Size(49, 23);
            this.TaxNum_label.TabIndex = 94;
            this.TaxNum_label.Text = "₪0.00";
            // 
            // Tax_label
            // 
            this.Tax_label.AutoSize = true;
            this.Tax_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax_label.Location = new System.Drawing.Point(210, 208);
            this.Tax_label.Name = "Tax_label";
            this.Tax_label.Size = new System.Drawing.Size(46, 23);
            this.Tax_label.TabIndex = 93;
            this.Tax_label.Text = "מע\"מ";
            // 
            // FinalPriceNum_label
            // 
            this.FinalPriceNum_label.AutoSize = true;
            this.FinalPriceNum_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalPriceNum_label.Location = new System.Drawing.Point(82, 234);
            this.FinalPriceNum_label.Name = "FinalPriceNum_label";
            this.FinalPriceNum_label.Size = new System.Drawing.Size(49, 23);
            this.FinalPriceNum_label.TabIndex = 96;
            this.FinalPriceNum_label.Text = "₪0.00";
            // 
            // FinalPrice_label
            // 
            this.FinalPrice_label.AutoSize = true;
            this.FinalPrice_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalPrice_label.Location = new System.Drawing.Point(174, 234);
            this.FinalPrice_label.Name = "FinalPrice_label";
            this.FinalPrice_label.Size = new System.Drawing.Size(82, 23);
            this.FinalPrice_label.TabIndex = 95;
            this.FinalPrice_label.Text = "סכום כולל";
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Clear_button.Location = new System.Drawing.Point(125, 303);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(52, 28);
            this.Clear_button.TabIndex = 108;
            this.Clear_button.Text = "נקה";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Confirm_button
            // 
            this.Confirm_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Confirm_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Confirm_button.Location = new System.Drawing.Point(23, 98);
            this.Confirm_button.Name = "Confirm_button";
            this.Confirm_button.Size = new System.Drawing.Size(70, 28);
            this.Confirm_button.TabIndex = 107;
            this.Confirm_button.Text = "אישור";
            this.Confirm_button.UseVisualStyleBackColor = false;
            this.Confirm_button.Click += new System.EventHandler(this.Confirm_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Confirm_button);
            this.groupBox1.Controls.Add(this.IDnum_Label);
            this.groupBox1.Controls.Add(this.ID_label);
            this.groupBox1.Controls.Add(this.ReturnDate_label);
            this.groupBox1.Controls.Add(this.RentDate_label);
            this.groupBox1.Controls.Add(this.ReturnDate_dateTimePicker);
            this.groupBox1.Controls.Add(this.RentDate_dateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(256, 138);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "זמן השכרה";
            // 
            // Pay_button
            // 
            this.Pay_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Pay_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pay_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Pay_button.Location = new System.Drawing.Point(32, 303);
            this.Pay_button.Name = "Pay_button";
            this.Pay_button.Size = new System.Drawing.Size(89, 28);
            this.Pay_button.TabIndex = 110;
            this.Pay_button.Text = "בצע תשלום";
            this.Pay_button.UseVisualStyleBackColor = false;
            this.Pay_button.Click += new System.EventHandler(this.Pay_button_Click);
            // 
            // Form_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.Pay_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.FinalPriceNum_label);
            this.Controls.Add(this.FinalPrice_label);
            this.Controls.Add(this.TaxNum_label);
            this.Controls.Add(this.Tax_label);
            this.Controls.Add(this.AmountPaid_textBox);
            this.Controls.Add(this.AmountPaid_label);
            this.Controls.Add(this.PriceNum_label);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.Exit_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Payment";
            this.Exit_panel.ResumeLayout(false);
            this.Exit_panel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Exit_panel;
        private System.Windows.Forms.Label Exit_label;
        private System.Windows.Forms.DateTimePicker ReturnDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker RentDate_dateTimePicker;
        private System.Windows.Forms.Label ReturnDate_label;
        private System.Windows.Forms.Label RentDate_label;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.TextBox AmountPaid_textBox;
        private System.Windows.Forms.Label AmountPaid_label;
        private System.Windows.Forms.Label Headline_label;
        private System.Windows.Forms.Label IDnum_Label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label PriceNum_label;
        private System.Windows.Forms.Button ConfirmPayment_button;
        private System.Windows.Forms.Label TaxNum_label;
        private System.Windows.Forms.Label Tax_label;
        private System.Windows.Forms.Label FinalPriceNum_label;
        private System.Windows.Forms.Label FinalPrice_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Confirm_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Pay_button;
    }
}
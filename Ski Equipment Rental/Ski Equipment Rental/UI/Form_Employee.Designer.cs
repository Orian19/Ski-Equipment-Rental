namespace Ski_Equipment_Rental.UI
{
    partial class Form_Employee
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
            this.Filter_groupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeIdFilter_textBox = new System.Windows.Forms.TextBox();
            this.ClientIdFilter_label = new System.Windows.Forms.Label();
            this.MobilePhoneFilter_textBox = new System.Windows.Forms.TextBox();
            this.LastNameFilter_textBox = new System.Windows.Forms.TextBox();
            this.IDFilter_textBox = new System.Windows.Forms.TextBox();
            this.MobilePhoneFilter_label = new System.Windows.Forms.Label();
            this.LastNameFilter_label = new System.Windows.Forms.Label();
            this.IDFilter_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.City_button = new System.Windows.Forms.Button();
            this.City_comboBox = new System.Windows.Forms.ComboBox();
            this.PhoneNumber_textBox = new System.Windows.Forms.TextBox();
            this.Hyphen_label = new System.Windows.Forms.Label();
            this.PrefixPhone_comboBox = new System.Windows.Forms.ComboBox();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.BirthDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderOther_radioButton = new System.Windows.Forms.RadioButton();
            this.GenderWoman_radioButton = new System.Windows.Forms.RadioButton();
            this.GenderMan_radioButton = new System.Windows.Forms.RadioButton();
            this.Id_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.FirstName_textBox = new System.Windows.Forms.TextBox();
            this.IDnum_Label = new System.Windows.Forms.Label();
            this.Headline_label = new System.Windows.Forms.Label();
            this.EmployeesListBox_label = new System.Windows.Forms.Label();
            this.Employee_listBox = new System.Windows.Forms.ListBox();
            this.City_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Gender_label = new System.Windows.Forms.Label();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PhoneNumber_label = new System.Windows.Forms.Label();
            this.Email_label = new System.Windows.Forms.Label();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_label = new System.Windows.Forms.Label();
            this.Admin_radioButton = new System.Windows.Forms.RadioButton();
            this.Regular_radioButton = new System.Windows.Forms.RadioButton();
            this.IsAdmin_label = new System.Windows.Forms.Label();
            this.CreatingUser_groupBox = new System.Windows.Forms.GroupBox();
            this.ShowPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.Filter_groupBox.SuspendLayout();
            this.CreatingUser_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter_groupBox
            // 
            this.Filter_groupBox.Controls.Add(this.EmployeeIdFilter_textBox);
            this.Filter_groupBox.Controls.Add(this.ClientIdFilter_label);
            this.Filter_groupBox.Controls.Add(this.MobilePhoneFilter_textBox);
            this.Filter_groupBox.Controls.Add(this.LastNameFilter_textBox);
            this.Filter_groupBox.Controls.Add(this.IDFilter_textBox);
            this.Filter_groupBox.Controls.Add(this.MobilePhoneFilter_label);
            this.Filter_groupBox.Controls.Add(this.LastNameFilter_label);
            this.Filter_groupBox.Controls.Add(this.IDFilter_label);
            this.Filter_groupBox.Location = new System.Drawing.Point(441, 32);
            this.Filter_groupBox.Name = "Filter_groupBox";
            this.Filter_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Filter_groupBox.Size = new System.Drawing.Size(197, 128);
            this.Filter_groupBox.TabIndex = 97;
            this.Filter_groupBox.TabStop = false;
            this.Filter_groupBox.Text = "סינון עובדים";
            // 
            // EmployeeIdFilter_textBox
            // 
            this.EmployeeIdFilter_textBox.Location = new System.Drawing.Point(15, 98);
            this.EmployeeIdFilter_textBox.Name = "EmployeeIdFilter_textBox";
            this.EmployeeIdFilter_textBox.Size = new System.Drawing.Size(90, 20);
            this.EmployeeIdFilter_textBox.TabIndex = 7;
            this.EmployeeIdFilter_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            this.EmployeeIdFilter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // ClientIdFilter_label
            // 
            this.ClientIdFilter_label.AutoSize = true;
            this.ClientIdFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.ClientIdFilter_label.Location = new System.Drawing.Point(153, 97);
            this.ClientIdFilter_label.Name = "ClientIdFilter_label";
            this.ClientIdFilter_label.Size = new System.Drawing.Size(28, 19);
            this.ClientIdFilter_label.TabIndex = 6;
            this.ClientIdFilter_label.Text = "ת\"ז";
            // 
            // MobilePhoneFilter_textBox
            // 
            this.MobilePhoneFilter_textBox.Location = new System.Drawing.Point(15, 73);
            this.MobilePhoneFilter_textBox.Name = "MobilePhoneFilter_textBox";
            this.MobilePhoneFilter_textBox.Size = new System.Drawing.Size(90, 20);
            this.MobilePhoneFilter_textBox.TabIndex = 5;
            this.MobilePhoneFilter_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            this.MobilePhoneFilter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // LastNameFilter_textBox
            // 
            this.LastNameFilter_textBox.Location = new System.Drawing.Point(15, 48);
            this.LastNameFilter_textBox.Name = "LastNameFilter_textBox";
            this.LastNameFilter_textBox.Size = new System.Drawing.Size(90, 20);
            this.LastNameFilter_textBox.TabIndex = 4;
            this.LastNameFilter_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            this.LastNameFilter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // IDFilter_textBox
            // 
            this.IDFilter_textBox.Location = new System.Drawing.Point(15, 23);
            this.IDFilter_textBox.Name = "IDFilter_textBox";
            this.IDFilter_textBox.Size = new System.Drawing.Size(90, 20);
            this.IDFilter_textBox.TabIndex = 0;
            this.IDFilter_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            this.IDFilter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // MobilePhoneFilter_label
            // 
            this.MobilePhoneFilter_label.AutoSize = true;
            this.MobilePhoneFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.MobilePhoneFilter_label.Location = new System.Drawing.Point(140, 72);
            this.MobilePhoneFilter_label.Name = "MobilePhoneFilter_label";
            this.MobilePhoneFilter_label.Size = new System.Drawing.Size(41, 19);
            this.MobilePhoneFilter_label.TabIndex = 2;
            this.MobilePhoneFilter_label.Text = "טלפון";
            // 
            // LastNameFilter_label
            // 
            this.LastNameFilter_label.AutoSize = true;
            this.LastNameFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.LastNameFilter_label.Location = new System.Drawing.Point(108, 47);
            this.LastNameFilter_label.Name = "LastNameFilter_label";
            this.LastNameFilter_label.Size = new System.Drawing.Size(73, 19);
            this.LastNameFilter_label.TabIndex = 1;
            this.LastNameFilter_label.Text = "שם משפחה";
            // 
            // IDFilter_label
            // 
            this.IDFilter_label.AutoSize = true;
            this.IDFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDFilter_label.Location = new System.Drawing.Point(144, 22);
            this.IDFilter_label.Name = "IDFilter_label";
            this.IDFilter_label.Size = new System.Drawing.Size(37, 19);
            this.IDFilter_label.TabIndex = 0;
            this.IDFilter_label.Text = "מזהה";
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Clear_button.Location = new System.Drawing.Point(219, 416);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(60, 28);
            this.Clear_button.TabIndex = 96;
            this.Clear_button.Text = "נקה";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Save_button.Location = new System.Drawing.Point(143, 416);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(70, 28);
            this.Save_button.TabIndex = 79;
            this.Save_button.Text = "שמור";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Delete_button.Location = new System.Drawing.Point(285, 416);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(51, 28);
            this.Delete_button.TabIndex = 95;
            this.Delete_button.Text = "מחק";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // City_button
            // 
            this.City_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.City_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.City_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.City_button.Location = new System.Drawing.Point(143, 252);
            this.City_button.Name = "City_button";
            this.City_button.Size = new System.Drawing.Size(25, 21);
            this.City_button.TabIndex = 94;
            this.City_button.Text = "+";
            this.City_button.UseVisualStyleBackColor = false;
            this.City_button.Click += new System.EventHandler(this.City_button_Click);
            // 
            // City_comboBox
            // 
            this.City_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.City_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.City_comboBox.FormattingEnabled = true;
            this.City_comboBox.Location = new System.Drawing.Point(174, 252);
            this.City_comboBox.Name = "City_comboBox";
            this.City_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.City_comboBox.Size = new System.Drawing.Size(125, 21);
            this.City_comboBox.TabIndex = 78;
            this.City_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // PhoneNumber_textBox
            // 
            this.PhoneNumber_textBox.Location = new System.Drawing.Point(219, 229);
            this.PhoneNumber_textBox.Name = "PhoneNumber_textBox";
            this.PhoneNumber_textBox.Size = new System.Drawing.Size(80, 20);
            this.PhoneNumber_textBox.TabIndex = 77;
            this.PhoneNumber_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // Hyphen_label
            // 
            this.Hyphen_label.AutoSize = true;
            this.Hyphen_label.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold);
            this.Hyphen_label.Location = new System.Drawing.Point(198, 227);
            this.Hyphen_label.Name = "Hyphen_label";
            this.Hyphen_label.Size = new System.Drawing.Size(15, 20);
            this.Hyphen_label.TabIndex = 93;
            this.Hyphen_label.Text = "-";
            // 
            // PrefixPhone_comboBox
            // 
            this.PrefixPhone_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PrefixPhone_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PrefixPhone_comboBox.FormattingEnabled = true;
            this.PrefixPhone_comboBox.Items.AddRange(new object[] {
            "050",
            "051",
            "052",
            "053",
            "054",
            "055",
            "056",
            "057",
            "058",
            "059"});
            this.PrefixPhone_comboBox.Location = new System.Drawing.Point(143, 229);
            this.PrefixPhone_comboBox.Name = "PrefixPhone_comboBox";
            this.PrefixPhone_comboBox.Size = new System.Drawing.Size(51, 21);
            this.PrefixPhone_comboBox.TabIndex = 76;
            this.PrefixPhone_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(143, 206);
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(156, 20);
            this.Email_textBox.TabIndex = 75;
            this.Email_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Email_KeyPress);
            // 
            // BirthDate_dateTimePicker
            // 
            this.BirthDate_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthDate_dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BirthDate_dateTimePicker.Location = new System.Drawing.Point(143, 160);
            this.BirthDate_dateTimePicker.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.BirthDate_dateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthDate_dateTimePicker.Name = "BirthDate_dateTimePicker";
            this.BirthDate_dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BirthDate_dateTimePicker.Size = new System.Drawing.Size(156, 20);
            this.BirthDate_dateTimePicker.TabIndex = 72;
            this.BirthDate_dateTimePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // GenderOther_radioButton
            // 
            this.GenderOther_radioButton.AutoSize = true;
            this.GenderOther_radioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderOther_radioButton.Location = new System.Drawing.Point(143, 136);
            this.GenderOther_radioButton.Name = "GenderOther_radioButton";
            this.GenderOther_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenderOther_radioButton.Size = new System.Drawing.Size(51, 23);
            this.GenderOther_radioButton.TabIndex = 73;
            this.GenderOther_radioButton.Text = "אחר";
            this.GenderOther_radioButton.UseVisualStyleBackColor = true;
            // 
            // GenderWoman_radioButton
            // 
            this.GenderWoman_radioButton.AutoSize = true;
            this.GenderWoman_radioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderWoman_radioButton.Location = new System.Drawing.Point(198, 136);
            this.GenderWoman_radioButton.Name = "GenderWoman_radioButton";
            this.GenderWoman_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenderWoman_radioButton.Size = new System.Drawing.Size(55, 23);
            this.GenderWoman_radioButton.TabIndex = 71;
            this.GenderWoman_radioButton.Text = "נקבה";
            this.GenderWoman_radioButton.UseVisualStyleBackColor = true;
            // 
            // GenderMan_radioButton
            // 
            this.GenderMan_radioButton.AutoSize = true;
            this.GenderMan_radioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderMan_radioButton.Location = new System.Drawing.Point(254, 136);
            this.GenderMan_radioButton.Name = "GenderMan_radioButton";
            this.GenderMan_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GenderMan_radioButton.Size = new System.Drawing.Size(45, 23);
            this.GenderMan_radioButton.TabIndex = 69;
            this.GenderMan_radioButton.Text = "זכר";
            this.GenderMan_radioButton.UseVisualStyleBackColor = true;
            // 
            // Id_textBox
            // 
            this.Id_textBox.Location = new System.Drawing.Point(143, 183);
            this.Id_textBox.Name = "Id_textBox";
            this.Id_textBox.Size = new System.Drawing.Size(156, 20);
            this.Id_textBox.TabIndex = 74;
            this.Id_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Location = new System.Drawing.Point(143, 114);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(156, 20);
            this.LastName_textBox.TabIndex = 70;
            this.LastName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // FirstName_textBox
            // 
            this.FirstName_textBox.Location = new System.Drawing.Point(143, 91);
            this.FirstName_textBox.Name = "FirstName_textBox";
            this.FirstName_textBox.Size = new System.Drawing.Size(156, 20);
            this.FirstName_textBox.TabIndex = 68;
            this.FirstName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // IDnum_Label
            // 
            this.IDnum_Label.AutoSize = true;
            this.IDnum_Label.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDnum_Label.Location = new System.Drawing.Point(281, 70);
            this.IDnum_Label.Name = "IDnum_Label";
            this.IDnum_Label.Size = new System.Drawing.Size(18, 20);
            this.IDnum_Label.TabIndex = 92;
            this.IDnum_Label.Text = "0";
            // 
            // Headline_label
            // 
            this.Headline_label.AutoSize = true;
            this.Headline_label.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline_label.ForeColor = System.Drawing.Color.Black;
            this.Headline_label.Location = new System.Drawing.Point(299, 32);
            this.Headline_label.Name = "Headline_label";
            this.Headline_label.Size = new System.Drawing.Size(111, 29);
            this.Headline_label.TabIndex = 91;
            this.Headline_label.Text = "פרטי עובד:";
            // 
            // EmployeesListBox_label
            // 
            this.EmployeesListBox_label.AutoSize = true;
            this.EmployeesListBox_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesListBox_label.ForeColor = System.Drawing.Color.Black;
            this.EmployeesListBox_label.Location = new System.Drawing.Point(532, 167);
            this.EmployeesListBox_label.Name = "EmployeesListBox_label";
            this.EmployeesListBox_label.Size = new System.Drawing.Size(108, 23);
            this.EmployeesListBox_label.TabIndex = 90;
            this.EmployeesListBox_label.Text = "רשימת עובדים";
            // 
            // Employee_listBox
            // 
            this.Employee_listBox.FormattingEnabled = true;
            this.Employee_listBox.Location = new System.Drawing.Point(441, 193);
            this.Employee_listBox.Name = "Employee_listBox";
            this.Employee_listBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Employee_listBox.Size = new System.Drawing.Size(197, 251);
            this.Employee_listBox.TabIndex = 89;
            this.Employee_listBox.Click += new System.EventHandler(this.Employee_listBox_Click);
            // 
            // City_label
            // 
            this.City_label.AutoSize = true;
            this.City_label.BackColor = System.Drawing.Color.Transparent;
            this.City_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_label.Location = new System.Drawing.Point(362, 252);
            this.City_label.Name = "City_label";
            this.City_label.Size = new System.Drawing.Size(46, 23);
            this.City_label.TabIndex = 88;
            this.City_label.Text = "יישוב";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(363, 68);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(46, 23);
            this.ID_label.TabIndex = 87;
            this.ID_label.Text = "מזהה";
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_label.Location = new System.Drawing.Point(379, 137);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(30, 23);
            this.Gender_label.TabIndex = 86;
            this.Gender_label.Text = "מין";
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDate_label.Location = new System.Drawing.Point(320, 160);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(91, 23);
            this.BirthDate_label.TabIndex = 85;
            this.BirthDate_label.Text = "תאריך לידה";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(375, 183);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(34, 23);
            this.IdLabel.TabIndex = 84;
            this.IdLabel.Text = "ת\"ז";
            // 
            // PhoneNumber_label
            // 
            this.PhoneNumber_label.AutoSize = true;
            this.PhoneNumber_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber_label.Location = new System.Drawing.Point(314, 229);
            this.PhoneNumber_label.Name = "PhoneNumber_label";
            this.PhoneNumber_label.Size = new System.Drawing.Size(94, 23);
            this.PhoneNumber_label.TabIndex = 83;
            this.PhoneNumber_label.Text = "מספר טלפון";
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(359, 206);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(50, 23);
            this.Email_label.TabIndex = 82;
            this.Email_label.Text = "דוא\"ל";
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_label.Location = new System.Drawing.Point(320, 114);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(89, 23);
            this.LastName_label.TabIndex = 81;
            this.LastName_label.Text = "שם משפחה";
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_label.Location = new System.Drawing.Point(338, 91);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(72, 23);
            this.FirstName_label.TabIndex = 80;
            this.FirstName_label.Text = "שם פרטי";
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(55, 43);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(101, 20);
            this.Password_textBox.TabIndex = 99;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(6, 20);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(150, 20);
            this.Username_textBox.TabIndex = 98;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.Location = new System.Drawing.Point(206, 39);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(57, 23);
            this.Password_label.TabIndex = 101;
            this.Password_label.Text = "סיסמה";
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.Location = new System.Drawing.Point(172, 16);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(92, 23);
            this.Username_label.TabIndex = 100;
            this.Username_label.Text = "שם משתמש";
            // 
            // Admin_radioButton
            // 
            this.Admin_radioButton.AutoSize = true;
            this.Admin_radioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_radioButton.Location = new System.Drawing.Point(41, 65);
            this.Admin_radioButton.Name = "Admin_radioButton";
            this.Admin_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Admin_radioButton.Size = new System.Drawing.Size(55, 23);
            this.Admin_radioButton.TabIndex = 103;
            this.Admin_radioButton.Text = "מנהל";
            this.Admin_radioButton.UseVisualStyleBackColor = true;
            // 
            // Regular_radioButton
            // 
            this.Regular_radioButton.AutoSize = true;
            this.Regular_radioButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regular_radioButton.Location = new System.Drawing.Point(102, 65);
            this.Regular_radioButton.Name = "Regular_radioButton";
            this.Regular_radioButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Regular_radioButton.Size = new System.Drawing.Size(51, 23);
            this.Regular_radioButton.TabIndex = 102;
            this.Regular_radioButton.Text = "רגיל";
            this.Regular_radioButton.UseVisualStyleBackColor = true;
            // 
            // IsAdmin_label
            // 
            this.IsAdmin_label.AutoSize = true;
            this.IsAdmin_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAdmin_label.Location = new System.Drawing.Point(190, 62);
            this.IsAdmin_label.Name = "IsAdmin_label";
            this.IsAdmin_label.Size = new System.Drawing.Size(73, 23);
            this.IsAdmin_label.TabIndex = 105;
            this.IsAdmin_label.Text = "סוג גישה";
            // 
            // CreatingUser_groupBox
            // 
            this.CreatingUser_groupBox.Controls.Add(this.ShowPassword_checkBox);
            this.CreatingUser_groupBox.Controls.Add(this.Username_label);
            this.CreatingUser_groupBox.Controls.Add(this.Admin_radioButton);
            this.CreatingUser_groupBox.Controls.Add(this.Password_label);
            this.CreatingUser_groupBox.Controls.Add(this.Regular_radioButton);
            this.CreatingUser_groupBox.Controls.Add(this.Username_textBox);
            this.CreatingUser_groupBox.Controls.Add(this.IsAdmin_label);
            this.CreatingUser_groupBox.Controls.Add(this.Password_textBox);
            this.CreatingUser_groupBox.Location = new System.Drawing.Point(143, 303);
            this.CreatingUser_groupBox.Name = "CreatingUser_groupBox";
            this.CreatingUser_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CreatingUser_groupBox.Size = new System.Drawing.Size(265, 98);
            this.CreatingUser_groupBox.TabIndex = 106;
            this.CreatingUser_groupBox.TabStop = false;
            this.CreatingUser_groupBox.Text = "יצירת משתמש";
            // 
            // ShowPassword_checkBox
            // 
            this.ShowPassword_checkBox.AutoSize = true;
            this.ShowPassword_checkBox.Location = new System.Drawing.Point(6, 46);
            this.ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            this.ShowPassword_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowPassword_checkBox.Size = new System.Drawing.Size(46, 17);
            this.ShowPassword_checkBox.TabIndex = 108;
            this.ShowPassword_checkBox.Text = "הצג";
            this.ShowPassword_checkBox.UseVisualStyleBackColor = true;
            this.ShowPassword_checkBox.CheckedChanged += new System.EventHandler(this.ShowPassword_checkBox_CheckedChanged);
            // 
            // Form_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.CreatingUser_groupBox);
            this.Controls.Add(this.Filter_groupBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.City_button);
            this.Controls.Add(this.City_comboBox);
            this.Controls.Add(this.PhoneNumber_textBox);
            this.Controls.Add(this.Hyphen_label);
            this.Controls.Add(this.PrefixPhone_comboBox);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.BirthDate_dateTimePicker);
            this.Controls.Add(this.GenderOther_radioButton);
            this.Controls.Add(this.GenderWoman_radioButton);
            this.Controls.Add(this.GenderMan_radioButton);
            this.Controls.Add(this.Id_textBox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.FirstName_textBox);
            this.Controls.Add(this.IDnum_Label);
            this.Controls.Add(this.Headline_label);
            this.Controls.Add(this.EmployeesListBox_label);
            this.Controls.Add(this.Employee_listBox);
            this.Controls.Add(this.City_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.PhoneNumber_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.FirstName_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Employee";
            this.Text = "Form_Employee";
            this.Filter_groupBox.ResumeLayout(false);
            this.Filter_groupBox.PerformLayout();
            this.CreatingUser_groupBox.ResumeLayout(false);
            this.CreatingUser_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Filter_groupBox;
        private System.Windows.Forms.TextBox EmployeeIdFilter_textBox;
        private System.Windows.Forms.Label ClientIdFilter_label;
        private System.Windows.Forms.TextBox MobilePhoneFilter_textBox;
        private System.Windows.Forms.TextBox LastNameFilter_textBox;
        private System.Windows.Forms.TextBox IDFilter_textBox;
        private System.Windows.Forms.Label MobilePhoneFilter_label;
        private System.Windows.Forms.Label LastNameFilter_label;
        private System.Windows.Forms.Label IDFilter_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button City_button;
        private System.Windows.Forms.ComboBox City_comboBox;
        private System.Windows.Forms.TextBox PhoneNumber_textBox;
        private System.Windows.Forms.Label Hyphen_label;
        private System.Windows.Forms.ComboBox PrefixPhone_comboBox;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.DateTimePicker BirthDate_dateTimePicker;
        private System.Windows.Forms.RadioButton GenderOther_radioButton;
        private System.Windows.Forms.RadioButton GenderWoman_radioButton;
        private System.Windows.Forms.RadioButton GenderMan_radioButton;
        private System.Windows.Forms.TextBox Id_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox FirstName_textBox;
        private System.Windows.Forms.Label IDnum_Label;
        private System.Windows.Forms.Label Headline_label;
        private System.Windows.Forms.Label EmployeesListBox_label;
        private System.Windows.Forms.ListBox Employee_listBox;
        private System.Windows.Forms.Label City_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label PhoneNumber_label;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.RadioButton Admin_radioButton;
        private System.Windows.Forms.RadioButton Regular_radioButton;
        private System.Windows.Forms.Label IsAdmin_label;
        private System.Windows.Forms.GroupBox CreatingUser_groupBox;
        private System.Windows.Forms.CheckBox ShowPassword_checkBox;
    }
}
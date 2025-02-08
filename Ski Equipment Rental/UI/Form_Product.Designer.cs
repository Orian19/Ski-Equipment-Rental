namespace Ski_Equipment_Rental.UI
{
    partial class Form_Product
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
            this.SkillLevelNameFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.SkillLevelNameFilter_label = new System.Windows.Forms.Label();
            this.CategoryNameFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.CompanyNameFilter_comboBox = new System.Windows.Forms.ComboBox();
            this.ProductCountFilter_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductCountFilter_label = new System.Windows.Forms.Label();
            this.CategoryNameFilter_label = new System.Windows.Forms.Label();
            this.ProductNameFilter_textBox = new System.Windows.Forms.TextBox();
            this.IDFilter_textBox = new System.Windows.Forms.TextBox();
            this.CompanyNameFilter_label = new System.Windows.Forms.Label();
            this.ProductNameFilter_label = new System.Windows.Forms.Label();
            this.IDFilter_label = new System.Windows.Forms.Label();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Company_button = new System.Windows.Forms.Button();
            this.CompanyName_comboBox = new System.Windows.Forms.ComboBox();
            this.ProductName_textBox = new System.Windows.Forms.TextBox();
            this.IDnum_Label = new System.Windows.Forms.Label();
            this.Headline_label = new System.Windows.Forms.Label();
            this.ProductListBox_label = new System.Windows.Forms.Label();
            this.Product_listBox = new System.Windows.Forms.ListBox();
            this.Company_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.ProductCount_label = new System.Windows.Forms.Label();
            this.ProductName_label = new System.Windows.Forms.Label();
            this.Category_button = new System.Windows.Forms.Button();
            this.CategoryName_comboBox = new System.Windows.Forms.ComboBox();
            this.Category_label = new System.Windows.Forms.Label();
            this.ProductCount_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.SkillLEVEL_button = new System.Windows.Forms.Button();
            this.SkillLevelName_comboBox = new System.Windows.Forms.ComboBox();
            this.SkillLevel_label = new System.Windows.Forms.Label();
            this.Filter_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCountFilter_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCount_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter_groupBox
            // 
            this.Filter_groupBox.Controls.Add(this.SkillLevelNameFilter_comboBox);
            this.Filter_groupBox.Controls.Add(this.SkillLevelNameFilter_label);
            this.Filter_groupBox.Controls.Add(this.CategoryNameFilter_comboBox);
            this.Filter_groupBox.Controls.Add(this.CompanyNameFilter_comboBox);
            this.Filter_groupBox.Controls.Add(this.ProductCountFilter_numericUpDown);
            this.Filter_groupBox.Controls.Add(this.ProductCountFilter_label);
            this.Filter_groupBox.Controls.Add(this.CategoryNameFilter_label);
            this.Filter_groupBox.Controls.Add(this.ProductNameFilter_textBox);
            this.Filter_groupBox.Controls.Add(this.IDFilter_textBox);
            this.Filter_groupBox.Controls.Add(this.CompanyNameFilter_label);
            this.Filter_groupBox.Controls.Add(this.ProductNameFilter_label);
            this.Filter_groupBox.Controls.Add(this.IDFilter_label);
            this.Filter_groupBox.Location = new System.Drawing.Point(460, 26);
            this.Filter_groupBox.Name = "Filter_groupBox";
            this.Filter_groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Filter_groupBox.Size = new System.Drawing.Size(198, 180);
            this.Filter_groupBox.TabIndex = 98;
            this.Filter_groupBox.TabStop = false;
            this.Filter_groupBox.Text = "סינון מוצרים";
            // 
            // SkillLevelNameFilter_comboBox
            // 
            this.SkillLevelNameFilter_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SkillLevelNameFilter_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SkillLevelNameFilter_comboBox.FormattingEnabled = true;
            this.SkillLevelNameFilter_comboBox.Location = new System.Drawing.Point(12, 122);
            this.SkillLevelNameFilter_comboBox.Name = "SkillLevelNameFilter_comboBox";
            this.SkillLevelNameFilter_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SkillLevelNameFilter_comboBox.Size = new System.Drawing.Size(99, 21);
            this.SkillLevelNameFilter_comboBox.TabIndex = 106;
            this.SkillLevelNameFilter_comboBox.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            this.SkillLevelNameFilter_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // SkillLevelNameFilter_label
            // 
            this.SkillLevelNameFilter_label.AutoSize = true;
            this.SkillLevelNameFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.SkillLevelNameFilter_label.Location = new System.Drawing.Point(112, 122);
            this.SkillLevelNameFilter_label.Name = "SkillLevelNameFilter_label";
            this.SkillLevelNameFilter_label.Size = new System.Drawing.Size(78, 19);
            this.SkillLevelNameFilter_label.TabIndex = 105;
            this.SkillLevelNameFilter_label.Text = "רמת מיומנות";
            // 
            // CategoryNameFilter_comboBox
            // 
            this.CategoryNameFilter_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryNameFilter_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryNameFilter_comboBox.FormattingEnabled = true;
            this.CategoryNameFilter_comboBox.Location = new System.Drawing.Point(12, 96);
            this.CategoryNameFilter_comboBox.Name = "CategoryNameFilter_comboBox";
            this.CategoryNameFilter_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CategoryNameFilter_comboBox.Size = new System.Drawing.Size(99, 21);
            this.CategoryNameFilter_comboBox.TabIndex = 104;
            this.CategoryNameFilter_comboBox.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            this.CategoryNameFilter_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // CompanyNameFilter_comboBox
            // 
            this.CompanyNameFilter_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyNameFilter_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyNameFilter_comboBox.FormattingEnabled = true;
            this.CompanyNameFilter_comboBox.Location = new System.Drawing.Point(12, 70);
            this.CompanyNameFilter_comboBox.Name = "CompanyNameFilter_comboBox";
            this.CompanyNameFilter_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanyNameFilter_comboBox.Size = new System.Drawing.Size(99, 21);
            this.CompanyNameFilter_comboBox.TabIndex = 103;
            this.CompanyNameFilter_comboBox.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // ProductCountFilter_numericUpDown
            // 
            this.ProductCountFilter_numericUpDown.Location = new System.Drawing.Point(69, 148);
            this.ProductCountFilter_numericUpDown.Name = "ProductCountFilter_numericUpDown";
            this.ProductCountFilter_numericUpDown.Size = new System.Drawing.Size(42, 20);
            this.ProductCountFilter_numericUpDown.TabIndex = 9;
            this.ProductCountFilter_numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            this.ProductCountFilter_numericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // ProductCountFilter_label
            // 
            this.ProductCountFilter_label.AutoSize = true;
            this.ProductCountFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.ProductCountFilter_label.Location = new System.Drawing.Point(153, 147);
            this.ProductCountFilter_label.Name = "ProductCountFilter_label";
            this.ProductCountFilter_label.Size = new System.Drawing.Size(37, 19);
            this.ProductCountFilter_label.TabIndex = 8;
            this.ProductCountFilter_label.Text = "כמות";
            // 
            // CategoryNameFilter_label
            // 
            this.CategoryNameFilter_label.AutoSize = true;
            this.CategoryNameFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.CategoryNameFilter_label.Location = new System.Drawing.Point(135, 97);
            this.CategoryNameFilter_label.Name = "CategoryNameFilter_label";
            this.CategoryNameFilter_label.Size = new System.Drawing.Size(55, 19);
            this.CategoryNameFilter_label.TabIndex = 6;
            this.CategoryNameFilter_label.Text = "קטגוריה";
            // 
            // ProductNameFilter_textBox
            // 
            this.ProductNameFilter_textBox.Location = new System.Drawing.Point(12, 45);
            this.ProductNameFilter_textBox.Name = "ProductNameFilter_textBox";
            this.ProductNameFilter_textBox.Size = new System.Drawing.Size(99, 20);
            this.ProductNameFilter_textBox.TabIndex = 4;
            this.ProductNameFilter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // IDFilter_textBox
            // 
            this.IDFilter_textBox.Location = new System.Drawing.Point(12, 20);
            this.IDFilter_textBox.Name = "IDFilter_textBox";
            this.IDFilter_textBox.Size = new System.Drawing.Size(99, 20);
            this.IDFilter_textBox.TabIndex = 0;
            this.IDFilter_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            this.IDFilter_textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // CompanyNameFilter_label
            // 
            this.CompanyNameFilter_label.AutoSize = true;
            this.CompanyNameFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.CompanyNameFilter_label.Location = new System.Drawing.Point(151, 72);
            this.CompanyNameFilter_label.Name = "CompanyNameFilter_label";
            this.CompanyNameFilter_label.Size = new System.Drawing.Size(39, 19);
            this.CompanyNameFilter_label.TabIndex = 2;
            this.CompanyNameFilter_label.Text = "חברה";
            // 
            // ProductNameFilter_label
            // 
            this.ProductNameFilter_label.AutoSize = true;
            this.ProductNameFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.ProductNameFilter_label.Location = new System.Drawing.Point(124, 47);
            this.ProductNameFilter_label.Name = "ProductNameFilter_label";
            this.ProductNameFilter_label.Size = new System.Drawing.Size(66, 19);
            this.ProductNameFilter_label.TabIndex = 1;
            this.ProductNameFilter_label.Text = "שם המוצר";
            // 
            // IDFilter_label
            // 
            this.IDFilter_label.AutoSize = true;
            this.IDFilter_label.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDFilter_label.Location = new System.Drawing.Point(153, 22);
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
            this.Clear_button.Location = new System.Drawing.Point(179, 280);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(60, 28);
            this.Clear_button.TabIndex = 97;
            this.Clear_button.Text = "נקה";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Save_button.Location = new System.Drawing.Point(103, 280);
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
            this.Delete_button.Location = new System.Drawing.Point(245, 280);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(51, 28);
            this.Delete_button.TabIndex = 96;
            this.Delete_button.Text = "מחק";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Company_button
            // 
            this.Company_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Company_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Company_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Company_button.Location = new System.Drawing.Point(103, 127);
            this.Company_button.Name = "Company_button";
            this.Company_button.Size = new System.Drawing.Size(25, 22);
            this.Company_button.TabIndex = 95;
            this.Company_button.Text = "+";
            this.Company_button.UseVisualStyleBackColor = false;
            this.Company_button.Click += new System.EventHandler(this.Company_button_Click);
            // 
            // CompanyName_comboBox
            // 
            this.CompanyName_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyName_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyName_comboBox.FormattingEnabled = true;
            this.CompanyName_comboBox.Location = new System.Drawing.Point(134, 126);
            this.CompanyName_comboBox.Name = "CompanyName_comboBox";
            this.CompanyName_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanyName_comboBox.Size = new System.Drawing.Size(125, 21);
            this.CompanyName_comboBox.TabIndex = 78;
            // 
            // ProductName_textBox
            // 
            this.ProductName_textBox.Location = new System.Drawing.Point(103, 101);
            this.ProductName_textBox.Name = "ProductName_textBox";
            this.ProductName_textBox.Size = new System.Drawing.Size(156, 20);
            this.ProductName_textBox.TabIndex = 68;
            // 
            // IDnum_Label
            // 
            this.IDnum_Label.AutoSize = true;
            this.IDnum_Label.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDnum_Label.Location = new System.Drawing.Point(241, 74);
            this.IDnum_Label.Name = "IDnum_Label";
            this.IDnum_Label.Size = new System.Drawing.Size(18, 20);
            this.IDnum_Label.TabIndex = 93;
            this.IDnum_Label.Text = "0";
            // 
            // Headline_label
            // 
            this.Headline_label.AutoSize = true;
            this.Headline_label.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline_label.ForeColor = System.Drawing.Color.Black;
            this.Headline_label.Location = new System.Drawing.Point(252, 26);
            this.Headline_label.Name = "Headline_label";
            this.Headline_label.Size = new System.Drawing.Size(113, 29);
            this.Headline_label.TabIndex = 92;
            this.Headline_label.Text = "פרטי מוצר:";
            // 
            // ProductListBox_label
            // 
            this.ProductListBox_label.AutoSize = true;
            this.ProductListBox_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductListBox_label.ForeColor = System.Drawing.Color.Black;
            this.ProductListBox_label.Location = new System.Drawing.Point(547, 212);
            this.ProductListBox_label.Name = "ProductListBox_label";
            this.ProductListBox_label.Size = new System.Drawing.Size(111, 23);
            this.ProductListBox_label.TabIndex = 90;
            this.ProductListBox_label.Text = "רשימת מוצרים";
            // 
            // Product_listBox
            // 
            this.Product_listBox.FormattingEnabled = true;
            this.Product_listBox.Location = new System.Drawing.Point(385, 235);
            this.Product_listBox.Name = "Product_listBox";
            this.Product_listBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Product_listBox.Size = new System.Drawing.Size(273, 251);
            this.Product_listBox.TabIndex = 89;
            this.Product_listBox.Click += new System.EventHandler(this.listBox_Product_Click);
            // 
            // Company_label
            // 
            this.Company_label.AutoSize = true;
            this.Company_label.BackColor = System.Drawing.Color.Transparent;
            this.Company_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_label.Location = new System.Drawing.Point(317, 123);
            this.Company_label.Name = "Company_label";
            this.Company_label.Size = new System.Drawing.Size(48, 23);
            this.Company_label.TabIndex = 88;
            this.Company_label.Text = "חברה";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(319, 71);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(46, 23);
            this.ID_label.TabIndex = 87;
            this.ID_label.Text = "מזהה";
            // 
            // ProductCount_label
            // 
            this.ProductCount_label.AutoSize = true;
            this.ProductCount_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCount_label.Location = new System.Drawing.Point(320, 227);
            this.ProductCount_label.Name = "ProductCount_label";
            this.ProductCount_label.Size = new System.Drawing.Size(45, 23);
            this.ProductCount_label.TabIndex = 82;
            this.ProductCount_label.Text = "כמות";
            // 
            // ProductName_label
            // 
            this.ProductName_label.AutoSize = true;
            this.ProductName_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_label.Location = new System.Drawing.Point(284, 97);
            this.ProductName_label.Name = "ProductName_label";
            this.ProductName_label.Size = new System.Drawing.Size(81, 23);
            this.ProductName_label.TabIndex = 81;
            this.ProductName_label.Text = "שם המוצר";
            // 
            // Category_button
            // 
            this.Category_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Category_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Category_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Category_button.Location = new System.Drawing.Point(103, 153);
            this.Category_button.Name = "Category_button";
            this.Category_button.Size = new System.Drawing.Size(25, 21);
            this.Category_button.TabIndex = 101;
            this.Category_button.Text = "+";
            this.Category_button.UseVisualStyleBackColor = false;
            this.Category_button.Click += new System.EventHandler(this.Category_button_Click);
            // 
            // CategoryName_comboBox
            // 
            this.CategoryName_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryName_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryName_comboBox.FormattingEnabled = true;
            this.CategoryName_comboBox.Location = new System.Drawing.Point(134, 152);
            this.CategoryName_comboBox.Name = "CategoryName_comboBox";
            this.CategoryName_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CategoryName_comboBox.Size = new System.Drawing.Size(125, 21);
            this.CategoryName_comboBox.TabIndex = 99;
            this.CategoryName_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.BackColor = System.Drawing.Color.Transparent;
            this.Category_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_label.Location = new System.Drawing.Point(297, 149);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(68, 23);
            this.Category_label.TabIndex = 100;
            this.Category_label.Text = "קטגוריה";
            // 
            // ProductCount_numericUpDown
            // 
            this.ProductCount_numericUpDown.Location = new System.Drawing.Point(219, 229);
            this.ProductCount_numericUpDown.Name = "ProductCount_numericUpDown";
            this.ProductCount_numericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProductCount_numericUpDown.Size = new System.Drawing.Size(40, 20);
            this.ProductCount_numericUpDown.TabIndex = 102;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(219, 204);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Price_textBox.Size = new System.Drawing.Size(40, 20);
            this.Price_textBox.TabIndex = 103;
            this.Price_textBox.Text = "₪0.00";
            this.Price_textBox.Click += new System.EventHandler(this.Price_textBox_Click);
            this.Price_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_KeyPress);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(287, 201);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(78, 23);
            this.Price_label.TabIndex = 104;
            this.Price_label.Text = "מחיר ליום";
            // 
            // SkillLEVEL_button
            // 
            this.SkillLEVEL_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.SkillLEVEL_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SkillLEVEL_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SkillLEVEL_button.Location = new System.Drawing.Point(103, 178);
            this.SkillLEVEL_button.Name = "SkillLEVEL_button";
            this.SkillLEVEL_button.Size = new System.Drawing.Size(25, 21);
            this.SkillLEVEL_button.TabIndex = 107;
            this.SkillLEVEL_button.Text = "+";
            this.SkillLEVEL_button.UseVisualStyleBackColor = false;
            this.SkillLEVEL_button.Click += new System.EventHandler(this.SkillLevel_button_Click);
            // 
            // SkillLevelName_comboBox
            // 
            this.SkillLevelName_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SkillLevelName_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SkillLevelName_comboBox.FormattingEnabled = true;
            this.SkillLevelName_comboBox.Location = new System.Drawing.Point(134, 178);
            this.SkillLevelName_comboBox.Name = "SkillLevelName_comboBox";
            this.SkillLevelName_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SkillLevelName_comboBox.Size = new System.Drawing.Size(125, 21);
            this.SkillLevelName_comboBox.TabIndex = 105;
            this.SkillLevelName_comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // SkillLevel_label
            // 
            this.SkillLevel_label.AutoSize = true;
            this.SkillLevel_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SkillLevel_label.Location = new System.Drawing.Point(269, 175);
            this.SkillLevel_label.Name = "SkillLevel_label";
            this.SkillLevel_label.Size = new System.Drawing.Size(96, 23);
            this.SkillLevel_label.TabIndex = 108;
            this.SkillLevel_label.Text = "רמת מיומנות";
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.SkillLevel_label);
            this.Controls.Add(this.SkillLEVEL_button);
            this.Controls.Add(this.SkillLevelName_comboBox);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.Price_label);
            this.Controls.Add(this.ProductCount_numericUpDown);
            this.Controls.Add(this.Category_button);
            this.Controls.Add(this.CategoryName_comboBox);
            this.Controls.Add(this.Category_label);
            this.Controls.Add(this.Filter_groupBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Company_button);
            this.Controls.Add(this.CompanyName_comboBox);
            this.Controls.Add(this.ProductName_textBox);
            this.Controls.Add(this.IDnum_Label);
            this.Controls.Add(this.Headline_label);
            this.Controls.Add(this.ProductListBox_label);
            this.Controls.Add(this.Product_listBox);
            this.Controls.Add(this.Company_label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.ProductCount_label);
            this.Controls.Add(this.ProductName_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Product";
            this.Text = "Form_Product";
            this.Filter_groupBox.ResumeLayout(false);
            this.Filter_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCountFilter_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCount_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Filter_groupBox;
        private System.Windows.Forms.TextBox ProductNameFilter_textBox;
        private System.Windows.Forms.TextBox IDFilter_textBox;
        private System.Windows.Forms.Label CompanyNameFilter_label;
        private System.Windows.Forms.Label ProductNameFilter_label;
        private System.Windows.Forms.Label IDFilter_label;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Company_button;
        private System.Windows.Forms.ComboBox CompanyName_comboBox;
        private System.Windows.Forms.TextBox ProductName_textBox;
        private System.Windows.Forms.Label IDnum_Label;
        private System.Windows.Forms.Label Headline_label;
        private System.Windows.Forms.Label ProductListBox_label;
        private System.Windows.Forms.ListBox Product_listBox;
        private System.Windows.Forms.Label Company_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label ProductCount_label;
        private System.Windows.Forms.Label ProductName_label;
        private System.Windows.Forms.NumericUpDown ProductCountFilter_numericUpDown;
        private System.Windows.Forms.Label ProductCountFilter_label;
        private System.Windows.Forms.Label CategoryNameFilter_label;
        private System.Windows.Forms.Button Category_button;
        private System.Windows.Forms.ComboBox CategoryName_comboBox;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.NumericUpDown ProductCount_numericUpDown;
        private System.Windows.Forms.ComboBox CategoryNameFilter_comboBox;
        private System.Windows.Forms.ComboBox CompanyNameFilter_comboBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.ComboBox SkillLevelNameFilter_comboBox;
        private System.Windows.Forms.Label SkillLevelNameFilter_label;
        private System.Windows.Forms.Button SkillLEVEL_button;
        private System.Windows.Forms.ComboBox SkillLevelName_comboBox;
        private System.Windows.Forms.Label SkillLevel_label;
    }
}
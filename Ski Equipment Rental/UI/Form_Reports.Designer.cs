namespace Ski_Equipment_Rental.UI
{
    partial class Form_Reports
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
            this.ReportsTabs_tabControl = new System.Windows.Forms.TabControl();
            this.OutOfStockProducts_tab1 = new System.Windows.Forms.TabPage();
            this.CountProduct_label_tab1 = new System.Windows.Forms.Label();
            this.ProductCount_numericUpDown_tab1 = new System.Windows.Forms.NumericUpDown();
            this.Products_listBox_tab1 = new System.Windows.Forms.ListBox();
            this.Products_listBox_label_tab1 = new System.Windows.Forms.Label();
            this.ReturnDatePast_tab2 = new System.Windows.Forms.TabPage();
            this.ClientInfoForContact_groupBox_tab2 = new System.Windows.Forms.GroupBox();
            this.Phone_label_tab2 = new System.Windows.Forms.Label();
            this.PhoneHyphen_label_tab2 = new System.Windows.Forms.Label();
            this.ClientFullNameHyphen_label_tab2 = new System.Windows.Forms.Label();
            this.ClientFullName_tab2 = new System.Windows.Forms.Label();
            this.OrderCostNum_label_tab2 = new System.Windows.Forms.Label();
            this.OrderCost_label_tab2 = new System.Windows.Forms.Label();
            this.Date_dateTimePicker_tab2 = new System.Windows.Forms.DateTimePicker();
            this.IDnum_Label_tab2 = new System.Windows.Forms.Label();
            this.ID_label_tab2 = new System.Windows.Forms.Label();
            this.Comment_textBox_tab2 = new System.Windows.Forms.TextBox();
            this.Comment_label_tab2 = new System.Windows.Forms.Label();
            this.Date_label_tab2 = new System.Windows.Forms.Label();
            this.Orders_listBox_tab2 = new System.Windows.Forms.ListBox();
            this.Orders_listBox_label_tab2 = new System.Windows.Forms.Label();
            this.TodayOrders_tab3 = new System.Windows.Forms.TabPage();
            this.Date_dateTimePicker_tab3 = new System.Windows.Forms.DateTimePicker();
            this.TodayOrders_listBox_tab3 = new System.Windows.Forms.ListBox();
            this.TodayOrders_listBox_label_tab3 = new System.Windows.Forms.Label();
            this.TodayRentEnd_tab4 = new System.Windows.Forms.TabPage();
            this.ReturnDate_dateTimePicker_tab4 = new System.Windows.Forms.DateTimePicker();
            this.TodayRentEnd_listBox_tab4 = new System.Windows.Forms.ListBox();
            this.TodayRentEnd_listBox_label_tab4 = new System.Windows.Forms.Label();
            this.ReportsTabs_tabControl.SuspendLayout();
            this.OutOfStockProducts_tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCount_numericUpDown_tab1)).BeginInit();
            this.ReturnDatePast_tab2.SuspendLayout();
            this.ClientInfoForContact_groupBox_tab2.SuspendLayout();
            this.TodayOrders_tab3.SuspendLayout();
            this.TodayRentEnd_tab4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportsTabs_tabControl
            // 
            this.ReportsTabs_tabControl.Controls.Add(this.OutOfStockProducts_tab1);
            this.ReportsTabs_tabControl.Controls.Add(this.ReturnDatePast_tab2);
            this.ReportsTabs_tabControl.Controls.Add(this.TodayOrders_tab3);
            this.ReportsTabs_tabControl.Controls.Add(this.TodayRentEnd_tab4);
            this.ReportsTabs_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportsTabs_tabControl.Location = new System.Drawing.Point(0, 0);
            this.ReportsTabs_tabControl.Name = "ReportsTabs_tabControl";
            this.ReportsTabs_tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ReportsTabs_tabControl.RightToLeftLayout = true;
            this.ReportsTabs_tabControl.SelectedIndex = 0;
            this.ReportsTabs_tabControl.Size = new System.Drawing.Size(774, 504);
            this.ReportsTabs_tabControl.TabIndex = 0;
            // 
            // OutOfStockProducts_tab1
            // 
            this.OutOfStockProducts_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.OutOfStockProducts_tab1.Controls.Add(this.CountProduct_label_tab1);
            this.OutOfStockProducts_tab1.Controls.Add(this.ProductCount_numericUpDown_tab1);
            this.OutOfStockProducts_tab1.Controls.Add(this.Products_listBox_tab1);
            this.OutOfStockProducts_tab1.Controls.Add(this.Products_listBox_label_tab1);
            this.OutOfStockProducts_tab1.Location = new System.Drawing.Point(4, 22);
            this.OutOfStockProducts_tab1.Name = "OutOfStockProducts_tab1";
            this.OutOfStockProducts_tab1.Padding = new System.Windows.Forms.Padding(3);
            this.OutOfStockProducts_tab1.Size = new System.Drawing.Size(766, 478);
            this.OutOfStockProducts_tab1.TabIndex = 0;
            this.OutOfStockProducts_tab1.Text = "בדיקת מלאי";
            // 
            // CountProduct_label_tab1
            // 
            this.CountProduct_label_tab1.AutoSize = true;
            this.CountProduct_label_tab1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountProduct_label_tab1.Location = new System.Drawing.Point(334, 66);
            this.CountProduct_label_tab1.Name = "CountProduct_label_tab1";
            this.CountProduct_label_tab1.Size = new System.Drawing.Size(37, 19);
            this.CountProduct_label_tab1.TabIndex = 78;
            this.CountProduct_label_tab1.Text = "כמות";
            // 
            // ProductCount_numericUpDown_tab1
            // 
            this.ProductCount_numericUpDown_tab1.Location = new System.Drawing.Point(282, 66);
            this.ProductCount_numericUpDown_tab1.Name = "ProductCount_numericUpDown_tab1";
            this.ProductCount_numericUpDown_tab1.Size = new System.Drawing.Size(46, 20);
            this.ProductCount_numericUpDown_tab1.TabIndex = 77;
            this.ProductCount_numericUpDown_tab1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ProductCount_numericUpDown_tab1.ValueChanged += new System.EventHandler(this.ProductCount_numericUpDown_tab1_ValueChanged);
            // 
            // Products_listBox_tab1
            // 
            this.Products_listBox_tab1.FormattingEnabled = true;
            this.Products_listBox_tab1.Location = new System.Drawing.Point(398, 66);
            this.Products_listBox_tab1.Name = "Products_listBox_tab1";
            this.Products_listBox_tab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Products_listBox_tab1.Size = new System.Drawing.Size(314, 264);
            this.Products_listBox_tab1.TabIndex = 76;
            // 
            // Products_listBox_label_tab1
            // 
            this.Products_listBox_label_tab1.AutoSize = true;
            this.Products_listBox_label_tab1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products_listBox_label_tab1.ForeColor = System.Drawing.Color.Black;
            this.Products_listBox_label_tab1.Location = new System.Drawing.Point(398, 40);
            this.Products_listBox_label_tab1.Name = "Products_listBox_label_tab1";
            this.Products_listBox_label_tab1.Size = new System.Drawing.Size(318, 23);
            this.Products_listBox_label_tab1.TabIndex = 75;
            this.Products_listBox_label_tab1.Text = "רשימת כמות מוצרים במלאי לפי כמות נבחרת:";
            // 
            // ReturnDatePast_tab2
            // 
            this.ReturnDatePast_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.ReturnDatePast_tab2.Controls.Add(this.ClientInfoForContact_groupBox_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.OrderCostNum_label_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.OrderCost_label_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.Date_dateTimePicker_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.IDnum_Label_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.ID_label_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.Comment_textBox_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.Comment_label_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.Date_label_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.Orders_listBox_tab2);
            this.ReturnDatePast_tab2.Controls.Add(this.Orders_listBox_label_tab2);
            this.ReturnDatePast_tab2.Location = new System.Drawing.Point(4, 22);
            this.ReturnDatePast_tab2.Name = "ReturnDatePast_tab2";
            this.ReturnDatePast_tab2.Padding = new System.Windows.Forms.Padding(3);
            this.ReturnDatePast_tab2.Size = new System.Drawing.Size(766, 478);
            this.ReturnDatePast_tab2.TabIndex = 1;
            this.ReturnDatePast_tab2.Text = "הזמנות שהציוד בהן טרם הוחזר";
            // 
            // ClientInfoForContact_groupBox_tab2
            // 
            this.ClientInfoForContact_groupBox_tab2.Controls.Add(this.Phone_label_tab2);
            this.ClientInfoForContact_groupBox_tab2.Controls.Add(this.PhoneHyphen_label_tab2);
            this.ClientInfoForContact_groupBox_tab2.Controls.Add(this.ClientFullNameHyphen_label_tab2);
            this.ClientInfoForContact_groupBox_tab2.Controls.Add(this.ClientFullName_tab2);
            this.ClientInfoForContact_groupBox_tab2.Location = new System.Drawing.Point(90, 183);
            this.ClientInfoForContact_groupBox_tab2.Name = "ClientInfoForContact_groupBox_tab2";
            this.ClientInfoForContact_groupBox_tab2.Size = new System.Drawing.Size(266, 73);
            this.ClientInfoForContact_groupBox_tab2.TabIndex = 111;
            this.ClientInfoForContact_groupBox_tab2.TabStop = false;
            this.ClientInfoForContact_groupBox_tab2.Text = "פרטי לקוח ליצירת קשר";
            // 
            // Phone_label_tab2
            // 
            this.Phone_label_tab2.AutoSize = true;
            this.Phone_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label_tab2.Location = new System.Drawing.Point(207, 43);
            this.Phone_label_tab2.Name = "Phone_label_tab2";
            this.Phone_label_tab2.Size = new System.Drawing.Size(50, 23);
            this.Phone_label_tab2.TabIndex = 112;
            this.Phone_label_tab2.Text = "טלפון";
            // 
            // PhoneHyphen_label_tab2
            // 
            this.PhoneHyphen_label_tab2.AutoSize = true;
            this.PhoneHyphen_label_tab2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneHyphen_label_tab2.Location = new System.Drawing.Point(97, 47);
            this.PhoneHyphen_label_tab2.Name = "PhoneHyphen_label_tab2";
            this.PhoneHyphen_label_tab2.Size = new System.Drawing.Size(13, 17);
            this.PhoneHyphen_label_tab2.TabIndex = 109;
            this.PhoneHyphen_label_tab2.Text = "-";
            // 
            // ClientFullNameHyphen_label_tab2
            // 
            this.ClientFullNameHyphen_label_tab2.AutoSize = true;
            this.ClientFullNameHyphen_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFullNameHyphen_label_tab2.Location = new System.Drawing.Point(27, 19);
            this.ClientFullNameHyphen_label_tab2.Name = "ClientFullNameHyphen_label_tab2";
            this.ClientFullNameHyphen_label_tab2.Size = new System.Drawing.Size(17, 21);
            this.ClientFullNameHyphen_label_tab2.TabIndex = 108;
            this.ClientFullNameHyphen_label_tab2.Text = "-";
            // 
            // ClientFullName_tab2
            // 
            this.ClientFullName_tab2.AutoSize = true;
            this.ClientFullName_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientFullName_tab2.Location = new System.Drawing.Point(119, 20);
            this.ClientFullName_tab2.Name = "ClientFullName_tab2";
            this.ClientFullName_tab2.Size = new System.Drawing.Size(140, 23);
            this.ClientFullName_tab2.TabIndex = 107;
            this.ClientFullName_tab2.Text = "שם מלא של הלקוח";
            // 
            // OrderCostNum_label_tab2
            // 
            this.OrderCostNum_label_tab2.AutoSize = true;
            this.OrderCostNum_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCostNum_label_tab2.Location = new System.Drawing.Point(157, 139);
            this.OrderCostNum_label_tab2.Name = "OrderCostNum_label_tab2";
            this.OrderCostNum_label_tab2.Size = new System.Drawing.Size(56, 21);
            this.OrderCostNum_label_tab2.TabIndex = 106;
            this.OrderCostNum_label_tab2.Text = "₪0.00";
            // 
            // OrderCost_label_tab2
            // 
            this.OrderCost_label_tab2.AutoSize = true;
            this.OrderCost_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderCost_label_tab2.Location = new System.Drawing.Point(247, 139);
            this.OrderCost_label_tab2.Name = "OrderCost_label_tab2";
            this.OrderCost_label_tab2.Size = new System.Drawing.Size(100, 23);
            this.OrderCost_label_tab2.TabIndex = 105;
            this.OrderCost_label_tab2.Text = "עלות ההזמנה";
            // 
            // Date_dateTimePicker_tab2
            // 
            this.Date_dateTimePicker_tab2.Enabled = false;
            this.Date_dateTimePicker_tab2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_dateTimePicker_tab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Date_dateTimePicker_tab2.Location = new System.Drawing.Point(136, 86);
            this.Date_dateTimePicker_tab2.MaxDate = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            this.Date_dateTimePicker_tab2.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Date_dateTimePicker_tab2.Name = "Date_dateTimePicker_tab2";
            this.Date_dateTimePicker_tab2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_dateTimePicker_tab2.Size = new System.Drawing.Size(104, 20);
            this.Date_dateTimePicker_tab2.TabIndex = 104;
            this.Date_dateTimePicker_tab2.Value = new System.DateTime(2018, 4, 26, 0, 0, 0, 0);
            // 
            // IDnum_Label_tab2
            // 
            this.IDnum_Label_tab2.AutoSize = true;
            this.IDnum_Label_tab2.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDnum_Label_tab2.Location = new System.Drawing.Point(226, 58);
            this.IDnum_Label_tab2.Name = "IDnum_Label_tab2";
            this.IDnum_Label_tab2.Size = new System.Drawing.Size(18, 20);
            this.IDnum_Label_tab2.TabIndex = 103;
            this.IDnum_Label_tab2.Text = "0";
            // 
            // ID_label_tab2
            // 
            this.ID_label_tab2.AutoSize = true;
            this.ID_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label_tab2.Location = new System.Drawing.Point(301, 56);
            this.ID_label_tab2.Name = "ID_label_tab2";
            this.ID_label_tab2.Size = new System.Drawing.Size(46, 23);
            this.ID_label_tab2.TabIndex = 102;
            this.ID_label_tab2.Text = "מזהה";
            // 
            // Comment_textBox_tab2
            // 
            this.Comment_textBox_tab2.Location = new System.Drawing.Point(136, 113);
            this.Comment_textBox_tab2.Multiline = true;
            this.Comment_textBox_tab2.Name = "Comment_textBox_tab2";
            this.Comment_textBox_tab2.Size = new System.Drawing.Size(104, 23);
            this.Comment_textBox_tab2.TabIndex = 99;
            // 
            // Comment_label_tab2
            // 
            this.Comment_label_tab2.AutoSize = true;
            this.Comment_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.Comment_label_tab2.Location = new System.Drawing.Point(299, 112);
            this.Comment_label_tab2.Name = "Comment_label_tab2";
            this.Comment_label_tab2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Comment_label_tab2.Size = new System.Drawing.Size(48, 23);
            this.Comment_label_tab2.TabIndex = 101;
            this.Comment_label_tab2.Text = "הערה";
            // 
            // Date_label_tab2
            // 
            this.Date_label_tab2.AutoSize = true;
            this.Date_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.Date_label_tab2.Location = new System.Drawing.Point(292, 84);
            this.Date_label_tab2.Name = "Date_label_tab2";
            this.Date_label_tab2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date_label_tab2.Size = new System.Drawing.Size(55, 23);
            this.Date_label_tab2.TabIndex = 100;
            this.Date_label_tab2.Text = "תאריך";
            // 
            // Orders_listBox_tab2
            // 
            this.Orders_listBox_tab2.FormattingEnabled = true;
            this.Orders_listBox_tab2.Location = new System.Drawing.Point(397, 56);
            this.Orders_listBox_tab2.Name = "Orders_listBox_tab2";
            this.Orders_listBox_tab2.Size = new System.Drawing.Size(331, 264);
            this.Orders_listBox_tab2.TabIndex = 74;
            this.Orders_listBox_tab2.Click += new System.EventHandler(this.Orders_listBox_tab2_Click);
            // 
            // Orders_listBox_label_tab2
            // 
            this.Orders_listBox_label_tab2.AutoSize = true;
            this.Orders_listBox_label_tab2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders_listBox_label_tab2.ForeColor = System.Drawing.Color.Black;
            this.Orders_listBox_label_tab2.Location = new System.Drawing.Point(394, 28);
            this.Orders_listBox_label_tab2.Name = "Orders_listBox_label_tab2";
            this.Orders_listBox_label_tab2.Size = new System.Drawing.Size(337, 23);
            this.Orders_listBox_label_tab2.TabIndex = 73;
            this.Orders_listBox_label_tab2.Text = "רשימת הזמנות שעבר תאריך החזרת הציוד שלהן:";
            // 
            // TodayOrders_tab3
            // 
            this.TodayOrders_tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TodayOrders_tab3.Controls.Add(this.Date_dateTimePicker_tab3);
            this.TodayOrders_tab3.Controls.Add(this.TodayOrders_listBox_tab3);
            this.TodayOrders_tab3.Controls.Add(this.TodayOrders_listBox_label_tab3);
            this.TodayOrders_tab3.Location = new System.Drawing.Point(4, 22);
            this.TodayOrders_tab3.Name = "TodayOrders_tab3";
            this.TodayOrders_tab3.Padding = new System.Windows.Forms.Padding(3);
            this.TodayOrders_tab3.Size = new System.Drawing.Size(766, 478);
            this.TodayOrders_tab3.TabIndex = 2;
            this.TodayOrders_tab3.Text = "הזמנות שבוצעו ביום מסויים";
            // 
            // Date_dateTimePicker_tab3
            // 
            this.Date_dateTimePicker_tab3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_dateTimePicker_tab3.Location = new System.Drawing.Point(383, 36);
            this.Date_dateTimePicker_tab3.Name = "Date_dateTimePicker_tab3";
            this.Date_dateTimePicker_tab3.Size = new System.Drawing.Size(99, 20);
            this.Date_dateTimePicker_tab3.TabIndex = 79;
            this.Date_dateTimePicker_tab3.Value = new System.DateTime(2018, 6, 7, 0, 0, 0, 0);
            this.Date_dateTimePicker_tab3.ValueChanged += new System.EventHandler(this.Date_dateTimePicker_tab3_ValueChanged);
            // 
            // TodayOrders_listBox_tab3
            // 
            this.TodayOrders_listBox_tab3.FormattingEnabled = true;
            this.TodayOrders_listBox_tab3.Location = new System.Drawing.Point(383, 59);
            this.TodayOrders_listBox_tab3.Name = "TodayOrders_listBox_tab3";
            this.TodayOrders_listBox_tab3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TodayOrders_listBox_tab3.Size = new System.Drawing.Size(326, 264);
            this.TodayOrders_listBox_tab3.TabIndex = 78;
            // 
            // TodayOrders_listBox_label_tab3
            // 
            this.TodayOrders_listBox_label_tab3.AutoSize = true;
            this.TodayOrders_listBox_label_tab3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayOrders_listBox_label_tab3.ForeColor = System.Drawing.Color.Black;
            this.TodayOrders_listBox_label_tab3.Location = new System.Drawing.Point(488, 33);
            this.TodayOrders_listBox_label_tab3.Name = "TodayOrders_listBox_label_tab3";
            this.TodayOrders_listBox_label_tab3.Size = new System.Drawing.Size(225, 23);
            this.TodayOrders_listBox_label_tab3.TabIndex = 77;
            this.TodayOrders_listBox_label_tab3.Text = "רשימת הזמנות שבוצעו בתאריך:";
            // 
            // TodayRentEnd_tab4
            // 
            this.TodayRentEnd_tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(147)))), ((int)(((byte)(156)))));
            this.TodayRentEnd_tab4.Controls.Add(this.ReturnDate_dateTimePicker_tab4);
            this.TodayRentEnd_tab4.Controls.Add(this.TodayRentEnd_listBox_tab4);
            this.TodayRentEnd_tab4.Controls.Add(this.TodayRentEnd_listBox_label_tab4);
            this.TodayRentEnd_tab4.Location = new System.Drawing.Point(4, 22);
            this.TodayRentEnd_tab4.Name = "TodayRentEnd_tab4";
            this.TodayRentEnd_tab4.Padding = new System.Windows.Forms.Padding(3);
            this.TodayRentEnd_tab4.Size = new System.Drawing.Size(766, 478);
            this.TodayRentEnd_tab4.TabIndex = 3;
            this.TodayRentEnd_tab4.Text = "הזמנות שתקופת ההשכרה שלהן מסתיימת ";
            // 
            // ReturnDate_dateTimePicker_tab4
            // 
            this.ReturnDate_dateTimePicker_tab4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDate_dateTimePicker_tab4.Location = new System.Drawing.Point(532, 63);
            this.ReturnDate_dateTimePicker_tab4.MaxDate = new System.DateTime(2018, 4, 27, 0, 0, 0, 0);
            this.ReturnDate_dateTimePicker_tab4.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ReturnDate_dateTimePicker_tab4.Name = "ReturnDate_dateTimePicker_tab4";
            this.ReturnDate_dateTimePicker_tab4.Size = new System.Drawing.Size(97, 20);
            this.ReturnDate_dateTimePicker_tab4.TabIndex = 117;
            this.ReturnDate_dateTimePicker_tab4.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.ReturnDate_dateTimePicker_tab4.ValueChanged += new System.EventHandler(this.ReturnDate_dateTimePicker_tab4_ValueChanged);
            // 
            // TodayRentEnd_listBox_tab4
            // 
            this.TodayRentEnd_listBox_tab4.FormattingEnabled = true;
            this.TodayRentEnd_listBox_tab4.Location = new System.Drawing.Point(358, 86);
            this.TodayRentEnd_listBox_tab4.Name = "TodayRentEnd_listBox_tab4";
            this.TodayRentEnd_listBox_tab4.Size = new System.Drawing.Size(339, 225);
            this.TodayRentEnd_listBox_tab4.TabIndex = 115;
            // 
            // TodayRentEnd_listBox_label_tab4
            // 
            this.TodayRentEnd_listBox_label_tab4.AutoSize = true;
            this.TodayRentEnd_listBox_label_tab4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayRentEnd_listBox_label_tab4.ForeColor = System.Drawing.Color.Black;
            this.TodayRentEnd_listBox_label_tab4.Location = new System.Drawing.Point(358, 37);
            this.TodayRentEnd_listBox_label_tab4.Name = "TodayRentEnd_listBox_label_tab4";
            this.TodayRentEnd_listBox_label_tab4.Size = new System.Drawing.Size(343, 46);
            this.TodayRentEnd_listBox_label_tab4.TabIndex = 114;
            this.TodayRentEnd_listBox_label_tab4.Text = "רשימת הזמנות שתקופת ההשכרה שלהן מסתיימת\r\nבתאריך:\r\n";
            // 
            // Form_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(774, 504);
            this.Controls.Add(this.ReportsTabs_tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Reports";
            this.Text = "Form_Reports";
            this.ReportsTabs_tabControl.ResumeLayout(false);
            this.OutOfStockProducts_tab1.ResumeLayout(false);
            this.OutOfStockProducts_tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCount_numericUpDown_tab1)).EndInit();
            this.ReturnDatePast_tab2.ResumeLayout(false);
            this.ReturnDatePast_tab2.PerformLayout();
            this.ClientInfoForContact_groupBox_tab2.ResumeLayout(false);
            this.ClientInfoForContact_groupBox_tab2.PerformLayout();
            this.TodayOrders_tab3.ResumeLayout(false);
            this.TodayOrders_tab3.PerformLayout();
            this.TodayRentEnd_tab4.ResumeLayout(false);
            this.TodayRentEnd_tab4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ReportsTabs_tabControl;
        private System.Windows.Forms.TabPage OutOfStockProducts_tab1;
        private System.Windows.Forms.TabPage ReturnDatePast_tab2;
        private System.Windows.Forms.Label Orders_listBox_label_tab2;
        private System.Windows.Forms.ListBox Orders_listBox_tab2;
        private System.Windows.Forms.Label OrderCostNum_label_tab2;
        private System.Windows.Forms.Label OrderCost_label_tab2;
        private System.Windows.Forms.DateTimePicker Date_dateTimePicker_tab2;
        private System.Windows.Forms.Label IDnum_Label_tab2;
        private System.Windows.Forms.Label ID_label_tab2;
        private System.Windows.Forms.TextBox Comment_textBox_tab2;
        private System.Windows.Forms.Label Comment_label_tab2;
        private System.Windows.Forms.Label Date_label_tab2;
        private System.Windows.Forms.Label ClientFullNameHyphen_label_tab2;
        private System.Windows.Forms.Label ClientFullName_tab2;
        private System.Windows.Forms.GroupBox ClientInfoForContact_groupBox_tab2;
        private System.Windows.Forms.ListBox Products_listBox_tab1;
        private System.Windows.Forms.Label Products_listBox_label_tab1;
        private System.Windows.Forms.NumericUpDown ProductCount_numericUpDown_tab1;
        private System.Windows.Forms.Label CountProduct_label_tab1;
        private System.Windows.Forms.TabPage TodayOrders_tab3;
        private System.Windows.Forms.ListBox TodayOrders_listBox_tab3;
        private System.Windows.Forms.Label TodayOrders_listBox_label_tab3;
        private System.Windows.Forms.TabPage TodayRentEnd_tab4;
        private System.Windows.Forms.ListBox TodayRentEnd_listBox_tab4;
        private System.Windows.Forms.Label TodayRentEnd_listBox_label_tab4;
        private System.Windows.Forms.DateTimePicker ReturnDate_dateTimePicker_tab4;
        private System.Windows.Forms.Label Phone_label_tab2;
        private System.Windows.Forms.Label PhoneHyphen_label_tab2;
        private System.Windows.Forms.DateTimePicker Date_dateTimePicker_tab3;
    }
}
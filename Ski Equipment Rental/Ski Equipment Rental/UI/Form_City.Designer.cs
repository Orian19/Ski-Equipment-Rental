namespace Ski_Equipment_Rental.UI
{
    partial class Form_City
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
            this.Clear_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.CityListBox_label = new System.Windows.Forms.Label();
            this.City_listBox = new System.Windows.Forms.ListBox();
            this.CityName_label = new System.Windows.Forms.Label();
            this.IDnum_Label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.CityName_textBox = new System.Windows.Forms.TextBox();
            this.Exit_panel = new System.Windows.Forms.Panel();
            this.Exit_label = new System.Windows.Forms.Label();
            this.Exit_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Clear_button.Location = new System.Drawing.Point(109, 135);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(60, 28);
            this.Clear_button.TabIndex = 69;
            this.Clear_button.Text = "נקה";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Save_button.Location = new System.Drawing.Point(33, 135);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(70, 28);
            this.Save_button.TabIndex = 67;
            this.Save_button.Text = "שמור";
            this.Save_button.UseVisualStyleBackColor = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Delete_button.Location = new System.Drawing.Point(175, 135);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(51, 28);
            this.Delete_button.TabIndex = 68;
            this.Delete_button.Text = "מחק";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // CityListBox_label
            // 
            this.CityListBox_label.AutoSize = true;
            this.CityListBox_label.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityListBox_label.Location = new System.Drawing.Point(351, 5);
            this.CityListBox_label.Name = "CityListBox_label";
            this.CityListBox_label.Size = new System.Drawing.Size(127, 25);
            this.CityListBox_label.TabIndex = 71;
            this.CityListBox_label.Text = "רשימת יישובים";
            // 
            // City_listBox
            // 
            this.City_listBox.FormattingEnabled = true;
            this.City_listBox.Location = new System.Drawing.Point(264, 53);
            this.City_listBox.Name = "City_listBox";
            this.City_listBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.City_listBox.Size = new System.Drawing.Size(197, 238);
            this.City_listBox.TabIndex = 70;
            this.City_listBox.Click += new System.EventHandler(this.listBox_City_Click);
            // 
            // CityName_label
            // 
            this.CityName_label.AutoSize = true;
            this.CityName_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.CityName_label.Location = new System.Drawing.Point(149, 84);
            this.CityName_label.Name = "CityName_label";
            this.CityName_label.Size = new System.Drawing.Size(83, 23);
            this.CityName_label.TabIndex = 75;
            this.CityName_label.Text = "שם היישוב";
            // 
            // IDnum_Label
            // 
            this.IDnum_Label.AutoSize = true;
            this.IDnum_Label.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold);
            this.IDnum_Label.Location = new System.Drawing.Point(125, 56);
            this.IDnum_Label.Name = "IDnum_Label";
            this.IDnum_Label.Size = new System.Drawing.Size(18, 20);
            this.IDnum_Label.TabIndex = 74;
            this.IDnum_Label.Text = "0";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.ID_label.Location = new System.Drawing.Point(186, 53);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(46, 23);
            this.ID_label.TabIndex = 73;
            this.ID_label.Text = "מזהה";
            // 
            // CityName_textBox
            // 
            this.CityName_textBox.Location = new System.Drawing.Point(41, 86);
            this.CityName_textBox.Name = "CityName_textBox";
            this.CityName_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CityName_textBox.Size = new System.Drawing.Size(102, 20);
            this.CityName_textBox.TabIndex = 76;
            this.CityName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HebrewText_KeyPress);
            // 
            // Exit_panel
            // 
            this.Exit_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Exit_panel.Controls.Add(this.Exit_label);
            this.Exit_panel.Controls.Add(this.CityListBox_label);
            this.Exit_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit_panel.Location = new System.Drawing.Point(0, 0);
            this.Exit_panel.Name = "Exit_panel";
            this.Exit_panel.Size = new System.Drawing.Size(490, 35);
            this.Exit_panel.TabIndex = 77;
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
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(490, 310);
            this.Controls.Add(this.Exit_panel);
            this.Controls.Add(this.CityName_textBox);
            this.Controls.Add(this.CityName_label);
            this.Controls.Add(this.IDnum_Label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.City_listBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_City";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.listBox_City_Click);
            this.Exit_panel.ResumeLayout(false);
            this.Exit_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label CityListBox_label;
        private System.Windows.Forms.ListBox City_listBox;
        private System.Windows.Forms.Label CityName_label;
        private System.Windows.Forms.Label IDnum_Label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.TextBox CityName_textBox;
        private System.Windows.Forms.Panel Exit_panel;
        private System.Windows.Forms.Label Exit_label;
    }
}
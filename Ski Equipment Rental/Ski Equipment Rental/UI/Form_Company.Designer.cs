namespace Ski_Equipment_Rental.UI
{
    partial class Form_Company
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
            this.Exit_label = new System.Windows.Forms.Label();
            this.CompanyListBox_label = new System.Windows.Forms.Label();
            this.CompanyName_textBox = new System.Windows.Forms.TextBox();
            this.CompanyName_label = new System.Windows.Forms.Label();
            this.IDnum_Label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Company_listBox = new System.Windows.Forms.ListBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Exit_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_panel
            // 
            this.Exit_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Exit_panel.Controls.Add(this.Exit_label);
            this.Exit_panel.Controls.Add(this.CompanyListBox_label);
            this.Exit_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exit_panel.Location = new System.Drawing.Point(0, 0);
            this.Exit_panel.Name = "Exit_panel";
            this.Exit_panel.Size = new System.Drawing.Size(490, 35);
            this.Exit_panel.TabIndex = 78;
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
            // CompanyListBox_label
            // 
            this.CompanyListBox_label.AutoSize = true;
            this.CompanyListBox_label.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyListBox_label.Location = new System.Drawing.Point(352, 5);
            this.CompanyListBox_label.Name = "CompanyListBox_label";
            this.CompanyListBox_label.Size = new System.Drawing.Size(126, 25);
            this.CompanyListBox_label.TabIndex = 83;
            this.CompanyListBox_label.Text = "רשימת חברות ";
            // 
            // CompanyName_textBox
            // 
            this.CompanyName_textBox.Location = new System.Drawing.Point(47, 85);
            this.CompanyName_textBox.Name = "CompanyName_textBox";
            this.CompanyName_textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CompanyName_textBox.Size = new System.Drawing.Size(102, 20);
            this.CompanyName_textBox.TabIndex = 88;
            // 
            // CompanyName_label
            // 
            this.CompanyName_label.AutoSize = true;
            this.CompanyName_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.CompanyName_label.Location = new System.Drawing.Point(155, 84);
            this.CompanyName_label.Name = "CompanyName_label";
            this.CompanyName_label.Size = new System.Drawing.Size(85, 23);
            this.CompanyName_label.TabIndex = 87;
            this.CompanyName_label.Text = "שם החברה";
            // 
            // IDnum_Label
            // 
            this.IDnum_Label.AutoSize = true;
            this.IDnum_Label.Font = new System.Drawing.Font("Rockwell", 12.75F, System.Drawing.FontStyle.Bold);
            this.IDnum_Label.Location = new System.Drawing.Point(131, 55);
            this.IDnum_Label.Name = "IDnum_Label";
            this.IDnum_Label.Size = new System.Drawing.Size(18, 20);
            this.IDnum_Label.TabIndex = 86;
            this.IDnum_Label.Text = "0";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.ID_label.Location = new System.Drawing.Point(192, 53);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(46, 23);
            this.ID_label.TabIndex = 85;
            this.ID_label.Text = "מזהה";
            // 
            // Company_listBox
            // 
            this.Company_listBox.FormattingEnabled = true;
            this.Company_listBox.Location = new System.Drawing.Point(266, 53);
            this.Company_listBox.Name = "Company_listBox";
            this.Company_listBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Company_listBox.Size = new System.Drawing.Size(197, 238);
            this.Company_listBox.TabIndex = 82;
            this.Company_listBox.Click += new System.EventHandler(this.listBox_Company_Click);
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Clear_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Clear_button.Location = new System.Drawing.Point(115, 135);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(60, 28);
            this.Clear_button.TabIndex = 81;
            this.Clear_button.Text = "נקה";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.Save_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_button.Font = new System.Drawing.Font("Rockwell", 12.75F);
            this.Save_button.Location = new System.Drawing.Point(39, 135);
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
            this.Delete_button.Location = new System.Drawing.Point(181, 135);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(51, 28);
            this.Delete_button.TabIndex = 80;
            this.Delete_button.Text = "מחק";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Form_Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(490, 310);
            this.Controls.Add(this.CompanyName_textBox);
            this.Controls.Add(this.CompanyName_label);
            this.Controls.Add(this.IDnum_Label);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.Company_listBox);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Exit_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Company";
            this.Exit_panel.ResumeLayout(false);
            this.Exit_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Exit_panel;
        private System.Windows.Forms.Label Exit_label;
        private System.Windows.Forms.TextBox CompanyName_textBox;
        private System.Windows.Forms.Label CompanyName_label;
        private System.Windows.Forms.Label IDnum_Label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label CompanyListBox_label;
        private System.Windows.Forms.ListBox Company_listBox;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Delete_button;
    }
}
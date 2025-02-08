using Ski_Equipment_Rental.BL;
using Ski_Equipment_Rental.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Equipment_Rental
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        #region Controls
        private void Minimized_label_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Exit_label_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Enabling_buttons(bool IsLogin)
        {
            if (IsLogin)
            {
                Clients_button.Enabled = true;
                Equipment_button.Enabled = true;
                RentEquipment_button.Enabled = true;
                Logout_button.Visible = true;
            }

            else
            {
                Clients_button.Enabled = false;
                Equipment_button.Enabled = false;
                RentEquipment_button.Enabled = false;
                Logout_button.Visible = false;
                ChartsData_button.Visible = false;
                Employee_button.Visible = false;
                Reports_button.Visible = false;
            }
            
        }
        private void AdminAccess()
        {
            ChartsData_button.Visible = true;
            Employee_button.Visible = true;
            Reports_button.Visible = true;
        }
        private void VisibleLogin(bool IsLogin)
        {
            if (IsLogin)
            {
                Login_groupBox.Visible = false;
            }
            else
            {
                Content_panel.Controls.Clear();
                Content_panel.Show();
                Content_panel.Controls.Add(Login_groupBox);
                Login_groupBox.Visible = true;

                Username_textBox.Text = null;
                Password_textBox.Text = null;
            }
        }
        private void Password_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_button_Click(null, null);
            }
        }
        #endregion

        #region Checks - בדיקות תקינות הטופס
        private bool CheckForm()
        {
            //בדיקת תקינות הטופס

            bool flag = true;

            if (Username_textBox.Text.Length == 0)
            {
                flag = false;
                Username_textBox.BackColor = Color.Red;
            }
            else
                Username_textBox.BackColor = Color.White;

            if (Password_textBox.Text.Length == 0)
            {
                flag = false;
                Password_textBox.BackColor = Color.Red;
            }
            else
                Password_textBox.BackColor = Color.White;

            return flag;
        } 
        #endregion

        #region Buttons - כפתורים
        private void Clients_button_Click(object sender, EventArgs e)
        {
            Content_panel.Controls.Clear();
            Form_Client formClient = new Form_Client();
            formClient.TopLevel = false;

            Content_panel.Controls.Add(formClient);
            formClient.Show();
        }
        private void Equipment_button_Click(object sender, EventArgs e)
        {
            Content_panel.Controls.Clear();
            Form_Product formProduct = new Form_Product();
            formProduct.TopLevel = false;

            Content_panel.Controls.Add(formProduct);
            formProduct.Show();
        }
        private void Orders_button_Click(object sender, EventArgs e)
        {
            Content_panel.Controls.Clear();
            Form_Order formOrder = new Form_Order();
            formOrder.TopLevel = false;

            Content_panel.Controls.Add(formOrder);
            formOrder.Show();
        }
        private void Employee_button_Click(object sender, EventArgs e)
        {
            Content_panel.Controls.Clear();
            Form_Employee formEmployee = new Form_Employee();
            formEmployee.TopLevel = false;

            Content_panel.Controls.Add(formEmployee);
            formEmployee.Show();
        }
        private void ChartsData_button_Click(object sender, EventArgs e)
        {
            Content_panel.Controls.Clear();
            Form_Charts formChart = new Form_Charts();
            formChart.TopLevel = false;

            Content_panel.Controls.Add(formChart);
            formChart.Show();
        }
        private void Reports_button_Click(object sender, EventArgs e)
        {
            Content_panel.Controls.Clear();
            Form_Reports formReports = new Form_Reports();
            formReports.TopLevel = false;

            Content_panel.Controls.Add(formReports);
            formReports.Show();
        }


        private void Login_button_Click(object sender, EventArgs e)
        {
            MainArr loginArr = new MainArr();
            loginArr.Fill();

            bool correct = false;
            bool isAdmin = false;

            if (!CheckForm())
            {
                MessageBox.Show("יש למלא את כל שדות החובה!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }

            else
            {
                for (int i = 0; i < loginArr.Count; i++)
                {
                    //בודק באוסף העובדים האם קיים עובד שמתאים לפרטים שהוזנו בטופס
                    Main login = loginArr[i] as Main;

                    if (login.UserName == Username_textBox.Text && login.Password == Password_textBox.Text)
                    {
                        if (login.IsAdmin)
                        {
                            isAdmin = true;
                        }
                        correct = true;
                        break;
                    }
                }

                if (correct && isAdmin)
                {
                    MessageBox.Show("התחברת בהצלחה!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    VisibleLogin(true);
                    Enabling_buttons(true);
                    AdminAccess();
                }
                else if (correct)
                {
                    MessageBox.Show("התחברת בהצלחה!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    VisibleLogin(true);
                    Enabling_buttons(true);
                }
                else
                {
                    MessageBox.Show("שם המשתמש או הסיסמה שגויים!", "שגיאה",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
            
        }
        private void Logout_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("את/ה בטוח/ה שברצונך להתנתק מהמערכת?", "אזהרה", MessageBoxButtons.YesNo
               , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
               MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
            {
                Enabling_buttons(false);
                VisibleLogin(false);
            }
        }
        #endregion

        #region ButtonsColorChange
        private void Clients_button_MouseEnter(object sender, EventArgs e)
        {
            Clients_button.Font = new Font(Clients_button.Font, FontStyle.Bold);
            Clients_button.ForeColor = Color.Yellow;
        }
        private void Clients_button_MouseLeave(object sender, EventArgs e)
        {
            Clients_button.Font = new Font(Clients_button.Font, FontStyle.Regular);
            Clients_button.ForeColor = Color.White;
        }

        private void Equipment_button_MouseEnter(object sender, EventArgs e)
        {
            Equipment_button.Font = new Font(Equipment_button.Font, FontStyle.Bold);
            Equipment_button.ForeColor = Color.Yellow;
        }
        private void Equipment_button_MouseLeave(object sender, EventArgs e)
        {
            Equipment_button.Font = new Font(Equipment_button.Font, FontStyle.Regular);
            Equipment_button.ForeColor = Color.White;
        }

        private void Orders_button_MouseEnter(object sender, EventArgs e)
        {
            RentEquipment_button.Font = new Font(RentEquipment_button.Font, FontStyle.Bold);
            RentEquipment_button.ForeColor = Color.Yellow;
        }
        private void Orders_button_MouseLeave(object sender, EventArgs e)
        {
            RentEquipment_button.Font = new Font(RentEquipment_button.Font, FontStyle.Regular);
            RentEquipment_button.ForeColor = Color.White;
        }

        private void Employee_button_MouseEnter(object sender, EventArgs e)
        {
            Employee_button.Font = new Font(Employee_button.Font, FontStyle.Bold);
            Employee_button.ForeColor = Color.Yellow;
        }
        private void Employee_button_MouseLeave(object sender, EventArgs e)
        {
            Employee_button.Font = new Font(Employee_button.Font, FontStyle.Regular);
            Employee_button.ForeColor = Color.White;
        }

        private void ChartsData_button_MouseEnter(object sender, EventArgs e)
        {
            ChartsData_button.Font = new Font(ChartsData_button.Font, FontStyle.Bold);
            ChartsData_button.ForeColor = Color.Yellow;
        }
        private void ChartsData_button_MouseLeave(object sender, EventArgs e)
        {
            ChartsData_button.Font = new Font(ChartsData_button.Font, FontStyle.Regular);
            ChartsData_button.ForeColor = Color.White;
        }

        private void Reports_button_MouseEnter(object sender, EventArgs e)
        {
            Reports_button.Font = new Font(Reports_button.Font, FontStyle.Bold);
            Reports_button.ForeColor = Color.Yellow;
        }
        private void Reports_button_MouseLeave(object sender, EventArgs e)
        {
            Reports_button.Font = new Font(Reports_button.Font, FontStyle.Regular);
            Reports_button.ForeColor = Color.White;
        }
        #endregion

        #region Connection Between Layers - קשר בין השכבות
        private Main FormToLogin()
        {
            Main login = new Main();
            login.UserName = Username_textBox.Text;
            login.Password = Password_textBox.Text;

            return login;
        }
        private void LoginToForm(Main login)
        {
            //ממירה את המידע בטנ"מ לטופס

            if (login != null)
            {
                Username_textBox.Text = login.UserName;
                Password_textBox.Text = login.Password;
            }

            else
            {
                Username_textBox.Text = "";
                Password_textBox.Text = "";
            }
        }
        private void LoginArrToForm()
        {
            //ממירה את הטנ"מ אוסף לטופס
            MainArr loginArr = new MainArr();
            loginArr.Fill();
        }
        #endregion

    }
}

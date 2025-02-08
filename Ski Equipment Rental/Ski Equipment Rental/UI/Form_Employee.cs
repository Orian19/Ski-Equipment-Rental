using Ski_Equipment_Rental.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Equipment_Rental.UI
{
    public partial class Form_Employee : Form
    {
        public Form_Employee()
        {
            InitializeComponent();

            EmployeeArrToForm();
            CityArrToForm(null);
        }

        #region Checks - בדיקות תקינות הטופס
        private bool IsHebrewLetter(char letter)
        {
            return (letter >= 'א' && letter <= 'ת');
        }
        private void CapsLockCheck()
        {
            //הצגת הודעה במידה ומקש ה-הקאפסלוק של המשתמש פתוח
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("מקש ה-CapsLock פתוח", "",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }
        private bool CheckForm()
        {
            //בדיקת תקינות הטופס

            bool flag = true;

            if (FirstName_textBox.Text.Length < 2)
            {
                flag = false;
                FirstName_textBox.BackColor = Color.Red;
            }
            else
                FirstName_textBox.BackColor = Color.Lime;

            if (LastName_textBox.Text.Length < 2)
            {
                flag = false;
                LastName_textBox.BackColor = Color.Red;
            }
            else
                LastName_textBox.BackColor = Color.Lime;

            if (!GenderMan_radioButton.Checked && !GenderOther_radioButton.Checked && !GenderWoman_radioButton.Checked)
            {
                flag = false;
            }

            if (!Regular_radioButton.Checked && !Admin_radioButton.Checked)
            {
                flag = false;
            }

            if (PhoneNumber_textBox.Text.Length != 7)
            {
                flag = false;
                PhoneNumber_textBox.BackColor = Color.Red;
            }
            else
                PhoneNumber_textBox.BackColor = Color.Lime;

            if (PrefixPhone_comboBox.Text.Length != 3)
            {
                flag = false;
                PrefixPhone_comboBox.BackColor = Color.Red;
            }
            else
                PrefixPhone_comboBox.BackColor = Color.Lime;

            if (Id_textBox.Text.Length != 9)
            {
                flag = false;
                Id_textBox.BackColor = Color.Red;
            }
            else
                Id_textBox.BackColor = Color.Lime;

            if (!Email_textBox.Text.Contains("@"))
            {
                flag = false;
                Email_textBox.BackColor = Color.Red;
            }
            else
                Email_textBox.BackColor = Color.Lime;

            if (City_comboBox.Text.Length == 0)
            {
                flag = false;
                City_comboBox.BackColor = Color.Red;
            }

            if (City_comboBox.SelectedItem != null)
            {
                if ((int)City_comboBox.SelectedValue < 0)
                {
                    flag = false;
                    City_comboBox.BackColor = Color.Red;
                }
                else
                    City_comboBox.BackColor = Color.Lime;
            }
            if (Username_textBox.Text.Length < 2)
            {
                flag = false;
                Username_textBox.BackColor = Color.Red;
            }
            else
                Username_textBox.BackColor = Color.Lime;

            if (Password_textBox.Text.Length < 2)
            {
                flag = false;
                Password_textBox.BackColor = Color.Red;
            }
            else
                Password_textBox.BackColor = Color.Lime;

            return flag;
        }

        private void HebrewText_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (!IsHebrewLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.KeyChar = char.MinValue;
            }
        }
        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
        }
        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (IsHebrewLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
        }

        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_checkBox.Checked)
            {
                Password_textBox.PasswordChar = char.Parse("\0");
            }
            else
                Password_textBox.PasswordChar = '*';
        }

        #endregion

        #region Buttons - כפתורים
        private void Delete_button_Click(object sender, EventArgs e)
        {
            //מחיקת עובד קיים מהמערכת
            if (int.Parse(IDnum_Label.Text) == 0)
            {
                MessageBox.Show("לא נבחר עובד למחיקה", "אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Employee employee = FormToEmployee();

                if (MessageBox.Show(" אתה בטוח שברצונך למחוק את העובד?", "אזהרה",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                       MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                       == System.Windows.Forms.DialogResult.Yes)
                {
                    if (employee.Delete())
                    {
                        MessageBox.Show("העובד נמחק בהצלחה!", "מחיקה",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        EmployeeToForm(null);
                        EmployeeArrToForm();
                    }
                    else
                        MessageBox.Show("שגיאה במחיקה");
                }
            }

        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            //ניקוי הטופס
            EmployeeToForm(null);
            EmployeeArrToForm();
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            //שמירת הנתונים שהוזנו

            if (!CheckForm())
            {
                MessageBox.Show("יש למלא את כל שדות החובה!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Employee employee = FormToEmployee();

                if (employee.Id == 0)
                {
                    //הוספת עובד חדש
                    if (employee.Insert())
                    {
                        MessageBox.Show("נוסף בהצלחה", "הוספת עובד",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        Clear_button_Click(null, null);
                    }

                    else
                        MessageBox.Show("שגיאה בהוספה", "שגיאה",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }

                else
                {
                    //עדכון עובד קיים
                    if (employee.Update())
                    {
                        MessageBox.Show("הטופס עודכן בהצלחה", "עדכון",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        Clear_button_Click(null, null);
                    }

                    else
                        MessageBox.Show("שגיאה בעדכון", "שגיאה",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        private void City_button_Click(object sender, EventArgs e)
        {
            //פתיחת הטופס להוספת יישוב

            Form_City form_city;

            form_city = new Form_City();

            form_city.ShowDialog();

            CityArrToForm(form_city.SelectedCity);
        }

        private void Employee_listBox_Click(object sender, EventArgs e)
        {
            EmployeeToForm(Employee_listBox.SelectedItem as Employee);
        }
        #endregion

        #region Connection Between Layers - קשר בין השכבות
        private Employee FormToEmployee()
        {
            //ממירה את המידע בטופס לטנ"מ לעובד

            Employee employee = new Employee();
            employee.Id = int.Parse(IDnum_Label.Text);
            employee.Username = Username_textBox.Text;
            employee.Password = Password_textBox.Text;
            employee.IsAdmin = (Regular_radioButton.Checked ? false : Admin_radioButton.Checked ? true : false);
            employee.FirstName = FirstName_textBox.Text;
            employee.LastName = LastName_textBox.Text;
            employee.Gender = (GenderMan_radioButton.Checked ? "זכר" : (GenderWoman_radioButton.Checked ? "נקבה" : ((GenderOther_radioButton.Checked ? "אחר" : " "))));
            employee.MobilePhone = int.Parse(PhoneNumber_textBox.Text);
            employee.PrefixMobile = PrefixPhone_comboBox.Text;
            employee.BirthDate = BirthDate_dateTimePicker.Value;
            employee.Email = Email_textBox.Text;
            employee.EmployeeId = int.Parse(Id_textBox.Text);
            employee.City = (City_comboBox.SelectedItem as City);

            return employee;
        }
        private void EmployeeToForm(Employee employee)
        {
            //ממירה את המידע בטנ"מ לעובד לטופס

            if (employee != null)
            {
                IDnum_Label.Text = employee.Id.ToString();
                FirstName_textBox.Text = employee.FirstName;
                LastName_textBox.Text = employee.LastName;
                PhoneNumber_textBox.Text = employee.MobilePhone.ToString();
                PrefixPhone_comboBox.Text = employee.PrefixMobile;
                BirthDate_dateTimePicker.Value = employee.BirthDate;
                Id_textBox.Text = employee.EmployeeId.ToString();
                Email_textBox.Text = employee.Email;
                City_comboBox.SelectedValue = employee.City.Id;
                Username_textBox.Text = employee.Username;
                Password_textBox.Text = employee.Password;


                if (employee.Gender == "זכר")
                    GenderMan_radioButton.Checked = true;
                else
                    GenderMan_radioButton.Checked = false;

                if (employee.Gender == "נקבה")
                    GenderWoman_radioButton.Checked = true;
                else
                    GenderWoman_radioButton.Checked = false;

                if (employee.Gender == "אחר")
                    GenderOther_radioButton.Checked = true;
                else
                    GenderOther_radioButton.Checked = false;

                if (employee.IsAdmin)
                    Admin_radioButton.Checked = true;
                else
                    Admin_radioButton.Checked = false;

                if (!employee.IsAdmin)
                    Regular_radioButton.Checked = true;
                else
                    Regular_radioButton.Checked = false;

            }

            else
            {
                IDnum_Label.Text = "0";
                FirstName_textBox.Text = "";
                LastName_textBox.Text = "";
                PhoneNumber_textBox.Text = "";
                PrefixPhone_comboBox.Text = "";
                GenderWoman_radioButton.Checked = false;
                GenderMan_radioButton.Checked = false;
                GenderOther_radioButton.Checked = false;
                BirthDate_dateTimePicker.Value = BirthDate_dateTimePicker.MinDate;
                Id_textBox.Text = "";
                Email_textBox.Text = "";
                City_comboBox.Text = "בחר יישוב";
                Username_textBox.Text = "";
                Password_textBox.Text = "";
                Regular_radioButton.Checked = false;
                Admin_radioButton.Checked = false;
                IDFilter_textBox.Text = "";
                LastNameFilter_textBox.Text = "";
                LastNameFilter_textBox.Text = "";
                MobilePhoneFilter_textBox.Text = "";
                EmployeeIdFilter_textBox.Text = "";
                ShowPassword_checkBox.Checked = false;

                FirstName_textBox.BackColor = Color.White;
                LastName_textBox.BackColor = Color.White;
                Id_textBox.BackColor = Color.White;
                Email_textBox.BackColor = Color.White;
                PrefixPhone_comboBox.BackColor = Color.White;
                PhoneNumber_textBox.BackColor = Color.White;
                City_comboBox.BackColor = Color.White;
                Username_textBox.BackColor = Color.White;
                Password_textBox.BackColor = Color.White;
            }
        }
        private void EmployeeArrToForm()
        {
            //ממירה את הטנ"מ אוסף עובדים לטופס

            EmployeeArr employeeArr = new EmployeeArr();
            employeeArr.Fill();

            Employee_listBox.DataSource = employeeArr;
        }
        public void CityArrToForm(City curCity)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס

            CityArr CityArr = new CityArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City CityDefault = new City();
            CityDefault.Id = -1;
            CityDefault.CityName = "בחר יישוב";

            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            CityArr.Add(CityDefault);

            CityArr.Fill();

            City_comboBox.DataSource = CityArr;
            City_comboBox.ValueMember = "ID";
            City_comboBox.DisplayMember = "CityName";

            if (curCity != null)
                City_comboBox.SelectedValue = curCity.Id;
        }
        #endregion

        #region Filter
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int ID = 0;
            int employeeId = 0;

            if (EmployeeIdFilter_textBox.Text != "")
            {
                employeeId = int.Parse(EmployeeIdFilter_textBox.Text);
            }

            if (IDFilter_textBox.Text != "")
            {
                ID = int.Parse(IDFilter_textBox.Text);
            }

            EmployeeArr EmployeeArr = new EmployeeArr();
            EmployeeArr.Fill();

            EmployeeArr = EmployeeArr.Filter(ID, LastNameFilter_textBox.Text,
            MobilePhoneFilter_textBox.Text, employeeId);

            Employee_listBox.DataSource = EmployeeArr;
        }
        #endregion

    }
}

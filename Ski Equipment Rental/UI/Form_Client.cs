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
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();

            ClientArrToForm();
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

            if(City_comboBox.SelectedItem != null)
            {
                if((int)City_comboBox.SelectedValue < 0)
                {
                    flag = false;
                    City_comboBox.BackColor = Color.Red;
                }
                else
                    City_comboBox.BackColor = Color.Lime;
            }

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

            if (IsHebrewLetter(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
        }
        #endregion

        #region Buttons - כפתורים
        private void Delete_button_Click(object sender, EventArgs e)
        {
            //מחיקת לקוח קיים מהמערכת
            if (int.Parse(IDnum_Label.Text) == 0)
            {
                MessageBox.Show("לא נבחר לקוח למחיקה", "אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Client client = FormToClient();
                //לפני המחיקה - בדיקה שהלקוח לא בשימוש ביישויות אחרות
                //בדיקה עבור הזמנות

                OrderArr orderArr = new OrderArr();
                orderArr.Fill();

                if (orderArr.DoesExist(client))
                    MessageBox.Show("אין אפשרות למחוק את הלקוח, הוא קשור להזמנה אחת או יותר", "אזהרה",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if (MessageBox.Show(" אתה בטוח שברצונך למחוק את הלקוח?", "אזהרה",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (client.Delete())
                        {
                            MessageBox.Show("הלקוח נמחק בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            ClientToForm(null);
                            ClientArrToForm();
                        }
                        else
                            MessageBox.Show("שגיאה במחיקה");
                    }
                }

            }
        }
        private void Clear_button_Click(object sender, EventArgs e)
        {
            //ניקוי הטופס
            ClientToForm(null);
            ClientArrToForm();
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
                Client client = FormToClient();

                if (client.Id == 0)
                {
                    //הוספת לקוח חדש
                    if (client.Insert())
                    {
                        MessageBox.Show("נוסף בהצלחה", "הוספת לקוח",
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
                    //עדכון לקוח קיים
                    if (client.Update())
                    {
                        MessageBox.Show("הטופס עודכן בהצלחה", "עדכון לקוח",
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

        private void listBox_Client_Click(object sender, EventArgs e)
        {
            ClientToForm(Client_listBox.SelectedItem as Client);
        }
        #endregion

        #region Connection Between Layers - קשר בין השכבות
        private Client FormToClient()
        {
            //ממירה את המידע בטופס לטנ"מ לקוח

            Client client = new Client();
            client.FirstName = FirstName_textBox.Text;
            client.LastName = LastName_textBox.Text;
            client.Gender = (GenderMan_radioButton.Checked ? "זכר" : (GenderWoman_radioButton.Checked ? "נקבה" : ((GenderOther_radioButton.Checked ? "אחר" : " "))));
            client.ClientId = int.Parse(Id_textBox.Text);
            client.MobilePhone = int.Parse(PhoneNumber_textBox.Text);
            client.PrefixMobile = PrefixPhone_comboBox.Text;
            client.BirthDate = BirthDate_dateTimePicker.Value;
            client.Email = Email_textBox.Text;
            client.Id = int.Parse(IDnum_Label.Text);
            client.City = (City_comboBox.SelectedItem as City);

            return client;
        }
        private void ClientToForm(Client client)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס

            if (client != null)
            {
                IDnum_Label.Text = client.Id.ToString();
                FirstName_textBox.Text = client.FirstName;
                LastName_textBox.Text = client.LastName;
                PhoneNumber_textBox.Text = client.MobilePhone.ToString();
                PrefixPhone_comboBox.Text = client.PrefixMobile;
                BirthDate_dateTimePicker.Value = client.BirthDate;
                Id_textBox.Text = client.ClientId.ToString();
                Email_textBox.Text = client.Email;
                City_comboBox.SelectedValue = client.City.Id;

                if (client.Gender == "זכר")
                    GenderMan_radioButton.Checked = true;
                else
                    GenderMan_radioButton.Checked = false;

                if (client.Gender == "נקבה")
                    GenderWoman_radioButton.Checked = true;
                else
                    GenderWoman_radioButton.Checked = false;

                if (client.Gender == "אחר")
                    GenderOther_radioButton.Checked = true;
                else
                    GenderOther_radioButton.Checked = false;

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
                IDFilter_textBox.Text = "";
                LastNameFilter_textBox.Text = "";
                LastNameFilter_textBox.Text = "";
                MobilePhoneFilter_textBox.Text = "";
                ClientIdFilter_textBox.Text = "";

                FirstName_textBox.BackColor = Color.White;
                LastName_textBox.BackColor = Color.White;
                Id_textBox.BackColor = Color.White;
                Email_textBox.BackColor = Color.White;
                PrefixPhone_comboBox.BackColor = Color.White;
                PhoneNumber_textBox.BackColor = Color.White;
                City_comboBox.BackColor = Color.White;
            }
        }
        private void ClientArrToForm()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            Client_listBox.DataSource = clientArr;
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
            int clientId = 0;

            if (ClientIdFilter_textBox.Text != "")
            {
                clientId = int.Parse(ClientIdFilter_textBox.Text);
            }

            if (IDFilter_textBox.Text != "")
            {
                ID = int.Parse(IDFilter_textBox.Text);
            }

            ClientArr ClientArr = new ClientArr();
            ClientArr.Fill();

            ClientArr = ClientArr.Filter(ID, LastNameFilter_textBox.Text,
            MobilePhoneFilter_textBox.Text, clientId);

            Client_listBox.DataSource = ClientArr;
        }
        #endregion
    }
}

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
    public partial class Form_City : Form
    {
        public Form_City()
        {
            InitializeComponent();

            CityArrToForm(null);
        }

        #region Controls
        private void Exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

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

            if (CityName_textBox.Text.Length < 2)
            {
                flag = false;
                CityName_textBox.BackColor = Color.Red;
            }
            else
                CityName_textBox.BackColor = Color.Lime;

            return flag;
        }

        private void HebrewText_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (!IsHebrewLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '-')
            {
                e.KeyChar = char.MinValue;
            }
        }
        #endregion

        #region Buttons - כפתורים
        private void Delete_button_Click(object sender, EventArgs e)
        {
            //מחיקת יישוב קיים מהמערכת

            City city = FormToCity();

            if (city.Id == 0)
            {
              MessageBox.Show("לא נבחר יישוב למחיקה", "אזהרה",
              MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
              MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                //לפני המחיקה - בדיקה שהישוב לא בשימוש ביישויות אחרות
                //בדיקה עבור לקוחות

                ClientArr clientArr = new ClientArr();
                clientArr.Fill();

                if (clientArr.DoesExist(city))
                    MessageBox.Show("אין אפשרות למחוק את היישוב, הוא קשור ללקוח אחד או יותר", "אזהרה",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if (MessageBox.Show(" אתה בטוח שברצונך למחוק את היישוב?", "אזהרה",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (city.Delete())
                        {


                            MessageBox.Show("היישוב נמחק בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            CityToForm(null);
                            CityArrToForm(null);

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
            CityToForm(null);
            CityArrToForm(null);
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
                City city = FormToCity();

                if (city.Id == 0)
                {

                    // בדיקה האם היישוב קיים כבר

                    CityArr oldCityArr = new CityArr();
                    oldCityArr.Fill();

                    if (!oldCityArr.IsContain(city.CityName))
                    {
                        //הוספת יישוב חדש
                        if (city.Insert())
                        {
                            MessageBox.Show("נוסף בהצלחה", "הוספת יישוב",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            Clear_button_Click(null, null);

                            //כיוון שמדובר על ישוב חדש, ניעזר במזהה הגבוה ביותר = הישוב האחרון שנוסף לטבלה

                            CityArr cityArr = new CityArr();
                            cityArr.Fill();
                            city = cityArr.GetCityWithMaxId();
                        }

                        else
                        {
                            CityName_textBox.BackColor = Color.Red;

                            MessageBox.Show("שגיאה בהוספה", "שגיאה",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        CityArrToForm(city);
                    }

                    else
                    {
                        CityName_textBox.BackColor = Color.Red;

                        MessageBox.Show("יישוב קיים", "הודעה",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }

                }

                else
                {
                    //עדכון יישוב קיים
                    if (city.Update())
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

                CityArrToForm(city);
            }
        }

        private void listBox_City_Click(object sender, EventArgs e)
        {
            CityToForm(City_listBox.SelectedItem as City);
        }
        #endregion

        #region Connection Between - קשר בין השכבות
        private City FormToCity()
        {
            //ממירה את המידע בטופס לטנ"מ יישוב 
            City City = new City();
            City.CityName = CityName_textBox.Text;
            City.Id = int.Parse(IDnum_Label.Text);

            return City;
        }
        private void CityToForm(City city)
        {
            //ממירה את המידע בטנ"מ יישוב לטופס

            if (city != null)
            {
                IDnum_Label.Text = city.Id.ToString();
                CityName_textBox.Text = city.CityName;
            }

            else
            {
                IDnum_Label.Text = "0";
                CityName_textBox.Text = "";

                CityName_textBox.BackColor = Color.White;
            }
        }
        private void CityArrToForm(City curCity)
        {
            //ממירה את הטנ"מ אוסף ישובים לטופס

            CityArr CityArr = new CityArr();

            CityArr.Fill();
            City_listBox.DataSource = CityArr;

            City_listBox.ValueMember = "Id";
            City_listBox.DisplayMember = "CityName";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCity != null)
                City_listBox.SelectedValue = curCity.Id;
        }

        #endregion

        public City SelectedCity
        {
            //סימון בטופס את השורה שמכילה את הישוב שנבחר
            get { return (City_listBox.SelectedItem as City); }
        }

    }
}

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
    public partial class Form_Company : Form
    {
        public Form_Company()
        {
            InitializeComponent();

            CompanyArrToForm(null);
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
            //הצגת הודעה במידה ומקש ה-קאפסלוק פתוח
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("מקש ה-CapsLock פתוח", "",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }
        private bool CheckForm()
        {
            bool flag = true;

            if (CompanyName_textBox.Text.Length < 2)
            {
                flag = false;
                CompanyName_textBox.BackColor = Color.Red;
            }
            else
                CompanyName_textBox.BackColor = Color.Lime;

            return flag;
        }

        private void HebrewText_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        #endregion

        #region Buttons - כפתורים
        private void Delete_button_Click(object sender, EventArgs e)
        {
            //מחיקת חברה קיימת מהמערכת
            Company company = FormToCompany();

            if (company.Id == 0)
            {
                MessageBox.Show("לא נבחרה חברה למחיקה", "אזהרה",
              MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
              MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                //לפני המחיקה - בדיקה שהחברה לא בשימוש ביישויות אחרות
                //בדיקה עבור מוצרים

                ProductArr productArr = new ProductArr();
                productArr.Fill();

                if (productArr.DoesExistCompany(company))
                    MessageBox.Show("אין אפשרות למחוק את החברה, היא קשורה למוצר אחד או יותר", "אזהרה",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if (MessageBox.Show(" אתה בטוח שברצונך למחוק את החברה?", "אזהרה",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (company.Delete())
                        {
                            MessageBox.Show("החברה נמחקה בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            CompanyToForm(null);
                            CompanyArrToForm(null);
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
            CompanyToForm(null);
            CompanyArrToForm(null);
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("יש למלא את כל שדות החובה!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Company company = FormToCompany();

                if (company.Id == 0)
                {

                    // בדיקה האם החברה קיימת כבר

                    CompanyArr oldCompanyArr = new CompanyArr();
                    oldCompanyArr.Fill();

                    if (!oldCompanyArr.IsContain(company.CompanyName))
                    {
                        //הוספת חברה חדשה
                        if (company.Insert())
                        {
                            MessageBox.Show("נוסף בהצלחה", "הוספת חברה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            Clear_button_Click(null, null);

                            //כיוון שמדובר על חברה חדש, ניעזר במזהה הגבוה ביותר = החברה האחרונה שנוספה לטבלה

                            CompanyArr companyArr = new CompanyArr();
                            companyArr.Fill();
                            company = companyArr.GetCompanyWithMaxId();
                        }

                        else
                        {
                            CompanyName_textBox.BackColor = Color.Red;

                            MessageBox.Show("שגיאה בהוספה", "שגיאה",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        CompanyArrToForm(company);
                    }

                    else
                    {
                        CompanyName_textBox.BackColor = Color.Red;

                        MessageBox.Show("חברה קיימת", "הודעה",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }

                }

                else
                {
                    //עדכון חברה קיים
                    if (company.Update())
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

                CompanyArrToForm(company);
            }
        }

        private void listBox_Company_Click(object sender, EventArgs e)
        {
            CompanyToForm(Company_listBox.SelectedItem as Company);
        }
        #endregion

        #region Connection Between Layers - קשר בין השכבות
        private Company FormToCompany()
        {
            //ממירה את המידע מהטופס לטנ"מ חברה
            Company Company = new Company();
            Company.CompanyName = CompanyName_textBox.Text;
            Company.Id = int.Parse(IDnum_Label.Text);

            return Company;
        }
        private void CompanyToForm(Company company)
        {
            //ממירה את המידע בטנ"מ חברה לטופס

            if (company != null)
            {
                IDnum_Label.Text = company.Id.ToString();
                CompanyName_textBox.Text = company.CompanyName;
            }

            else
            {
                IDnum_Label.Text = "0";
                CompanyName_textBox.Text = "";

                CompanyName_textBox.BackColor = Color.White;
            }
        }
        private void CompanyArrToForm(Company curCompany)
        {
            //ממירה את הטנ"מ אוסף חברות לטופס

            CompanyArr CompanyArr = new CompanyArr();

            CompanyArr.Fill();
            Company_listBox.DataSource = CompanyArr;

            Company_listBox.ValueMember = "Id";
            Company_listBox.DisplayMember = "CompanyName";

            //אם נשלח לפעולה חברה ,הצבתו בתיבת הבחירה של החברות בטופס

            if (curCompany != null)
                Company_listBox.SelectedValue = curCompany.Id;
        }
        #endregion

        public Company SelectedCompany
        {
            //סימון בטופס את השורה שמכילה את החברה שנבחרה
            get { return (Company_listBox.SelectedItem as Company); }
        }
    }
}

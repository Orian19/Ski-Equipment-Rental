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
    public partial class Form_SkillLevel : Form
    {
        public Form_SkillLevel()
        {
            InitializeComponent();

            SkillLevelArrToForm(null);
        }

        #region Controls
        private void Exit_label_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Checkes - בדיקות תקינות הטופס
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

            if (SkillLevelName_textBox.Text.Length < 2)
            {
                flag = false;
                SkillLevelName_textBox.BackColor = Color.Red;
            }
            else
                SkillLevelName_textBox.BackColor = Color.Lime;

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
            SkillLevel skillLevel = FormToSkillLevel();

            //מחיקת רמת מיומנות קיימת מהמערכת 
            if (skillLevel.Id == 0)
            {
                MessageBox.Show("לא נבחרה רמת מיומנות", "אזהרה",
              MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
              MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                //לפני המחיקה - בדיקה שרמת המיומנות לא בשימוש ביישויות אחרות
                //בדיקה עבור מוצרים

                ProductArr productArr = new ProductArr();
                productArr.Fill();

                if (productArr.DoesExistSkillLevel(skillLevel))
                    MessageBox.Show("אין אפשרות למחוק את רמת המיומנות, היא קשורה למוצר אחד או יותר", "אזהרה",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if (MessageBox.Show(" אתה בטוח שברצונך למחוק את רמת המיומנות?", "אזהרה",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                      MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                      == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (skillLevel.Delete())
                        {
                            MessageBox.Show("רמת המיומנות נמחקה בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            SkillLevelToForm(null);
                            SkillLevelArrToForm(null);
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
            SkillLevelToForm(null);
            SkillLevelArrToForm(null);
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
                SkillLevel skillLevel = FormToSkillLevel();

                if (skillLevel.Id == 0)
                {

                    // בדיקה האם רמת המיומנות קיימת כבר

                    SkillLevelArr oldSkillLevelArr = new SkillLevelArr();
                    oldSkillLevelArr.Fill();

                    if (!oldSkillLevelArr.IsContain(skillLevel.LevelName))
                    {
                        //הוספת רמת מיומנות חדשה
                        if (skillLevel.Insert())
                        {
                            MessageBox.Show("נוסף בהצלחה", "הוספת רמת מיומנות",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            Clear_button_Click(null, null);

                            //כיוון שמדובר על רמת מיומנות חדשה, ניעזר במזהה הגבוה ביותר = רמת המיומנות האחרונה שנוספה לטבלה

                            SkillLevelArr skillLevelArr = new SkillLevelArr();
                            skillLevelArr.Fill();
                            skillLevel = skillLevelArr.GetSkillLevelWithMaxId();
                        }

                        else
                        {
                            SkillLevelName_textBox.BackColor = Color.Red;

                            MessageBox.Show("שגיאה בהוספה", "שגיאה",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        SkillLevelArrToForm(skillLevel);
                    }

                    else
                    {
                        SkillLevelName_textBox.BackColor = Color.Red;

                        MessageBox.Show("רמת מיומנות זו קיימת", "הודעה",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }

                }

                else
                {
                    //עדכון רמת מיומנות קיימת
                    if (skillLevel.Update())
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

                SkillLevelArrToForm(skillLevel);
            }
        }

        private void listBox_SkillLevel_Click(object sender, EventArgs e)
        {
            SkillLevelToForm(SkillLevel_listBox.SelectedItem as SkillLevel);
        }
        #endregion

        #region Connections Between Layers - קשר בין השכבות
        private SkillLevel FormToSkillLevel()
        {
            //ממירה את המידע בטופס לטנ"מ רמת מיומנות

            SkillLevel skillLevel = new SkillLevel();
            skillLevel.LevelName = SkillLevelName_textBox.Text;
            skillLevel.Id = int.Parse(IDnum_Label.Text);

            return skillLevel;
        }
        private void SkillLevelToForm(SkillLevel skilLevel)
        {
            //ממירה את המידע בטנ"מ רמת מיומנות לטופס

            if (skilLevel != null)
            {
                IDnum_Label.Text = skilLevel.Id.ToString();
                SkillLevelName_textBox.Text = skilLevel.LevelName;
            }

            else
            {
                IDnum_Label.Text = "0";
                SkillLevelName_textBox.Text = "";

                SkillLevelName_textBox.BackColor = Color.White;
            }
        }
        private void SkillLevelArrToForm(SkillLevel curSkillLevel)
        {
            //ממירה את הטנ"מ אוסף רמות מיומנות לטופס

            SkillLevelArr skillLevelArr = new SkillLevelArr();

            skillLevelArr.Fill();
            SkillLevel_listBox.DataSource = skillLevelArr;

            SkillLevel_listBox.ValueMember = "Id";
            SkillLevel_listBox.DisplayMember = "LevelName";

            //אם נשלח לפעולה רמת מיומנות ,הצבתו בתיבת הבחירה של רמת מיומנות בטופס

            if (curSkillLevel != null)
                SkillLevel_listBox.SelectedValue = curSkillLevel.Id;
        }
        #endregion

        public SkillLevel SelectedSkillLevel
        {
            //סימון בטופס את השורה שמכילה את רמת המיומנות שנבחרה
            get { return (SkillLevel_listBox.SelectedItem as SkillLevel); }
        }
    }
}

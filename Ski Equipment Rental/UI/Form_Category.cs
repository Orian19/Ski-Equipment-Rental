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
    public partial class Form_Category : Form
    {
        public Form_Category()
        {
            InitializeComponent();

            CategoryArrToForm(null);
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

            if (CategoryName_textBox.Text.Length < 2)
            {
                flag = false;
                CategoryName_textBox.BackColor = Color.Red;
            }
            else
                CategoryName_textBox.BackColor = Color.Lime;

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
            Category category = FormToCategory();

            //מחיקת קטגוריה קיימת מהמערכת 
            if (category.Id == 0)
            {
                MessageBox.Show("לא נבחרה קטגוריה למחיקה", "אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                //לפני המחיקה - בדיקה שהקטגוריה לא בשימוש ביישויות אחרות
                //בדיקה עבור מוצרים

                ProductArr productArr = new ProductArr();
                productArr.Fill();

                if (productArr.DoesExistCategory(category))
                    MessageBox.Show("אין אפשרות למחוק את הקטגוריה, היא קשורה למוצר אחד או יותר", "אזהרה",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if (MessageBox.Show(" אתה בטוח שברצונך למחוק את הקטגוריה?", "אזהרה",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (category.Delete())
                        {
                            MessageBox.Show("הקטגוריה נמחקה בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            CategoryToForm(null);
                            CategoryArrToForm(null);
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
            CategoryToForm(null);
            CategoryArrToForm(null);
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
                Category category = FormToCategory();

                if (category.Id == 0)
                {

                    // בדיקה האם הקטגוריה קיימת כבר

                    CategoryArr oldCategoryArr = new CategoryArr();
                    oldCategoryArr.Fill();

                    if (!oldCategoryArr.IsContain(category.CategoryName))
                    {
                        //הוספת קטגוריה חדשה
                        if (category.Insert())
                        {
                            MessageBox.Show("נוסף בהצלחה", "הוספת קטגוריה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            Clear_button_Click(null, null);

                            //כיוון שמדובר על קטגוריה חדשה, ניעזר במזהה הגבוה ביותר = הקטגוריה האחרונה שנוספה לטבלה

                            CategoryArr categoryArr = new CategoryArr();
                            categoryArr.Fill();
                            category = categoryArr.GetCategoryWithMaxId();
                        }

                        else
                        {
                            CategoryName_textBox.BackColor = Color.Red;

                            MessageBox.Show("שגיאה בהוספה", "שגיאה",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        }
                        CategoryArrToForm(category);
                    }

                    else
                    {
                        CategoryName_textBox.BackColor = Color.Red;

                        MessageBox.Show("קטגוריה קיימת", "הודעה",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }

                }

                else
                {
                    //עדכון קטגוריה קיימת
                    if (category.Update())
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

                CategoryArrToForm(category);
            }
        }

        private void listBox_Category_Click(object sender, EventArgs e)
        {
            CategoryToForm(Category_listBox.SelectedItem as Category);
        }
        #endregion

        #region Connections Between Layers - קשר בין השכבות
        private Category FormToCategory()
        {
            //ממירה את המידע בטופס לטנ"מ קטגוריה

            Category Category = new Category();
            Category.CategoryName = CategoryName_textBox.Text;
            Category.Id = int.Parse(IDnum_Label.Text);

            return Category;
        }
        private void CategoryToForm(Category category)
        {
            //ממירה את המידע בטנ"מ קטגוריה לטופס

            if (category != null)
            {
                IDnum_Label.Text = category.Id.ToString();
                CategoryName_textBox.Text = category.CategoryName;
            }

            else
            {
                IDnum_Label.Text = "0";
                CategoryName_textBox.Text = "";

                CategoryName_textBox.BackColor = Color.White;
            }
        }
        private void CategoryArrToForm(Category curCategory)
        {
            //ממירה את הטנ"מ אוסף קטגוריות לטופס

            CategoryArr CategoryArr = new CategoryArr();

            CategoryArr.Fill();
            Category_listBox.DataSource = CategoryArr;

            Category_listBox.ValueMember = "Id";
            Category_listBox.DisplayMember = "CategoryName";

            //אם נשלח לפעולה קטגוריה ,הצבתו בתיבת הבחירה של קטגוריות בטופס

            if (curCategory != null)
                Category_listBox.SelectedValue = curCategory.Id;
        }
        #endregion

        public Category SelectedCategory
        {
            //סימון בטופס את השורה שמכילה את הקטגוריה שנבחרה
            get { return (Category_listBox.SelectedItem as Category); }
        }
    }
}

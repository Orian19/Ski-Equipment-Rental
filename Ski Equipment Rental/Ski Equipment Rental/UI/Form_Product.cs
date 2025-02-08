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
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();

            ProductArrToForm();

            CompanyArrToForm(null, CompanyNameFilter_comboBox, false);
            CompanyArrToForm(null, CompanyName_comboBox, true);
            CategoryArrToForm(null, CategoryNameFilter_comboBox, false);
            CategoryArrToForm(null, CategoryName_comboBox, true);
            SkillLevelArrToForm(null, SkillLevelNameFilter_comboBox, false);
            SkillLevelArrToForm(null, SkillLevelName_comboBox, true);
        }

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

            if (ProductName_textBox.Text.Length < 2)
            {
                flag = false;
                ProductName_textBox.BackColor = Color.Red;
            }
            else
                ProductName_textBox.BackColor = Color.Lime;

            if (CompanyName_comboBox.Text.Length == 0)
            {
                flag = false;
                CompanyName_comboBox.BackColor = Color.Red;
            }

            if (CompanyName_comboBox.SelectedItem != null)
            {
                if ((int)CompanyName_comboBox.SelectedValue < 0)
                {
                    flag = false;
                    CompanyName_comboBox.BackColor = Color.Red;
                }
                else
                    CompanyName_comboBox.BackColor = Color.Lime;
            }

            if (CategoryName_comboBox.Text.Length == 0)
            {
                flag = false;
                CategoryName_comboBox.BackColor = Color.Red;
            }

            if (CategoryName_comboBox.SelectedItem != null)
            {
                if ((int)CategoryName_comboBox.SelectedValue < 0)
                {
                    flag = false;
                    CategoryName_comboBox.BackColor = Color.Red;
                }
                else
                    CategoryName_comboBox.BackColor = Color.Lime;
            }

            if (SkillLevelName_comboBox.Text.Length == 0)
            {
                flag = false;
                SkillLevelName_comboBox.BackColor = Color.Red;
            }

            if (SkillLevelName_comboBox.SelectedItem != null)
            {
                if ((int)SkillLevelName_comboBox.SelectedValue < 0)
                {
                    flag = false;
                    SkillLevelName_comboBox.BackColor = Color.Red;
                }
                else
                    SkillLevelName_comboBox.BackColor = Color.Lime;
            }

            
            if (ProductCount_numericUpDown.Value <= 0)
            {
                flag = false;
                ProductCount_numericUpDown.BackColor = Color.Red;
            }
            else
                ProductCount_numericUpDown.BackColor = Color.Lime;

            if (Price_textBox.Text == "₪0.00") //|| int.Parse(Price_textBox.Text) == 0)
            {
                flag = false;
                Price_textBox.BackColor = Color.Red;
            }
            else
                Price_textBox.BackColor = Color.Lime;

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
        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' )
            {
                e.KeyChar = char.MinValue;
            }
        }

        private void Price_textBox_Click(object sender, EventArgs e)
        {
            Price_textBox.Text = "";
        }

        #endregion

        #region Buttons - כפתורים
        private void Delete_button_Click(object sender, EventArgs e)
        {
            //מחיקת מוצר קיים מהמערכת
            if (int.Parse(IDnum_Label.Text) == 0)
            {
                MessageBox.Show("לא נבחר מוצר למחיקה", "אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                Product product = Product_listBox.SelectedItem as Product;
                //לפני המחיקה - בדיקה שהמוצר לא בשימוש ביישויות אחרות
                //בדיקה עבור הזמנותמוצרים

                OrderProductArr orderProductArr = new OrderProductArr();
                orderProductArr.Fill();

                if (orderProductArr.DoesExist_Product(product))
                    MessageBox.Show("אין אפשרות למחוק את המוצר, הוא קשור להזמנה אחת או יותר", "אזהרה",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if(MessageBox.Show(" אתה בטוח שברצונך למחוק את המוצר?", "אזהרה",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (product.Delete())
                        {

                            MessageBox.Show("המוצר נמחק בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            ProductToForm(null);
                            ProductArrToForm();

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
            CompanyArrToForm(null, CompanyNameFilter_comboBox, false);
            CategoryArrToForm(null, CategoryNameFilter_comboBox, false);
            SkillLevelArrToForm(null, SkillLevelNameFilter_comboBox, false);

            ProductToForm(null);
            ProductArrToForm();
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
                Product product = FormToProduct();

                if (product.Id == 0)
                {
                    //הוספת מוצר חדש
                    if (product.Insert())
                    {
                        MessageBox.Show("המוצר נוסף בהצלחה", "הוספת מוצר",
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
                    //עדכון מוצר קיים
                    if (product.Update())
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

        private void Company_button_Click(object sender, EventArgs e)
        {
            Form_Company form_company;

            form_company = new Form_Company();

            form_company.ShowDialog();

            CompanyArrToForm(form_company.SelectedCompany, CompanyName_comboBox, true);
        }
        private void Category_button_Click(object sender, EventArgs e)
        {
            Form_Category form_category;

            form_category = new Form_Category();

            form_category.ShowDialog();

            CategoryArrToForm(form_category.SelectedCategory, CategoryName_comboBox, true);
        }
        private void SkillLevel_button_Click(object sender, EventArgs e)
        {
            Form_SkillLevel form_skillLevel;

            form_skillLevel = new Form_SkillLevel();

            form_skillLevel.ShowDialog();

            SkillLevelArrToForm(form_skillLevel.SelectedSkillLevel, SkillLevelName_comboBox, true);
        }

        private void listBox_Product_Click(object sender, EventArgs e)
        {
            ProductToForm(Product_listBox.SelectedItem as Product);
        }
        #endregion

        #region Connection Between Layers - קשר בין השכבות
        private Product FormToProduct()
        {
            //ממירה את המידע בטופס לטנ"מ מוצר

            Product product = new Product();
            product.ProductName = ProductName_textBox.Text;
            product.Id = int.Parse(IDnum_Label.Text);
            product.Company = (CompanyName_comboBox.SelectedItem as Company);
            product.Category = (CategoryName_comboBox.SelectedItem as Category);
            product.Count = (int)ProductCount_numericUpDown.Value;
            product.PricePerDay = decimal.Parse(Price_textBox.Text);
            product.SkillLevel = (SkillLevelName_comboBox.SelectedItem as SkillLevel);

            return product;
        }
        private void ProductToForm(Product product)
        {
            //ממירה את המידע בטנ"מ מוצר לטופס

            if (product != null)
            {
                IDnum_Label.Text = product.Id.ToString();
                ProductName_textBox.Text = product.ProductName;
                CompanyName_comboBox.SelectedValue = product.Company.Id;
                CategoryName_comboBox.SelectedValue = product.Category.Id;
                ProductCount_numericUpDown.Value = product.Count;
                Price_textBox.Text = "₪" + product.PricePerDay.ToString();
                SkillLevelName_comboBox.SelectedValue = product.SkillLevel.Id;
            }
            else
            {
                IDnum_Label.Text = "0";
                ProductName_textBox.Text = "";
                CompanyName_comboBox.Text = "בחר חברה";
                CategoryName_comboBox.Text = "בחר קטגוריה";
                SkillLevelName_comboBox.Text = "בחר רמת מיומנות";
                ProductCount_numericUpDown.Value = 0;
                IDFilter_textBox.Text = "";
                ProductNameFilter_textBox.Text = "";
                CompanyNameFilter_comboBox.Text = "כל החברות";
                CategoryNameFilter_comboBox.Text = "כל הקטגוריות";
                SkillLevelNameFilter_comboBox.Text = "כל הרמות";
                ProductCountFilter_numericUpDown.Value = 0;
                Price_textBox.Text = "₪0.00";

                ProductName_textBox.BackColor = Color.White;
                CompanyName_comboBox.BackColor = Color.White;
                CategoryName_comboBox.BackColor = Color.White;
                ProductCount_numericUpDown.BackColor = Color.White;
                Price_textBox.BackColor = Color.White;
                SkillLevelName_comboBox.BackColor = Color.White;

            }
        }
        private void ProductArrToForm()
        {
            //ממירה את הטנ"מ אוסף המוצרים לטופס

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            Product_listBox.DataSource = productArr;
        }
        public void CompanyArrToForm(Company curCompany, ComboBox comboBox, bool isMustChoose)
        {

            //ממירה את הטנ"מ אוסף החברות לטופס

            CompanyArr companyArr = new CompanyArr();

            //הוספת חברה ברירת מחדל - בחר חברה
            //יצירת מופע חדש של חברה עם מזהה מינוס 1 ושם מתאים

            Company companyDefault = new Company();
            companyDefault.Id = -1;

            if (isMustChoose)
                companyDefault.CompanyName = "בחר חברה";
            else
                companyDefault.CompanyName = "כל החברות";

            //הוספת החברה לאוסף החברות - אותו נציב במקור הנתונים של תיבת הבחירה

            companyArr.Add(companyDefault);

            companyArr.Fill();

            comboBox.DataSource = companyArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "CompanyName";

            if (curCompany != null)
                comboBox.SelectedValue = curCompany.Id;
        }
        public void CategoryArrToForm(Category curCategory, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף הקטגוריות לטופס

            CategoryArr categoryArr = new CategoryArr();

            //הוספת קטגוריה ברירת מחדל - בחר קטגוריה
            //יצירת מופע חדש של קטגוריה עם מזהה מינוס 1 ושם מתאים

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;

            if (isMustChoose)
                categoryDefault.CategoryName = "בחר קטגוריה";
            else
                categoryDefault.CategoryName = "כל הקטגוריות";

            //הוספת הקטגוריה לאוסף הקטגוריות - אותו נציב במקור הנתונים של תיבת הבחירה

            categoryArr.Add(categoryDefault);

            categoryArr.Fill();

            comboBox.DataSource = categoryArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "CategoryName";

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }
        public void SkillLevelArrToForm(SkillLevel curSkillLevel, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף רמת המיומנות לטופס

            SkillLevelArr skillLevelArr = new SkillLevelArr();

            //הוספת רמת מיומנות ברירת מחדל - בחר רמת מיומנות
            //יצירת מופע חדש של רמת מיומנות עם מזהה מינוס 1 ושם מתאים

            SkillLevel skillLevelDefault = new SkillLevel();
            skillLevelDefault.Id = -1;

            if (isMustChoose)
                skillLevelDefault.LevelName = "בחר רמת מיומנות";
            else
                skillLevelDefault.LevelName = "כל הרמות";

            //הוספת רמת המיומנות לאוסף רמות המיומנות - אותו נציב במקור הנתונים של תיבת הבחירה

            skillLevelArr.Add(skillLevelDefault);

            skillLevelArr.Fill();

            comboBox.DataSource = skillLevelArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "LevelName";

            if (curSkillLevel != null)
                comboBox.SelectedValue = curSkillLevel.Id;
        }
        #endregion

        #region Filter
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void SetProductsByFilter()
        {
            int Id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (IDFilter_textBox.Text != "")
                Id = int.Parse(IDFilter_textBox.Text);

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(Id, ProductNameFilter_textBox.Text,

            CompanyNameFilter_comboBox.SelectedItem as Company,
            CategoryNameFilter_comboBox.SelectedItem as Category,
            (int)ProductCountFilter_numericUpDown.Value,
            SkillLevelNameFilter_comboBox.SelectedItem as SkillLevel);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            Product_listBox.DataSource = productArr;
        }
        #endregion
    }
}

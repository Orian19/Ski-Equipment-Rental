using Ski_Equipment_Rental.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class CategoryArr : ArrayList
    {
        public void Fill()
        {
            //-DAL טבלה מלאה בכל הקטגוריות
            DataTable dataTable = Category_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הקטגוריות
            //להעביר כל שורה בטבלה לקטגוריה

            DataRow dataRow;
            Category category;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                category = new Category(dataRow);
                this.Add(category);
            }
        }

        public bool IsContain(string categoryName)
        {

            //בדיקה האם יש קטגוריה עם אותו שם
            //הסרת האותיות י', ו' משם הקטגוריה לבדיקה - כדי לשפר מניעת כפילות

            categoryName = categoryName.Replace("י", "");
            categoryName = categoryName.Replace("ו", "");
            string curCategoryName;

            for (int i = 0; i < this.Count; i++)
            {
                curCategoryName = (this[i] as Category).CategoryName;

                //הסרת האותיות י', ו' משם הקטגוריה הנוכחית - כדי לשפר מניעת כפילות

                curCategoryName = curCategoryName.Replace("י", "");
                curCategoryName = curCategoryName.Replace("ו", "");

                if (curCategoryName == categoryName)
                    return true;
            }
            return false;
        }

        public Category GetCategoryWithMaxId()
        {

            //מחזירה את הקטגוריה עם המזהה הגבוה ביותר

            Category maxCategory = new Category();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Category).Id > maxCategory.Id)
                    maxCategory = (this[i] as Category);

            }
            return maxCategory;
        }
    }
}

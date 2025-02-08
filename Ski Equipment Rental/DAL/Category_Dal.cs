using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Category_Dal
    {
        public static bool Insert(string categoryName)
        {

            //מוסיפה את הקטגוריה למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_Category"

            + " ("
            + "[CategoryName]"
            + ")"

            + " VALUES "
            + "("
            + "'" + categoryName + "'"
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_Category"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            // ממלאת את אוסף הטבלאות בטבלת הקטגוריות
            Dal.FillDataSet(dataSet, "table_Category", "CategoryName");

            // בהמשך יהיו כאן הוראות נופסות הקשורות לקשרי גומלין
        }

        public static bool Update(int id, string categoryName)
        {
            //מעדכנת את הקטגוריה במסד הנתונים

            string str = "UPDATE table_Category SET"
            + " " + "[CategoryName] = " + "'" + categoryName + "'"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את הקטגוריה ממסד הנתונים

            string str = "DELETE * FROM table_Category"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}

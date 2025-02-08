using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Company_Dal
    {
        public static bool Insert(string companyName)
        {
            //מוסיפה את החברה למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_Company"

            + " ("
            + "[CompanyName]"
            + ")"

            + " VALUES "
            + "("
            + "'" + companyName + "'"
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_Company"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            // ממלאת את אוסף הטבלאות בטבלת החברות
            Dal.FillDataSet(dataSet, "table_Company", "CompanyName");
        }

        public static bool Update(int id, string companyName)
        {
            //מעדכנת את החברה במסד הנתונים

            string str = "UPDATE table_Company SET"
            + " " + "[CompanyName] = " + "'" + companyName + "'"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את החברה ממסד הנתונים

            string str = "DELETE * FROM table_Company"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}

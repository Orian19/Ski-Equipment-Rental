using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class City_Dal
    {
        public static bool Insert(string cityName)
        {
            //מוסיפה את הארץ למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_City"

            + " ("
            + "[CityName]"
            + ")"

            + " VALUES "
            + "("
            + "'" + cityName + "'"
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_City"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            // ממלאת את אוסף הטבלאות בטבלת היישובים
            Dal.FillDataSet(dataSet, "table_City", "CityName");
        }

        public static bool Update(int Id, string cityName)
        {
            //מעדכנת את היישובים במסד הנתונים

            string str = "UPDATE table_City SET"
            + " " + "[CityName] = " + "'" + cityName + "'"
            + " WHERE ID = " + Id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int Id)
        {
            //מוחקת את היישוב ממסד הנתונים

            string str = "DELETE * FROM table_City"
            + " WHERE ID = " + Id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}

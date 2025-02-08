using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class SkillLevel_Dal
    {
        public static bool Insert(string levelName)
        {

            //מוסיפה את רמת המיומנות למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_SkillLevel"

            + " ("
            + "[LevelName]"
            + ")"

            + " VALUES "
            + "("
            + "'" + levelName + "'"
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_SkillLevel"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            // ממלאת את אוסף הטבלאות בטבלת הרמת מיומנות
            Dal.FillDataSet(dataSet, "table_SkillLevel", "LevelName");

            // בהמשך יהיו כאן הוראות נופסות הקשורות לקשרי גומלין
        }

        public static bool Update(int id, string levelName)
        {
            //מעדכנת את הרמת מייומנות במסד הנתונים

            string str = "UPDATE table_SkillLevel SET"
            + " " + "[LevelName] = " + "'" + levelName + "'"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את רמת המיומנות ממסד הנתונים

            string str = "DELETE * FROM table_SkillLevel"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }
    }
}

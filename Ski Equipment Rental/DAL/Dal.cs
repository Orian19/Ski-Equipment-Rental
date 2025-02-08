using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ski_Equipment_Rental.DAL
{
    class Dal
    {
        public static bool ExecuteSql(string sql)
        {
            bool flag = false;

            //מקשר
            OleDbConnection connection = new OleDbConnection();
            //הצבת מחרוזת הקישור במקשר - שימוש בפעולת עזר למציאת מחרוזת זאת
            connection.ConnectionString = GetConnectionString();

            //ההוראה
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = sql;

            //בגלל שיש גישה לקבצים חיצוניים וכן בגלל פתיחת קשר לקובץ חיצוני - "עוטפים" במנגנון טיפול בשגיאות"
            try
            {
                //פתיחת הקשר
                connection.Open();

                //הפעלת הפקודה
                command.ExecuteNonQuery();
                flag = true;

                //סגירת הקשר
                connection.Close();
            }
            catch (Exception e)
            {
                //משמש רק לצרכי בקרה במקרה של תקלה - חשוב להשאיר כאן נקודת עצירה
                e.ToString();
                flag = false;
            }

            return flag;
        }

        public static void FillDataSet(DataSet dataSet, string tableName, string orderBy)
        {
            //מקשר
            OleDbConnection connection = new OleDbConnection();
            //הצבת מחרוזת הקישור במקשר
            connection.ConnectionString = GetConnectionString();

            //מבצע פעולה
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            if (orderBy != "")
                command.CommandText = "SELECT * FROM " + tableName + " ORDER BY " + orderBy;
            else
                command.CommandText = "SELECT * FROM " + tableName;

            //מתאם
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dataSet, tableName);
        }

        private static string GetConnectionString()
        {
            //בניית מחרוזת הקישור
            string connectionString;

            //ציון סוג מסד הנתונים
            //"Provider=Microsoft.ACE.OLEDB.19.0;"
            //"Provider=Microsoft.Jet.OLEDB.4.0;"
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;";
            //ציון מקום מסד הנתונים - שימוש בפעולת עזר למציאת מיקומו
            connectionString += "Data Source=" + "'" + GetDbLocation() + "'" + ";";
            //ציון אבטחת המידע
            connectionString += "Persist Security Info=True";

            return connectionString;
        }

        private static string GetDbLocation()
        {
            //מציאת הנתיב ממנו רץ היישום
            string path = Application.StartupPath;

            //מעבר לתיקייה בה שמור קובץ האקסס
            path = path.Replace(@"bin\Debug", "");
            path = path.Replace(@"bin\Release", "");

            //הוספת שם קובץ האקסס - להקפיד על שם הקובץ המתאים שלכם
            path = path + "DB_ski_squipment_rental.accdb";

            return path;
        }
    }
}
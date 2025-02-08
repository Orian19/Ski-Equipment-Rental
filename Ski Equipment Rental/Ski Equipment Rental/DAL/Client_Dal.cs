using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Client_Dal
    {
        public static bool Insert(string firstName, string lastName,
        string gender, int mobilePhone, string prefixMobilePhone,
        DateTime birthDate, string email, int clientId, int city)
        {
            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_Client"

            + " ("
            + "[FirstName]"
            + ",[LastName]"
            + ",[Gender]"
            + ",[MobilePhone]"
            + ",[PrefixMobile]"
            + ",[BirthDate]"
            + ",[Email]"
            + ",[ClientId]"
            + ",[City]"
            + ")"

            + " VALUES "
            + "("
            + "'" + firstName + "'"
            + "," + "'" + lastName + "'"
            + "," + "'" + gender + "'"
            + "," + "" + mobilePhone + ""
            + "," + "'" + prefixMobilePhone + "'"
            + "," + "'" + birthDate.Date + "'"
            + "," + "'" + email + "'"
            + "," + "" + clientId + ""
            + "," + "" + city + ""
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_Client"];

            return dataTable;
        }

        public static bool Update(int id, string firstName, string lastName,
        string gender, int mobilePhone, string prefixMobilePhone,
        DateTime birthDate, string email, int clientId, int city)
        {
            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE table_Client SET"
            + " " + "[FirstName] = " + "'" + firstName + "'"
            + "," + "[LastName] = " + "'" + lastName + "'"
            + "," + "[Gender] = " + "'" + gender + "'"
            + "," + "[MobilePhone] = " + "" + mobilePhone + ""
            + "," + "[PrefixMobile] = " + "'" + prefixMobilePhone + "'"
            + "," + "[BirthDate] = " + "'" + birthDate + "'"
            + "," + "[Email] = " + "'" + email + "'"
            + "," + "[ClientId] = " + "" + clientId + ""
            + "," + "[City] = " + "" + city + ""
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את הלקוח ממסד הנתונים

            string str = "DELETE FROM table_Client"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static void FillDataSet(DataSet dataSet)
        {
            Dal.FillDataSet(dataSet, "table_Client", "LastName,FirstName");

            City_Dal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ClientCity"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["table_City"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }
    }
}

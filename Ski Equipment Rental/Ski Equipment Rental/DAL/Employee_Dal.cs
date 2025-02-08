using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Employee_Dal
    {
        public static bool Insert(string username, string password,
        bool isAdmin, string firstName, string lastName, string gender, 
        int mobilePhone, string prefixMobilePhone, DateTime birthDate, 
        string email, int employeeId, int city)
        {
            //מוסיפה את העובד למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_Employee"

            + " ("
            + "[Username]"
            + ",[Password]"
            + ",[IsAdmin]"
            + ",[FirstName]"
            + ",[LastName]"
            + ",[Gender]"
            + ",[MobilePhone]"
            + ",[PrefixMobile]"
            + ",[BirthDate]"
            + ",[Email]"
            + ",[EmployeeId]"
            + ",[City]"
            + ")"
            + " VALUES "
            + "("
            + "'" + username + "'"
            + "," + "'" + password + "'"
            + "," + "" + isAdmin + ""
            + "," + "'" + firstName + "'"
            + "," + "'" + lastName + "'"
            + "," + "'" + gender + "'"
            + "," + "" + mobilePhone + ""
            + "," + "'" + prefixMobilePhone + "'"
            + "," + "'" + birthDate.Date + "'"
            + "," + "'" + email + "'"
            + "," + "" + employeeId + ""
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
            dataTable = dataSet.Tables["table_Employee"];

            return dataTable;
        }

        public static bool Update(int id, string username, string password,
        bool isAdmin, string firstName, string lastName, string gender,
        int mobilePhone, string prefixMobilePhone, DateTime birthDate,
        string email, int employeeId, int city)
        {
            //מעדכנת את העובד במסד הנתונים

            string str = "UPDATE table_Employee SET"
            + " " + "[Username] = " + "'" + username + "'" 
            + "," + "[Password] = " + "'" + password + "'"
            + "," + "[IsAdmin] = " + "" + isAdmin + ""
            + "," + "[FirstName] = " + "'" + firstName + "'"
            + "," + "[LastName] = " + "'" + lastName + "'"
            + "," + "[Gender] = " + "'" + gender + "'"
            + "," + "[MobilePhone] = " + "" + mobilePhone + ""
            + "," + "[PrefixMobile] = " + "'" + prefixMobilePhone + "'"
            + "," + "[BirthDate] = " + "'" + birthDate.Date + "'"
            + "," + "[Email] = " + "'" + email + "'"
            + "," + "[EmployeeId] = " + "" + employeeId + ""
            + "," + "[City] = " + "" + city + ""
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את העובד ממסד הנתונים

            string str = "DELETE FROM table_Employee"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static void FillDataSet(DataSet dataSet)
        {
            Dal.FillDataSet(dataSet, "table_Employee", "LastName,FirstName");

            City_Dal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "EmployeeCity"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["table_City"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["table_Employee"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }
    }
}

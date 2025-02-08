using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Order_Dal
    {
        public static bool Insert(string comment, int client, DateTime orderDate, decimal totalPricePerDay,
        bool isPaid, DateTime returnDate, bool isReturned, decimal finalPrice)
        {
            //מוסיפה את הההזמנה למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Order"

            + " ("
            + "[Client]"
            + ",[OrderDate]"
            + ",[Comment]"
            + ",[TotalPricePerDay]"
            + ",[IsPaid]"
            + ",[ReturnDate]"
            + ",[IsReturned]"
            + ",[FinalPrice]"
            + ")"

            + " VALUES "
            + "("
            + "" + "" + client + ""
            + "," + "'" + orderDate.Date + "'"
            + "," + "'" + comment + "'"
            + "," + "" + totalPricePerDay + ""
            + "," + "" + isPaid + ""
            + "," + "'" + returnDate.Date + "'"
            + "," + "" + isReturned + ""
            + "," + "" + finalPrice + ""
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_Order"];

            return dataTable;
        }

        public static bool Update(int id, string comment, int client, DateTime orderDate, decimal totalPricePerDay,
        bool isPaid, DateTime returnDate, bool isReturned, decimal finalPrice)
        {
            //מעדכנת את ההזמנה במסד הנתונים

            string str = "UPDATE table_Order SET"
            + " " + "[Comment] = " + "'" + comment + "'"
            + "," + "[Client] = " + "" + client + ""
            + "," + "[OrderDate] = " + "'" + orderDate.Date + "'"
            + "," + "[TotalPricePerDay] = " + "" + totalPricePerDay + ""
            + "," + "[IsPaid] = " + "" + isPaid + ""
            + "," + "[ReturnDate] = " + "'" + returnDate.Date + "'"
            + "," + "[IsReturned] = " + "" + isReturned + ""
            + "," + "[FinalPrice] = " + "" + finalPrice + ""
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את ההזמנה ממסד הנתונים

            string str = "DELETE FROM table_Order"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static void FillDataSet(DataSet dataSet)
        {
            Dal.FillDataSet(dataSet, "table_Order", "[OrderDate]");

            DataRelation dataRelation = null;

            Client_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                        //שם קשר הגומלין
                        "OrderClient"
                        //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                        , dataSet.Tables["table_Client"].Columns["ID"]
                        //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                        , dataSet.Tables["table_Order"].Columns["Client"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class OrderProduct_Dal
    {
        public static bool Insert(int order, int product, int quantity)
        {
            //מוסיפה את הההזמנת המוצרים למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_OrderProduct"

            + " ("
            + "[Order]"
            + ",[Product]"
            + ",[Quantity]"
            + ")"

            + " VALUES "
            + "("
            + "" + "" + order + ""
            + "," + "" + product + ""
            + "," + "" + quantity + ""
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_OrderProduct"];

            return dataTable;
        }

        public static bool Update(int id, int order, int product, int quantity)
        {
            //מעדכנת את המוצר במסד הנתונים

            string str = "UPDATE table_Order SET"
            + " " + "[Order] = " + "" + order + ""
            + "," + "[Product] = " + "" + product + ""
            + "," + "[Quantity] = " + "" + quantity + ""
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את ההזמנה ממסד הנתונים

            string str = "DELETE FROM table_OrderProduct"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static void FillDataSet(DataSet dataSet)
        {
            Dal.FillDataSet(dataSet, "table_OrderProduct", "[Product]");

            DataRelation dataRelation = null;

            Order_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                        //שם קשר הגומלין
                        "OrderProductOrder"
                        //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                        , dataSet.Tables["table_Order"].Columns["ID"]
                        //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                        , dataSet.Tables["table_OrderProduct"].Columns["Order"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);

            Product_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

                //שם קשר הגומלין
                "OrderProductProduct"
                //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                , dataSet.Tables["table_Product"].Columns["ID"]
                //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                , dataSet.Tables["table_OrderProduct"].Columns["Product"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);
        }
    }
}

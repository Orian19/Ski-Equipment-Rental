using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Product_Dal
    {
        public static bool Insert(string product, int company, int category, int count, 
            decimal pricePerDay, int skillLevel)
        {

            //מוסיפה את המוצר למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO table_Product"

            + " ("
            + "[ProductName]"
            + ",[Company]"
            + ",[Category]"
            + ",[Count]"
            + ",[PricePerDay]"
            + ",[SkillLevel]"
            + ")"

            + " VALUES "
            + "("
            + "'" + product + "'"
            + "," + "" + company + ""
            + "," + "" + category + ""
            + "," + "" + count + ""
            + "," + "" + pricePerDay + ""
            + "," + "" + skillLevel + ""
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_Product"];

            return dataTable;
        }

        public static bool Update(int id, string product, int company, int category, int count, 
            decimal pricePerDay, int skillLevel)
        {
            //מעדכנת את המוצר במסד הנתונים

            string str = "UPDATE table_Product SET"
            + " " + "[ProductName] = " + "'" + product + "'"
            + "," + "[Company] = " + "" + company + ""
            + "," + "[Category] = " + "" + category + ""
            + "," + "[Count] = " + "" + count + ""
            + "," + "[PricePerDay] = " + "" + pricePerDay + ""
            + "," + "[SkillLevel] = " + "" + skillLevel + ""
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {
            //מוחקת את המוצר ממסד הנתונים

            string str = "DELETE FROM table_Product"
            + " WHERE ID = " + id;

            //הפעלת פעולת ה SQL-תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static void FillDataSet(DataSet dataSet)
        {
            Dal.FillDataSet(dataSet, "table_Product", "[ProductName]");

            DataRelation dataRelation = null;

            Company_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(
                        //שם קשר הגומלין
                        "ProductCompany"
                        //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                        , dataSet.Tables["table_Company"].Columns["ID"]
                        //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                        , dataSet.Tables["table_Product"].Columns["Company"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);

            Category_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

                //שם קשר הגומלין
                "ProductCategory"
                //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                , dataSet.Tables["table_Category"].Columns["ID"]
                //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                , dataSet.Tables["table_Product"].Columns["Category"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);

            SkillLevel_Dal.FillDataSet(dataSet);
            dataRelation = new DataRelation(

                //שם קשר הגומלין
                "ProductSkillLevel"
                //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(
                , dataSet.Tables["table_SkillLevel"].Columns["ID"]
                //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(
                , dataSet.Tables["table_Product"].Columns["SkillLevel"]);

            //הוספת קשר הגומלין לאוסף הטבלאות
            dataSet.Relations.Add(dataRelation);
        }
    }
}

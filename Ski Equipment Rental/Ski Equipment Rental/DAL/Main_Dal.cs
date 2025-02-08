using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.DAL
{
    public class Main_Dal
    {
        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["table_Employee"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {
            // ממלאת את אוסף הטבלאות בטבלת המשתמשים
            Dal.FillDataSet(dataSet, "table_Employee", "UserName, Password, IsAdmin");
        }
    }
}

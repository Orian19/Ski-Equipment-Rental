using Ski_Equipment_Rental.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class MainArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל המשתמשים
            DataTable dataTable = Main_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף המשתמשים
            //להעביר כל שורה בטבלה למשתמש

            DataRow dataRow;
            Main login;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                login = new Main(dataRow);
                this.Add(login);
            }
        }
    }
}

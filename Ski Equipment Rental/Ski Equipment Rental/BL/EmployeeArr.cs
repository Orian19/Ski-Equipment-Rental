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
    public class EmployeeArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל העובדים
            DataTable dataTable = Employee_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף העובדים
            //להעביר כל שורה בטבלה לעובד

            DataRow dataRow;
            Employee employee;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                employee = new Employee(dataRow);
                this.Add(employee);
            }
        }

        public EmployeeArr Filter(int id, string lastName, string mobilePhone, int clientId)
        {
            EmployeeArr employeeArr = new EmployeeArr();

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת העובד הנוכחי במשתנה עזר - עובד

                Employee employee = (this[i] as Employee);
                if
                (
                //מזהה 0 – כלומר, לא נבחר מזהה בסינון
                (id <= 0 || employee.Id == id)
                && employee.LastName.StartsWith(lastName)
                && (employee.PrefixMobile + employee.MobilePhone.ToString()).Contains(mobilePhone)
                && (clientId <= 0 || employee.EmployeeId == clientId)
                )
                    //העובד ענה לדרישות הסינון - הוספת העובדח לאוסף העובדים המוחזר
                    employeeArr.Add(employee);
            }
            return employeeArr;
        }

        public bool DoesExist(City curCity)
        {
            //מחזירה האם לפחות לאחד מהעובדים יש את היישוב
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Employee).City.Id == curCity.Id)
                    return true;
            }
            return false;
        }
    }
}

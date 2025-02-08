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
    public class CompanyArr : ArrayList
    {
        public void Fill()
        {
            //-DAL טבלה מלאה בכל החברות
            DataTable dataTable = Company_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף החברות
            //להעביר כל שורה בטבלה לחברה

            DataRow dataRow;
            Company company;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                company = new Company(dataRow);
                this.Add(company);
            }
        }

        public bool IsContain(string companyName)
        {
            //בדיקה האם יש חברה עם אותו שם
            //הסרת האותיות י', ו' משם החברה לבדיקה - כדי לשפר מניעת כפילות

            companyName = companyName.Replace("י", "");
            companyName = companyName.Replace("ו", "");
            string curCompanyName;

            for (int i = 0; i < this.Count; i++)
            {
                curCompanyName = (this[i] as Company).CompanyName;

                //הסרת האותיות י', ו' משם החברה הנוכחי - כדי לשפר מניעת כפילות

                curCompanyName = curCompanyName.Replace("י", "");
                curCompanyName = curCompanyName.Replace("ו", "");

                if (curCompanyName == companyName)
                    return true;
            }
            return false;
        }

        public Company GetCompanyWithMaxId()
        {
            //מחזירה את החברה עם המזהה הגבוה ביותר

            Company maxCompany = new Company();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Company).Id > maxCompany.Id)
                    maxCompany = (this[i] as Company);

            }
            return maxCompany;
        }
    }
}

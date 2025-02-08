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
    public class CityArr : ArrayList
    {
        public void Fill()
        {
            //-DAL טבלה מלאה בכל היישובים
            DataTable dataTable = City_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף היישובים
            //להעביר כל שורה בטבלה ליישוב

            DataRow dataRow;
            City city;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                city = new City(dataRow);
                this.Add(city);
            }
        }

        public bool IsContain(string cityName)
        {
            //בדיקה האם יש יישוב עם אותו שם
            //הסרת האותיות י', ו' משם היישוב לבדיקה - כדי לשפר מניעת כפילות

            cityName = cityName.Replace("י", "");
            cityName = cityName.Replace("ו", "");
            string curCityName;

            for (int i = 0; i < this.Count; i++)
            {
                curCityName = (this[i] as City).CityName;

                //הסרת האותיות י', ו' משם היישוב הנוכחי - כדי לשפר מניעת כפילות

                curCityName = curCityName.Replace("י", "");
                curCityName = curCityName.Replace("ו", "");

                if (curCityName == cityName)
                    return true;
            }
            return false;
        }

        public City GetCityWithMaxId()
        {

            //מחזירה את היישוב עם המזהה הגבוה ביותר

            City maxCity = new City();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as City).Id > maxCity.Id)
                    maxCity = (this[i] as City);
            }
            return maxCity;
        }

    }
}

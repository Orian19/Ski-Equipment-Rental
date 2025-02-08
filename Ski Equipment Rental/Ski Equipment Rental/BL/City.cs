using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class City
    {
        #region Members - תכונות
        private int m_Id;
        private string m_CityName;

        public int Id
        {
            get
            {
                return m_Id;
            }

            set
            {
                m_Id = value;
            }
        }
        public string CityName
        {
            get
            {
                return m_CityName;
            }

            set
            {
                m_CityName = value;
            }
        }
        #endregion

        #region Constructors - בנאים
        public City()
        {
        }
        public City(DataRow dataRow)
        {
            //מייצרת יישוב מתוך שורת היישובים
            this.Id = (int)dataRow["ID"];
            this.m_CityName = dataRow["CityName"].ToString();
        }
        #endregion

        public override string ToString()
        {
            return m_CityName;
        }

        public bool Insert()
        {
            return City_Dal.Insert(m_CityName);
        }

        public bool Update()
        {
            return City_Dal.Update(m_Id, m_CityName);
        }

        public bool Delete()
        {
            return City_Dal.Delete(m_Id);
        }

    }
}

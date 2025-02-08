using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Company
    {
        #region Members - תכונות
        private int m_Id;
        private string m_CompanyName;

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
        public string CompanyName
        {
            get
            {
                return m_CompanyName;
            }

            set
            {
                m_CompanyName = value;
            }
        }
        #endregion

        #region Constructors - בנאים
        public Company()
        {
        }
        public Company(DataRow dataRow)
        {
            //מייצרת חברה מתוך שורת חברות

            this.Id = (int)dataRow["ID"];
            this.m_CompanyName = dataRow["CompanyName"].ToString();
        }
        #endregion

        public override string ToString()
        {
            return m_CompanyName;
        }

        public bool Insert()
        {
            return Company_Dal.Insert(m_CompanyName);
        }

        public bool Update()
        {
            return Company_Dal.Update(m_Id, m_CompanyName);
        }

        public bool Delete()
        {
            return Company_Dal.Delete(m_Id);
        }

    }
}

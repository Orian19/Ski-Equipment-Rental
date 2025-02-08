using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Category
    {
        #region Members - תכונות
        private int m_Id;
        private string m_CategoryName;

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
        public string CategoryName
        {
            get
            {
                return m_CategoryName;
            }

            set
            {
                m_CategoryName = value;
            }
        }
        #endregion

        #region Constructors - בנאים
        public Category()
        {
        }
        public Category(DataRow dataRow)
        {
            //מייצרת קטגוריה מתוך שורת הקטגוריות

            this.Id = (int)dataRow["ID"];
            this.m_CategoryName = dataRow["CategoryName"].ToString();
        }
        #endregion

        public override string ToString()
        {
            return m_CategoryName;
        }

        public bool Insert()
        {
            return Category_Dal.Insert(m_CategoryName);
        }

        public bool Update()
        {
            return Category_Dal.Update(m_Id, m_CategoryName);
        }

        public bool Delete()
        {
            return Category_Dal.Delete(m_Id);
        }
    }
}

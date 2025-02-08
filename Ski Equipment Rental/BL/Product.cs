using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Product
    {
        #region Members - תכונות
        private int m_Id;
        private string m_ProductName;
        private int m_Count;
        private decimal m_PricePerDay;
        private Company m_Company;
        private Category m_Category;
        private SkillLevel m_SkillLevel;

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
        public string ProductName
        {
            get
            {
                return m_ProductName;
            }

            set
            {
                m_ProductName = value;
            }
        }
        public string ProductFullName
        {
            get
            {
                return m_ProductName + " [" + m_Category.CategoryName + "] " + "(נותרו במלאי - " + m_Count + ")";
            }

        }
        public int Count
        {
            get
            {
                return m_Count;
            }

            set
            {
                m_Count = value;
            }
        }
        public decimal PricePerDay
        {
            get
            {
                return m_PricePerDay;
            }

            set
            {
                m_PricePerDay = value;
            }
        }
        public Company Company
        {
            get
            {
                return m_Company;
            }

            set
            {
                m_Company = value;
            }
        }
        public Category Category
        {
            get
            {
                return m_Category;
            }

            set
            {
                m_Category = value;
            }
        }
        public SkillLevel SkillLevel
        {
            get
            {
                return m_SkillLevel;
            }

            set
            {
                m_SkillLevel = value;
            }
        }

        #endregion

        #region Constructors - בנאים
        public Product()
        {
        }
        public Product(DataRow dataRow)
        {
            //מייצרת מוצר מתוך שורת המוצרים

            this.Id = (int)dataRow["ID"];
            this.m_ProductName = dataRow["ProductName"].ToString();
            this.m_Count = (int)dataRow["Count"];
            this.m_PricePerDay = (decimal)dataRow["PricePerDay"];
            this.m_Company = new Company(dataRow.GetParentRow("ProductCompany"));
            this.m_Category = new Category(dataRow.GetParentRow("ProductCategory"));
            this.m_SkillLevel = new SkillLevel(dataRow.GetParentRow("ProductSkillLevel"));
        }
        #endregion

        public override string ToString()
        {
            return m_ProductName + " [" + m_Category.CategoryName + "] " + "(נותרו במלאי - " + m_Count + ")";
        }

        public bool Insert()
        {
            return Product_Dal.Insert(m_ProductName, m_Company.Id, m_Category.Id, m_Count, m_PricePerDay, m_SkillLevel.Id);
        }

        public bool Update()
        {
            return Product_Dal.Update(Id, m_ProductName, m_Company.Id, m_Category.Id, m_Count, m_PricePerDay, m_SkillLevel.Id);
        }

        public bool Delete()
        {
            return Product_Dal.Delete(m_Id);
        }
    }
}

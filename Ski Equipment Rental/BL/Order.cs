using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class Order
    {
        #region Members - תכונות
        private int m_Id;
        private string m_Comment;
        private DateTime m_OrderDate;
        private decimal m_TotalPricePerDay;
        private bool m_IsPaid;
        private DateTime m_ReturnDate;
        private bool m_IsReturned;
        private decimal m_FinalPrice;

        private Client m_Client;

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
        public string Comment
        {
            get
            {
                return m_Comment;
            }

            set
            {
                m_Comment = value;
            }
        }
        public DateTime OrderDate
        {
            get
            {
                return m_OrderDate;
            }

            set
            {
                m_OrderDate = value;
            }
        }
        public decimal TotalPricePerDay
        {
            get
            {
                return m_TotalPricePerDay;
            }

            set
            {
                m_TotalPricePerDay = value;
            }
        }
        public bool IsPaid
        {
            get
            {
                return m_IsPaid;
            }

            set
            {
                m_IsPaid = value;
            }
        }
        public DateTime ReturnDate
        {
            get
            {
                return m_ReturnDate;
            }

            set
            {
                m_ReturnDate = value;
            }
        }
        public bool IsReturned
        {
            get
            {
                return m_IsReturned;
            }

            set
            {
                m_IsReturned = value;
            }
        }
        public decimal FinalPrice
        {
            get
            {
                return m_FinalPrice;
            }

            set
            {
                m_FinalPrice = value;
            }
        }

        public Client Client
        {
            get
            {
                return m_Client;
            }

            set
            {
                m_Client = value;
            }
        }

        #endregion

        #region Constructors - בנאים
        public Order()
        {
        }
        public Order(DataRow dataRow)
        {
            //מייצרת הזמנה מתוך שורת הזמנות

            this.Id = (int)dataRow["ID"];
            this.m_Comment = dataRow["Comment"].ToString();
            this.m_OrderDate = (DateTime)dataRow["OrderDate"];
            this.m_Client = new Client(dataRow.GetParentRow("OrderClient"));
            this.m_TotalPricePerDay = (decimal)dataRow["TotalPricePerDay"];
            this.m_IsPaid = (bool)dataRow["IsPaid"];
            this.m_ReturnDate = (DateTime)dataRow["ReturnDate"];
            this.m_IsReturned = (bool)dataRow["IsReturned"];
            this.m_FinalPrice = (decimal)dataRow["FinalPrice"];
        }
        #endregion

        private string IsPaid_ToString(bool isPaid)
        {
            if (isPaid)
            {
                return "שולם";
            }
            return "לא שולם";
        }

        private string IsReturned_ToString(bool isReturned)
        {
            if (isReturned)
            {
                return "הציוד הוחזר";
            }
            return "הציוד בשימוש";
        }

        public override string ToString()
        {
            return m_Client.LastName + " " + m_Client.FirstName + " " + m_OrderDate.Date.ToShortDateString() +
                " [" + IsPaid_ToString(m_IsPaid) + "] - " + IsReturned_ToString(m_IsReturned);
        }

        public bool Update()
        {
            return Order_Dal.Update(m_Id, m_Comment, m_Client.Id, m_OrderDate, m_TotalPricePerDay,
                m_IsPaid, m_ReturnDate, m_IsReturned, m_FinalPrice);
        }

        public bool Insert()
        {
            return Order_Dal.Insert(m_Comment, m_Client.Id, m_OrderDate, m_TotalPricePerDay, 
                m_IsPaid, m_ReturnDate, m_IsReturned, m_FinalPrice);
        }

        public bool Delete()
        {
            return Order_Dal.Delete(m_Id);
        }
    }
}

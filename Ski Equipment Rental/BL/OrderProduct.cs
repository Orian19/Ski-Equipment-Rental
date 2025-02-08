using Ski_Equipment_Rental.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Equipment_Rental.BL
{
    public class OrderProduct
    {
        #region Members - תכונות
        private int m_Id;
        private Order m_Order;
        private Product m_Product;
        private int m_Quantity;

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
        public Order Order
        {
            get
            {
                return m_Order;
            }

            set
            {
                m_Order = value;
            }
        }
        public Product Product
        {
            get
            {
                return m_Product;
            }

            set
            {
                m_Product = value;
            }
        }
        public int Quantity
        {
            get
            {
                return m_Quantity;
            }

            set
            {
                m_Quantity = value;
            }
        }
        #endregion

        #region Constructors - בנאים
        public OrderProduct()
        {
        }
        public OrderProduct(DataRow dataRow)
        {
            //מייצרת הזמנה מתוך שורת הזמנות

            this.Id = (int)dataRow["ID"];
            this.m_Order = new Order(dataRow.GetParentRow("OrderProductOrder"));
            this.m_Product = new Product(dataRow.GetParentRow("OrderProductProduct"));
            this.m_Quantity = (int)dataRow["Quantity"];
        }
        #endregion

        public bool Update()
        {
            return OrderProduct_Dal.Update(m_Id, m_Order.Id, m_Product.Id, m_Quantity);
        }

        public bool Insert()
        {
            return OrderProduct_Dal.Insert(m_Order.Id, m_Product.Id, m_Quantity);
        }

        public bool Delete()
        {
            return OrderProduct_Dal.Delete(m_Id);
        }
    }
}

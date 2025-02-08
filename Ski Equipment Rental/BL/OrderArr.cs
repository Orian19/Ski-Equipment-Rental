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
    public class OrderArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל ההזמנות
            DataTable dataTable = Order_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההזמנות
            //להעביר כל שורה בטבלה להזמנה

            DataRow dataRow;
            Order order;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                order = new Order(dataRow);
                this.Add(order);
            }
        }

        #region Filter
        public OrderArr Filter_OrderDetails(int id, Client client, DateTime fromDate, DateTime untilDate, bool returnDate)
        {
            OrderArr orderArr = new OrderArr();
            Order order;

            if (returnDate)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                    order = (this[i] as Order);
                    if
                    (
                    //מזהה 0 – כלומר, לא נבחר מזהה בסינון
                    (id <= 0 || order.Id == id)
                    //סינון לפי הלקוח
                    && (client == null || client.Id == -1 || order.Client.Id == client.Id)
                    //סינון לפי הזמנות שעבר תאריך ההחזרה שלהן
                    && (order.ReturnDate < DateTime.Today && !order.IsReturned)
                    //סינון לפי תאריכים
                    && (fromDate == DateTime.MinValue || order.OrderDate >= fromDate.Date)
                    && (untilDate == DateTime.MinValue || order.OrderDate <= untilDate.Date)

                    )
                    {
                        //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                        orderArr.Add(order);
                        if (id > 0)
                            break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                    order = (this[i] as Order);
                    if
                    (
                    //מזהה 0 – כלומר, לא נבחר מזהה בסינון
                    (id <= 0 || order.Id == id)
                    //סינון לפי הלקוח
                    && (client == null || client.Id == -1 || order.Client.Id == client.Id)
                    //סינון לפי תאריכים
                    && (fromDate == DateTime.MinValue || order.OrderDate >= fromDate.Date)
                    && (untilDate == DateTime.MinValue || order.OrderDate <= untilDate.Date)

                    )
                    {
                        //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                        orderArr.Add(order);
                        if (id > 0)
                            break;
                    }
                }
            }


            return orderArr;
        }
        public ClientArr Filter_Client(int id, string lastName, string mobilePhone)
        {
            ClientArr clientArr = new ClientArr();

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                Client client = (this[i] as Client);
                if
                (

                //מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id <= 0 || client.Id == id)
                && client.LastName.StartsWith(lastName)
                && (client.PrefixMobile + client.MobilePhone.ToString()).Contains(mobilePhone)
                )
                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר
                    clientArr.Add(client);
            }
            return clientArr;
        }
        public ProductArr Filter_Products(int id, string Product, Company company, Category category)
        {
            ProductArr productArr = new ProductArr();

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת המוצר הנוכחי במשתנה עזר - מוצר

                Product product = (this[i] as Product);
                if (

                //סינון לפי מזהה המוצר

                (id <= 0 || product.Id == id)

                //סינון לפי שם המוצר

                && product.ProductName.StartsWith(Product)

                //סינון לפי החברה
                && (company == null || company.Id == -1 || product.Category.Id == company.Id)
                //סינון לפי קטגוריה
                && (category == null || category.Id == -1 || product.Category.Id == category.Id)
                )
                {
                    //המוצר ענה לדרישות החיפוש – הוספה שלו לאוסף המוחזר

                    productArr.Add(product);
                    if (id > 0)
                        break;
                }
            }
            return productArr;
        }

        public OrderArr FilterByYearMonth_ForChart(int year, int month)
        {
            OrderArr orderArr = new OrderArr();
            Order order;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                order = (this[i] as Order);
                if
                (
                //סינון לפי שנה וחודש
                (order.OrderDate.Year == year && order.OrderDate.Month == month)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderArr.Add(order);
                }
            }

            return orderArr;
        }
        public OrderArr FilterByNumOfOrders_ForChart(int year, int month)
        {
            OrderArr orderArr = new OrderArr();
            Order order;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                order = (this[i] as Order);
                if
                (
                //סינון לפי שנה וחודש
                (order.OrderDate.Year == year && order.OrderDate.Month == month)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderArr.Add(order);
                }
            }

            return orderArr;
        }
        public OrderArr FilterByReturnDateOver_ForReport()
        {
            OrderArr orderArr = new OrderArr();
            Order order;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                order = (this[i] as Order);
                if
                (
                //סינון תאריך החזרה
                (order.ReturnDate < DateTime.Today && !order.IsReturned)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderArr.Add(order);
                }
            }

            return orderArr;
        }
        public OrderArr FilterByTodayOrders_ForReport(DateTime date)
        {
            OrderArr orderArr = new OrderArr();
            Order order;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                order = (this[i] as Order);
                if
                (
                //סינון תאריך החזרה
                (order.OrderDate == date)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderArr.Add(order);
                }
            }

            return orderArr;
        }
        public OrderArr FilterByTodayRentEnd_ForReport(DateTime date)
        {
            OrderArr orderArr = new OrderArr();
            Order order;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                order = (this[i] as Order);
                if
                (
                //סינון תאריך החזרה
                (order.ReturnDate == date)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderArr.Add(order);
                }
            }

            return orderArr;
        }

        #endregion

        public decimal GetFinalPriceSum()
        {
            decimal sum = 0;
            for (int i = 0; i < this.Count; i++)
                sum += (this[i] as Order).FinalPrice;

            return sum;
        }

        public Order GetOrder(int id)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Order).Id == id)
                    return this[i] as Order;
            return null;
        }

        public bool DoesExist(Client curClient)
        {
            //מחזירה האם לפחות לאחד מהלקוחות יש את ההזמנה
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Order).Client.Id == curClient.Id)
                    return true;
            }
            return false;
        }

        public Order GetOrderWithMaxId()
        {
            //מחזירה את ההזמנה עם המזהה הגבוה ביותר

            Order maxOrder = new Order();
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as Order).Id > maxOrder.Id)
                    maxOrder = (this[i] as Order);

            }
            return maxOrder;
        }
    }
}

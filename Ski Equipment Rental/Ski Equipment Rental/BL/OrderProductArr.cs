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
    public class OrderProductArr : ArrayList
    {
        public void Fill()
        {
            //להביא מה-DAL טבלה מלאה בכל ההזמנות
            DataTable dataTable = OrderProduct_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף ההזמנות
            //להעביר כל שורה בטבלה להזמנה

            DataRow dataRow;
            OrderProduct orderProduct;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                orderProduct = new OrderProduct(dataRow);
                this.Add(orderProduct);
            }
        }

        public bool DoesExist_Order(Order curOrder)
        {
            //מחזירה האם לפחות לאחד מהמוצרים יש הזמנה
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderProduct).Order.Id == curOrder.Id)
                    return true;
            }
            return false;
        }

        public bool DoesExist_Product(Product curProduct)
        {
            //מחזירה האם לפחות לאחד מהמוצרים יש הזמנה
            for (int i = 0; i < this.Count; i++)
            {
                if ((this[i] as OrderProduct).Product.Id == curProduct.Id)
                    return true;
            }
            return false;
        }

        public bool Insert()
        {
            //מוסיפה את אוסף המוצרים להזמנה למסד הנתונים
            bool flag = true;
            OrderProduct orderProduct = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (!orderProduct.Insert())
                    flag = false;
            }
            return flag;
        }

        public ProductArr GetProductArr()
        {

            //מחזירה את אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArr = new ProductArr();
            OrderProduct orderProduct;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);

                //מוסיפים רק פריטים שלא קיימים כבר באוסף

                if (!productArr.IsContains(orderProduct.Product))
                    productArr.Add(orderProduct.Product);

            }
            return productArr;
        }

        public OrderProductArr Filter(Order order)
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנהמוצר
                orderProduct = (this[i] as OrderProduct);
                if
                (
                //סינון לפי הזמנה
                 (order == null || order.Id == -1 || orderProduct.Order.Id == order.Id)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הזמנה לאוסף ההזמנות המוחזר
                    orderProductArr.Add(orderProduct);
                }
            }
            return orderProductArr;
        }
        public OrderProductArr Filter(Product product)
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנהמוצר
                orderProduct = (this[i] as OrderProduct);
                if
                (
                //סינון לפי מוצר
                 (product == null || product.Id == -1 || orderProduct.Order.Id == product.Id)
                )
                {
                    //המוצר ענה לדרישות הסינון - הוספת המוצר לאוסף המוצרים המוחזר
                    orderProductArr.Add(orderProduct);
                }
            }
            return orderProductArr;
        }
        public OrderProductArr MostRentedProduct_ForChart(int year, Product product)
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                orderProduct = (this[i] as OrderProduct);

                if
                (
                // סינון לפי שנה
                (orderProduct.Order.OrderDate.Year == year)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderProductArr.Add(orderProduct);
                }
            }

            return orderProductArr;
        }
        public OrderProductArr FilterByCategory_ForChart(int year, Category category)
        {
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;

            for (int i = 0; i < this.Count; i++)
            {
                //הצבת ההזמנה הנוכחית במשתנה עזר - הזמנה
                orderProduct = (this[i] as OrderProduct);
                if
                (
                //סינון לפי שנה וחודש
                (orderProduct.Product.Category.CategoryName == category.CategoryName 
                && 
                orderProduct.Order.OrderDate.Year == year)
                )
                {
                    //ההזמנה עונה לדרישות הסינון - הוספת הההזמנה לאוסף ההזמנות המוחזר
                    orderProductArr.Add(orderProduct);
                }
            }

            return orderProductArr;
        }

        public bool Delete()
        {
            //מוחקת את אוסף המוצרים להזמנה ממסד הנתונים

            bool flag = true;
            OrderProduct orderProduct = null;
            for (int i = 0; i < this.Count; i++)
            {
                orderProduct = (this[i] as OrderProduct);
                if (!orderProduct.Delete())
                    flag = false;
            }
            return flag;
        }
    }
}

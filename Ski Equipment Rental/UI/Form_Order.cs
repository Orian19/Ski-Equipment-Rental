using Ski_Equipment_Rental.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Equipment_Rental.UI
{
    public partial class Form_Order : Form
    {
        //TODO: hello world!

        public Form_Order()
        {
            InitializeComponent();

            SetDateToToday();
            OrderArrToForm();
            ClientArrToForm_2();
            ClientArrToForm1Filter();
            ClientArrToForm1ListBox(null);

            ProductArrToForm(null, PotentialProducts_listBox_tab3);
            CompanyArrToForm(null, CompanyNameFilter_comboBox_tab3, false);
            CategoryArrToForm(null, CategoryNameFilter_comboBox_tab3, false);
            SkillLevelArrToForm(null, SkillLevelNameFilter_comboBox_tab3, false);
        }

        #region Checks - בדיקות תקינות הטופס
        private bool IsHebrewLetter(char letter)
        {
            return (letter >= 'א' && letter <= 'ת');
        }
        private void CapsLockCheck()
        {
            //הצגת הודעה במידה ומקש ה-קאפסלוק פתוח

            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("מקש ה-CapsLock פתוח", "",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
        }
        private bool CheckForm()
        {
            bool flag = true;

            //בדיקה שישנו לפחות מוצר אחד בהזמנה
            if (InOrderProducts_listBox_tab3.Items.Count < 1)
            {
                flag = false;
            }

            return flag;
        }

        private void HebrewText_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (!IsHebrewLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.KeyChar = char.MinValue;
            }
        }
        private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            CapsLockCheck();

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
        }
        #endregion

        #region Order Detailes - tab#1
        private void OrderToForm(Order order)
        {
            //ממירה את המידע בטנ"מ הזמנה לטופס

            if (order != null)
            {
                IDnum_Label_tab1.Text = order.Id.ToString();
                Date_dateTimePicker_tab1.Value = order.OrderDate;
                Comment_textBox_tab1.Text = order.Comment;
                OrderCostNum_label_tab1.Text = "₪" + order.FinalPrice;
            }

            else
            {
                IDnum_Label_tab1.Text = "0";
                Date_dateTimePicker_tab1.Value = DateTime.Today;
                Comment_textBox_tab1.Text = "";
                YetToBeChosen_Label_tab1.Text = "טרם נבחר";
                IDFilter_textBox_tab1.Text = "";
                FromDate_dateTimePicker_tab1.Value = DateTime.Today;
                ToDate_dateTimePicker_tab1.Value = DateTime.Today;
                ClientFilter_comboBox_tab1.Text = "כל הלקוחות";
                ReturnDayePastFilter_comboBox_tab1.Text = "כל ההזמנות";
                DateFilter_checkBox_tab1.Checked = false;
                OrderCostNum_label_tab1.Text = "₪0.00";
            }
        }
        private Order FormToOrder()
        {
            //ממירה את המידע בטופס לטנ"מ הזמנה

            Order order = new Order();

            order.Comment = Comment_textBox_tab1.Text;
            order.OrderDate = Date_dateTimePicker_tab1.Value;
            order.Id = int.Parse(IDnum_Label_tab1.Text);
            order.Client = ClientsOrders_listBox_tab2.SelectedItem as Client;
            order.TotalPricePerDay = totalPricePerDay;
            order.IsPaid = false;
            order.ReturnDate = DateTime.Today;
            order.IsReturned = false;
            order.FinalPrice = 0;

            return order;
        }
        private void OrderArrToForm()
        {
            //ממירה את הטנ"מ אוסף הזמנות לטופס

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            Order_listBox_tab1.DataSource = orderArr;
        }
        public void ClientArrToForm1ListBox(Client curClient)
        {
            ClientArr clientArr = new ClientArr();

            clientArr.Fill();

            ClientsOrders_listBox_tab2.DataSource = clientArr;
            ClientsOrders_listBox_tab2.ValueMember = "Id";
            ClientsOrders_listBox_tab2.DisplayMember = "FullName";
        }
        public void ClientArrToForm1Filter()
        {
            //ממירה את הטנ"מ אוסף הלקוחות לטופס

            ClientArr clientArr = new ClientArr();

            //הוספת לקוח ברירת מחדל - בחר לקוח
            //יצירת מופע חדש של לקוח עם מזהה מינוס 1 ושם מתאים

            Client clientDefault = new Client();
            clientDefault.Id = -1;

            clientDefault.FirstName = "כל הלקוחות";

            //הוספת הלקוח לאוסף הלקוחות - אותו נציב במקור הנתונים של תיבת הבחירה

            clientArr.Add(clientDefault);

            clientArr.Fill();

            ClientFilter_comboBox_tab1.DataSource = clientArr;
            ClientFilter_comboBox_tab1.ValueMember = "Id";
            ClientFilter_comboBox_tab1.DisplayMember = "FullName";
        }
        private void Order_listBox_tab1_DoubleClick(object sender, EventArgs e)
        {
            //המוצר שנבחר
            Order order = Order_listBox_tab1.SelectedItem as Order;

            //הצגת חלקי ההזמנה בלשוניות השונות

            //לשונית פרטי הזמנה
            OrderToForm(order);

            //לשונית לקוח להזמנה

            ClientToForm(order.Client);
            ClientsOrders_listBox_tab2.SelectedValue = order.Client.Id;

            YetToBeChosen_Label_tab1.Text = (Order_listBox_tab1.SelectedItem as Order).Client.FullName;

            //לשונית פריטי הזמנה

            //תיבת רשימה - פריטים בהזמנה
            //מוצאים את הפריטים בהזמנה הנוכחית
            ProductArr productArrInOrder = new ProductArr();

            //כל הזוגות פריט-הזמנה
            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            //סינון לפי הזמנה נוכחית
            orderProductArr = orderProductArr.Filter(order);

            //רק אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה
            productArrInOrder = orderProductArr.GetProductArr();
            ProductArrToForm(productArrInOrder, InOrderProducts_listBox_tab3);

            ProductArrQuantityToForm(orderProductArr);

            //תיבת רשימה - פריטים פוטנציאלים
            //כל הפריטים - פחות אלו שכבר נבחרו
            ProductArr productArrNotInOrder = new ProductArr();
            productArrNotInOrder.Fill();

            //הורדת הפריטים שכבר קיימים בהזמנה
            productArrNotInOrder.Remove(productArrInOrder);
            ProductArrToForm(productArrNotInOrder, PotentialProducts_listBox_tab3);

            Visible_tab2();
            ReturnEquipment_checkBox_tab3.Checked = false;
        }
        private void SetDateToToday()
        {
            Date_dateTimePicker_tab1.MaxDate = DateTime.Today;
            FromDate_dateTimePicker_tab1.MaxDate = DateTime.Today;
            ToDate_dateTimePicker_tab1.MaxDate = DateTime.Today;
            RentDate_dateTimePicker_tab3.MaxDate = DateTime.Today;
            ReturnDate_dateTimePicker_tab3.MaxDate = DateTime.Today;
            ReturnDayePastFilter_comboBox_tab1.SelectedItem = "כל ההזמנות";

            Date_dateTimePicker_tab1.Value = DateTime.Today;
            FromDate_dateTimePicker_tab1.Value = DateTime.Today;
            ToDate_dateTimePicker_tab1.Value = DateTime.Today;
            RentDate_dateTimePicker_tab3.Value = DateTime.Today;
            ReturnDate_dateTimePicker_tab3.Value = DateTime.Today;
        }

        #region Buttons

        decimal totalPricePerDay = 0;

        private void Delete_button_tab1_Click(object sender, EventArgs e)
        {
            //מחיקת הזמנה קיימת מהמערכת

            Order order = FormToOrder();

            if (order.Id == 0)
            {
                MessageBox.Show("לא נבחרה הזמנה למחיקה", "אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                //לפני המחיקה - בדיקה שההזמנה לא בשימוש ביישויות אחרות
                //בדיקה עבור הזמנותמוצרים

                OrderProductArr orderProductArr = new OrderProductArr();
                orderProductArr.Fill();

                if (orderProductArr.DoesExist_Order(order))
                    MessageBox.Show("אין אפשרות למחוק את ההזמנה, היא קשורה למוצר אחד או יותר", "אזהרה",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                else
                {
                    if (MessageBox.Show(" אתה בטוח/ה שברצונך למחוק את ההזמנה?", "אזהרה",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading)
                        == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (order.Delete())
                        {
                            MessageBox.Show("ההזמנה נמחקה בהצלחה!", "מחיקה",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                            OrderToForm(null);
                            OrderArrToForm();
                        }
                        else
                            MessageBox.Show("שגיאה במחיקה");
                    }
                }
            }


        }
        private void Clear_button_tab1_Click(object sender, EventArgs e)
        {
            //ניקוי הטופס
            OrderToForm(null);
            ClientToForm(null);
            OrderArrToForm();
            Order_listBox_tab1.SelectedItem = null;
        }
        private void Payment_button_tab1_Click(object sender, EventArgs e)
        {
            if ((Order_listBox_tab1.SelectedItem as Order) != null)
            {
                if ((Order_listBox_tab1.SelectedItem as Order).IsPaid)
                {
                    MessageBox.Show("ההזמנה כבר שולמה!", "התראה",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    return;
                }
            }

            Product product = null;

            //חישוב מחיר ליום של סה"כ המוצרים בהזמנה
            for (int i = 0; i < InOrderProducts_listBox_tab3.Items.Count; i++)
            {
                product = InOrderProducts_listBox_tab3.Items[i] as Product;

                totalPricePerDay += Decimal.Multiply(product.PricePerDay,
                    decimal.Parse(OrderProductsQuantity_listBox_tab3.Items[i].ToString()));
            }

            // בדיקה שנבחר לקוח ליצירת הזמנה חדשה
            if (YetToBeChosen_Label_tab1.Text == "טרם נבחר")
            {
                MessageBox.Show("לא נבחר לקוח להזמנה!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }

            else if (!CheckForm())
            {
                MessageBox.Show("לא נבחר מוצר להזמנה!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }

            else
            {
                Order order = FormToOrder();
                OrderProductArr orderProductArr_New;

                if (order.Id == 0)
                {
                    //הוספת הזמנה חדשה
                    if (order.Insert())
                    {
                        {
                            //מוצאים את ההזמנה החדשה - לפי המזהה הגבוה ביותר

                            OrderArr orderArr = new OrderArr();
                            orderArr.Fill();
                            order = orderArr.GetOrderWithMaxId();
                            orderProductArr_New = FormToOrderProductArr(order);

                            //מוסיפים את הפריטים החדשים להזמנה
                            orderProductArr_New.Insert();

                            ProductArr productArrInOrder = orderProductArr_New.GetProductArr();
                            //מעדכנים את מלאי הפריטים שהוזמנו

                            productArrInOrder.Update();

                            MessageBox.Show("הנתונים נשמרו בהצלחה", "שמירת נתונים",
                            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading);

                            OrderArrToForm();

                            Form_Payment formPayment = new Form_Payment(order, totalPricePerDay);
                            formPayment.ShowDialog();

                            //"רענון הטופס" - ההזמנה עודכנה צריך להציג את פרטיה העדכניים בטופס
                            Clear_button_tab1_Click(null, null);
                            Clear_button_tab3_Click(null, null);
                        }
                    }

                    else
                        MessageBox.Show("שגיאה בהוספה", "שגיאה",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }

                else
                {
                    //עדכון הזמנה קיימת
                    if (order.Update())
                    {
                        orderProductArr_New = FormToOrderProductArr(order);

                        //מוחקים את הפריטים הקודמים של ההזמנה
                        //אוסף כלל הזוגות - הזמנה-פריט

                        OrderProductArr orderProductArr_Old = new OrderProductArr();
                        orderProductArr_Old.Fill();

                        //סינון לפי ההזמנה הנוכחית

                        orderProductArr_Old = orderProductArr_Old.Filter(order);

                        //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                        orderProductArr_Old.Delete();

                        //מוסיפים את הפריטים החדשים להזמנה

                        orderProductArr_New.Insert();

                        //מעדכנים את מלאי הפריטים, אלו שהוזמנו ואלו שבפוטנציאל

                        (InOrderProducts_listBox_tab3.DataSource as ProductArr).Update();
                        (PotentialProducts_listBox_tab3.DataSource as ProductArr).Update();

                        MessageBox.Show("ההזמנה עודכנה בהצלחה", "עדכון",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        Form_Payment formPayment = new Form_Payment(order, totalPricePerDay);
                        formPayment.ShowDialog();

                        Clear_button_tab1_Click(null, null);
                        Clear_button_tab1_Click(null, null);
                    }

                    else
                        MessageBox.Show("שגיאה בעדכון", "שגיאה",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
            totalPricePerDay = 0;
        }

        #endregion
        #endregion

        #region Client - tab#2
        private void ClientToForm(Client client)
        {
            //ממירה את המידע בטנ"מ לקוח לטופס

            if (client != null)
            {
                IDnum_label_tab2.Text = client.Id.ToString();
                FirstNameHyphen_label_tab2.Text = client.FirstName;
                LastNameHyphen_Label_tab2.Text = client.LastName;
                MobilePhone_label_tab2.Text = client.MobilePhone.ToString();
                PrefixMobilePhone_Label_tab2.Text = client.PrefixMobile;
                EmailHyphen_label_tab2.Text = client.Email;
                CityHyphen_label_tab2.Text = client.City.ToString();
            }

            else
            {
                IDnum_label_tab2.Text = "0";
                FirstNameHyphen_label_tab2.Text = "";
                LastNameHyphen_Label_tab2.Text = "";
                MobilePhone_label_tab2.Text = "";
                PrefixMobilePhone_Label_tab2.Text = "";
                EmailHyphen_label_tab2.Text = "";
                CityHyphen_label_tab2.Text = "";
                PhoneHyphen_label_tab2.Text = "";

            }
        }
        private void ClientArrToForm_2()
        {
            //ממירה את הטנ"מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            ClientsOrders_listBox_tab2.DataSource = clientArr;
        }
        private void ClientsOrders_listBox_tab2_Click(object sender, EventArgs e)
        {
            Clear_button_tab1_Click(null, null);
            Clear_button_tab3_Click(null, null);
            ClientToForm(ClientsOrders_listBox_tab2.SelectedItem as Client);
            YetToBeChosen_Label_tab1.Text = (ClientsOrders_listBox_tab2.SelectedItem as Client).FullName;
            Visible_tab2();
        }
        private void Visible_tab2()
        {
            IDnum_label_tab2.Visible = true;
            LastNameHyphen_Label_tab2.Visible = true;
            FirstNameHyphen_label_tab2.Visible = true;
            CityHyphen_label_tab2.Visible = true;
            EmailHyphen_label_tab2.Visible = true;
            MobilePhone_label_tab2.Visible = true;
            PhoneHyphen_label_tab2.Visible = true;
            PrefixMobilePhone_Label_tab2.Visible = true;
            PhoneHyphen_label_tab2.Visible = true;
        }
        #endregion

        #region Products - tab#3
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            ProductArr productArr = null;

            //מוצאים את הפריט הנבחר להעברה

            object selectedItem = listBox_From.SelectedItem;
            Product product = selectedItem as Product;

            if (selectedItem != null)
            {
                //עדכון הכמות במלאי של הפריט
                //ההעברה היא אל הרשימה של הפריטים בהזמנה

                if (isToOrder)
                {
                    if (product.Count > 0)
                    {
                        (selectedItem as Product).Count--;
                        OrderProductsQuantity_listBox_tab3.Items.Add(1);
                    }
                    else
                    {
                        MessageBox.Show("המוצר חסר במלאי!", "שגיאה",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        return;
                    }
                }
                else
                {
                    (selectedItem as Product).Count += int.Parse(OrderProductsQuantity_listBox_tab3.Items[OrderProductsQuantity_listBox_tab3.SelectedIndex].ToString());
                    OrderProductsQuantity_listBox_tab3.Items.RemoveAt(OrderProductsQuantity_listBox_tab3.SelectedIndex);
                }

                //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
                //אם כבר יש פריטים ברשימת הפוטנציאליים

                if (listBox_To.DataSource != null)
                    productArr = listBox_To.DataSource as ProductArr;
                else
                    productArr = new ProductArr();

                productArr.Add(selectedItem);
                ProductArrToForm(productArr, listBox_To);

                productArr = listBox_From.DataSource as ProductArr;
                productArr.Remove(selectedItem);
                ProductArrToForm(productArr, listBox_From);
            }

        }
        private void ProductArrToForm(ProductArr productArr, ListBox listBox)
        {
            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;


            if (productArr == null)
            {
                productArr = new ProductArr();
                productArr.Fill();
            }

            listBox.DataSource = productArr;

        }
        private OrderProductArr FormToOrderProductArr(Order curOrder)
        {
            //יצירת אוסף המוצרים להזמנה מהטופס
            //(מייצרים זוגות של הזמנה-מוצר ההזמנה - תמיד אותה הזמנה (הרי מדובר על הזמנה אחת),
            //המוצר - מגיע מרשימת המוצרים שנבחרו

            OrderProductArr orderProductArr = new OrderProductArr();

            // יצירת אוסף הזוגות הזמנה-מוצר
            OrderProduct orderProduct;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < InOrderProducts_listBox_tab3.Items.Count; i++)
            {
                orderProduct = new OrderProduct();
                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף
                orderProduct.Order = curOrder;
                //מוצר נוכחי לזוג הזמנה-מוצר
                orderProduct.Product = InOrderProducts_listBox_tab3.Items[i] as Product;

                //כמות מוצר נוכחי לזוג הזמנה-מוצר
                orderProduct.Quantity = (int)OrderProductsQuantity_listBox_tab3.Items[i];

                //הוספת הזוג הזמנה - מוצר לאוסף
                orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        private void ProductArrQuantityToForm(OrderProductArr curOrderproductsArr)
        {
            OrderProductsQuantity_listBox_tab3.Items.Clear();
            for (int i = 0; i < curOrderproductsArr.Count; i++)
            {
                OrderProductsQuantity_listBox_tab3.Items.Add(
                (curOrderproductsArr[i] as OrderProduct).Quantity);
            }

        }

        private void PotentialProducts_listBox_tab3_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(PotentialProducts_listBox_tab3, InOrderProducts_listBox_tab3, true);
        }
        private void InOrderProducts_listBox_tab3_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(InOrderProducts_listBox_tab3, PotentialProducts_listBox_tab3, false);
        }
        //private void InOrderProducts_listBox_tab3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (InOrderProducts_listBox_tab3.SelectedIndex >= 0 &&
        //        OrderProductsQuantity_listBox_tab3.Items.Count > InOrderProducts_listBox_tab3.SelectedIndex)
        //    {
        //        OrderProductsQuantity_listBox_tab3.SelectedIndex = InOrderProducts_listBox_tab3.SelectedIndex;
        //    }
        //}

        //private void OrderProductsQuantity_listBox_tab3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (InOrderProducts_listBox_tab3.SelectedIndex >= 0 &&
        //        InOrderProducts_listBox_tab3.Items.Count > InOrderProducts_listBox_tab3.SelectedIndex)
        //    {
        //        InOrderProducts_listBox_tab3.SelectedIndex = OrderProductsQuantity_listBox_tab3.SelectedIndex;
        //    }
        //}
        private void InOrderProducts_listBox_tab3_Click(object sender, EventArgs e)
        {
            if (InOrderProducts_listBox_tab3.SelectedIndex >= 0 && OrderProductsQuantity_listBox_tab3.Items.Count >
            InOrderProducts_listBox_tab3.SelectedIndex)
                OrderProductsQuantity_listBox_tab3.SelectedIndex = InOrderProducts_listBox_tab3.SelectedIndex;

        }
        private void OrderProductsQuantity_listBox_tab3_Click(object sender, EventArgs e)
        {
            if (InOrderProducts_listBox_tab3.SelectedIndex >= 0 && InOrderProducts_listBox_tab3.Items.Count >
            InOrderProducts_listBox_tab3.SelectedIndex)
                InOrderProducts_listBox_tab3.SelectedIndex = OrderProductsQuantity_listBox_tab3.SelectedIndex;
        }
        //private void ProductQuantity_numericUpDown_ValueChanged(object sender, EventArgs e)
        //{
        //    ProductArr productArr = InOrderProducts_listBox_tab3.DataSource as ProductArr;
        //    Product product = InOrderProducts_listBox_tab3.SelectedItem as Product;

        //    //הגדלת הכמות של המוצר בהזמנה באחד
        //    //אם לא מסומנת השורה של הכמויות – נפעיל את הפעולה המסמנת אותה
        //    if (InOrderProducts_listBox_tab3.SelectedIndex < 1)
        //        listBox_InOrderProducts_SelectedIndexChanged(null, null);

        //    //בדיקה האם יש במלאי לפחות 1
        //    if (InOrderProducts_listBox_tab3.Items.Count > 0)
        //    //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי
        //    {
        //        //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה
        //        OrderProductsQuantity_listBox_tab3.Items[OrderProductsQuantity_listBox_tab3.SelectedIndex] = ProductQuantity_numericUpDown.Value;

        //        //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
        //        product.Count -= (int)ProductQuantity_numericUpDown.Value;

        //        productArr.UpdateProduct(product);
        //        ProductArrToForm(productArr, InOrderProducts_listBox_tab3);
        //    }


        //    //אם לא הודעה מתאימה

        //    else
        //        MessageBox.Show("המוצר חסר במלאי!", "שגיאה",
        //        MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
        //        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        //}

        public void CompanyArrToForm(Company curCompany, ComboBox comboBox, bool isMustChoose)
        {

            //ממירה את הטנ"מ אוסף החברות לטופס

            CompanyArr companyArr = new CompanyArr();

            //הוספת חברה ברירת מחדל - בחר חברה
            //יצירת מופע חדש של חברה עם מזהה מינוס 1 ושם מתאים

            Company companyDefault = new Company();
            companyDefault.Id = -1;

            if (isMustChoose)
                companyDefault.CompanyName = "בחר חברה";
            else
                companyDefault.CompanyName = "כל החברות";

            //הוספת החברה לאוסף החברות - אותו נציב במקור הנתונים של תיבת הבחירה

            companyArr.Add(companyDefault);

            companyArr.Fill();

            comboBox.DataSource = companyArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "CompanyName";

            if (curCompany != null)
                comboBox.SelectedValue = curCompany.Id;
        }
        public void CategoryArrToForm(Category curCategory, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף הקטגוריות לטופס

            CategoryArr categoryArr = new CategoryArr();

            //הוספת קטגוריה ברירת מחדל - בחר קטגוריה
            //יצירת מופע חדש של קטגוריה עם מזהה מינוס 1 ושם מתאים

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;

            if (isMustChoose)
                categoryDefault.CategoryName = "בחר קטגוריה";
            else
                categoryDefault.CategoryName = "כל הקטגוריות";

            //הוספת הקטגוריה לאוסף הקטגוריות - אותו נציב במקור הנתונים של תיבת הבחירה

            categoryArr.Add(categoryDefault);

            categoryArr.Fill();

            comboBox.DataSource = categoryArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "CategoryName";

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }
        public void SkillLevelArrToForm(SkillLevel curSkillLevel, ComboBox comboBox, bool isMustChoose)
        {
            //ממירה את הטנ"מ אוסף רמת המיומנות לטופס

            SkillLevelArr skillLevelArr = new SkillLevelArr();

            //הוספת רמת מיומנות ברירת מחדל - בחר רמת מיומנות
            //יצירת מופע חדש של רמת מיומנות עם מזהה מינוס 1 ושם מתאים

            SkillLevel skillLevelDefault = new SkillLevel();
            skillLevelDefault.Id = -1;

            if (isMustChoose)
                skillLevelDefault.LevelName = "בחר רמת מיומנות";
            else
                skillLevelDefault.LevelName = "כל הרמות";

            //הוספת רמת המיומנות לאוסף רמות המיומנות - אותו נציב במקור הנתונים של תיבת הבחירה

            skillLevelArr.Add(skillLevelDefault);

            skillLevelArr.Fill();

            comboBox.DataSource = skillLevelArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "LevelName";

            if (curSkillLevel != null)
                comboBox.SelectedValue = curSkillLevel.Id;
        }

        private void ReturnEquipment_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ReturnEquipment_checkBox_tab3.Checked)
            {
                ReturnEquipment_groupBox_tab3.Enabled = false;
                RentDate_dateTimePicker_tab3.Value = DateTime.Today;
                ReturnDate_dateTimePicker_tab3.Value = DateTime.Today;

                return;
            }

            Order order = (Order_listBox_tab1.SelectedItem as Order);

            if (order != null)
            {
                if (order.IsReturned)
                {
                    MessageBox.Show("הציוד להזמנה זו כבר הוחזר!", "התראה",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    ReturnEquipment_checkBox_tab3.Checked = false;

                    return;
                }

                if (!order.IsPaid)
                {
                    MessageBox.Show("ההזמנה לא שולמה ולכן אין אפשרות להחזיר את הציוד!", "התראה",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    ReturnEquipment_checkBox_tab3.Checked = false;
                    ReturnEquipment_groupBox_tab3.Enabled = false;

                    return;
                }

                if (ReturnEquipment_checkBox_tab3.Checked)
                {
                    RentDate_dateTimePicker_tab3.MaxDate = DateTime.Today.AddDays(1);
                    RentDate_dateTimePicker_tab3.Value = order.OrderDate;

                    ReturnDate_dateTimePicker_tab3.MaxDate = order.OrderDate.AddDays(30);
                    ReturnDate_dateTimePicker_tab3.Value = order.ReturnDate;

                    ReturnEquipment_groupBox_tab3.Enabled = true;
                }
                else
                    ReturnEquipment_groupBox_tab3.Enabled = false;
            }

            else
            {
                MessageBox.Show("לא נבחרה הזמנה!", "אזהרה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                ReturnEquipment_checkBox_tab3.Checked = false;
            }

        }

        #region Buttons
        private void Cancel_button_tab3_Click(object sender, EventArgs e)
        {
            Clear_button_tab3_Click(null, null);
            Clear_button_tab1_Click(null, null);
            OrderTabs_tabControl.SelectTab(0);
        }
        private void Clear_button_tab3_Click(object sender, EventArgs e)
        {
            //ניקוי הטופס
            OrderProductsQuantity_listBox_tab3.Items.Clear();
            InOrderProducts_listBox_tab3.DataSource = null;
            IDFilter_textBox_tab3.Text = "";
            ProductNameFilter_textBox_tab3.Text = "";
            CompanyNameFilter_comboBox_tab3.Text = "כל החברות";
            CategoryNameFilter_comboBox_tab3.Text = "כל הקטגוריות";
            SkillLevelNameFilter_comboBox_tab3.Text = "כל הרמות";
            ProductCountFilter_numericUpDown_tab3.Value = 0;
            RentDate_dateTimePicker_tab3.MaxDate = DateTime.Today;
            RentDate_dateTimePicker_tab3.Value = DateTime.Today;
            ReturnDate_dateTimePicker_tab3.MaxDate = DateTime.Today;
            ReturnDate_dateTimePicker_tab3.Value = DateTime.Today;
            ProductArrToForm(null, PotentialProducts_listBox_tab3);
        }
        private void Confirm_button_tab3_Click(object sender, EventArgs e)
        {
            Order order = (Order_listBox_tab1.SelectedItem as Order);

            //בדיקה שנבחרה הזמנה ותיבת החזרת הציוד סומנה
            if (ReturnEquipment_checkBox_tab3.Checked && order != null)
            {
                //חישוב הקנס 
                decimal fine = order.FinalPrice * (decimal)1.25;

                //בידקה האם הלקוח החזיר את כל הציוד והאם החזיר אותו בזמן
                if (InOrderProducts_listBox_tab3.Items.Count == 0 && DateTime.Today <= order.ReturnDate)
                {
                    MessageBox.Show("החזרת הציוד הושלמה בהצלחה! ", "החזרת ציוד",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading);

                    order.IsReturned = true;
                    order.Update();
                    OrderArrToForm();

                    //ניקוי הטופס ועדכון
                    Clear_button_tab3_Click(null, null);
                    Clear_button_tab1_Click(null, null);
                }
                else
                {
                    MessageBox.Show("לא כל הציוד הציוד הוחזר בזמן! " + "הקנס: " + fine + "\n לתשלום הקנס יש לשלוח את הלקוח לקופה הראשית!", "התראה",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    if (InOrderProducts_listBox_tab3.Items.Count == 0)
                    {
                        order.IsReturned = true;
                        order.Update();
                        OrderArrToForm();
                    }

                    Clear_button_tab3_Click(null, null);
                    Clear_button_tab1_Click(null, null);
                }
            }
            OrderTabs_tabControl.SelectTab(0);
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            ProductArr productArr = InOrderProducts_listBox_tab3.DataSource as ProductArr;
            Product product = InOrderProducts_listBox_tab3.SelectedItem as Product;

            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות – נפעיל את הפעולה המסמנת אותה
            if (InOrderProducts_listBox_tab3.SelectedIndex < 1)
                InOrderProducts_listBox_tab3_Click(null, null);

            //הגדלת הכמות של המוצר בהזמנה באחד
            //בדיקה האם יש במלאי לפחות 1
            if (product.Count > 0)

            //אם כן, הוספה לכמות של פריט-הזמנה והורדה מהמלאי
            {
                //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה
                OrderProductsQuantity_listBox_tab3.Items[OrderProductsQuantity_listBox_tab3.SelectedIndex] =
                int.Parse(OrderProductsQuantity_listBox_tab3.Text) + 1;

                //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                product.Count--;

                productArr.UpdateProduct(product);
                ProductArrToForm(productArr, InOrderProducts_listBox_tab3);
            }

            //אם לא הודעה מתאימה

            else
                MessageBox.Show("המוצר חסר במלאי!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
        private void button_Minus_Click(object sender, EventArgs e)
        {
            ProductArr productArr = InOrderProducts_listBox_tab3.DataSource as ProductArr;
            Product product = InOrderProducts_listBox_tab3.SelectedItem as Product;

            //הגדלת הכמות של המוצר בהזמנה באחד
            //אם לא מסומנת השורה של הכמויות – נפעיל את הפעולה המסמנת אותה
            if (InOrderProducts_listBox_tab3.SelectedIndex < 1)
                InOrderProducts_listBox_tab3_Click(null, null);

            // הורדה לכמות של פריט-הזמנה והוספה בחזרה למלאי
            if (int.Parse(OrderProductsQuantity_listBox_tab3.Text) > 1)
            //עדכון כמות המוצר בתוך רשימת כמויות המוצרים בהזמנה
            {
                OrderProductsQuantity_listBox_tab3.Items[OrderProductsQuantity_listBox_tab3.SelectedIndex] =
                int.Parse(OrderProductsQuantity_listBox_tab3.Text) - 1;

                //הורדה מהמלאי - עדכון כמות המוצר בתוך אוסף המוצרים ברשימת המוצרים בהזמנה
                product.Count++;

                productArr.UpdateProduct(product);
                ProductArrToForm(productArr, InOrderProducts_listBox_tab3);
            }
            else
            {
                MoveSelectedItemBetweenListBox(InOrderProducts_listBox_tab3, PotentialProducts_listBox_tab3, false);
            }
        }

        #endregion
        #endregion

        #region Filter

        #region Order_Details_Filter - tab#1

        private bool ReturnDateFilter()
        {
            if (ReturnDayePastFilter_comboBox_tab1.SelectedItem.ToString() == "הצג הזמנות אלו")
            {
                return true;
            }
            else
                return false;
        }
        private void SetOrdersByFilter_1()
        {
            int Id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (IDFilter_textBox_tab1.Text != "")
                Id = int.Parse(IDFilter_textBox_tab1.Text);

            //מייצרים אוסף של כלל ההזמנות

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            //מוודאים שנבחר לקוח ולא נמצא הערך הראשוני - בחר לקוח

            if (ClientFilter_comboBox_tab1.Text == "בחר לקוח")
            {
                ClientFilter_comboBox_tab1.SelectedItem = null;
            }


            if (DateFilter_checkBox_tab1.Checked)
            {
                orderArr = orderArr.Filter_OrderDetails(Id, ClientFilter_comboBox_tab1.SelectedItem as Client,
                FromDate_dateTimePicker_tab1.Value.Date, ToDate_dateTimePicker_tab1.Value.Date, ReturnDateFilter());
            }

            else
            {
                orderArr = orderArr.Filter_OrderDetails(Id, ClientFilter_comboBox_tab1.SelectedItem as Client,
                DateTime.MinValue.Date, DateTime.MinValue.Date, ReturnDateFilter());
            }

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            //orderArr = orderArr.Filter(Id, Client_Filter_ComboBox.SelectedItem as Client,
            //FromDate_dateTimePicker_Filter.Value.Date, ToDate_dateTimePicker_Filter.Value.Date);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            Order_listBox_tab1.DataSource = orderArr;


        }

        private void DateFilter_checkBox_tab1_CheckedChanged(object sender, EventArgs e)
        {
            if (DateFilter_checkBox_tab1.Checked)
            {
                FromDate_dateTimePicker_tab1.Enabled = true;
                ToDate_dateTimePicker_tab1.Enabled = true;
            }
            else
            {
                FromDate_dateTimePicker_tab1.Enabled = false;
                ToDate_dateTimePicker_tab1.Enabled = false;
            }
            SetOrdersByFilter_1();
        }

        private void textBox_Filter_KeyUp1(object sender, KeyEventArgs e)
        {
            int id = 0;
            int clientId = 0;

            if (ClientIdFilter_textBox_tab2.Text != "")
            {
                clientId = int.Parse(ClientIdFilter_textBox_tab2.Text);
            }

            if (IDFilter_textBox_tab2.Text != "")
            {
                id = int.Parse(IDFilter_textBox_tab2.Text);
            }

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            clientArr = clientArr.Filter(id, LastNameFilter_textBox_tab2.Text,
            PhoneFilter_textBox_tab2.Text, clientId);

            ClientsOrders_listBox_tab2.DataSource = clientArr;
            ClientsOrders_listBox_tab2.ValueMember = "Id";
            ClientsOrders_listBox_tab2.DisplayMember = "FullName";
        }
        private void IDFilter_textBox_tab1_TextChanged(object sender, EventArgs e)
        {
            SetOrdersByFilter_1();
        }
        private void FromDate_dateTimePicker_tab1_ValueChanged(object sender, EventArgs e)
        {
            SetOrdersByFilter_1();
        }
        private void ToDate_dateTimePicker_tab1_ValueChanged(object sender, EventArgs e)
        {
            SetOrdersByFilter_1();
        }
        private void ClientFilter_comboBox_tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOrdersByFilter_1();
        }
        private void ReturnDayePastFilter_comboBox_tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOrdersByFilter_1();
        }
        #endregion

        #region Client_Filter - tab#2
        private void textBox_Filter_KeyUp2(object sender, KeyEventArgs e)
        {
            int ID = 0;
            int clientId = 0;

            if (ClientIdFilter_textBox_tab2.Text != "")
            {
                clientId = int.Parse(ClientIdFilter_textBox_tab2.Text);
            }

            if (IDFilter_textBox_tab2.Text != "")
            {
                ID = int.Parse(IDFilter_textBox_tab2.Text);
            }

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            clientArr = clientArr.Filter(ID, LastNameFilter_textBox_tab2.Text,
            PhoneFilter_textBox_tab2.Text, clientId);

            ClientsOrders_listBox_tab2.DataSource = clientArr;
            ClientsOrders_listBox_tab2.ValueMember = "Id";
            ClientsOrders_listBox_tab2.DisplayMember = "FullName";
        }
        #endregion

        #region Products_Filter - tab#3
        private void textBox_Filter_KeyUp3(object sender, KeyEventArgs e)
        {
            SetProductsByFilter_3();
        }
        private void comboBoxFilter_SelectedIndexChanged_3(object sender, EventArgs e)
        {
            SetProductsByFilter_3();
        }
        private void numericUpDown_ValueChanged_3(object sender, EventArgs e)
        {
            SetProductsByFilter_3();
        }
        private void SetProductsByFilter_3()
        {
            int Id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (IDFilter_textBox_tab3.Text != "")
                Id = int.Parse(IDFilter_textBox_tab3.Text);

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(Id, ProductNameFilter_textBox_tab3.Text,

            CompanyNameFilter_comboBox_tab3.SelectedItem as Company,
            CategoryNameFilter_comboBox_tab3.SelectedItem as Category,
            (int)ProductCountFilter_numericUpDown_tab3.Value,
            SkillLevelNameFilter_comboBox_tab3.SelectedItem as SkillLevel);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            PotentialProducts_listBox_tab3.DataSource = productArr;
            PotentialProducts_listBox_tab3.ValueMember = "Id";
            PotentialProducts_listBox_tab3.DisplayMember = "ProductFullName";
        }

        #endregion

        #endregion

    }
}

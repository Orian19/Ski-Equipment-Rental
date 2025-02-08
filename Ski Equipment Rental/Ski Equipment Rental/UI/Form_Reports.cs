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
    public partial class Form_Reports : Form
    {
        public Form_Reports()
        {
            InitializeComponent();

            SetDateToToday();

            SetReportByFilter_ProductsStock_tab1();
            SetReportByFilter_ReturnDateOver_tab2();
        }

        #region SetReportsByFilters
        public void SetReportByFilter_ProductsStock_tab1()
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();

            productArr = productArr.Filter((int)ProductCount_numericUpDown_tab1.Value);

            Products_listBox_tab1.DataSource = productArr;
        }
        public void SetReportByFilter_ReturnDateOver_tab2()
        {
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            orderArr = orderArr.FilterByReturnDateOver_ForReport();

            Orders_listBox_tab2.DataSource = orderArr;
        }
        #endregion

        private void Orders_listBox_tab2_Click(object sender, EventArgs e)
        {
            Order order = Orders_listBox_tab2.SelectedItem as Order;

            //לשונית פרטי הזמנה
            OrderToForm(order);

        }
        private void OrderToForm(Order order)
        {
            //ממירה את המידע בטנ"מ הזמנה לטופס

            if (order != null)
            {
                IDnum_Label_tab2.Text = order.Id.ToString();
                Date_dateTimePicker_tab2.MaxDate = DateTime.Today;
                Date_dateTimePicker_tab2.Value = order.OrderDate;
                Comment_textBox_tab2.Text = order.Comment;
                OrderCostNum_label_tab2.Text = "₪" + order.FinalPrice;
                PhoneHyphen_label_tab2.Text = order.Client.MobilePhone + " - " + order.Client.PrefixMobile;
                ClientFullNameHyphen_label_tab2.Text = order.Client.FullName;
            }

            else
            {
                IDnum_Label_tab2.Text = "0";
                Date_dateTimePicker_tab2.MaxDate = DateTime.Today;
                Date_dateTimePicker_tab2.Value = DateTime.Today;
                Comment_textBox_tab2.Text = "";
                OrderCostNum_label_tab2.Text = "₪0.00";
                PhoneHyphen_label_tab2.Text = "-";
                ClientFullNameHyphen_label_tab2.Text = "-";
            }
        }

        #region ValueChanged
        private void ProductCount_numericUpDown_tab1_ValueChanged(object sender, EventArgs e)
        {
            SetReportByFilter_ProductsStock_tab1();
        }
        private void ReturnDate_dateTimePicker_tab4_ValueChanged(object sender, EventArgs e)
        {
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            orderArr = orderArr.FilterByTodayRentEnd_ForReport(ReturnDate_dateTimePicker_tab4.Value);

            TodayRentEnd_listBox_tab4.DataSource = orderArr;
        }
        private void Date_dateTimePicker_tab3_ValueChanged(object sender, EventArgs e)
        {
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            orderArr = orderArr.FilterByTodayOrders_ForReport(Date_dateTimePicker_tab3.Value);

            TodayOrders_listBox_tab3.DataSource = orderArr;
        } 
        #endregion

        private void SetDateToToday()
        {
            ReturnDate_dateTimePicker_tab4.MaxDate = DateTime.Today.AddDays(30);
            ReturnDate_dateTimePicker_tab4.Value = DateTime.Today;

            Date_dateTimePicker_tab3.MaxDate = DateTime.Today;
            Date_dateTimePicker_tab3.Value = DateTime.Today;

            Date_dateTimePicker_tab2.MaxDate = DateTime.Today;
            Date_dateTimePicker_tab2.Value = DateTime.Today;
        }
    }
}

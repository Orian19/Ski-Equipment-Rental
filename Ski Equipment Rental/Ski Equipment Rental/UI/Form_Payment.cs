using Ski_Equipment_Rental.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ski_Equipment_Rental.UI
{
    public partial class Form_Payment : Form
    {
        public Form_Payment()
        {
            InitializeComponent();
        }

        TimeSpan totalRentDays = new TimeSpan();
        decimal tax = 0;
        decimal totalPricePerDay = 0;
        decimal priceNum = 0;
        decimal taxNum = 0;
        decimal finalPriceNum = 0;
        string change = null;
        Order order;

        public Form_Payment(Order order, decimal totalPricePerDay)
        {
            InitializeComponent();

            this.totalPricePerDay = totalPricePerDay;

            this.order = order;

            IDnum_Label.Text = order.Id.ToString();

            RentDate_dateTimePicker.MaxDate = DateTime.Today;
            ReturnDate_dateTimePicker.MaxDate = DateTime.Today.AddDays(30);
            ReturnDate_dateTimePicker.MinDate = DateTime.Today.AddDays(1);
            
            RentDate_dateTimePicker.Value = DateTime.Today;
            ReturnDate_dateTimePicker.Value = DateTime.Today.AddDays(1);
        }

        #region Checks - בדיקות תקינות הטופס
        private bool CheckForm()
        {
            //בדיקת תקינות הטופס

            bool flag = true;

            //בדיקה שנבחר תאריך ויש סכום לתשלום
            if (finalPriceNum == 0)
            {
                flag = false;
            }

            if (ReturnDate_dateTimePicker.Value == DateTime.Today)
            {
                flag = false;
            }

            if (AmountPaid_textBox.Text.Length < 1)
            {
                flag = false;
                AmountPaid_textBox.BackColor = Color.Red;
            }
            else
                AmountPaid_textBox.BackColor = Color.Lime;

            return flag;
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.KeyChar = char.MinValue;
            }
        }
        #endregion

        #region Controls
        private void Exit_label_Click(object sender, EventArgs e)
        { 
            if (!order.IsPaid)
            {
                if (MessageBox.Show("לא בוצע תשלום. האם ברצונך לצאת?", "אזהרה",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
        #endregion

        private Order FormToOrder()
        {
            //ממירה את המידע בטופס לטנ"מ הזמנה
            order.IsPaid = true;
            order.ReturnDate = ReturnDate_dateTimePicker.Value;
            order.FinalPrice = finalPriceNum;

            return order;
        }

        #region Email
        private void mail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("skiequipmentrental19@gmail.com");
            mail.To.Add(order.Client.Email);
            mail.Subject = "חשובנית על הזמנתך בחנות השכרת ציוד הסקי של אוריאן";
            mail.Body = mailbody();

            SmtpServer.Port = 587;
            SmtpServer.EnableSsl = true;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("skiequipmentrental19", "eyibqdqwxqazhujm");

            SmtpServer.Send(mail);
            MessageBox.Show("המייל נשלח ללקוח");
        }
        private string mailbody()
        {
            string str;

            str = "הזמנה ל: " + order.Client + "\nבתאריך: " + DateTime.Now + "\r\nהערה: " +
                order.Comment + "\r\nעלות הזמנה: " + "₪" + order.FinalPrice + 
                "\nתקופת ההשכרה שלך מסתיימת בתאריך:" + order.ReturnDate.Date +
                "\n תודה ששכרת ציוד סקי אצלנו!";

            return str;
        } 
        #endregion

        #region Buttons - כפתורים
        private void Clear_button_Click(object sender, EventArgs e)
        {
            RentDate_dateTimePicker.Value = DateTime.Today;
            ReturnDate_dateTimePicker.Value = DateTime.Today;
            PriceNum_label.Text = "₪0.00";
            TaxNum_label.Text = "₪0.00";
            FinalPriceNum_label.Text = "₪0.00";
            AmountPaid_textBox.Text = "";
            AmountPaid_textBox.BackColor = Color.White;
        }
        private void Confirm_button_Click(object sender, EventArgs e)
        {
            totalRentDays = ReturnDate_dateTimePicker.Value - RentDate_dateTimePicker.Value;
            tax = (Decimal.Multiply((decimal)totalRentDays.TotalDays, (decimal)0.17)) * totalPricePerDay;

            priceNum = (Decimal.Multiply((decimal)totalRentDays.TotalDays, totalPricePerDay));
            PriceNum_label.Text = "₪" + priceNum;

            taxNum = tax;
            TaxNum_label.Text = "₪" + taxNum;

            finalPriceNum = (tax + Decimal.Multiply((decimal)totalRentDays.TotalDays, totalPricePerDay));
            FinalPriceNum_label.Text = "₪" + finalPriceNum;
        }
        private void Pay_button_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("לא נבחר תאריך החזרה ו/או לא מולאו שדות החובה!", "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                try
                {
                    decimal amountPaid = decimal.Parse(AmountPaid_textBox.Text);

                    if (amountPaid < finalPriceNum)
                    {
                        AmountPaid_textBox.BackColor = Color.Red;

                        //הצגת הודעה במידה והוכנס סכום שקטן מהסכום לתשלום
                        MessageBox.Show("הסכום שהוזן קטן מהסכום לתשלום!", "שגיאה",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                        return;
                    }

                    Order order = FormToOrder();

                    if (order.Update())
                    {
                        change = "₪" + (Decimal.Subtract(amountPaid, finalPriceNum));

                        if (MessageBox.Show("התשלום בוצע בהצלחה! \nעודף : " + change + "\nהאם ברצונך לשלוח חשבונית ללקוח?", "ביצוע תשלום",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign) == System.Windows.Forms.DialogResult.Yes)
                        {
                            mail();

                            this.Close();
                        }
                        else
                            this.Close();

                    }

                    else
                        MessageBox.Show("שגיאה בתשלום", "",
                        MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }

                catch(Exception ex)
            {
                AmountPaid_textBox.BackColor = Color.Red;

                MessageBox.Show("סכום הכסף שהוזן אינו בתבנית הנכונה.\nראה דוגמא: 2.5" + ex.Message, "שגיאה",
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                
            }

        }

    }
    #endregion
}
}

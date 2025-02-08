using Ski_Equipment_Rental.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ski_Equipment_Rental.UI
{
    public partial class Form_Charts : Form
    {
        public Form_Charts()
        {
            InitializeComponent();

            AddYearsToFilter();

            DataToChart_MonthlyIncome();
            DataToChart_ClientsAge();
            DataToChart_MostPopularCategory();
            DataToChart_NumOfOrders();
        }

        #region DataToChart
        public void DataToChart_MonthlyIncome()
        {
            //פלטת הצבעים
            MonthlyIncome_chart_tab1.Palette = ChartColorPalette.BrightPastel;
            //מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            MonthlyIncome_chart_tab1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            //כותרת הגרף
            MonthlyIncome_chart_tab1.Titles.Clear();
            MonthlyIncome_chart_tab1.Titles.Add("הכנסה חודשית");

            //הוספת הערכים למשתנה מסוג מילון ממוין
            Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            for (int i = 1; i < 13; i++)
            {
                if (YearFilter_comboBox_tab1.SelectedItem != null)
                {
                    dictionary.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i),
                    orderArr.FilterByYearMonth_ForChart(int.Parse(YearFilter_comboBox_tab1.Text), i).GetFinalPriceSum());
                }

            }

            //הגדרת סדרה וערכיה
            Series series = new Series("הכנסה חודשית בשקלים", 500);
            //סוג הגרף
            series.ChartType = SeriesChartType.Column;
            //המידע שיוצג לכל רכיב ערך בגרף
            //#VALX - שם
            //#VAL - הערך
            //#PERCENT{P0} - אחוז עם אפס אחרי הנקודה
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            series.Label = "#VAL";
            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //הוספת הסדרה לפקד הגרף
            MonthlyIncome_chart_tab1.Series.Clear();
            MonthlyIncome_chart_tab1.Series.Add(series);
        }
        public void DataToChart_ClientsAge()
        {
            //פלטת הצבעים
            ClientsAge_chart_tab2.Palette = ChartColorPalette.Pastel;
            //מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            ClientsAge_chart_tab2.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            //כותרת הגרף
            ClientsAge_chart_tab2.Titles.Clear();
            ClientsAge_chart_tab2.Titles.Add("התפלגות גילאים של הלקוחות");

            //הוספת הערכים למשתנה מסוג מילון ממוין
            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            dictionary2.Add("18-25", clientArr.Filter(18, 25));
            dictionary2.Add("26-35", clientArr.Filter(26, 35));
            dictionary2.Add("36-59", clientArr.Filter(36, 59));
            dictionary2.Add("60-99", clientArr.Filter(60, 99));

            //הגדרת סדרה וערכיה
            Series series = new Series("מספר לקוחות לפי תחום גילאים", 100);
            //סוג הגרף
            series.ChartType = SeriesChartType.Column;

            series.Label = "#VAL";
            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary2.Keys, dictionary2.Values);

            //הוספת הסדרה לפקד הגרף
            ClientsAge_chart_tab2.Series.Clear();
            ClientsAge_chart_tab2.Series.Add(series);
        }
        public void DataToChart_MostPopularCategory()
        {
            //כותרת הגרף
            MostPopularCategory_chart_tab3.Titles.Clear();
            MostPopularCategory_chart_tab3.Titles.Add("הקטגוריה הפופולארית ביותר");

            //הוספת הערכים למשתנה מסוג מילון ממוין
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            CategoryArr categoryArr = new CategoryArr();
            categoryArr.Fill();

            for (int i = 0; i < categoryArr.Count; i++)
            {
                if (YearFilter_comboBox_tab3.SelectedItem != null)
                {
                    dictionary.Add(categoryArr[i].ToString(), 
                    orderProductArr.FilterByCategory_ForChart(int.Parse(YearFilter_comboBox_tab3.Text),
                    categoryArr[i] as Category).Count);
                }
            }

            //הגדרת סדרה וערכיה
            Series series = new Series("", 10);
            //סוג הגרף
            series.ChartType = SeriesChartType.Pie;
            //המידע שיוצג לכל רכיב ערך בגרף
            //#VALX - שם
            //#VAL - הערך
            //#PERCENT{P0} - אחוז עם אפס אחרי הנקודה
            series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            //series.Label = "#VAL";
            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //הוספת הסדרה לפקד הגרף
            MostPopularCategory_chart_tab3.Series.Clear();
            MostPopularCategory_chart_tab3.Series.Add(series);
        }
        public void DataToChart_NumOfOrders()
        {
            //פלטת הצבעים
            NumOfOrders_chart_tab4.Palette = ChartColorPalette.Fire;
            //מחייב הצגת כל הערכים בציר האיקס, אם רוצים שיוצגו לסירוגין רושמים 2
            NumOfOrders_chart_tab4.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            //כותרת הגרף
            NumOfOrders_chart_tab4.Titles.Clear();
            NumOfOrders_chart_tab4.Titles.Add("מספר הזמנות בחודש");

            //הוספת הערכים למשתנה מסוג מילון ממוין
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            for (int i = 1; i < 13; i++)
            {
                if (YearFilter_comboBox_tab4.SelectedItem != null)
                {
                    dictionary.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(i),
                    orderArr.FilterByNumOfOrders_ForChart(int.Parse(YearFilter_comboBox_tab4.Text), i).Count);
                }

            }

            //הגדרת סדרה וערכיה
            Series series = new Series("מספר הזמנות", 100);
            //סוג הגרף
            series.ChartType = SeriesChartType.Column;
            //המידע שיוצג לכל רכיב ערך בגרף
            //#VALX - שם
            //#VAL - הערך
            //#PERCENT{P0} - אחוז עם אפס אחרי הנקודה
            //series.Label = "#VALX [#VAL = #PERCENT{P0}]";
            series.Label = "#VAL";
            //הוספת הערכים מתוך משתנה המילון לסדרה
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);

            //הוספת הסדרה לפקד הגרף
            NumOfOrders_chart_tab4.Series.Clear();
            NumOfOrders_chart_tab4.Series.Add(series);
        }

        #endregion

        #region Filter
        private void AddYearsToFilter()
        {
            for (int i = DateTime.Today.Year - 3; i <= DateTime.Today.Year; i++)
            {
                YearFilter_comboBox_tab1.Items.Add(i);
                YearFilter_comboBox_tab3.Items.Add(i);
                YearFilter_comboBox_tab4.Items.Add(i);
            }

            YearFilter_comboBox_tab1.Text = DateTime.Today.Year.ToString();
            YearFilter_comboBox_tab3.Text = DateTime.Today.Year.ToString();
            YearFilter_comboBox_tab4.Text = DateTime.Today.Year.ToString();
        }

        private void YearFilter_comboBox_tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataToChart_MonthlyIncome();
        }
        private void YearFilter_comboBox_tab3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataToChart_MostPopularCategory();
        }
        private void YearFilter_comboBox_tab4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataToChart_NumOfOrders();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class ReportForm : Form
    {
        Koneksi koneksi = new Koneksi();
        public ReportForm()
        {
            InitializeComponent();

            dtPicker1.Format = DateTimePickerFormat.Custom;
            dtPicker1.CustomFormat = "MMMM";
            dtPicker1.ShowUpDown = true;

            dtPicker2.Format = DateTimePickerFormat.Custom;
            dtPicker2.CustomFormat = "MMMM";
            dtPicker2.ShowUpDown = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.Parse(dtPicker1.Value.ToString("MM")) <= int.Parse(dtPicker2.Value.ToString("MM")))
            {
                generateDG();
            }
            else
            {
                MessageBox.Show("Dari Bulan tidak boleh lebih dari Tujuan Bulan");
            }

        }

        private void generateDG()
        {
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dg.Refresh();
            dg.DataSource = dt;

            koneksi.select("select MONTH(OH.Date) Bulan ,SUM(OD.Qty * MM.Price) Total from OrderDetail OD left join OrderHeader OH on OD.OrderId = OH.Id left join MsMenu MM on OD.MenuId = MM.Id where OH.PaymentType IS NOT NULL AND MONTH(OH.Date) BETWEEN '" + dtPicker1.Value.ToString("MM") + "' AND '" + dtPicker2.Value.ToString("MM") + "' group by MONTH(OH.Date)");
            koneksi.adp.Fill(dt);

            dg.DataSource = dt;

            int i = 0;
            List<string> month = new List<string>();
            List<int> price = new List<int>();

            foreach (DataRow dtr in dt.Rows)
            {
                month.Add(dtr[0].ToString());
                price.Add(int.Parse(dtr[1].ToString()));
                i += 1;
            }

            var resMonth = month.ToArray();
            var resPrice = price.ToArray();

            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Series.Add("Income");
            chart1.Titles.Add("Income in Million");
            
            for (int j = 0; j < resMonth.Length; j++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName( int.Parse(resMonth[j]) );
                chart1.Series["Income"].Points.AddXY( monthName , (float) resPrice[j] / 1000000); // dibagi 1 juta, karena ditampilinnya dalam satuan juta kalo disoal
            }
        }
    }
}
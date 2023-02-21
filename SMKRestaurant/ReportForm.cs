using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class ReportForm : Form
    {
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

        }
    }
}
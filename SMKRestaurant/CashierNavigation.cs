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
    public partial class CashierNavigation : Form
    {
        string employeeID, employeeName;
        public CashierNavigation(String employeeID, String employeeName)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            labelCashier.Text = employeeName;
        }

        private void btnToPayment_Click(object sender, EventArgs e)
        {
            PaymentForm frmPay = new PaymentForm(employeeID);
            frmPay.ShowDialog();
        }
    }
}

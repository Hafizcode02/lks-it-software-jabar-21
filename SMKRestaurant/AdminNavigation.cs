using System;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class AdminNavigation : Form
    {
        string employeeID, employeeName;
        public AdminNavigation(String employeeID, String employeeName)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            labelAdmin.Text = employeeName;
        }

        private void btnToManageMenu_Click(object sender, EventArgs e)
        {
            ManageMenu manageMenuForm = new ManageMenu(employeeID);
            manageMenuForm.ShowDialog();
        }

        private void btnToManageMember_Click(object sender, EventArgs e)
        {
            ManageMember manageMember = new ManageMember();
            manageMember.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Hide();
            MessageBox.Show("You Has Been Logged Out");
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnToOrderForm_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm(employeeID);
            order.ShowDialog();
        }
    }
}

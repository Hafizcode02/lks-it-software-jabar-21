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
    public partial class Login : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string employeeID, position, employeeName;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please Fill all column");
            }
            else
            {
                koneksi.select("select * from MsEmployee where Email = '" + txtEmail.Text + "' and Password = '" + txtPassword.Text + "'");
                koneksi.adp.Fill(dt);
                if (koneksi.dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Wrong Account");
                }
                else
                {
                    foreach (DataRow dtr in dt.Rows)
                    {
                        employeeID = dtr["Id"].ToString();
                        employeeName = dtr["Name"].ToString();
                        position = dtr["Position"].ToString();
                    }

                    if (position == "admin")
                    {
                        AdminNavigation admNav = new AdminNavigation(employeeID, employeeName);
                        this.Hide();
                        admNav.ShowDialog();
                        this.Close();

                    }
                    else if (position == "kasir")
                    {
                        CashierNavigation casNav = new CashierNavigation(employeeID, employeeName);
                        this.Hide();
                        casNav.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong");
                    }

                }
            }
        }
    }
}

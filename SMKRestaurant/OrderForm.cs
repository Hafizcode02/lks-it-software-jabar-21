using System;
using System.Data;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class OrderForm : Form
    {
        string employeeID;
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable(); // DG Menu
        DataTable dt2 = new DataTable(); // DG Order List
        DataTable dt3 = new DataTable(); // Temporary DT
        int MenuID = 0;
        public OrderForm(String employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            viewDGMenu();
        }

        private void viewDGMenu()
        {
            dt.Clear();
            dgMenuList.DataSource = dt;
            dgMenuList.Refresh();
            koneksi.select("SELECT * FROM MsMenu");
            koneksi.adp.Fill(dt);
            dgMenuList.DataSource = dt;

            dgMenuList.Columns[0].Visible = false;
            dgMenuList.Columns[1].HeaderText = "Name";
            dgMenuList.Columns[2].HeaderText = "Price";
            dgMenuList.Columns[3].Visible = false;
            dgMenuList.Columns[4].HeaderText = "Carbo";
            dgMenuList.Columns[5].HeaderText = "Protein";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuID != 0)
                {
                    dt3.Clear();
                    koneksi.select("SELECT * FROM MsMenu WHERE Id='" + MenuID + "'");
                    koneksi.adp.Fill(dt3);

                    if (dt3.Rows.Count != 0)
                    {
                        DataRow dtr = dt3.Rows[0];
                        int price = int.Parse(dtr[2].ToString()) * int.Parse(txtQty.Text);
                        dgOrderList.Rows.Add(
                            dtr[0].ToString(),
                            dtr[1].ToString(),
                            txtQty.Text,
                            dtr[4].ToString(),
                            dtr[5].ToString(),
                            dtr[2].ToString(),
                            price
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }

        private void dgMenuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgMenuList.Rows[e.RowIndex];
                MenuID = Int32.Parse(row.Cells[0].Value.ToString());
                txtMenuName.Text = row.Cells[1].Value.ToString();
                pictureMenu.ImageLocation = row.Cells[3].Value.ToString();
                pictureMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

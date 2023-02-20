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
        int MenuID, rowIndexDeleted = 0;
        bool equalStatus = false;
        int carboSum, proteinSum, totalSum = 0;
        public OrderForm(String employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
            viewDGMenu();
            RefreshLabel();

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void RefreshLabel()
        {
            labelCarbo.Text = "Carbo : " + carboSum;
            labelProtein.Text = "Protein : " + proteinSum;
            labelTotal.Text = "Total : " + totalSum;

            txtMenuName.Clear();
            txtQty.Clear();
            pictureMenu.ImageLocation = "";

            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
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

        private void dgOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgOrderList.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    MenuID = Int32.Parse(row.Cells[0].Value.ToString());
                    txtMenuName.Text = row.Cells[1].Value.ToString();
                    txtQty.Text = row.Cells[2].Value.ToString();
                    pictureMenu.ImageLocation = row.Cells[7].Value.ToString();
                    pictureMenu.SizeMode = PictureBoxSizeMode.StretchImage;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgOrderList.Rows[rowIndexDeleted];
            MessageBox.Show(rowIndexDeleted.ToString());

            carboSum -= (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[3].Value.ToString()));
            proteinSum -= (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(row.Cells[4].Value.ToString()));
            totalSum -= int.Parse(row.Cells[6].Value.ToString());

            dgOrderList.Rows.Remove(row);

            RefreshLabel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MenuID != 0)
                {
                    dt3.Clear(); // Clear Datatable
                    koneksi.select("SELECT * FROM MsMenu WHERE Id='" + MenuID + "'"); // Get Data

                    koneksi.adp.Fill(dt3);

                    if (dt3.Rows.Count != 0) // Checking Not 0
                    {
                        DataRow dtr = dt3.Rows[0]; // Get Data in Row
                        int price = int.Parse(dtr[2].ToString()) * int.Parse(txtQty.Text); // Calculate Price

                        int maxCount = dgOrderList.RowCount; // Max Iteration in DataGridView
                        int count = 0;

                        foreach (DataGridViewRow row in dgOrderList.Rows)
                        {
                            count += 1;
                            if (count == maxCount) // This Line is Important, because Datagridview also read a last row, which is empty row
                            {
                                break;
                            }

                            // Check Equals Data For Update
                            if (row.Cells["Column1"].Value.ToString() == dtr[0].ToString())
                            {
                                equalStatus = true;

                                // min sum
                                carboSum -= (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(dtr[4].ToString()));
                                proteinSum -= (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(dtr[5].ToString()));
                                totalSum -= int.Parse(row.Cells[6].Value.ToString());

                                row.Cells[2].Value = txtQty.Text;
                                row.Cells[6].Value = price;

                                // plus sum again
                                carboSum += (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(dtr[4].ToString()));
                                proteinSum += (int.Parse(row.Cells[2].Value.ToString()) * int.Parse(dtr[5].ToString()));
                                totalSum += int.Parse(row.Cells[6].Value.ToString());

                                break;
                            } // Give status = false
                            else
                            {
                                equalStatus = false;
                            }

                        }
                        count = 0; // reset counter

                        if (equalStatus == false) // add new row, if not find equal data on order list
                        {
                            if ((dgOrderList.RowCount - 1) < dt.Rows.Count) // for restrict add new menu over sum of menu list
                            {
                                dgOrderList.Rows.Add(
                                    dtr[0].ToString(),
                                    dtr[1].ToString(),
                                    txtQty.Text,
                                    dtr[4].ToString(),
                                    dtr[5].ToString(),
                                    dtr[2].ToString(),
                                    price,
                                    dtr[3].ToString()
                                );
                                carboSum += (int.Parse(txtQty.Text.ToString()) * int.Parse(dtr[4].ToString()));
                                proteinSum += (int.Parse(txtQty.Text.ToString()) * int.Parse(dtr[5].ToString()));
                                totalSum += price;
                            }
                        }

                        equalStatus = true; // reset equal status

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                RefreshLabel();
            }

        }

        private void dgMenuList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgMenuList.Rows[e.RowIndex];

                if (row.Cells[0].Value != null)
                {
                    MenuID = Int32.Parse(row.Cells[0].Value.ToString());
                    txtMenuName.Text = row.Cells[1].Value.ToString();
                    pictureMenu.ImageLocation = row.Cells[3].Value.ToString();
                    pictureMenu.SizeMode = PictureBoxSizeMode.StretchImage;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = false;
                }

                rowIndexDeleted = e.RowIndex; // Ada Problem disini, nanti di cari lebih lanjut aja. tapi hapusnya bisa, di kondisi tertentu error
                if (e.RowIndex > 0)
                {
                    if (dgOrderList.RowCount <= 2)
                    {
                        rowIndexDeleted -= 1;
                    }
                }

            }
        }
    }
}

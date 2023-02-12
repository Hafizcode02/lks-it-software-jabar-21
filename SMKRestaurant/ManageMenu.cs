using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class ManageMenu : Form
    {
        Koneksi koneksi = new Koneksi();
        OpenFileDialog ofd = new OpenFileDialog();
        DataTable dt = new DataTable();
        string employeeId;
        public ManageMenu(String employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            InitiateRefresh();
        }

        private void InitiateRefresh()
        {
            viewDG();
            txtMenuID.ReadOnly = true;
            txtPhoto.ReadOnly = true;

            clearForm();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void clearForm()
        {
            txtSearch.Text = "";
            txtMenuID.Text = "";
            txtName.Text = "";
            txtPhoto.Text = "";
            txtCarbo.Text = "";
            txtProtein.Text = "";
            txtPrice.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void viewDG()
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("SELECT * FROM MsMenu");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "MenuID";
            dg.Columns[1].HeaderText = "Name";
            dg.Columns[2].HeaderText = "Price";
            dg.Columns[3].Visible = false;
            dg.Columns[4].HeaderText = "Carbo";
            dg.Columns[5].HeaderText = "Protein";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtName.Text) || "".Equals(txtPrice.Text) || "".Equals(txtCarbo.Text) || "".Equals(txtProtein.Text))
                {
                    MessageBox.Show("Please Fill All Column");
                }
                else
                {
                    if (txtPhoto.Text == "" || pictureBox1.ImageLocation == "" || pictureBox1.Image == null)
                    {
                        MessageBox.Show("Please Input The Picture");
                    }
                    else
                    {
                        koneksi.cud(
                            "INSERT INTO MsMenu (Name, Price, Photo, Carbo, Protein) VALUES ('" + txtName.Text + "', '" + txtPrice.Text + "', '" + pictureBox1.ImageLocation + "', '" + txtCarbo.Text + "', '" + txtProtein.Text + "')"
                        );
                        MessageBox.Show("Insert Data Successfull");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                InitiateRefresh();
            }
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Chose Image (*.img; *.jpg; *.png; *.gif)|*.img; *.jpg; *.png; *.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.ImageLocation = ofd.FileName;
                txtPhoto.Text = ofd.SafeFileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if ("".Equals(txtName.Text) || "".Equals(txtPrice.Text) || "".Equals(txtCarbo.Text) || "".Equals(txtProtein.Text))
                {
                    MessageBox.Show("Please Fill All Column");
                }
                else
                {
                    if (txtPhoto.Text == "" || pictureBox1.ImageLocation == "" || pictureBox1.Image == null)
                    {
                        MessageBox.Show("Please Input The Picture");
                    }
                    else
                    {
                        koneksi.cud(
                            "UPDATE MsMenu SET Name = '" + txtName.Text + "', Price = '" + txtPrice.Text + "', Photo = '" + pictureBox1.ImageLocation + "', Carbo = '" + txtCarbo.Text + "', Protein = '" + txtProtein.Text + "' where Id = '" + txtMenuID.Text + "'"
                        );
                        MessageBox.Show("Update Data Successfull");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                InitiateRefresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this data ? ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    koneksi.cud("DELETE FROM MsMenu WHERE Id='" + txtMenuID.Text + "'");
                    MessageBox.Show("Data Deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                InitiateRefresh();
            }
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                txtMenuID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPrice.Text = row.Cells[2].Value.ToString();
                txtPhoto.Text = row.Cells[3].Value.ToString();
                txtCarbo.Text = row.Cells[4].Value.ToString();
                txtProtein.Text = row.Cells[5].Value.ToString();
                pictureBox1.ImageLocation = row.Cells[3].Value.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                if(row.Cells[0].Value.ToString() != "")
                {
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }
    }
}

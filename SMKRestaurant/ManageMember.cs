using System;
using System.Data;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class ManageMember : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
        string status = "";
        public ManageMember()
        {
            InitializeComponent();
            InitiateRefresh();
        }

        private void InitiateRefresh()
        {
            viewDG();
            txtMemberID.ReadOnly = true;

            clearForm();
            btnInsert.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Visible = false;
            btnCancel.Visible = false;

            btnSearch.Enabled = false;
            btnSearch.Visible = false;

            status = "";
        }

        private void clearForm()
        {
            txtSearch.Text = "";
            txtMemberID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

            txtMemberID.Enabled = false;
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
        }

        private void enabledForm()
        {
            txtMemberID.Enabled = true;
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
        }

        private void viewDG()
        {
            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("SELECT * FROM MsMember");
            koneksi.adp.Fill(dt);
            dg.DataSource = dt;

            dg.Columns[0].HeaderText = "MemberID";
            dg.Columns[1].HeaderText = "Name";
            dg.Columns[2].HeaderText = "Email";
            dg.Columns[3].HeaderText = "Handphone";
            dg.Columns[4].HeaderText = "Join Date";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Contoh Pencarian Realtime

            dt.Clear();
            dg.DataSource = dt;
            dg.Refresh();
            koneksi.select("SELECT * FROM MsMember WHERE Name LIKE '%" + txtSearch.Text + "%' or Handphone LIKE '%" + txtSearch.Text + "%' or Email LIKE '%" + txtSearch.Text + "%'");
            koneksi.adp.Fill(dt);

            dg.Columns[0].HeaderText = "MemberID";
            dg.Columns[1].HeaderText = "Name";
            dg.Columns[2].HeaderText = "Email";
            dg.Columns[3].HeaderText = "Handphone";
            dg.Columns[4].HeaderText = "Join Date";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            status = "Insert";
            btnSave.Visible = true;
            btnCancel.Visible = true;
            enabledForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (status == "Insert")
            {
                try
                {
                    if ("".Equals(txtName.Text) || "".Equals(txtEmail.Text) || "".Equals(txtPhone.Text))
                    {
                        MessageBox.Show("Please Fill all column");
                    }
                    else
                    {
                        koneksi.cud("INSERT INTO MsMember (Name, Email, Handphone, JoinDate) VALUES ('" + txtName.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')");
                        MessageBox.Show("Insert Data Successfully");
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
            else if (status == "Update")
            {
                try
                {
                    if ("".Equals(txtMemberID.Text) || "".Equals(txtName.Text) || "".Equals(txtEmail.Text) || "".Equals(txtPhone.Text))
                    {
                        MessageBox.Show("Please Fill all column");
                    }
                    else
                    {
                        koneksi.cud("UPDATE MsMember SET Name='" + txtName.Text + "', Email='" + txtEmail.Text + "', Handphone='" + txtPhone.Text + "' WHERE Id='" + txtMemberID.Text + "'");
                        MessageBox.Show("Update Data Successfully");
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
            else
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            status = "Update";
            btnSave.Visible = true;
            btnCancel.Visible = true;
            enabledForm();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg.Rows[e.RowIndex];
                txtMemberID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();

                if (row.Cells[0].Value.ToString() != "")
                {
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;

                    btnCancel.Visible = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete this data ? ", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == result)
                {
                    koneksi.cud("DELETE FROM MsMember WHERE Id='" + txtMemberID.Text + "'");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitiateRefresh();
        }
    }
}

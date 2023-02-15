using System;
using System.Data;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class ManageMember : Form
    {
        Koneksi koneksi = new Koneksi();
        DataTable dt = new DataTable();
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
        }

        private void clearForm()
        {
            txtSearch.Text = "";
            txtMemberID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
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

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if("".Equals(txtName.Text) || "".Equals(txtEmail.Text) || "".Equals(txtPhone.Text))
            {

            }
        }
    }
}

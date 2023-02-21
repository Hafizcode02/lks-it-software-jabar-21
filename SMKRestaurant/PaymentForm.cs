using System;
using System.Data;
using System.Windows.Forms;

namespace SMKRestaurant
{
    public partial class PaymentForm : Form
    {
        Koneksi koneksi = new Koneksi();
        string employeeID;
        int totalHarga = 0;
        public PaymentForm(String employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;

            setDefault();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool finish = false;
            try
            {
                if (cbPaymentType.Text == "")
                {
                    MessageBox.Show("Harap isi terlebih dahulu");
                    finish = false;
                }
                else if (cbPaymentType.Text == "Credit" && (txtCardNumber.Text == "" || cbBankName.Text == ""))
                {
                    MessageBox.Show("Harap Isi Card Number & Nama Bank");
                    finish = false;
                }
                else if (cbPaymentType.Text == "Cash" && (txtHarga.Text == ""))
                {
                    MessageBox.Show("Harap Isi Input Bayar");
                    finish = false;
                }
                else
                {
                    if (cbPaymentType.Text == "Credit")
                    {
                        int valnum = 0;

                        if (int.TryParse(txtCardNumber.Text.Trim(), out valnum))
                        {
                            koneksi.cud("UPDATE OrderHeader SET EmployeeId ='" + employeeID + "', Date='" + DateTime.Now.ToString("yyyy-MM-dd") + "', PaymentType='" + cbPaymentType.Text + "', CardNumber='" + txtCardNumber.Text + "', Bank='" + cbBankName.Text + "' WHERE Id='" + cbOrderID.Text + "'");
                            MessageBox.Show("Pembayaran Berhasil");
                            finish = true;
                        }
                        else
                        {
                            //not a number
                            MessageBox.Show("Harap Isikan Nilai Angka dengan benar");
                            finish = false;
                        }
                    }
                    else
                    {
                        int valnum = 0;

                        if (int.TryParse(txtHarga.Text.Trim(), out valnum))
                        {
                            if (Int32.Parse(txtHarga.Text) < totalHarga)
                            {
                                MessageBox.Show("Uang Anda Kurang");
                                finish = false;
                            }
                            else
                            {
                                koneksi.cud("UPDATE OrderHeader SET EmployeeId ='" + employeeID + "', Date='" + DateTime.Now.ToString("yyyy-MM-dd") + "', PaymentType='" + cbPaymentType.Text + "' WHERE Id='" + cbOrderID.Text + "'");

                                MessageBox.Show("Pembayaran Berhasil");
                                MessageBox.Show("Kembalian Anda : " + (Int32.Parse(txtHarga.Text) - totalHarga).ToString());
                                finish = true;
                            }
                        }
                        else
                        {
                            //not a number
                            MessageBox.Show("Harap Isikan Nilai Angka dengan benar");
                            finish = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (finish)
                { setDefault(); }


            }
        }

        private void setDefault()
        {
            labelCardNumber.Visible = false;
            labelBank.Visible = false;
            labelInputHarga.Visible = false;

            labelCardNumber.Enabled = false;
            labelBank.Enabled = false;
            labelInputHarga.Enabled = false;

            txtCardNumber.Enabled = false;
            cbBankName.Enabled = false;
            txtHarga.Enabled = false;

            txtCardNumber.Visible = false;
            cbBankName.Visible = false;
            txtHarga.Visible = false;

            loadOrderID();
            loadCBPayment();
            refreshLabel();
            loadCBBank();
            totalHarga = 0;

            txtHarga.Text = "";
            txtCardNumber.Text = "";
            cbPaymentType.Text = "";
            cbBankName.Text = "";
            cbOrderID.Text = "";

            dataGridView1.DataSource = null;

        }


        private void refreshLabel()
        {
            labelTotal.Text = "Total : " + totalHarga;
        }


        private void loadOrderID()
        {
            cbOrderID.Items.Clear();
            cbOrderID.Refresh();

            DataTable cb = new DataTable();
            cb.Clear();
            koneksi.select("SELECT Id FROM OrderHeader WHERE PaymentType IS NULL");
            koneksi.adp.Fill(cb);

            foreach (DataRow dtr in cb.Rows)
            {
                cbOrderID.Items.Add(dtr[0].ToString().TrimEnd());
            }
        }

        private void loadCBPayment()
        {
            cbPaymentType.Items.Clear();
            cbPaymentType.Refresh();

            cbPaymentType.Items.Add("Cash");
            cbPaymentType.Items.Add("Credit");
        }

        private void loadCBBank()
        {
            cbBankName.Items.Clear();

            cbBankName.Items.Add("BCA");
            cbBankName.Items.Add("BNI");
            cbBankName.Items.Add("MANDIRI");
        }


        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void cbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalHarga = 0;
            loadDGOrder(cbOrderID.Text);
        }

        private void loadDGOrder(string orderId)
        {
            DataTable dt = new DataTable();
            dt.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView1.DataSource = dt;

            koneksi.select("select MsMenu.Name, OrderDetail.Qty, MsMenu.Price, (OrderDetail.Qty * MsMenu.Price) As Total from OrderDetail left join MsMenu on OrderDetail.MenuId = MsMenu.Id Where OrderId = '" + orderId + "'");
            koneksi.adp.Fill(dt);

            dataGridView1.DataSource = dt;

            foreach (DataRow dtr in dt.Rows)
            {
                totalHarga += Int32.Parse(dtr[3].ToString());
            }

            refreshLabel();
        }

        private void cbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPaymentType.Text != "")
            {
                if (cbPaymentType.Text == "Credit")
                {
                    labelCardNumber.Visible = true;
                    labelBank.Visible = true;
                    labelInputHarga.Visible = false;

                    labelCardNumber.Enabled = true;
                    labelBank.Enabled = true;
                    labelInputHarga.Enabled = false;

                    txtCardNumber.Enabled = true;
                    cbBankName.Enabled = true;
                    txtHarga.Enabled = false;

                    txtCardNumber.Visible = true;
                    cbBankName.Visible = true;
                    txtHarga.Visible = false;
                }
                else if (cbPaymentType.Text == "Cash")
                {
                    labelCardNumber.Visible = false;
                    labelBank.Visible = false;
                    labelInputHarga.Visible = true;

                    labelCardNumber.Enabled = false;
                    labelBank.Enabled = false;
                    labelInputHarga.Enabled = true;

                    txtCardNumber.Enabled = false;
                    cbBankName.Enabled = false;
                    txtHarga.Enabled = true;

                    txtCardNumber.Visible = false;
                    cbBankName.Visible = false;
                    txtHarga.Visible = true;
                }
            }
        }
    }
}

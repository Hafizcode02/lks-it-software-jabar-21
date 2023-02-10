using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SMKRestaurant
{
    class Koneksi
    {
        public static string database = ("Data Source = DESKTOP-UUUQOK8;Initial Catalog =LKSJabar2021;Integrated Security=True");
        public SqlConnection koneksi = new SqlConnection(database);
        public SqlCommand cmd;
        public SqlDataAdapter adp = new SqlDataAdapter();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataSet ds;

        public void select(string query)
        {
            try
            {
                dt.Clear();
                koneksi.Open();
                cmd = new SqlCommand(query, koneksi);
                adp.SelectCommand = cmd;
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        public void cud(string query)
        {
            try
            {
                koneksi.Open();
                cmd = new SqlCommand(query, koneksi);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

        public void chart(string query)
        {
            try
            {
                koneksi.Open();
                cmd = new SqlCommand(query, koneksi);
                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}

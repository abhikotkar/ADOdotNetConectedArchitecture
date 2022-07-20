using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

using System.Windows.Forms;

namespace ADOdotNetConecterArchitecture.HomeworkADONet
{
    public partial class ProductForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public ProductForm()
        {
            InitializeComponent();
            //step 1
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        }
        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try 
            { 

            string qry = "insert into Product values(@name,@Price)";
                cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtprice.Text));
                con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                MessageBox.Show("Success ! record inserted");
            }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtname.Text = dr["Name"].ToString();// Name , Salary are the col names
                        txtprice.Text = dr["Price"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update Product set Name=@Name, Price=@Price where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtprice.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! record Updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "Delete from Product where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();

                if (result == 1)
                {
                    MessageBox.Show("Record was deleted");
                    txtid.Clear();
                    txtname.Clear();
                    txtprice.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Product";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    empgrid.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

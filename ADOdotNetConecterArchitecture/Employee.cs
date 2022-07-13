using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADOdotNetConecterArchitecture
{
    public partial class Employee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Employee()
        {
            InitializeComponent();
            //step 1
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {


                //step 2 write a query
                string qry = "insert into Employee values(@name,@Salary)";
                //strp 3 assign query to the command
                cmd = new SqlCommand(qry, con);
                //step 4 assign parameter value
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtsal.Text));
                //step 5 open the connection to fire query
                con.Open();
                //step 6 fire the query
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
                string qry = "select * from Employee where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtname.Text = dr["Name"].ToString();// Name , Salary are the col names
                        txtsal.Text = dr["Salary"].ToString();
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
                string qry = "update Employee set Name=@name, Salary=@Salary where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtsal.Text));
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
                string qry = "Delete from Employee where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtid.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                
                if(result==1)
                {
                    MessageBox.Show("Record was deleted");
                    txtid.Clear();
                    txtname.Clear();
                    txtsal.Clear();
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
                string qry = "select * from Employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    empgrid.DataSource=dt;
                    
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

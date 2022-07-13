using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace ADOdotNetConecterArchitecture
{
    public partial class DisconnectedForm1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public DisconnectedForm1()
        {
            InitializeComponent();

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private void DisconnectedForm1_Load(object sender, EventArgs e)
        {

        }
        public DataSet GetAllEmps()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            // assign PK to the col which in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is a table name given which is in the DataSet
            da.Fill(ds, "emp");// Fill method fire the select qry
            return ds;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].NewRow();
                row["Name"] = txtname.Text;
                row["Salary"] = txtsal.Text;
                // attach the new row to the ds
                ds.Tables["emp"].Rows.Add(row);
                //update() will reflect the changes to the DB
                int result = da.Update(ds.Tables["emp"]);
                if (result == 1)
                {
                    MessageBox.Show("Success ! Recored inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    row["Name"] = txtname.Text;
                    row["Salary"] = txtsal.Text;

                    //update() will reflect the changes to the DB
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Success ! Recored Updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    row.Delete();

                    //update() will reflect the changes to the DB
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Success ! Recored Deleted");
                        txtid.Clear();
                        txtname.Clear();
                        txtsal.Clear();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtid.Text);
                if (row != null)
                {
                    txtname.Text = row["Name"].ToString();
                    txtsal.Text = row["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Records not found!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ds = GetAllEmps();
            empgrid.DataSource = ds.Tables["emp"];
        }
    }
}

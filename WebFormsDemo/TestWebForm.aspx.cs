using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebFormsDemo
{
    public partial class TestWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection("data source=192.168.16.231;database=TestDB;user=sam;password=pwd82;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select sum(price) from products";
                cmd.Connection = con;
                con.Open();    
                int res = (int) cmd.ExecuteScalar();
                Response.Write("Total Price = " + res.ToString()+"<br/>");
                //cmd.CommandText = "insert into products(p_name,price) values('speaker',400)";
                //int rowsAffected = cmd.ExecuteNonQuery();
                //Response.Write("Rows Inserted = " + rowsAffected.ToString()+"<br/>");

                //cmd.CommandText = "update products set price = 450 where p_name = 'speaker'";
                //int rowsAffected = cmd.ExecuteNonQuery();
                //Response.Write("Rows Updated = " + rowsAffected.ToString()+"<br/>");

                //cmd.CommandText = "delete from products where p_id = 4";
                //int rowsAffected = cmd.ExecuteNonQuery();
                //Response.Write("\nRows Deleted = " + rowsAffected.ToString()+"<br/>");

                con.Close();
            }

            //using (SqlConnection con = new SqlConnection("data source=192.168.16.231;database=TestDB;user=sam;password=pwd82;"))
            //{
            //    SqlCommand cmd = new SqlCommand("select * from products", con);
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    GridView1.DataSource = rdr;
            //    GridView1.DataBind();
            //    con.Close();
            //}
            //SqlConnection con = new SqlConnection("data source=192.168.16.231;database=TestDB;user=sam;password=pwd82;");
            //SqlConnection con = new SqlConnection(CS);
            //SqlCommand cmd = new SqlCommand("select * from products",con);
            //con.Open();
            //try
            //{
            //SqlDataReader rdr = cmd.ExecuteReader();
            //GridView1.DataSource = rdr; 
            //    GridView1.DataSource = cmd.ExecuteReader();
            //    GridView1.DataBind();
            //}
            //catch(Exception ex)
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                try
                {
                    string command = "Select * from products where p_name like '%" + txtSearchProduct.Text + "%'";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                }
                catch(Exception ex)
                {
                    Response.Write("Error: " + ex);
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
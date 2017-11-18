using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class WebForm2 : System.Web.UI.Page
{
    private string conStr = WebConfigurationManager.ConnectionStrings["StudentConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!this.IsPostBack)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("select * from students order by id", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = reader["Id"] + "," + reader["Name"];
                    newItem.Value = reader["Id"].ToString();
                    DropDownList1.Items.Add(newItem);
                }


            }
            catch (Exception er)
            {
                Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
            }
            finally
            {
                con.Close();

            }
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand("select * from students where id='" + TextBox1.Text + "'", con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ListBox1.Items.Clear();
            ListBox1.Items.Add("Id:" + reader["Id"]);
            ListBox1.Items.Add("Name:" + reader["Name"]);
            ListBox1.Items.Add("Scholar:" + reader["Scholar"]);

        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();

        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand("select * from students where id='" + DropDownList1.SelectedValue + "'", con);
        SqlDataReader reader;
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
            ListBox1.Items.Clear();
            ListBox1.Items.Add("Id:" + reader["Id"]);
            ListBox1.Items.Add("Name:" + reader["Name"]);
            ListBox1.Items.Add("Scholar:" + reader["Scholar"]);

        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();

        }
    }
}
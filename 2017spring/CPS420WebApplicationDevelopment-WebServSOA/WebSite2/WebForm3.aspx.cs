using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class WebForm3 : System.Web.UI.Page
{
    private string conStr = WebConfigurationManager.ConnectionStrings["StudentConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
            FillList();
            BtnsActive(false, true, false, false, false, false);
        }
    }

    protected void BtnsActive(bool a, bool b, bool c, bool d, bool e, bool f)
    {
        Panel2.Enabled = a;
        btnAdd.Enabled = b;
        btnInsert.Enabled = c;
        btnEdit.Enabled = d;
        btnUpdate.Enabled = e;
        btnDelete.Enabled = f;
    }

    protected void FillList()
    {
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand("select * from students order by id", con);
        SqlDataReader reader;
        DropDownList1.Items.Clear();
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
            TextBox1.Text = reader["Id"].ToString();
            TextBox2.Text = reader["Name"].ToString();
            CheckBox1.Checked = (bool)reader["Scholar"];

        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();
            BtnsActive(false, true, false, true, false, true);
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        BtnsActive(true, false, true, false, false, false);
        TextBox1.Text = "";
        TextBox2.Text = "";
        CheckBox1.Checked = false;
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand("insert into students(Id,Name,Scholar) values(@Id,@Name,@Scholar)", con);
        cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Scholar", CheckBox1.Checked);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been added.');</script>");

        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();
            BtnsActive(false, true, false, false, false, false);
            FillList();
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        BtnsActive(true, false, false, false, true, false);
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand("update students set Id=@Id,Name=@Name,Scholar=@Scholar where Id=@oldId", con);
        cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
        cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
        cmd.Parameters.AddWithValue("@Scholar", CheckBox1.Checked);
        cmd.Parameters.AddWithValue("@oldId", DropDownList1.SelectedValue);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been updated.');</script>");

        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();
            BtnsActive(false, true, false, false, false, false);
            FillList();
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);
        SqlCommand cmd = new SqlCommand("delete from students where Id=@Id", con);
        cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script language='javascript'>alert('Record has been deleted.');</script>");

        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();
            BtnsActive(false, true, false, false, false, false);
            FillList();
        }
    }
}
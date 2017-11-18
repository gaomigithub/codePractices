using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class WebForm1 : System.Web.UI.Page
{
    private string conStr = WebConfigurationManager.ConnectionStrings["StudentConnectionString1"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);
        try
        {
            con.Open();
            Response.Write("<script language='javascript'>alert('Connection is Open');</script>");
        }
        catch (Exception er)
        {
            Response.Write("<script language='javascript'>alert('Connection Problem');</script>");
        }
        finally
        {
            con.Close();
            Response.Write("<script language='javascript'>alert('Connection is Closed');</script>");
        }
    }
}
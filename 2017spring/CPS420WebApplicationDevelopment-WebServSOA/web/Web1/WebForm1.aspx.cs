using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm1 : System.Web.UI.Page
{
    
    List<Books> books1;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnBooks_Click(object sender, EventArgs e)
    {
        books1 = Books.GetBooks();
        var booktitles = from b in books1 select b.Title;
        foreach (var title in booktitles)
            lblbooks.Text += String.Format("{0} <br />", title);
    }
}
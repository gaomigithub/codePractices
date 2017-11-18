using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Books> books1 = Books.GetBooks();
        IEnumerable<Books> result = from b in books1 select b;
        lstBooks.DataSource = result;
        lstBooks.DataBind();
    }
}
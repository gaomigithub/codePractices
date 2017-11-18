using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm2 : System.Web.UI.Page
{
    IEnumerable<Books> books;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnJoin_Click(object sender, EventArgs e)
    {
        books = Books.GetBooks();
        IEnumerable<Salesdetails> sales = Salesdetails.getsalesdetails();
        var booktitles = from b in books
                         join s in sales on b.ID equals s.ID
                         select new { Name = b.Title, Pages = s.pages };
        foreach (var title in booktitles)
            lblJoin.Text += String.Format("{0} <br />", title);
    }
}
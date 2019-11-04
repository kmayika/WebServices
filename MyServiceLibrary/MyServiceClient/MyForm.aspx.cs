using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyServiceReference;

public partial class MyForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MyLibraryServiceClient client = new MyLibraryServiceClient("BasicHttpBinding_IMyLibraryService");

        Response.Write(client.Multiply(5, 5));


    }
}
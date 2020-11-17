using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("hello " + Request.QueryString["user"]);
            Session["user"] = Request.QueryString["user"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int inv = Class1.Inventory_return("onion");
            if(Convert.ToInt32(Label1.Text)< inv)
            {
                Label1.Text = (Convert.ToInt32(Label1.Text) + 1).ToString();

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int inv = Class1.Inventory_return("banana");
            if (Convert.ToInt32(Label2.Text) < inv)
            {
                Label2.Text = (Convert.ToInt32(Label2.Text) + 1).ToString();

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int inv = Class1.Inventory_return("potato");
            if (Convert.ToInt32(Label3.Text) < inv)
            {
                Label3.Text = (Convert.ToInt32(Label3.Text) + 1).ToString();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Label1.Text) > 0)
            {
                Label1.Text = (Convert.ToInt32(Label1.Text) - 1).ToString();

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Label2.Text) > 0)
            {
                Label2.Text = (Convert.ToInt32(Label2.Text) - 1).ToString();

            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Label3.Text) > 0)
            {
                Label3.Text = (Convert.ToInt32(Label3.Text) - 1).ToString();

            }

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Class1.Insertval(Session["user"].ToString(), Convert.ToInt32(Label1.Text), Convert.ToInt32(Label2.Text), Convert.ToInt32(Label3.Text));
            //Dictionary<string, int[]> Invoice = Class1.InvoiceGen(Request.QueryString["user"]);
            Response.Redirect("WebForm3.aspx");
        }
    }
}
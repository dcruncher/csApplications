using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dictionary<string, int[]> Invoice = Class1.InvoiceGen(Session["user"].ToString());
            int count = 0,amount=0;
            Response.Write("<table><tr><th>S.No</th><th>Item</th><th>Quantity</th><th>Rate</th><th>Amount</th></tr>");
            foreach(KeyValuePair<string,int[]> item in Invoice)
            {
                if(item.Value[1]!=0)
                {
                    count++;
                    string str= "<tr><td>"+count.ToString() +"</td><td>"+ item.Key.ToString()+"</td><td>"+item.Value[1].ToString()+"</td><td>"+item.Value[0].ToString()  +"</td><td>" +item.Value[2].ToString()+"</td></tr>" ;
                    amount += item.Value[2];
                    Response.Write(str);
                }
            }
            Response.Write("</table>");
            Label1.Text = amount.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = "";
            Response.Redirect("WebForm1.aspx");
        }
    }
}
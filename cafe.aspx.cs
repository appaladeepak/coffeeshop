using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adee
{
    public partial class cafe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-7LNB6MF4\\SQLEXPRESS01;  initial catalog=cafe; persist security info = True; Integrated Security =SSPI ");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into deep values('" + TextBox3.Text + "','" + TextBox4.Text + "', '" + TextBox5.Text + "')", con);
           // SqlCommand cmd=new SqlCommand("insert into order values('" + TextBox3.Text + "','" + TextBox4.Text + "', '" + TextBox5.Text + "')", con);   
            cmd.ExecuteNonQuery();
            Response.Write("order placed");
            con.Close();
            // HttpContext CurrContext = HttpContext.Current;
            //CurrContext.Items.Add("Name", "TextBox3.Text");
            Server.Transfer("~/bill.aspx");

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
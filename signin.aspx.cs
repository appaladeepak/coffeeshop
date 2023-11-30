using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adee
{
    public partial class signin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-7LNB6MF4\\SQLEXPRESS01;  initial catalog=cafe; persist security info = True; Integrated Security =SSPI ");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into details values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
      
            cmd.ExecuteNonQuery();
            Response.Write("welcome");
            con.Close();
            Server.Transfer("cafe.aspx");
        }
    }
}
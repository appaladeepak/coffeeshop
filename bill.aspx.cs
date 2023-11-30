using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace adee
{
    public partial class bill : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Collections.Specialized.NameValueCollection previousFormcollction = Request.Form;
            Label3.Text = previousFormcollction["TextBox3"];
            SqlConnection con = new SqlConnection("data source=LAPTOP-7LNB6MF4\\SQLEXPRESS01;  initial catalog=cafe; persist security info = True; Integrated Security =SSPI ");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from deep where name='" + Label3.Text + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            String st="", st1="",st2="";
            while (dr.Read())
            {
                String st4 = dr.GetString(0);
                String st5 = dr.GetString(1);
                String st6 = dr.GetString(2);

                st = st4;
                st1 = st5;
                st2 = st6;
            }
            dr.Close();
            Response.Write(st);
            con.Close();
            SqlConnection con1 = new SqlConnection("data source=LAPTOP-7LNB6MF4\\SQLEXPRESS01;  initial catalog=cafe; persist security info = True; Integrated Security =SSPI ");
            con1.Open();
            float f = 0, f1 = 0, t = 0;
            // SqlCommand cmd = new SqlCommand("select * from FLIGHT where name = '" + TextBox5.Text + "' ", conn);

            SqlCommand cm = new SqlCommand("Select * from price where item = '"+st1+"'",con1);
            
            SqlDataReader dr1 = cm.ExecuteReader();
            while (dr1.Read())
            {
                f = dr1.GetFloat(1);
            }
            Label5.Text = f.ToString();
            dr1.Close();

            SqlCommand cm1 = new SqlCommand("Select * from price where item = '" + st2 + "'", con1);
            SqlDataReader dr2 = cm1.ExecuteReader();

            DateTime DT = new DateTime(2022,11,29,18,57,58);

            Label10.Text = DT.ToString();
            while (dr2.Read())
            {
                f1 = dr2.GetFloat(1);
            }
            Label7.Text = f1.ToString();
            t = f + f1;
            Label9.Text = t.ToString();
            con1.Close();

                
        }

            
            
        
    }
}
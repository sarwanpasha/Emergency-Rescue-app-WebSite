using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class login : System.Web.UI.Page
{
    String username, password,firstname;
    String NAME;
    string source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Visual Studio 2013 Projects\WebSites\WebSite2\App_Data\Database.mdf;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
 

    }
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        Server.Transfer("Registration.aspx", true);
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        username = tbusername.Text;
        password = tbpassword.Text;


        SqlConnection myConnection = new SqlConnection(source);
        try
        {


            myConnection.Open();
            //  MessageBox.Show("Username = "+username+"\n"+" Password = "+password);
           String Fname = "select FirstName from Pasha where EmailAddress='" + tbusername.Text + "'and Password='" + tbpassword.Text + "'";


            SqlCommand cmd = new SqlCommand("select EmailAddress,Password from Pasha where EmailAddress='" + tbusername.Text + "'and Password='" + tbpassword.Text + "'", myConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (dt.Rows.Count > 0)
            {
             //  NAME = Fname.ExecuteNonQuery();
                NAME = tbusername.Text;
                lbstatus.Text = "Login sucess";
              //  Server.Transfer("Default.aspx", true);
              //  Server.Transfer("Default.aspx" + NAME);
                Session["name"] = tbusername.Text;
                Server.Transfer("Default.aspx", true);

            }
            else
            {
                lbstatus.Text = "Invalid Login please check username and password";
            }

            myConnection.Close();
        }
        catch (SqlException ex)
        {
            lbstatus.Text = "You failed!" + ex.Message;
        }

    }
    protected void tbpassword_TextChanged(object sender, EventArgs e)
    {

    }
}
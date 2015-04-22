using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; 
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Net.Mail; 

public partial class Registration : System.Web.UI.Page
{
    String userName;
    String lastName;
    String password;
    String repeatpassword;
    String email;
    String city;
    bool status = false;
   
    string display = "Pop-up!";
    string source = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Visual Studio 2013 Projects\WebSites\WebSite2\App_Data\Database.mdf;Integrated Security=True";
 
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        CreateUserWizard wizard = (CreateUserWizard)sender;
        MembershipUser user = Membership.GetUser(wizard.UserName);
        if (user != null)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtpServer");
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Send(email, user.Email, "Account Conformation Email","hst/Confirm.aspx?id=" + user.ProviderUserKey.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
            }
        }
    }
    protected void SendMail()
    {
        String fromAddress = "sarwanpasha@gmail.com";
        String toAddress = "sarwanpasha@gmail.com";
        String fromPassword = "incorrect123@";
        String subject = "Account Conformation Email";
        String comments = "Nothing Bro!";
        MembershipUser user = Membership.GetUser("");
        String body = "hst/Confirm.aspx?id=" + "http://localhost:1836/Default.aspx";
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
        smtp.Credentials = new System.Net.NetworkCredential(toAddress, fromPassword);
        smtp.Timeout = 20000;
        smtp.Send(fromAddress, toAddress, subject, body);
    }
 

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Please wait...";
        int id = 1;
        userName = txtName.Value;
        lastName = txtLastName.Value;
        email = txtEmail.Value;
        city = txtCity.Value;
        password = txtPassword.Value;
        repeatpassword = txtRepeatPassword.Value;
        if (userName == String.Empty || lastName == String.Empty || password == String.Empty || repeatpassword == String.Empty || email == String.Empty || city == String.Empty)
        {
            Label1.ForeColor = System.Drawing.Color.Red;////COLOUR
          //  headerr.ForeColor = System.Drawing.Color.Red;////COLOUR
            Label1.Text = "Please Fill All Fields";
        }
        
        else
        {
            if (password != repeatpassword)
            {
                Label1.ForeColor = System.Drawing.Color.Red;////COLOUR
                Label1.Text = "Password Doesnot Match!";
            }

            else
            {
                SqlConnection myConnection = new SqlConnection(source);
                try
                {


                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = ("insert into Pasha values('" + id + "','" + userName + "','" + lastName + "','" + email + "','" + city + "','" + password + "','" + repeatpassword + "','" + status + "');");
                    cmd.Connection = myConnection;
                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                    myConnection.Close();
                    //   MessageBox.Show("Stored Successfully");
                    Label1.ForeColor = System.Drawing.Color.Green;////COLOUR
                    Label1.Text = "Records are Submitted Successfully!"+" \n  Confermation Email has been sended to you!";
                    SendMail();
                    lbemail.Text = "Success Pasha!";
                }
                catch (SqlException ex)
                {
                   // Label1.Text = "Records are Submitted Successfully" + ex.Message;
                    //  MessageBox.Show("You failed!" + ex.Message);
                    Label1.ForeColor = System.Drawing.Color.Red;////COLOUR
                    Label1.Text = "You failed! " + ex.Message;
                }
            }
            // Label1.Text = "Records are Submitted Successfully";
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;  
using System.Net.Mail;
using System.Net;
using System.Activities; 
using System.Data;
using System.IO;
public partial class _Default : System.Web.UI.Page
{
    String toAddress, fromAddress, subject, body, fromPassword, comments,currentLocation;
    bool techstatus = true;
    bool confermation=false;
    int techId =1;
    String contactText = "Contacts:\n\nEmergency Rescue App Contacts:\n\n UET Peshawarr";

    protected void Page_Load(object sender, EventArgs e)
    {
        lbviews.ForeColor = System.Drawing.Color.Green; 
        lbviews.BackColor = System.Drawing.Color.White; 

        lbemail.ForeColor = System.Drawing.Color.Green; 
        lbemail.BackColor = System.Drawing.Color.White; 

        lbcomments.ForeColor = System.Drawing.Color.Green; 
        lbcomments.BackColor = System.Drawing.Color.White;

        LbTech.Font.Size = FontUnit.XLarge; 
        LbPost.Font.Size = FontUnit.XLarge;
        LbArrival.Font.Size = FontUnit.XXLarge;
        LbJoin.Font.Size = FontUnit.XXLarge;
        lbviews.Font.Size = FontUnit.XXLarge;
        lbemail.Font.Size = FontUnit.XLarge;
        lbcomments.Font.Size = FontUnit.XLarge;
        LbLocation.Font.Size = FontUnit.XXLarge;
        LbUet.Font.Size = FontUnit.XXLarge;
        LbNumber.Font.Size = FontUnit.XXLarge;
        LbPurpose.Font.Size = FontUnit.XXLarge;
        LbAbout.Font.Size = FontUnit.XXLarge;
        lblAnything.Font.Size = FontUnit.XLarge;
        Lb1.Font.Size = FontUnit.XLarge;
        Lb2.Font.Size = FontUnit.XLarge;
        Lb3.Font.Size = FontUnit.XLarge;
        Lb4.Font.Size = FontUnit.XLarge;
        Lb5.Font.Size = FontUnit.XLarge;
        Lb6.Font.Size = FontUnit.XLarge;

        btnpost.Font.Size = FontUnit.Medium;
        btnout.Font.Size = FontUnit.Medium;
        Button1.Font.Size = FontUnit.Medium;
        Offers.Font.Size = FontUnit.Medium;
        Button9.Font.Size = FontUnit.Medium;
        Button10.Font.Size = FontUnit.Medium;
        btncontact.Font.Size = FontUnit.Medium;
        btnchat.Font.Size = FontUnit.Medium;
        Button2.Font.Size = FontUnit.Medium;
        btntwitter.Font.Size = FontUnit.Medium;
        btngoogle.Font.Size = FontUnit.Medium;
        Button6.Font.Size = FontUnit.Medium;
        Button7.Font.Size = FontUnit.Medium;
        btnsend.Font.Size = FontUnit.Medium;
        btnLocation.Font.Size = FontUnit.Medium;

        // string NAME = Response.QueryString.GetValue(" NAME ");
        name();
     }
    public void name()
    {
        try
        {
            lbname.ForeColor = System.Drawing.Color.Green;////COLOUR
            lbname.Text = Session["name"].ToString();
            Session.Remove("name");
            Button1.Visible = false;
            btnout.Visible = true;
        }
        catch(Exception ex){
            lbname.Text = "";
        }
    }
    private void btnlogin_Click(object sender, EventArgs e)
    {
       // Response.Redirect("http://www.microsoft.com/gohere/look.htm");
        Server.Transfer("Registration.aspx", true);
    }
  


    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("login.aspx", true);
    }
  
    protected void btnNewTab_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://www.facebook.com/pages/Emergency-Rescue-app/684092021697287?ref=ts&fref=ts");
        
    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        try
        {

            SendMail();
            commentdisplay.Text = "Your Comments after sending the mail";
            commentdisplay.Visible = true;
            subject = "";
            fromemail.Text = "";
            fromcomments.Text = "";
            commentdisplay.ForeColor = System.Drawing.Color.Green;////COLOUR

            commentdisplay.Text = "Message Sended ";
           // abc();
        }
        catch (Exception ex)
        {
            commentdisplay.ForeColor = System.Drawing.Color.Red;////COLOUR
            commentdisplay.Text = "You Failed! "+ex.Message;

        }
    }
    protected void SendMail()
    {
         fromAddress = fromemail.Text.ToString();
         toAddress = "sarwanpasha@gmail.com";
         fromPassword = "incorrect123@";
         subject = "User Views About The Website ";
         comments = fromcomments.Text.ToString();
         body = "From: " + fromAddress + "\n\n"; 
         body += "Subject: " + subject + "\n\n"; 
         body += "Question: \n\n" + comments + "\n"; 
         SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587); 
         smtp.EnableSsl = true;
         smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
         smtp.Credentials = new System.Net.NetworkCredential(toAddress, fromPassword);
         smtp.Timeout = 20000; 
         smtp.Send(fromAddress, toAddress, subject, body);
    }
    public void abc()
    {
                try 
        {
            // Get the current directory. 
            string path = Directory.GetCurrentDirectory();
            string target = @"c:\temp";
           // Console.WriteLine("The current directory is {0}", path);
            Clocation.Text = "The current directory is {0}"+ path;
            if (!Directory.Exists(target)) 
            {
                Directory.CreateDirectory(target);
            }

            // Change the current directory.
            Environment.CurrentDirectory = (target);
            if (path.Equals(Directory.GetCurrentDirectory())) 
            {
              //  Console.WriteLine("You are in the temp directory.");
                Clocation.Text="You are in the temp directory.";
            } 
            else 
            {
               // Console.WriteLine("You are not in the temp directory.");
            Clocation.Text="You are not in the temp directory.";
            }
        } 
        catch (Exception e) 
        {
          //  Console.WriteLine("The process failed: {0}", e.ToString());
         Clocation.Text="The process failed: {0}"+e;
        }
    }


    protected void btnLocation_Click(object sender, EventArgs e)
    {
        Server.Transfer("currentLocation.html", true);

    }

    protected void btntwitter_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://twitter.com/pashapapp");
    }

    protected void btngoogle_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://plus.google.com/u/0/b/105199438247747560056/105199438247747560056/about");

    }
    protected void Offers_Click(object sender, EventArgs e)
    {
        if (PnlMain.Visible == false)
        {
            PnlMain.Visible = true;
            // PnlMain.Controls.Add(contactText);
            PnlMain.Controls.Add(new LiteralControl("Offers"));
        }
        else if (PnlMain.Visible == true)
        {
            PnlMain.Visible = false;
        }
    }
    protected void btnchat_Click(object sender, EventArgs e)
    {
       // Server.Transfer("ChatDefault.aspx", true);
      //  Response.Redirect("http://localhost:1836/ChatDefault.aspx");
        Response.Redirect("ChatDefault.aspx");


    }
    protected void btnout_Click(object sender, EventArgs e)
    {


        Session.Abandon();
        Response.Redirect("Default.aspx");
        lbname.Text = "";
    }
 
    public void technewsBar()
    {
        lblAnything.Text = lblAnything.Text + "    " + ("||") + " : " + tbpost.Text;
        
        tbpost.Text = "";
       // techId = techId + 1;
    }
    protected void btnpost_Click(object sender, EventArgs e)
    {
        technewsBar();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        if (PnlMain.Visible == false)
        {
        PnlMain.Visible = true;
       // PnlMain.Controls.Add(contactText);
      PnlMain.Controls.Add(new LiteralControl(contactText));
       }
       else if(PnlMain.Visible == true){
           PnlMain.Visible = false;
       }
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        if (PnlMain.Visible == false)
        {
            PnlMain.Visible = true;
            // PnlMain.Controls.Add(contactText);
            PnlMain.Controls.Add(new LiteralControl("Blog"));
        }
        else if (PnlMain.Visible == true)
        {
            PnlMain.Visible = false;
        }
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        if (PnlMain.Visible == false)
        {
            PnlMain.Visible = true;
            // PnlMain.Controls.Add(contactText);
            PnlMain.Controls.Add(new LiteralControl("Working"));
        }
        else if (PnlMain.Visible == true)
        {
            PnlMain.Visible = false;
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("https://play.google.com/store?hl=en");
    }
 
}
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SuperJockey
{ 
	public class TheChatScreenWin : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			string sDealer="";
			if (  Session["ChatChannel"] != null )
				sDealer = Session["ChatChannel"].ToString();

			Response.Write( "<meta http-equiv=\"Refresh\"content=\"4\">" );
			Response.Write(PageModule.Chat.GetAllMessages(sDealer));
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{ 
			InitializeComponent();
			base.OnInit(e);
		} 
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}

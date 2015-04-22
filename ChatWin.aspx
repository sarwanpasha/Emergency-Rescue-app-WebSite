<%@ Page language="c#" Codebehind="ChatWin.aspx.cs" AutoEventWireup="false" Inherits="SuperJockey.ChatWin" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>ChatWin</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="assets/formstyle.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout" style="background-image:url('images/image_7.jpg');">
		<form id="Form1" method="post" runat="server" >
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="456" align="center" border="0">
				<TR>
					 
				</TR>
				<TR>
					 
				</TR>
			</TABLE>
			<TABLE id="Table3" cellSpacing="0" cellPadding="1" border="0" align="center"  >
				<TR>
					<TD>
						&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						<iframe style="opacity: 0.5;filter: alpha(opacity=50)"
							src="TheChatScreenWin.aspx" >Chat</iframe>
					</TD>
				</TR>
				<TR>
					<TD align="right">
						Message:
						<asp:TextBox id="TB_ToSend" runat="server" Width="300px" tabIndex="1" Height="24px"  ></asp:TextBox>
						<asp:Button id="BT_Send" runat="server" Text="Send" Width="80px" CssClass="button1" tabIndex="2" BorderStyle="Dotted" ></asp:Button>
					</TD>
				</TR>
			</TABLE>

		</form>
        
	</body>
</HTML>

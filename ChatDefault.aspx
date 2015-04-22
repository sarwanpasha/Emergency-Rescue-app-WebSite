<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChatDefault.aspx.cs" Inherits="ChatDefault" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 476px">
    <form id="form1" runat="server" style="background-image:url('images/image_9.jpg'); height: 744px;">
    <div>
    
        Channel&nbsp;
        <asp:TextBox ID="tbchannel" runat="server"></asp:TextBox>
        <br />
        <br />
        Username&nbsp;
        <asp:TextBox ID="tbusername" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnjoin" runat="server" OnClick="btnjoin_Click" Text="Joinchat" BorderStyle="Dotted" />
    
    </div>
    </form>
</body>
</html>

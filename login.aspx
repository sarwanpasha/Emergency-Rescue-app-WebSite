<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server" style="background-image:url('images/image_7.jpg'); height: 724px;" >
 
    <h1 style="color:brown;"">
        Create Login

    </h1>
        UserName:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbusername" runat="server" ></asp:TextBox >
    <br />
        Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;

        <asp:TextBox ID="tbpassword" runat="server" OnTextChanged="tbpassword_TextChanged"></asp:TextBox>

    <br /> 
        <br />
        </div>
 
        <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
       &nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnsignup" runat="server" Text="Signup" OnClick="btnsignup_Click"   />
 
        <p>
            <asp:Label ID="lbstatus" runat="server"></asp:Label>
        </p>
   
    </form>
</body>
</html>

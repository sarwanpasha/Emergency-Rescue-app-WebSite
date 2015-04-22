<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body >
    <form id="form1" runat="server" style="background-image:url('images/image_8.jpg'); height: 719px;">
 
    <h1 style="color:brown;"">
        Create Login

    </h1>
        First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input type="text" id="txtName" runat="server" value="" />
    <br />
    Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input type="text" id="txtLastName" runat="server" value="" />
            <br />
    Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<input type="text" id="txtEmail" runat="server" value="" />
            <br />
    City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <input type="text" id="txtCity" runat="server" value="" />
            <br />
    Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input type="text" id="txtPassword" runat="server" value="" />
    <br />
    Repeat Password:
    <input type="text" id="txtRepeatPassword" runat="server" value="" />

    <br /> 
        <br />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" BorderStyle="Dotted" />
        </div>
 
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lbemail" runat="server"></asp:Label>
        </p>
   
    </form>
</body>
</html>

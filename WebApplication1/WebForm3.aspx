
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h3>Total Amount :</h3>
            <asp:Label ID="Label1" runat="server" Text="0"></asp:Label><br /><br />
            <asp:label runat="server" text="Thank You for Shopping!"></asp:label><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Signout" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

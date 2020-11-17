<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>PLACE YOUR ORDER</h1><br /> <br />
           
            <table>
                <tr>
                    <th>Item</th>
                    <th>Price</th>
                    <th></th>
                    <th></th>
                    <th>Quantity</th>
                </tr>
                <tr>
                    <td>ONION</td>
                    <td>Rs.35/Kg</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Add Item" OnClick="Button1_Click" /></td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Remove Item" OnClick="Button2_Click" /></td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="0"></asp:Label></td>
                </tr>
                <tr>
                    <td>BANANA</td> 
                    <td>Rs.25/Kg</td>
                    <td>
                        <asp:Button ID="Button3" runat="server" Text="Add Item" OnClick="Button3_Click" /></td>
                    <td>
                        <asp:Button ID="Button4" runat="server" Text="Remove Item" OnClick="Button4_Click" /></td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="0"></asp:Label></td>
                </tr>
                <tr>
                    <td>POTATO</td>
                    <td>Rs.20/Kg</td>
                    <td>
                        <asp:Button ID="Button5" runat="server" Text="Add Item" OnClick="Button5_Click" /></td>
                    <td> <asp:Button ID="Button6" runat="server" Text="Remove Item" OnClick="Button6_Click" /></td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="0"></asp:Label></td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button7" runat="server" Text="generate Invoice" OnClick="Button7_Click" />
        </div>
    </form>
</body>
</html>

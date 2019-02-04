<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter FruitId:
<asp:TextBox ID="txtFruitId" runat="server" />

<asp:Button ID="btnSubmit" OnClick="on_Submit" Text="Submit" runat="server" />
<br />
<br />
<asp:Label ID="lblFruitName" runat="server" />
    </div>
    </form>
</body>
</html>


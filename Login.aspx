<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebFormNovice1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="col-3">
            <label for="<%= txtUserName.ClientID %>" class="form-label">User Name</label>
            <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-3">
            <label for="<%= txtPassword.ClientID %>" class="form-label">Password</label>
            <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button runat="server" ID="btnLodin" CssClass="btn btn-primary" Text="Login" OnClick="btnLodin_Click" />
    </form>
</body>
</html>

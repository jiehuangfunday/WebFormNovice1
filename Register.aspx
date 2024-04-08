<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebFormNovice1.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-3">
        <label for="<%= txtUserName.ClientID %>" class="form-label">User Name</label>
        <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="col-3">
        <label for="<%= txtPassword.ClientID %>" class="form-label">Password</label>
        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password"></asp:TextBox>
    </div>
    <div class="col-3">
        <label for="<%= txtEmail.ClientID %>" class="form-label">Email</label>
        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email"></asp:TextBox>
    </div>
    <asp:Button runat="server" ID="btnRegister" CssClass="btn btn-primary" Text="Register" OnClick="btnRegister_Click" />
</asp:Content>

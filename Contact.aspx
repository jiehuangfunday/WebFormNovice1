<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebFormNovice1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-3">
        <label for="<%= txtUserName.ClientID %>" class="form-label">User Name</label>
        <asp:TextBox runat="server" ID="txtUserName" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="col-3">
        <label for="<%= txtEmail.ClientID %>" class="form-label">Email</label>
        <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" TextMode="Email"></asp:TextBox>
    </div>
    <div class="col-3">
        <label for="<%= txtMsg.ClientID %>" class="form-label">Message</label>
        <asp:TextBox runat="server" ID="txtMsg" CssClass="form-control"></asp:TextBox>
    </div>
    <asp:Button runat="server" ID="btnSend" CssClass="btn btn-primary" Text="Submit" OnClick="btnSend_Click" />
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="WebFormNovice1.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-3">
        <label for="<%= txtName.ClientID %>" class="form-label">Product Name</label>
        <asp:TextBox runat="server" ID="txtName" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="col-3">
        <label for="<%= txtPrice.ClientID %>" class="form-label">Product Price</label>
        <asp:TextBox runat="server" ID="txtPrice" CssClass="form-control"></asp:TextBox>
    </div>
    <div class="col-3">
        <label for="<%= txtDescription.ClientID %>" class="form-label">Description</label>
        <asp:TextBox runat="server" ID="txtDescription" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
    </div>
    <asp:Button runat="server" ID="btnAdd" CssClass="btn btn-primary" Text="Add" OnClick="btnAdd_Click"/>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CssStyle.aspx.cs" Inherits="WebFormNovice1.CssStyle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-12">
        
        <h2>Use bootstrap CssClass text-muted</h2>
        <label>No Use text-muted</label>
        <br />
        <label class="form-text text-muted">Use text-muted</label>
        <br />
        <h2>Use bootstrap CssClass form-control</h2>
        <asp:TextBox runat="server" ID="txt1" Text="No Use form-control" ReadOnly="true"></asp:TextBox>
        <br />
        <asp:TextBox runat="server" ID="txt2" CssClass="form-control" Text="Use form-control" ReadOnly="true"></asp:TextBox>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="WebFormNovice1.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-12">
        <label for="<%= txtMsg.ClientID %>" class="form-label">Message</label>
        <asp:TextBox runat="server" ID="txtMsg" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
    </div>
    <asp:Button runat="server" ID="btnSend" CssClass="btn btn-primary" Text="Submit" OnClick="btnSend_Click" />
</asp:Content>

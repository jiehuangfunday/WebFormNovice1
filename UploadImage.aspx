<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UploadImage.aspx.cs" Inherits="WebFormNovice1.UploadImage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-10 input-group">
        <asp:FileUpload runat="server" ID="fileUpload" class="form-control" accept="image/*" />
        <asp:Button runat="server" ID="btnUpload" CssClass="btn btn-primary" Text="Upload" OnClick="btnUpload_Click" />
    </div>
    <asp:Image runat="server" ID="image" />
</asp:Content>

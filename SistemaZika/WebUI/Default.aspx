<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebUI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Página Principal<br />
    <br />
    Teste de Upload de Arquivo<br />
    <asp:FileUpload ID="fupArquivo" runat="server" />
    <br />
    <br />
    <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
    <br />
    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
&nbsp;
</asp:Content>

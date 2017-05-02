<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroUsuario.aspx.cs" Inherits="WebUI.CadastroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Cadastro Usuário:
</p>
<p>
    Usuário:
    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
</p>
<p>
    Senha:
    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cadastrar" />
</p>
</asp:Content>

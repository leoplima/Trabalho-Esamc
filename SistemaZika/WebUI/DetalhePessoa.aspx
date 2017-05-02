<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalhePessoa.aspx.cs" Inherits="WebUI.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        <strong>Detalhe Pessoa:</strong></p>
    <p>
        Nome:
        <asp:Label ID="lblNome" runat="server"></asp:Label>
    </p>
    <p>
        Email:
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
    </p>
    <p>
        Sexo:
        <asp:Label ID="lblSexo" runat="server"></asp:Label>
    </p>
    <p>
        Estado Civil:
        <asp:Label ID="lblEstCivil" runat="server"></asp:Label>
    </p>
    <p>
        Recebe Email:
        <asp:CheckBox ID="cbRecebeEmail" runat="server" />
    </p>
    <p>
        Recebe SMS:
        <asp:CheckBox ID="cbRecebeSMS" runat="server" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCarro.aspx.cs" Inherits="WebUI.CadastroCarro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastro Carro</h1>

    <br />
    Marca: <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMarca" runat="server" ControlToValidate="txtMarca" ErrorMessage="O campo marca é obrigatório" ForeColor="Red">*</asp:RequiredFieldValidator>
    <br />
    <br />
    Digite um número inteiro:
    <asp:TextBox ID="txtNumeroInteiro" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="cvNumeroInteiro" runat="server" ControlToValidate="txtNumeroInteiro" ErrorMessage="O campo deve ser número inteiro" ForeColor="Red" Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
    <br />
    <br />
    Digite um número inteiro &gt; 12:
    <asp:TextBox ID="txtMaiorQue12" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="vcMaiorQue12" runat="server" ControlToValidate="txtMaiorQue12" ErrorMessage="O campo deve ser inteiro maior que 12" ForeColor="Red" Operator="GreaterThan" Type="Integer" ValueToCompare="12">*</asp:CompareValidator>
    <br />
    <br />
    Data Inicial:
    <asp:TextBox ID="txtDataInicial" runat="server"></asp:TextBox>
&nbsp;Data Final:
    <asp:TextBox ID="txtDataFinal" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="cvData" runat="server" ControlToCompare="txtDataInicial" ControlToValidate="txtDataFinal" ErrorMessage="Data Final deve maior ou igual Data Inicial" ForeColor="Red" Operator="GreaterThanEqual" Type="Date">*</asp:CompareValidator>
    <br />
    <br />
    E-mail:
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail inválido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    <br />
    <br />
    Insira um número inteiro de 1 a 10:
    <asp:TextBox ID="txt1a10" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="rv1a10" runat="server" ControlToValidate="txt1a10" ErrorMessage="O número deve ser inteiro de 1 a 10" ForeColor="Red" MaximumValue="10" MinimumValue="1" Type="Integer">*</asp:RangeValidator>
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <br />
    <br />
    <asp:Button ID="btnInserir" runat="server" Text="Inserir" OnClick="btnInserir_Click" />
    <br />
    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
</asp:Content>

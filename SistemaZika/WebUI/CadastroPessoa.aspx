<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPessoa.aspx.cs" Inherits="WebUI.CadastroPessoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cadastro Pessoa</h1>
    <p>Código:
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigo" Display="Dynamic" ErrorMessage="Código é Obrigatório" ForeColor="Red" ValidationGroup="busca"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="cvCodigo" runat="server" ControlToValidate="txtCodigo" Display="Dynamic" ErrorMessage="Código deve ser numérico" ForeColor="Red" Operator="DataTypeCheck" Type="Integer" ValidationGroup="busca"></asp:CompareValidator>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" ValidationGroup="busca" OnClick="btnBuscar_Click" />
    </p>
    <p>Nome:
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Nome é obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
    </p>
    <p>E-mail:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail é obrigatório" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="E-mail deve ser válido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>Sexo:<asp:RadioButtonList ID="rblSexo" runat="server">
        <asp:ListItem Selected="True">Masculino</asp:ListItem>
        <asp:ListItem>Feminino</asp:ListItem>
        </asp:RadioButtonList>
    </p>
    <p>Estado Civil:
        <asp:DropDownList ID="ddlEC" runat="server">
            <asp:ListItem>Solteiro</asp:ListItem>
            <asp:ListItem>Casado</asp:ListItem>
            <asp:ListItem>Divorciado</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:CheckBox ID="chkRecebeSMS" runat="server" Text="Recebe SMS" />
    </p>
    <p>
        <asp:CheckBox ID="chkRecebeEmail" runat="server" Text="Recebe E-mail" />
    </p>
    <p>
        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />
    &nbsp;&nbsp;&nbsp;<asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar" />
        &nbsp;&nbsp;&nbsp;<asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" CausesValidation="False" OnClick="btnCancelar_Click" Text="Cancelar" />
    </p>
    <p>
        <asp:GridView ID="grvPessoas" runat="server" AutoGenerateColumns="False" DataKeyNames="CdPessoa" OnSelectedIndexChanged="grvPessoas_SelectedIndexChanged" Width="364px">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="CdPessoa" HeaderText="Código" />
                <asp:BoundField DataField="NmPessoa" HeaderText="Nome" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="DetalhePessoa.aspx?codigo=<%#Eval("CdPessoa") %>" />Visualizar Detalhes</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </p>
    
</asp:Content>

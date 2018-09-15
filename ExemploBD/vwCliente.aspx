<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwCliente.aspx.cs" Inherits="ExemploBD.vwCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblId" runat="server" Text="Id: "></asp:Label>
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblCPF" runat="server" Text="CPF: "></asp:Label>
            <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblRG" runat="server" Text="RG: "></asp:Label>
            <asp:TextBox ID="txtRG" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnAdicionar" Text="Adicionar" runat="server" OnClick="btnAdicionar_Click" />
            <asp:Button ID="btnAlterar" Text="Alterar" runat="server" OnClick="btnAlterar_Click" />
            <asp:Button ID="btnDeletar" Text="Deletar" runat="server" OnClick="btnDeletar_Click" />
            <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click"/>
            <br />
            <asp:Label ID="lblResultado" runat="server" Font-Size="X-Large" ForeColor="#009933"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vwCliente.aspx.cs" Inherits="ExemploBD.vwCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Content/bootstrap.css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body style="width: auto; height: 1000px">
    <div class="container-fluid">
        <div class="row justify-content-md-center">
            <div class="col-md-4">
                <form id="form1" runat="server">
                    <div class="form-group row">
                        <label for="inputID" class="col-sm-2 col-form-label">ID</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtId" type="text" class="form-control" placeholder="ID" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="inputNome" class="col-sm-2 col-form-label">Nome</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtNome" type="text" class="form-control" placeholder="Nome" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="inputCPF" class="col-sm-2 col-form-label">CPF</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtCPF" type="text" class="form-control" placeholder="CPF" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="inputRG" class="col-sm-2 col-form-label">RG</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtRG" type="text" class="form-control" placeholder="RG" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="inputEndereco" class="col-sm-2 col-form-label">Endereço</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtEndereco" type="text" class="form-control" placeholder="Endereço" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row justify-content-center">
                        <div class="col-md-3">
                            <asp:Button class="btn btn-primary btn-block" ID="btnAdicionar" Text="Adicionar" runat="server" OnClick="btnAdicionar_Click" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button class="btn btn-success btn-block" ID="btnAlterar" Text="Alterar" runat="server" OnClick="btnAlterar_Click" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button class="btn btn-danger btn-block" ID="btnDeletar" Text="Deletar" runat="server" OnClick="btnDeletar_Click" />
                        </div>
                        <div class="col-md-3">
                            <asp:Button class="btn btn-dark btn-block" ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click" />
                        </div>
                    </div>
                </form>
                <div class="row justify-content-md-center">
                    <div class="col">
                    </div>
                </div>
                <div class="row" style="padding-top:30px;">
                    <div class="col offset-4">
                        <asp:Label class="alert alert-success" role="alert" ID="lblResultado" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

    </div>

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormProdutos.aspx.cs" Inherits="SistemaDeRelatorios.ProdutosView.FormProdutos" %>

<!DOCTYPE html>
<html  lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Cadastro de Produtos </title>
    <link rel="stylesheet" type="text/css" href="../Estilos/CadProdutosEstilos.css"/>
</head>
<body>
    <header> <h3> Wilson's Websystem </h3> </header>
    <form id="formProdutos" runat="server" method="get" >
        <div>
                <h1> Controle de Produtos </h1>
            <p>
                <asp:Label runat="server" ID="lblDescricao" Text="Descricao: " Font-Names="Verdana" ForeColor="White" />
                <asp:TextBox runat="server" ID="txtDescricao" Font-Names="Verdana" Width="200px"  />
            </p>
            <p>
                <asp:Label runat="server" ID="lblValorUnt" Text="Valor Unitario: " Font-Names="Verdana" ForeColor="White" />
                <asp:TextBox runat="server" ID="txtValorUnt" Font-Names="Verdana" Width="170px"/>
            </p>
            <p>
                <asp:Label runat="server" ID="lblCategoria" Text="Categoria: " Font-Names="Verdana" ForeColor="White" />
                <asp:DropDownList runat="server" ID="cmbCategoria" Width="200px"/>
            </p>
                <!-- <p>
                <asp:Label runat="server" ID="Fornecedor" Text="Fornecedor: " Font-Names="Verdana" ForeColor="White" />
                <asp:DropDownList runat="server" ID="cmbFornecedor" Width="190px"/>
                </p> -->
            <p> 
                <asp:Button runat="server" ID="btnInserir" Text="Inserir" Width="100px" OnClick="btnInserir_Click"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" Width="100px" OnClick="btnCancelar_Click"/>
            </p>
            <p>
                <asp:Button runat="server" ID="btnAlterar" Text="Alterar" Width="100px"/>
                <asp:Button runat="server" ID="btnExcluir" Text="Excluir" Width="100px"/>
            </p>
        </div>
    </form>
    <footer> <h4> Copyright 2019 - Vinicius Wilson </h4> </footer>
</body>
</html>

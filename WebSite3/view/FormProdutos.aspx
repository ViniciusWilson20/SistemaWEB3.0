<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormProdutos.aspx.cs" Inherits="WebSite3.view.FormProdutos" %>

<!DOCTYPE html>

<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Produtos</title>
     <style>
        header {
            width: 100%;
            position: fixed;
            top: 0;
            left: 0;
            color:white;
            background: mediumslateblue;
            height: 80px;
            font-family: Verdana;
            font-size: 25px;
            display: inline-block;
        }
        footer {
            width: 100%;
            position: fixed;
            bottom: 0;
            right: 0;
            background: mediumslateblue;
            font-family: Verdana;
            color: white;
            font-size: 15px;
            height: 50px;
            display: inline-block;
        }

        body {
            background-color: slateblue;
            position: absolute;
            text-align: center;
            width: 100%;
            height: 100%;
        }

        form {
          
            background-color: mediumslateblue;
            position: relative;
            display: inline-block;
            text-align: center;
            width: 400px;
            top: 100px;
            color: white;
            font-family: Verdana;
        }
    </style>
</head>
<body>
    <header> <h3> WebSystem 3.0 </h3> </header>
    <form id="formProdutos" runat="server">
        <div>
            <h2> Controle de Produtos </h2>
            <p>
                <asp:Label runat="server" ID="lblDesc" Text="Descrição: " Font-Names="Verdana" ForeColor="White"></asp:Label>
                <asp:TextBox runat="server" ID="txtDescricao" Font-Names="Verdana" Width="200px"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" ID="lblValor" Text="Valor Unitário: " Font-Names="Verdana" ForeColor="White"></asp:Label>
                <asp:TextBox runat="server" ID="txtValor" Font-Names="Verdana" Width="170px"></asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" ID="lblCategoria" Text="Categoria: " Font-Names="Verdana" ForeColor="White"></asp:Label>
                <asp:DropDownList runat="server" ID="cmbCategoria" Font-Names="Verdana" Width="205px"></asp:DropDownList>
            </p>
        </div>
        <div>
            <p> 
                <asp:Button runat="server" ID="btnInserir" Text="Inserir" Font-Names="Verdana" Width="140px" OnClick="btnInserir_Click" />
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" Font-Names="Verdana" Width="140px" OnClick="btnCancelar_Click" />
            </p>
            <p>
                <asp:Button runat="server" ID="btnAlterar" Text="Alterar" Font-Names="Verdana" Width="140px" OnClick="btnAlterar_Click" />
                <asp:Button runat="server" ID="btnExcluir" Text="Excluir" Font-Names="Verdana" Width="140px" OnClick="btnExcluir_Click" />
            </p>
        </div>
    </form>
    <footer><h4>Copyright 2019 - Vinicius Wilson</h4></footer>
</body>
</html>

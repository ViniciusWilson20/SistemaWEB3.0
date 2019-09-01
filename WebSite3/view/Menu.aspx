<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebSite3.view.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" lang="pt-br">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Menu Principal </title>
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
            width: 300px;
            top: 100px;
        }
    </style>
</head>
<body>
    <header> 
           <h3> WebSystem 3.0 </h3>
    </header>
        <form id="Menu" runat="server">
            <p>
                <asp:Label runat="server" ID="lblTitulo" ForeColor="White" Font-Names="Verdana"> </asp:Label>
            </p>
            <p> 
                <asp:Button runat="server" ID="btnProduto" Text="Inserir Produto" Width="130px" Height="40px" OnClick="btnProduto_Click"/>
                <asp:Button runat="server" ID="btnConProduto" Text="Consultar Produtos" Width="130px" Height="40" OnClick="btnConProduto_Click"/>
            </p>
            <p>
                <asp:Button runat="server" ID="btnNewUsr" Text="Novo Usuário" Width="130px" Height="40px" OnClick="btnNewUsr_Click"/>
                <asp:Button runat="server" ID="btnRegistros" Text="Relatórios" Width="130px" Height="40px" OnClick="btnRegistros_Click"/>
            </p>
        </form>
    <footer>
            <h4> Copyright 2019 - Vinicius Wilson </h4>
    </footer>
</body>
</html>

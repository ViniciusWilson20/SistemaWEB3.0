<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMenu.aspx.cs" Inherits="SistemaDeRelatorios.Views.FormMenu" %>

<!DOCTYPE html>
<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="../Estilos/CadProdutosEstilos.css" />  
    <title> Menu Principal </title>
</head>
<body>
    <header> <h3> Wilson's Websystem </h3> </header>
    <form id="formMenu" runat="server">
        <div>
            <p>
                <asp:Label runat="server" ID="lblSaudacoes" Font-Names="Verdana" ForeColor="White" />
            </p>
        </div>
    </form>
    <footer> <h4> Copyright 2019 - Vinicius Wilson </h4> </footer>
</body>
</html>

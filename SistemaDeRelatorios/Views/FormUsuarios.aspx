<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormUsuarios.aspx.cs" Inherits="SistemaDeRelatorios.Views.FormUsuarios" %>

<!DOCTYPE html>

<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Usuários </title>
    <link rel="stylesheet" type="text/css" href="../Estilos/CadProdutosEstilos.css"/>
    <style>
        a {
            color: white;
        }
    </style>
</head>
<body>
    <header> <h3> Wilson's Websystem </h3> </header>
    <form id="formUsuarios" runat="server">
        <div>
           <h2> Novo Usuário </h2>
           <p>
               <asp:Label runat="server" ID="lblNome" Text="Nome: " Font-Names="Verdana" ForeColor="White" />
               <asp:TextBox runat="server" ID="txtNome" Font-Names="Verdana" Width="200px"/>
           </p>
            <p>
                <asp:Label runat="server" ID="lblDataN" Text="Nascimento: " Font-Names="Verdana" ForeColor="White"/>
                <asp:TextBox runat="server" ID="txtData" TextMode="Date" Font-Names="Verdana" Width="155px"/>
            </p>
            <p>
                <asp:Label runat="server" ID="lblEmail" Text="Email: " Font-Names="Verdana" ForeColor="White"/>
                <asp:TextBox runat="server" ID="txtEmail" Font-Names="Verdana" Width="200px"/>
            </p>
            <p>
                <asp:Label runat="server" ID="lblLogin" Text="Login: " Font-Names="Verdana" ForeColor="White"/>
                <asp:TextBox runat="server" ID="txtLogin" Font-Names="Verdana" Width="200px"/>
            </p>
            <p>
                <asp:Label runat="server" ID="lblSenha" Text="Senha: " Font-Names="Verdana" ForeColor="White"/>
                <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" Font-Names="Verdana" Width="195px"/>
            </p>
        </div>
        <div>
            <p>
                <asp:Button runat="server" ID="btnInserir" Text="Inserir" Width="140px" OnClick="btnInserir_Click"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" Width="140px" OnClick="btnCancelar_Click"/>
            </p>
        </div>
        <div>
            <p>
                <a href="FormLogin.aspx"> Retomar à tela de Login </a>
            </p>
        </div>
    </form>
    <footer> <h4> Copyright 2019 - Vinicius Wilson </h4> </footer>
</body>
</html>

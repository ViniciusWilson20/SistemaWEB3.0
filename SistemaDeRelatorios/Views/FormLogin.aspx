<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormLogin.aspx.cs" Inherits="SistemaDeRelatorios.Views.LoginView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Tela de Login</title>
    <link rel="stylesheet" type="text/css" href="../Estilos/CadProdutosEstilos.css" />
    <style>        
        a {
            color: white;
        }
    </style>
</head>
<body>
    <header> <h3> Wilson's Websystem </h3> </header>
    <form id="formLogin" runat="server">
        <div>
            <h2> Login </h2>
            <p>
                <asp:Label runat="server" ID="lblUser" Text="Usuário: " Font-Names="Verdana" ForeColor="White"/>
                <asp:TextBox runat="server" ID="txtUsuario" Font-Names="Verdana" />
            </p>
            <p>
                <asp:Label runat="server" ID="lblSenha" Text="Senha: " Font-Names="Verdana" ForeColor="White" />
                <asp:TextBox runat="server" ID="txtSenha" Text="Password" Font-Names="Verdana" ForeColor="White" />

            </p>
        </div>
        <div>
            <p>
                <asp:Button runat="server" ID="btnEntrar" Text="Entrar" Width="140px" OnClick="btnEntrar_Click"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Sair" Width="140px" OnClick="btnCancelar_Click"/>
            </p>
        </div>
        <div>
            <a href="FormUsuarios.aspx"> ainda não é cadastrado ? </a>
        </div>
    </form>
    <footer> <h4>Copyright 2019 - Vinicius Wilson </h4> </footer>
</body>
</html>

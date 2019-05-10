<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoUsuario.aspx.cs" Inherits="PrimeiroWebSite.WebForm1"%>
<!DOCTYPE html>
<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Usuário </title>
    <style> 
       body{      
            background-color: indigo;
            text-align: center;
            position: absolute;
            width: 100%;
        }

        h1 {
            font-family: Verdana;
            color: white;
            text-align: center;
            font-size: 30px;
            color:white;
        }

        form {
            background-color: darkslateblue;
            text-align: center;
            position: relative;
            display: inline-block;
            border-style: ridge;
            width: 300px;
        }
        a {
            font-family: Arial;
            color: white;
            font-size: 11px;
        }


    </style>
    
</head>
<body>
    <h1> Meu Sistema Web </h1>

    <form id="FormUsuario" runat="server" method="get">
        <h1> Novo Usuario </h1>
        <p>
            <asp:Label ID="lblNome" runat="server" Text="Nome: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lblDataN" runat="server" Text="Data Nasc.: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox ID="dtData" runat="server" TextMode="Date"> </asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lblEmail" runat="server" Text="Email: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"> </asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lblLogin" runat="server" Text="Login: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox ID="txtLogin" runat="server"> </asp:TextBox>
        </p>

        <p>
            <asp:Label ID="lblSenha" runat="server" Text="Senha: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"> </asp:TextBox>
        </p>

        <p>
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
            <asp:Button ID="btnCancelar"  runat="server" Text="Cancelar" OnClick="btnCancelar_Click"/>
        </p>
    </form>
           <p> <a href="UsuarioCrud.aspx"> Clique aqui, se deseja pesquisar ou modificar <br/> um Usuário já Cadastrado </a> </p>
           <p> <a href="DadosdeUsuarios.aspx"> Clique aqui, se deseja acessar <br/> todos os Usuários </a> </p>
</body>
</html>

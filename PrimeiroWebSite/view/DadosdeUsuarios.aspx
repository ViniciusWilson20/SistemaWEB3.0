<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DadosdeUsuarios.aspx.cs" Inherits="PrimeiroWebSite.DadosdeUsuarios" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" lang="pt-br">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dados </title>
    <style>
        body {
            background-color: indigo;
            position: absolute;
            width: 100%;
            font-family: Verdana;
            text-align: center;
            color: white;
        }

        form {
            background-color: darkslateblue;
            text-align: center;
            position: relative;
            display: inline-block;
            border-style: ridge;
            width: 700px;
        }

        a {
            font-family: Arial;
            color: white;
            font-size: 11px;
        }
    </style>
</head>
<body>
    <h1>Lista de Usuários </h1>
    <form id="formDados" runat="server">

        <p>
            <asp:GridView ID="dtDados" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="nomeUsuario" HeaderText="Nome: " />
                    <asp:BoundField DataField="dataNascimento" HeaderText="Data: " />
                    <asp:BoundField DataField="loginUsuario" HeaderText="Login: " />
                    <asp:BoundField DataField="emailUsuario" HeaderText="Email: " />
                </Columns>
            </asp:GridView>
        </p>
    </form>
    <p><a href="NovoUsuario.aspx">Retomar a Página Principal </a></p>
</body>
</html>

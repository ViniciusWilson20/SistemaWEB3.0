
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsuarioCrud.aspx.cs" Inherits="PrimeiroWebSite.view.UsuarioCrud" %>

<!DOCTYPE html>

<html lang="pt-br"  xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Manter Usuario </title>
    <style>
        h1 {

            font-family: Verdana;
            color: white;
            font-size: 25px;
            text-align: center; 
        }
        body {
            background-color: indigo;
            text-align: center;
            position: absolute;
            width: 100%;

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
            font-size: 11px;
            color: white;
        }

    </style>

</head>
<body>
    <form id="UsuarioBusca" runat="server">
    
        <div>
       
            <h1> Busca </h1>
            <p> 
                <asp:Label runat="server" ID="lblCodigo" Text="Codigo" ForeColor="White" Font-Names="Verdana"> </asp:Label>
                <asp:TextBox runat="server" ID="txtCodigo" TextMode="Number"> </asp:TextBox>
            </p>
            <p> 
                 <asp:Button runat="server" ID="btnPesquisar" Text="Pesquisar" Width="100px" OnClick="btnPesquisar_Click" />
            </p>

        </div>

        <div>

            <h1> Dados </h1>
            <p>
                <asp:Label runat="server" ID="lblNome" Text="Nome: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
                <asp:TextBox runat="server" ID="txtNome" Enabled="false"> </asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" ID="lblData" Text="Data Nasc.: " ForeColor="White" Font-Names="Verdana"> </asp:Label> 
                <asp:TextBox runat="server" ID="dtData" Enabled="false"> </asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" ID="lblEmail" Text="Email: " ForeColor="White" Font-Names="Verdana" > </asp:Label>
                <asp:TextBox runat="server" ID="txtEmail" TextMode="Email" Enabled="false"> </asp:TextBox>
            </p>
            <p>
                <asp:Label runat="server" ID="lblLogin" Text="Login: " ForeColor="White" Font-Names="Verdana" > </asp:Label>
                <asp:TextBox runat="server" ID="txtLogin" Enabled="false"> </asp:TextBox>  
            </p>
            <p>
                <asp:Button runat="server" ID="btnEditar" Text="Editar" Width="80px" OnClick="btnEditar_Click" Enabled="false" />
                <asp:Button runat="server" ID="btnRemover" Text="Remover" Width="80px" OnClick="btnRemover_Click" Enabled="false"/>
                <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" Width="80px" OnClick="btnCancelar_Click" />
            
            </p>
        </div>
    </form>

    <p> <a href="NovoUsuario.aspx"> Retomar a Página Principal </a> </p>

</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovoUsuario.aspx.cs" Inherits="WebSite3.view.NovoUsuario" %>

<!DOCTYPE html>

<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Novo Usuario </title>
    <style>
        body {
       
            background-color: slateblue;
            position: absolute;
            text-align: center;
            width: 100%;    
            color: white;
            font-family: Verdana;
        }
        form {
            background-color:mediumslateblue;
            position: relative;
            display: inline-block;
            text-align: center;
            width: 300px;
            border: ridge;
        }
        a {
           font-family: Arial;
           color:white;
           font-size:12px;
        }
    </style>

</head>
<body>
    <h1> WebSystem 3.0 </h1>        
    <form id="FormUserCad" runat="server">
        <h2> Novo Usuario </h2>
        <div>
        <p> 
            <asp:Label runat="server" ID="lblNome" Text="Nome: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox runat="server" ID="txtNome"> </asp:TextBox>
        </p> 
        <p>
            <asp:Label runat="server" ID="lblDataN" Text="Data Nasc.: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox runat="server" ID="dtData" TextMode="Date" Width="125px"> </asp:TextBox>
         </p>
        <p>
            <asp:Label runat="server" ID="lblEmail" Text="Email: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox runat="server" ID="txtEmail"> </asp:TextBox>
        </p>    
        <p>
            <asp:Label runat="server" ID="lblLogin" Text="Login: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox runat="server" ID="txtLogin"> </asp:TextBox> 
        </p>
        <p> 
            <asp:Label runat="server" ID="lblSenha" Text="Senha: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
            <asp:TextBox runat="server" ID="txtSenha" TextMode="Password"> </asp:TextBox>
        </p>
         <p>
             <asp:Button runat="server" ID="btnGravar" Text="Gravar" Width="80px" OnClick="btnGravar_Click"/>
             <asp:Button runat="server" ID="btnCancelar" Text="Cancelar" Width="80px" OnClick="btnCancelar_Click"/>
        </p>
        </div>
    </form>
        <p>  
             <a href="LoginUsuario.aspx"> Retomar a Página Inicial </a>
        </p>
</body>
</html>

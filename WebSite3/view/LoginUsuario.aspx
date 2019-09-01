<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUsuario.aspx.cs" Inherits="WebSite3.view.LoginUsuario" %>

<!DOCTYPE html>

<html lang="pt-br" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title> Acesso do Usuário </title>
         <style>
             body {
                 background-color: slateblue;
                 position: absolute;
                 width: 100%;
                 text-align: center;
                 font-family: Verdana;
                 color: white;
             }

             form {

                 background-color: mediumslateblue;
                 position: relative;
                 display:inline-block;
                 text-align: center;
                 width: 300px;
             }

             a {
                
                 color: white;
                 font-size: 12px;
             }


         </style>
</head>
       
<body>
    <h1> WebSystem 3.0 </h1> 
    <form id="LoginUsuario" runat="server">
        <div>
             <h1> Login </h1>
             <p> 
                 <asp:Label runat="server" ID="lblUsuario" Text="Usuario: " ForeColor="White" Font-Names="Verdana"> </asp:Label>
                 <asp:TextBox runat="server" ID="txtUsuario" Width="140px"> </asp:TextBox>
             </p>
             <p> 
                 <asp:Label runat="server" ID="lblSenha" Text="Senha: " ForeColor="White" Font-Names="Verdana" Width="70"> </asp:Label>
                 <asp:TextBox runat="server" ID="txtSenha" TextMode="Password" Width="140px" ToolTip="Senha"> </asp:TextBox>
             </p>
             <p>
                 
                 <a href=""> Esqueceu a sua Senha? </a> 
             </p>
            <p>
                <asp:Button runat="server" ID="btnEntrar" Text="Entrar" Width="80px" OnClick="btnEntrar_Click"/>
            </p>
        </div>
    </form>
        <p> 
                <a href="NovoUsuario.aspx"> Ainda não possui uma conta? </a> 
        </p>
</body>
</html>

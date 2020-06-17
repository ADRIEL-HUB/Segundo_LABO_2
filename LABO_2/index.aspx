<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LABO_2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h4>Usuario</h4>
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox> 
            <br />
            <h4>Contraseña</h4> 
            <asp:TextBox ID="txtContrasena" TextMode="Password" runat="server"/>
            <br />
            <br />
            <asp:Button ID="btnIngresar" Text="Ingresar" runat="server" OnClick="btnIngresar_Click"/> 


            
            

        </div>
    </form>
</body>
</html>

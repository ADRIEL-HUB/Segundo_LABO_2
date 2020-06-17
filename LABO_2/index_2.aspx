<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index_2.aspx.cs" Inherits="LABO_2.index_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h4>Adriel Calderon Acuña</h4> 
            <asp:TextBox ID="txtPrimerNumero" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID=btnCalcular Text="Calcular" runat="server" OnClick="btnCalcular_Click"/>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
            

        </div>
    </form>
</body>
</html>

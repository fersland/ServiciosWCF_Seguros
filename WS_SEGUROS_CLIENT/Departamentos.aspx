<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Departamentos.aspx.cs" Inherits="WS_SEGUROS_CLIENT.Departamentos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <table class="table">
                <tr>
                    <td>NOMBRE</td>
                    <td>
                        <asp:TextBox ID="txtnombre" runat="server" Text='<% #Eval("Nombre") %>'></asp:TextBox></td>
                </tr>
                <tr><td>
                    <asp:Button ID="bttsave" runat="server" Text="Guardar" OnClick="bttsave_Click" /></td></tr>
            </table>

            <table class="table table-striped">
                <asp:GridView ID="dglista" runat="server"></asp:GridView>
            </table>

            <p>
                <asp:Label ID="lblstatus" runat="server"></asp:Label></p>
        </div>
    </form>
</body>
</html>

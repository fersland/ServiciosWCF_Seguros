<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WS_SEGUROS_CLIENT.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <!-- Bootstrap CSS -->
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Bootstrap JS and dependencies -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Clientes</h1>
            <table class="table">
                        <tr>
                            <td>CEDULA</td>
                            <td><asp:TextBox ID="txtcedula" runat="server" Text='<% #Eval("Cedula") %>'></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>NOMBRE</td>
                            <td><asp:TextBox ID="txtnombre" runat="server" Text='<% #Eval("Nombre") %>'></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>TELEFONO</td>
                            <td><asp:TextBox ID="txttelefono" runat="server" Text='<% #Eval("Telefono") %>'></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td>EDAD</td>
                            <td><asp:TextBox ID="txtedad" runat="server" Text='<% #Eval("Edad") %>'></asp:TextBox></td>
                        </tr>

                        <tr>
                            <td></td>
                            <td class="style">
                                <asp:Button ID="btnsave" runat="server" Text="Guardar" OnClick="btnsave_Click" />
                                <asp:Button ID="btncancel" runat="server" Text="Cancelar" OnClick="btncancel_Click" />
                            </td>
                        </tr>

                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lblstatus" runat="server"></asp:Label>
                            </td>
                        </tr>
                        
                    </table>

                    <asp:GridView ID="grilla" runat="server" CssClass="table table-striped table-bordered"></asp:GridView>
  
            </div>
        
    </form>
</body>
</html>

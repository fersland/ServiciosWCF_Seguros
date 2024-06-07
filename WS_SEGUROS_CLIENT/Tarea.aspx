<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tarea.aspx.cs" Inherits="WS_SEGUROS_CLIENT.Tarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
<!-- Bootstrap JS and dependencies -->
<script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container ">
            <h1>Tareas</h1>

            <button class="btn btn-info" type="button" data-toggle="modal" data-target="#myModal">Nuevo</button>

            <div class="modal" id="myModal">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h4 class="modal-title">Nuevo Registro</h4>
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                        </div>

                        <div class="modal-body">
                            <table class="table table-striped table-hover" >
                                <thead>
                                    <tr>
                                        <td>TITULO</td>
                                        <td><asp:TextBox ID="txttitulo" runat="server" Text='<% #Eval("Titulo") %>'></asp:TextBox></td></tr>
                                        <tr><td>DESCRIPCION</td>
                                        <td><asp:TextBox ID="txtdescripcion" runat="server" Text='<% #Eval("Descripcion") %>'></asp:TextBox></td></tr>
                                        <tr><td>FECHA VENCIMIENTO</td>
                                        <td><asp:TextBox ID="txtfechavencimiento" runat="server" TextMode="Date" Text='<%#Eval("FechaVencimiento") %>'></asp:TextBox></td></tr>
                                        <tr><td>COMPLEATADA</td>
                                        <td><asp:TextBox ID="txtcompletada" runat="server" Text='<%#Eval("Completada") %>'></asp:TextBox></td></tr>
                                </thead>

                                
                            </table>
                        </div>

                        <div class="modal-footer">
                            <asp:Button ID="bttGuardar" CssClass="btn btn-success" runat="server" Text="Guardar" OnClick="bttGuardar_Click" />
                            <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                        </div>


                    </div>
                </div>
            </div> <!-- FIN MODAL -->

            <p id="statusMessage" display="none">
                <asp:Label ID="lblstatus" runat="server" Text="Label"></asp:Label>
            </p>

            <div class="row">           
                <table class="table table-striped table-hover">
                    <asp:GridView ID="dgTareas" runat="server"></asp:GridView>
                </table>
            </div>
        </div>
    </form>
</body>
</html>

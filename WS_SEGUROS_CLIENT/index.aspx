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

    <form id="form1" runat="server" onsubmit="return validarFormulario()">
        <div class="container">
            <h1>Clientes</h1>
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
                Añadir Cliente
            </button>

            <!-- Modal para el formulario de registro -->
            <div class="modal" id="myModal">
                <div class="modal-dialog">
                    <div class="modal-content">

                        <!-- Modal Header -->
                        <div class="modal-header">
                            <h4 class="modal-title">Registro de Cliente</h4>
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                        </div>

                        <!-- Modal Body -->
                        <div class="modal-body">
                            <table class="table">
                                <tr>
                                    <td>CEDULA</td>
                                    <td><asp:TextBox ID="txtcedula" MinLength="10" MaxLength="10" runat="server" oninput="validarInputNumerico(this)" Text='<% #Eval("Cedula") %>'></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td>NOMBRE</td>
                                    <td><asp:TextBox ID="txtnombre" onkeypress="return soloLetras(event)" runat="server" Text='<% #Eval("Nombre") %>'></asp:TextBox></td>
                                </tr>

                                <tr>
                                    <td>TELEFONO</td>
                                    <td><asp:TextBox ID="txttelefono" MinLength="10" MaxLength="10" oninput="validarInputNumerico(this)" runat="server" Text='<% #Eval("Telefono") %>'></asp:TextBox></td>
                                </tr>

                                <tr>
                                    <td>EDAD</td>
                                    <td><asp:TextBox ID="txtedad" oninput="validarInputNumerico(this)" MinLength="1" MaxLength="3" runat="server" Text='<% #Eval("Edad") %>'></asp:TextBox></td>
                                </tr>
                            </table>
                        </div>

                        <!-- Modal Footer -->
                        <div class="modal-footer">
                            <asp:Button ID="btnsave" class="btn btn-primary" runat="server" Text="Guardar" OnClick="btnsave_Click" />
                        
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                        </div>

                    </div>
                </div>
            </div>
            
                <tr>
                    <td colspan="2" id="statusMessage" style="display: none;">
                        <asp:Label ID="lblstatus" runat="server"></asp:Label>
                    </td>
                </tr>

            <table class="table table-hover table-striped">
                <!-- Aquí va tu tabla que muestra la lista de clientes -->
                <asp:GridView ID="grilla" runat="server"  CssClass="table table-striped table-bordered"></asp:GridView>
            </table>
                    
  7
            </div>
        
    </form>
</body>
</html>

<script>

    // JavaScript para cambiar el texto del botón en función del modo (Guardar o Actualizar)
    $(document).ready(function () {
        $('#myModal').on('show.bs.modal', function (e) {
            var mode = $(e.relatedTarget).data('mode');
            if (mode == 'edit') {
                $('#btnSubmit').text('Actualizar');
            } else {
                $('#btnSubmit').text('Guardar');
            }
        });
    });

    function soloLetras(e) {
        // Obtener el evento de la tecla presionada
        var key = e.keyCode || e.which;

        // Permitir teclas de control como Enter y Backspace
        if (key == 8 || key == 13 || key == 32) {
            return true;
        }

        // Convertir el código de la tecla en un carácter
        var char = String.fromCharCode(key);

        // Validar que solo sean letras (mayúsculas y minúsculas)
        var pattern = /^[A-Za-z\s]+$/;
        if (!pattern.test(char)) {
            return false;
        }

        return true;
    }

    function validarInputNumerico(input) {
        // Eliminar cualquier carácter no numérico ingresado
        input.value = input.value.replace(/[^0-9]/g, '');
    }

    function validarFormulario() {
        var cedula = document.getElementById("txtcedula").value;
        var nombre = document.getElementById("txtnombre").value;
        var telefono = document.getElementById("txttelefono").value;
        var edad = document.getElementById("txtedad").value;

        /*if (!cedula || !nombre || !telefono || !edad) {
            alert('Todos los campos son ogligatorios');
            return false;
        }*/

        if (!/^([0-9]{1,10})$/.test(cedula)){
            alert("Ingrese solo numeros para la cedula, maximo 10 caracteres.");
            return false;
        }

        if (!/^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+$/.test(nombre)) {
            alert("Ingrese solo letras para el nombre, sin caracteres especiales.");
            return false;
        }

        if (!/^([0-9]{1,10})$/.test(telefono)) {
            alert("Ingrese solo numeros para la cedula, maximo 10 caracteres.");
            return false;
        }

        if (!/^\d{1,3}$/.test(edad)) {
            alert("Ingrese solo numeros para la edad, hasta 3 cifras.");
            return false;
        }

        return true;
    }



</script>
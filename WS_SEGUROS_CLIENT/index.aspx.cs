using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WS_SEGUROS_CLIENT.ServicioRespuesta;

namespace WS_SEGUROS_CLIENT
{
    public partial class index : System.Web.UI.Page
    {
        ServicioRespuesta.ServiceClienteClient _service = new ServicioRespuesta.ServiceClienteClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                clearInputs();
                //clienteById(null);
                clientesListar();
                btnsave.Text = "Guardar";
            }
        }

        private void clearInputs()
        {
            txtcedula.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txttelefono.Text = string.Empty;
            txtedad.Text = string.Empty;
            btnsave.Text = "Guardar";
        }

        private void clienteById(int? id)
        {
            Cliente cliente = new Cliente();
            DataSet _ds = new DataSet();
            _ds = _service.GetClienteById(cliente);
            grilla.DataSource = _ds;
            grilla.DataBind();
        }

        private void clientesListar()
        {
            DataSet _ds = new DataSet();
            _ds = _service.GetClientes();
            grilla.DataSource = _ds;
            grilla.DataBind();
        }

        private void SaveClientes()
        {
            Cliente cliente = new Cliente();

            // Usar las propiedades en lugar de los campos privados
            cliente.Cedula = txtcedula.Text;
            cliente.Nombre = txtnombre.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Edad = Convert.ToInt32(txtedad.Text);

            lblstatus.Text = _service.InsertClientes(cliente);
            clearInputs();
            clientesListar();
            // clienteById(null);
        }

        private void updateClientes()
        {
            Cliente cliente = new Cliente();
            cliente.Id = Convert.ToInt32(ViewState["id"].ToString());
            cliente.Cedula = txtcedula.Text;
            cliente.Nombre = txtnombre.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Edad = Convert.ToInt32(txtedad.Text);
            lblstatus.Text = _service.UpdateClientes(cliente);
            clearInputs();
            clienteById(null);
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (btnsave.Text == "Guardar")
            {
                SaveClientes();
            }
            else
            {
                updateClientes();
            }

        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            clearInputs();
            lblstatus.Text = string.Empty;
        }
    }
}
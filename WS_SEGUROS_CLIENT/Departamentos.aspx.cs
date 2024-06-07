using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WS_SEGUROS_CLIENT.DepartamentosService;

namespace WS_SEGUROS_CLIENT
{
    public partial class Departamentos : System.Web.UI.Page
    {
        DepartamentosService.DepartamentoServiceClient _services = new DepartamentosService.DepartamentoServiceClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarDepartamentos();
                CleanInputs();
            }
        }

        private void ListarDepartamentos()
        {
            DataSet _ds = new DataSet();
            _ds = _services.GetAllDepartamentos();
            dglista.DataSource = _ds;
            dglista.DataBind();
        }

        private void CleanInputs()
        {
            txtnombre.Text = string.Empty;
        }

        private void Guardar()
        {
            Departamento departamento = new Departamento();
            departamento.Nombre = txtnombre.Text;

            if (string.IsNullOrEmpty(departamento.Nombre))
            {
                throw new Exception("Error: Datos invalidos.");
            }

            try
            {
                string mensaje = _services.InsertDepartamento(departamento);
                CleanInputs();
                ListarDepartamentos();

                if(mensaje.Contains("El dato se registro correctamente."))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "registroExitoso", "alert('El departamento fue registrado');", true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "errorRegistro", $"alert('{mensaje}');", true);
                }
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        protected void bttsave_Click(object sender, EventArgs e)
        {
            if(bttsave.Text == "Guardar")
            {
                Guardar();
            }
        }
    }
}
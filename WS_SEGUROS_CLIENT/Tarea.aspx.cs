using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WS_SEGUROS_CLIENT.ServiceTareas;
using static System.Net.Mime.MediaTypeNames;

namespace WS_SEGUROS_CLIENT
{
    public partial class Tarea : System.Web.UI.Page
    {
        ServiceTareas.ServiceTareasClient _services = new ServiceTareas.ServiceTareasClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TareasListar();
                CleanInputs();
            }
        }

        protected void bttGuardar_Click(object sender, EventArgs e)
        {
            if(bttGuardar.Text == "Guardar")
            {
                Save();
            }
        }

        private void TareasListar()
        {
            DataSet _dataSet = new DataSet();
            _dataSet = _services.GetTareas();
            dgTareas.DataSource = _dataSet;
            dgTareas.DataBind();
        }

        private void Save()
        {
            WS_SEGUROS_CLIENT.ServiceTareas.Tarea tarea = new ServiceTareas.Tarea();
            tarea.Titulo = txttitulo.Text;
            tarea.Descripcion = txtdescripcion.Text;
            tarea.FechaVencimiento = Convert.ToDateTime(txtfechavencimiento.Text);
            tarea.Completada = txtcompletada.Text;

            if (string.IsNullOrEmpty(tarea.Titulo) || string.IsNullOrEmpty(tarea.Descripcion) || string.IsNullOrEmpty(tarea.Completada))
            {
                throw new Exception("Error: Datos invalidos.");
            }

            try
            {
                string mensaje = _services.InsertTarea(tarea);
                TareasListar();
                CleanInputs();

            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }

        }

        private void CleanInputs()
        {
            txttitulo.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtfechavencimiento.Text = string.Empty;
            txtcompletada.Text = string.Empty;

        }
    }

    
}
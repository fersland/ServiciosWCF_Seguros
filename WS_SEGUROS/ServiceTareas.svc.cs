using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI;
using System.Xml;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceTareas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceTareas.svc o ServiceTareas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceTareas : IServiceTareas
    {
        SqlConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["dbArgments"].ConnectionString);


        public DataSet GetTareas()
        {
            SqlCommand _command = new SqlCommand("sp_GetAll_Tareas", _db);
            _command.CommandType = CommandType.StoredProcedure;
            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataSet _dataSet = new DataSet();
            _adapter.Fill(_dataSet);
            _command.ExecuteNonQuery();
            _db.Close();
            return _dataSet;
        }
        public DataSet GetByIdTareas(Tarea tarea)
        {
            SqlCommand _command = new SqlCommand("sp_GetById_Tareas", _db);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Id", tarea.Id);

            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataSet _dataSet = new DataSet();
            _adapter.Fill(_dataSet);
            _command.ExecuteNonQuery();
            _db.Close();
            return _dataSet;
        }

        public string InsertTarea(Tarea tarea)
        {
            string status;
            SqlCommand _command = new SqlCommand("sp_Insert_Tareas", _db);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Titulo", tarea.Titulo);
            _command.Parameters.AddWithValue("@Descripcion", tarea.Descripcion);
            _command.Parameters.AddWithValue("@FechaVencimiento", tarea.FechaVencimiento);
            _command.Parameters.AddWithValue("@Completada", tarea.Completada);

            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            int result = _command.ExecuteNonQuery();
            if (result == 1)
            {
                status = "fue registrado correctamente.";

            }
            else
            {
                status = "Error: no se registro, compruebe los datos.";
            }
            _db.Close();
            return status;
        }

        public string UpdateTarea(Tarea tarea)
        {
            string status;
            SqlCommand _command = new SqlCommand("sp_Update_Tareas", _db);
            _command.Parameters.AddWithValue("@Id", tarea.Id);
            _command.Parameters.AddWithValue("@Titulo", tarea.Titulo);
            _command.Parameters.AddWithValue("@Descripcion", tarea.Descripcion);
            _command.Parameters.AddWithValue("@FechaVencimiento", tarea.FechaVencimiento);
            _command.Parameters.AddWithValue("@Completada", tarea.Completada);

            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            int results = _command.ExecuteNonQuery();
            if(results == 1)
            {
                status = tarea.Titulo + ", fue actualizado correctmante.";
            }
            else
            {
                status = "Error: la tarea no se ha actualizado.";
            }

            _db.Close();
            return status;
        }

        public bool DeleteTarea(Tarea tarea)
        {
            SqlCommand _command = new SqlCommand("sp_Delete_Tareas", _db);
            _command.Parameters.AddWithValue("@Id", tarea.Id);
            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            _command.ExecuteNonQuery();
            _db.Close();
            return true;
        }
 
    }
}


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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceCliente" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceCliente.svc o ServiceCliente.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceCliente : IServiceCliente
    {
        SqlConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["dbArgments"].ConnectionString);
                

        public DataSet GetClientes()
        {
            SqlCommand _command = new SqlCommand("SP_CLIENTES_LISTAR", _db);
            _command.CommandType = CommandType.StoredProcedure;
            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds);
            _command.ExecuteNonQuery();
            _db.Close();
            return _ds;
        }

        public DataSet GetClienteById(Cliente cliente)
        {
            SqlCommand _command = new SqlCommand("SP_CLIENTES_ID", _db);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Id", cliente.Id);

            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            SqlDataAdapter _adapter = new SqlDataAdapter(_command);
            DataSet _ds = new DataSet();
            _adapter.Fill(_ds);
            _command.ExecuteNonQuery();
            _db.Close();
            return _ds;
        }

        public string InsertClientes(Cliente cliente)
        {
            string status;
            SqlCommand _command = new SqlCommand("SP_CLIENTES_INSERT", _db);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            _command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            _command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            _command.Parameters.AddWithValue("@Edad", cliente.Edad);

            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            int results = _command.ExecuteNonQuery();
            if(results == 1){
                status = cliente.Nombre + " " + ", fue registrado correctamente.";
            }
            else
            {
                status = " Error: no se ha registrado, compruebe los datos.";
            }

            _db.Close();
            return status;

        }

        public string UpdateClientes(Cliente cliente)
        {
            string status;
            SqlCommand _command = new SqlCommand("SP_CLIENTES_UPDATE", _db);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            _command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            _command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            _command.Parameters.AddWithValue("@Edad", cliente.Edad);

            if (_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            int results = _command.ExecuteNonQuery();
            if (results == 1)
            {
                status = cliente.Nombre + " " + cliente.Telefono + " cliente ha sido registrado correctamente.";
            }
            else
            {
                status = cliente.Nombre + " no se ha registrado, compruebe los datos.";
            }

            _db.Close();
            return status;
        }

        public bool DeleteClientes(Cliente cliente)
        {
            SqlCommand _comamnd = new SqlCommand("SP_CLIENTES_DELETE", _db);
            _comamnd.CommandType = CommandType.StoredProcedure;
            _comamnd.Parameters.AddWithValue("@Id", cliente.Id);

            if (_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            _comamnd.ExecuteNonQuery();
            _db.Close();
            return true;
        }
    }
}

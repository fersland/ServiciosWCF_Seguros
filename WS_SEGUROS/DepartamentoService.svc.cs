using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "DepartamentoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione DepartamentoService.svc o DepartamentoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class DepartamentoService : IDepartamentoService
    {
        SqlConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["dbArgments"].ConnectionString);
        
        public DataSet GetAllDepartamentos()
        {
            SqlCommand _command = new SqlCommand("sp_GetAll_Departamentos", _db);
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

        public DataSet GetByIdDepartamentos(Departamento departamento)
        {
            throw new NotImplementedException();
        }

        public string InsertDepartamento(Departamento departamento)
        {
            string status;
            SqlCommand _command = new SqlCommand("sp_Insert_Departamentos", _db);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("@Nombre", departamento.Nombre);
            if(_db.State == ConnectionState.Closed)
            {
                _db.Open();
            }

            int result = _command.ExecuteNonQuery();
            if(result == 1)
            {
                status = "El dato se registro correctamente.";
                GetAllDepartamentos();
                
            }
            else
            {
                status = "Error: el dato no se registro, compruebe los datos.";
            }

            _db.Close();
            return status;
        }

        public string UpdateDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }
        public bool DeleteDepartamento(Departamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}

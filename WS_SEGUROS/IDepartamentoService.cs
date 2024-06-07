using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IDepartamentoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IDepartamentoService
    {
        [OperationContract]
        DataSet GetAllDepartamentos();
        [OperationContract]
        DataSet GetByIdDepartamentos(Departamento departamento);
        [OperationContract]
        string InsertDepartamento(Departamento departamento);
        [OperationContract]
        string UpdateDepartamento(Departamento departamento);
        [OperationContract]
        bool DeleteDepartamento(Departamento departamento);
    }

    [DataContract]
    public class Departamento
    {
        private int? _id;
        [DataMember]
        public int? Id
        {
            get{ return _id; }
            set { _id = value; }
        }

        private string _nombre;
        [DataMember]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceCliente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceCliente
    {
        [OperationContract]
        DataSet GetClientes();

        [OperationContract]
        DataSet GetClienteById(Cliente cliente);
        [OperationContract]
        string InsertClientes(Cliente cliente);
        [OperationContract]
        string UpdateClientes(Cliente cliente);
        [OperationContract]
        bool DeleteClientes(Cliente cliente);
    }

    [DataContract]
    public class Cliente
    {        
        private int? _id;
        [DataMember]
        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _cedula;
        [DataMember]
        public string Cedula
        {
            get { return _cedula; }
            set { _cedula = value; }
        }
        
        private string _nombre;
        [DataMember]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
                
        private string _telefono;
        [DataMember]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        
        private int _edad;
        [DataMember]
        public int Edad
        {
            get { return _edad;}
            set {  _edad = value; }
        }
    }
}

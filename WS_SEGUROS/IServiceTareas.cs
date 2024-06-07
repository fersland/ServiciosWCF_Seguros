using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceTareas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceTareas
    {
        [OperationContract]
        DataSet GetTareas();

        [OperationContract]
        DataSet GetByIdTareas(Tarea tarea);
        [OperationContract]
        string InsertTarea(Tarea tarea);
        [OperationContract]
        string UpdateTarea(Tarea tarea);
        [OperationContract]
        bool DeleteTarea(Tarea tarea);
    }

    [DataContract]
    public class Tarea
    {
        private int? _id;
        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _titulo;
        [DataMember]
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private string _descripcion;
        [DataMember]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private DateTime _fechaVencimiento;
        [DataMember]
        public DateTime FechaVencimiento
        {
            get { return _fechaVencimiento; }
            set { _fechaVencimiento = value; }
        }

        private string _completada;
        [DataMember]
        public string Completada
        {
            get { return _completada; }
            set { _completada = value; }
        }

    }
}

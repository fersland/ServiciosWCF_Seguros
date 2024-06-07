using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductoService
    {
        [OperationContract]
        DataSet GetProductos();

        [OperationContract]
        DataSet GetByIdProductos(Producto producto);
        [OperationContract]
        string InsertProductos(Producto producto);
        [OperationContract]
        string UpdateProductos(Producto producto);
        [OperationContract]
        bool DeleteProductos(Producto producto);
    }

    [DataContract]
    public class Producto
    {
        private int? _id;
        [DataMember]
        public int? Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _codigo;
        [DataMember]
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        private string _descripcion;
        [DataMember]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private decimal _precio;
        [DataMember]
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _stock;
        [DataMember]
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
    }
}
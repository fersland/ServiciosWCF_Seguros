using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WS_SEGUROS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProductoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProductoService.svc o ProductoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProductoService : IProductoService
    {
        public bool DeleteProductos(Producto producto)
        {
            throw new NotImplementedException();
        }

        public DataSet GetByIdProductos(Producto producto)
        {
            throw new NotImplementedException();
        }

        public DataSet GetProductos()
        {
            throw new NotImplementedException();
        }

        public string InsertProductos(Producto producto)
        {
            throw new NotImplementedException();
        }

        public string UpdateProductos(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}

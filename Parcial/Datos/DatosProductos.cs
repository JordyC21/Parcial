using System;
using Entidades;

namespace Datos
{
    public class DatosProductos
    {
        //Estos objetos simularan nuestra base de datos
        //Tenemos una tiendita con 5 productos y
        //cada producto tiene su id, nombre, precio, marca y existencias
        EntidadProducto producto1 = new EntidadProducto(1, "Café instantáneo", "", 500, 60);
        EntidadProducto producto2 = new EntidadProducto(2, "Café instantáneo", "", 500, 60);
        EntidadProducto producto3 = new EntidadProducto(3, "Café instantáneo", "", 500, 60);
        EntidadProducto producto4 = new EntidadProducto(4, "Café instantáneo", "", 500, 60);


        public EntidadProducto buscarProductoPorID(EntidadProducto producto) {

            //Este metodo nos devolverá los datos completos del producto
            //Para saber que producto devolver debemos obtener el id del producto
            //Dependiendo de ese id, así devolveremos el producto correspondiente
            if (producto.Id == 1)
            {
                producto = producto1;

                return producto;
            }
            else if (producto.Id == 2)
            {
                producto = producto2;

                return producto;
            }
            else if (producto.Id == 3)
            {
                producto = producto3;

                return producto;
            }
            else if (producto.Id == 4)
            {
                producto = producto4;

                return producto;
            }

            
            else
            {
                return null;
            }
        }

        //Para vender productos, solo necesitamos el producto a vender
        //asi como la cantidaque venderemos
        public EntidadProducto venderProducto(EntidadProducto producto, int cantidad) {
            //Para simular la venta, solo restaremos la cantidad vendida a las existencias
            //de nuestro producto
            producto.Cobro = (producto.Preciodelproducto * cantidad).ToString("00.00");

            return producto;
        }
    }
}

using System;
using Entidades;

namespace Datos
{
    public class DatosProductos
    {

        EntidadProducto producto1 = new EntidadProducto(1, "Café instantáneo", "", 500, 60);
        EntidadProducto producto2 = new EntidadProducto(2, "Café instantáneo", "", 500, 60);
        EntidadProducto producto3 = new EntidadProducto(3, "Café instantáneo", "", 500, 60);
        EntidadProducto producto4 = new EntidadProducto(4, "Café instantáneo", "", 500, 60);


        public EntidadProducto buscarProductoPorID(EntidadProducto producto) {


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


        public EntidadProducto venderProducto(EntidadProducto producto, int cantidad) {
 
            producto.Cobro = (producto.Preciodelproducto * cantidad).ToString("00.00");

            return producto;
        }
    }
}

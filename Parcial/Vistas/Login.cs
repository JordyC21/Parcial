using System;
using Entidades;
using Negocios;

namespace Vistas
{
    class Login
    {
        static void Main(string[] args)
        {
            EntidadUsuario usuario = new EntidadUsuario();
            NegociosUsuarios negocio = new NegociosUsuarios();


            Console.WriteLine("TIENDITA" +
                "\n\nPara Iniciar Sesión, por favor ingresa tú nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ahora ingresa la contraseña: ");
            usuario.Contraseña = Console.ReadLine();

            usuario = negocio.negocioIniciarSesion(usuario);

            if (usuario == null)
            {
                Console.WriteLine(":(");
                Environment.Exit(1);
            }
            else
            {

                Console.WriteLine("Bienvenido " + usuario.Nombre + "!" );

                Console.WriteLine("¿Qué producto desea comprar?" +
                "\n1 - usb de 256 gb" +
                "\n2 - SSD de 500 GB" +
                "\n3 - Tarjeta Grafica.");
            }
        }
    }
}


using System;
using Entidades;
using Datos;

namespace Negocios
{
    public class NegociosUsuarios
    {
        DatosUsuarios datos = new DatosUsuarios();

        public EntidadUsuario negocioIniciarSesion(EntidadUsuario usuario)
        {

            if (usuario.Nombre == "" || usuario.Contraseña == "")
            {
                Console.WriteLine("Debe ingresar un nombre y/o una contraseña!");
                return null;
            }
            else
            {

                usuario = datos.IniciarSesion(usuario);


                if (usuario == null)
                {
                    Console.WriteLine("NOMBRE DE USUARIO INCORRECTO");
                    return null;
                }
                else
                {
                    Console.WriteLine("INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA");
                    return usuario;
                }
            }
        }
    }
}

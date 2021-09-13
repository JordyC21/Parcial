using System;
using Entidades;

namespace Datos
{
    public class DatosUsuarios
    {
        EntidadUsuario Usuario = new EntidadUsuario("Jordy", "123"); 

        public EntidadUsuario IniciarSesion(EntidadUsuario usuario)
        {


            if (usuario.Nombre == Usuario.Nombre && usuario.Contraseña == Usuario.Contraseña)
            {            
                return usuario;
            }

            else
                return null;
        }

    }
}

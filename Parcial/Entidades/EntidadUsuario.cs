using System;

namespace Entidades
{
    public class EntidadUsuario
    {
        private string nombre;
        private string contraseña;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }


        public EntidadUsuario() { }

        public EntidadUsuario(string nombre, string contraseña) 
        {
            this.nombre = nombre;
            this.contraseña = contraseña;

        }
        
    }
}


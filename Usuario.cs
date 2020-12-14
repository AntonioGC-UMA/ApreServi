using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    class Usuario
    {
        static Usuario instance;

        public string usuario { get; set;}
        public string nombre { get; set;}
        public string apellido { get; set;}
        public string contraseña { get; set;}
        public string correo { get; set;}
        public Rol rol { get; set;}

        private Usuario()
        {

        }

        public static void cerrarSesion()
        {
            instance.usuario = null;
            instance.nombre = null;
            instance.apellido = null;
            instance.correo = null;
            instance.contraseña = null;
            instance.rol = null;

            instance = null;
        }

        public static Usuario getInstance()
        {
            if(instance == null)
            {
                instance = new Usuario();
            }

            return instance;
        }

        public static bool hasInstance()
        {
            return instance != null;
        } 
    }
}

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
        //string rol { get; set;}

        private Usuario()
        {

        }

        public static Usuario getInstance()
        {
            if(instance == null)
            {
                instance = new Usuario();
            }

            return instance;
        }
    }
}

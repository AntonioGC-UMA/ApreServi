using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    class PersonaBD
    {
        public string usuario { get; private set; }
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public string contraseña { get; private set; }
        public string correo { get; private set; }
        public bool admin { get; private set; }

        public PersonaBD(string usuario, string correo, string contraseña, string nombre, string apellidos, bool admin)
        {
            this.usuario = usuario; this.nombre = nombre; this.apellido = apellidos; this.contraseña = contraseña; this.admin = admin; this.correo = correo;
        }

        public override string ToString()
        {
            return usuario;
        }
    }
}

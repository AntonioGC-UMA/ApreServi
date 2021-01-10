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

        public static List<(DateTime dia, string descripcion)> get_eventos()
        {
            List<(DateTime dia, string descripcion)> res = new List<(DateTime dia, string descripcion)>();

            foreach (var elem in BD.Select("select * from Actividad a join Inscripcion i on a.id = i.idActividad where i.nombreUsuario = '" + Usuario.getInstance().usuario + "';"))
            {
                res.Add(((DateTime)elem[3], "Comienza la actividad: " + (string)elem[1]));
                res.Add(((DateTime)elem[4], "Termina la actividad: " + (string)elem[1]));
            }
            foreach (var elem in BD.Select("select * from Curso c join Matricula m on c.id = m.idCurso where m.nombreUsuario = '" + Usuario.getInstance().usuario + "';"))
            {
                res.Add(((DateTime)elem[3], "Comienza el curso: " + (string)elem[1]));
                res.Add(((DateTime)elem[4], "Termina el curso: " + (string)elem[1]));
            }

            return res;
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

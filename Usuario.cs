﻿using System;
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
        public bool admin { get; set;}

        private Usuario()
        {

        }

        public static List<(DateTime dia, string descripcion)> get_eventos()
        {
            if (instance == null) return new List<(DateTime dia, string descripcion)>();

            List<(DateTime dia, string descripcion)> res;

            if (Usuario.getInstance().admin)
            {
                res = new List<(DateTime dia, string descripcion)>();

                foreach (var elem in BD.Select("select * from Actividad;"))
                {
                    res.Add(((DateTime)elem[3], "Comienza la actividad: " + (string)elem[1]));
                    res.Add(((DateTime)elem[4], "Termina la actividad: " + (string)elem[1]));
                }
                foreach (var elem in BD.Select("select * from Curso;"))
                {
                    res.Add(((DateTime)elem[3], "Comienza el curso: " + (string)elem[1]));
                    res.Add(((DateTime)elem[4], "Termina el curso: " + (string)elem[1]));
                }
            }
            else
            {
                res = new List<(DateTime dia, string descripcion)>();
                string nombre = Usuario.getInstance().usuario;

                foreach (var elem in BD.Select("select * from Actividad a WHERE a.id IN (SELECT idActividad from Inscripcion WHERE nombreUsuario = '" + nombre + "') OR a.propietario = '" + nombre + "';"))
                {
                    res.Add(((DateTime)elem[3], "Comienza la actividad: " + (string)elem[1]));
                    res.Add(((DateTime)elem[4], "Termina la actividad: " + (string)elem[1]));
                }
                foreach (var elem in BD.Select("select * from Curso c WHERE c.id IN (SELECT idCurso from Matricula WHERE nombreUsuario = '" + nombre + "') OR c.propietario = '" + nombre + "';"))
                {
                    res.Add(((DateTime)elem[3], "Comienza el curso: " + (string)elem[1]));
                    res.Add(((DateTime)elem[4], "Termina el curso: " + (string)elem[1]));
                }
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
            instance.admin = false;

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

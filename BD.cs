using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    class BD
    {
        static MySqlConnection connection;

        public static MySqlConnection GetConnection(){
            if(connection == null)
            {
                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                connection = new MySqlConnection(MyConString);
            }
            return connection;
        }

        public static void Insert(Object obj)
        {
            if (connection == null)
            {
                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                connection = new MySqlConnection(MyConString);
            }
            connection.Open();

            string sql = "";

            switch(obj)
            {
                case CursoBD c:
                    {
                        sql = String.Format("insert into Curso (nombre,descripcion,fechaInicio,fechaFin) values ('{0}','{1}','{2}','{3}')", c.nombre, c.descripcion, c.fecha_inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"), c.fecha_fin.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    }break;
                case ForoBD f:
                    {
                        if (f.idCurso == 0 && f.idActividad == 0)
                        {
                            sql = String.Format("insert into Foro (nombre, descripcion, categoria) values ('{0}','{1}','{2}')", f.nombre, f.descripcion, f.categoria);
                        }
                        else if (f.idActividad == 0)
                        {
                            sql = String.Format("insert into Foro (nombre, descripcion, categoria, idCurso) values ('{0}','{1}','{2}', {3})", f.nombre, f.descripcion, f.categoria, f.idCurso);
                        }
                        else
                        {
                            sql = String.Format("insert into Foro (nombre, descripcion, categoria, idActividad) values ('{0}','{1}','{2}', {3})", f.nombre, f.descripcion, f.categoria, f.idActividad);
                        }
                    } break;
                case ActividadBD a:
                    {

                        sql = String.Format("insert into Actividad (nombre,descripcion,fechaInicio,fechaFin) values ('{0}','{1}','{2}','{3}')", a.nombre, a.descripcion, a.fecha_inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"), a.fecha_fin.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    } break;
                case Usuario u:
                    {
                        sql = String.Format("insert into Usuario values ('{0}','{1}','{2}','{3}','{4}', 'usuario')", u.usuario, u.correo, u.contraseña, u.nombre, u.apellido);
                    } break;
                default: throw new Exception("No sabemos como insertar esta clase en la base de datos");
            }

            
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

    }
}

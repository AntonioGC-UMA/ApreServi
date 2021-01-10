using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    class BD
    {
        static MySqlConnection connection;

        public static void EnsureConection()
        {
            if (connection == null)
            {
                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                connection = new MySqlConnection(MyConString);
            }
        }

        public static MySqlConnection GetConnection(){
            if(connection == null)
            {
                string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
                connection = new MySqlConnection(MyConString);
            }
            return connection;
        }


        public static void Insert(string sql)
        {
            EnsureConection();
            connection.Open();
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }


        public static void Insert(Object obj)
        {
            EnsureConection();
            connection.Open();

            string sql = "";

            switch(obj)
            {
                case CursoBD c:
                    {
                        sql = String.Format("insert into Curso (nombre,descripcion,fechaInicio,fechaFin,propietario) values ('{0}','{1}','{2}','{3}', '{4}')", c.nombre, c.descripcion, c.fecha_inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"), c.fecha_fin.ToString("yyyy-MM-dd HH:mm:ss.fff"), c.dueño);
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
                        sql = String.Format("insert into Actividad (nombre,descripcion,fechaInicio,fechaFin, propietario) values ('{0}','{1}','{2}','{3}', '{4}')", a.nombre, a.descripcion, a.fecha_inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"), a.fecha_fin.ToString("yyyy-MM-dd HH:mm:ss.fff"), a.dueño);
                    } break;
                case Usuario u:
                    {
                        sql = String.Format("insert into Usuario values ('{0}','{1}','{2}','{3}','{4}', {5})", u.usuario, u.correo, u.contraseña, u.nombre, u.apellido, u.admin ? 1 : 0);
                    } break;
                default: throw new Exception("No sabemos como insertar esta clase en la base de datos");
            }

            
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }


        public static void Delete(string table, int id)
        {
            EnsureConection();
            connection.Open();

            string sql = String.Format("delete from {0} where id = {1}", table, id);
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void Delete(string sql)
        {
            EnsureConection();
            connection.Open();

            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void Update(string sql)
        {
            EnsureConection();
            connection.Open();
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static List<object[]> Select(string sql)
        {
            EnsureConection();
            connection.Open();

            var cmd = new MySqlCommand(sql, connection);
            var reader = cmd.ExecuteReader();

            List<object[]> res = new List<object[]>();

            while (reader.Read())
            {
                int numColumnas = reader.FieldCount;
                object[] fila = new object[numColumnas];
                for (int i = 0; i < numColumnas; ++i) fila[i] = reader[i];
                res.Add(fila);
            }
            

            reader.Close();
            connection.Close();

            return res;
        }
    }
}

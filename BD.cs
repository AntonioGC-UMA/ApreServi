﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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

        public static void Subir(string path, string nombre, int id_curso)
        {
            EnsureConection();
            connection.Open();

            var data = File.ReadAllBytes(path);

            var cmd = new MySqlCommand("", connection);

            cmd.CommandText = String.Format("insert into Archivo values ('{0}', {1}, @data)", nombre, id_curso);
            
            var paramUserImage = new MySqlParameter("@data", MySqlDbType.Blob, data.Length);
            paramUserImage.Value = data;
            cmd.Parameters.Add(paramUserImage);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void Descargar(string path, string nombre, int id_curso)
        {
            if (path == null || path == "") path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var file = Select("select informacion from Archivo where nombre = '" + nombre + "' and idCurso = " + id_curso);

            if (file == null || file.Count == 0) return;

            File.WriteAllBytes(path + "/" + nombre, (byte[])(file[0][0]));
        }


        public static void Insert(string sql)
        {
            EnsureConection();
            connection.Open();
            var cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static byte[] ImageToByteArray(Image theImage)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                theImage.Save(memoryStream, ImageFormat.Png);
                return memoryStream.ToArray();
            }
        }
        public static void Insert(Object obj)
        {
            EnsureConection();
            connection.Open();

            var cmd = new MySqlCommand("", connection);

            switch(obj)
            {

                case CursoBD c:
                    {
                        cmd.CommandText = String.Format("insert into Curso (nombre,descripcion,fechaInicio,fechaFin,propietario) values ('{0}','{1}','{2}','{3}', '{4}')", c.nombre, c.descripcion, c.fecha_inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"), c.fecha_fin.ToString("yyyy-MM-dd HH:mm:ss.fff"), c.dueño);
                    }break;
                case ForoBD f:
                    {
                        if (f.idCurso == 0 && f.idActividad == 0)
                        {
                            cmd.CommandText = String.Format("insert into Foro (nombre, descripcion, categoria) values ('{0}','{1}','{2}')", f.nombre, f.descripcion, f.categoria);
                        }
                        else if (f.idActividad == 0)
                        {
                            cmd.CommandText = String.Format("insert into Foro (nombre, descripcion, categoria, idCurso) values ('{0}','{1}','{2}', {3})", f.nombre, f.descripcion, f.categoria, f.idCurso);
                        }
                        else
                        {
                            cmd.CommandText = String.Format("insert into Foro (nombre, descripcion, categoria, idActividad) values ('{0}','{1}','{2}', {3})", f.nombre, f.descripcion, f.categoria, f.idActividad);
                        }
                    } break;
                case ActividadBD a:
                    {
                        cmd.CommandText = String.Format("insert into Actividad (nombre,descripcion,fechaInicio,fechaFin, propietario) values ('{0}','{1}','{2}','{3}', '{4}')", a.nombre, a.descripcion, a.fecha_inicio.ToString("yyyy-MM-dd HH:mm:ss.fff"), a.fecha_fin.ToString("yyyy-MM-dd HH:mm:ss.fff"), a.dueño);
                    } break;
                case NoticiaBD n:
                    {
                        cmd.CommandText = String.Format("insert into Noticia (titular,cuerpo,imagen,fechaPublicacion, autor) values ('{0}','{1}',@userImage,'{2}', '{3}')", n.titulo, n.cuerpo, n.fecha.ToString("yyyy-MM-dd HH:mm:ss.fff"), n.autor);
                        var userImage = ImageToByteArray(n.image);
                        var paramUserImage = new MySqlParameter("@userImage", MySqlDbType.Blob, userImage.Length);
                        paramUserImage.Value = userImage;
                        cmd.Parameters.Add(paramUserImage);
                    }
                    break;
                case TestBD t:
                    {
                        cmd.CommandText = String.Format("INSERT INTO Test (idCurso,nombre) VALUES({0},'{1}');", t.idCurso, t.nombre);                        
                    } break;
                case Usuario u:
                    {
                        cmd.CommandText = String.Format("insert into Usuario values ('{0}','{1}','{2}','{3}','{4}', {5})", u.usuario, u.correo, u.contraseña, u.nombre, u.apellido, u.admin ? 1 : 0);
                    } break;
                default: throw new Exception("No sabemos como insertar esta clase en la base de datos");
            }
                        
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

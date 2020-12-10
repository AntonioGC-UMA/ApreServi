using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;


namespace ApreServi
{
    class Rol
    {
        private string rolName;
        private bool admin;
        //private List<Permiso> permisos;

        /*
        public static List<Rol> ListaRoles()
        {
            List<Rol> lista = new List<Rol>();
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);

            foreach (object[] tupla in miBD.Select("SELECT rolName FROM tRol;"))
            {
                string r = (string)tupla[0];
                lista.Add(new Rol(r));
            }
            return lista;
        }
        */
        public Rol(string name)
        {
            
            string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo04; UID=grupo04; PASSWORD=morillasmanuel2021;";
            MySqlConnection connection = new MySqlConnection(MyConString);

            connection.Open();


            var sql = "SELECT * FROM Rol WHERE nombreRol = '" + name + "';";
            var cmd = new MySqlCommand(sql, connection);

            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            rolName = (string)rdr[0];
            admin = (UInt64)rdr[1] == 1;
        }
/*
        public Rol(string name, string des, bool adm)
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "INSERT INTO tRol VALUES("
                + "'" + name + "',"
                + "'" + des + "',"
                + (adm ? 1 : 0) + ");";

            miBD.Insert(sentencia);
            rolName = name;
            rolDes = des;
            admin = adm;
            permisos = null;
        }

        public string RolName
        {
            get { return rolName; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE tRol SET rolName = '" + value + "' "
                    + "WHERE rolName='" + rolName + "';";
                miBD.Update(sentencia);
                rolName = value;
            }
        }

        public string RolDes
        {
            get { return rolDes; }
            set
            {
                SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
                string sentencia = "UPDATE tRol SET rolDes = '" + value + "' "
                    + "WHERE rolName='" + rolName + "';";
                miBD.Update(sentencia);
                rolDes = value;
            }
        }

        public bool Admin
        {
            get { return admin; }
        }

        public void setAdmin(Rol other, bool value)
        {
            if (!admin) throw new Error("Rol sin permiso para establecer administradores.");
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "UPDATE tRol SET admin = " + (value ? 1 : 0) + " "
                + "WHERE rolName='" + other.RolName + "';";
            miBD.Update(sentencia);
            other.admin = value;

        }

        public bool Acceso(string pantalla)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla)) return p.Acceso;
            }
            return false;
        }

        public void setAcceso(string pantalla, bool value)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla))
                {
                    p.Acceso = value;
                    return;
                }
            }
        }

        public bool Insertar(string pantalla)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla)) return p.Insertar;
            }
            return false;
        }

        public void setInsertar(string pantalla, bool value)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla))
                {
                    p.Insertar = value;
                    return;
                }
            }
        }

        public bool Modificar(string pantalla)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla)) return p.Modificar;
            }
            return false;
        }

        public void setModificar(string pantalla, bool value)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla))
                {
                    p.Modificar = value;
                    return;
                }
            }
        }

        public bool Borrar(string pantalla)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla)) return p.Borrar;
            }
            return false;
        }

        public void setBorrar(string pantalla, bool value)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            foreach (Permiso p in permisos)
            {
                if (p.Pantalla.Equals(pantalla))
                {
                    p.Borrar = value;
                    return;
                }
            }
        }
        public void BorrarRol()
        {
            SQLSERVERDB miBD = new SQLSERVERDB(BD_SERVER, BD_NAME);
            string sentencia = "DELETE FROM tRol "
                + "WHERE rolName='" + rolName + "';";
            miBD.Update(sentencia);

            rolName = null;
            rolDes = null;
            admin = false;
            permisos = null;
        }

        public void AddPermiso(Permiso p)
        {
            if (permisos == null) permisos = Permiso.ListaPermisosRol(this);

            if (!permisos.Contains(p))
            {
                permisos.Add(p);
            }
        }
*/
        public override string ToString()
        {
            return rolName;
        }
        /*
        public override bool Equals(object obj)
        {
            return (obj is Rol) && (rolName.Equals(((Rol)obj).rolName));
        }

        public override int GetHashCode()
        {
            return rolName.GetHashCode();
        }

        */
    }
}

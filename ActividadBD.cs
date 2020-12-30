using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class ActividadBD
    {

        public int id { get; private set; }
        public string nombre { get; private set; }
        public string descripcion { get; private set; }
        public DateTime fecha_inicio { get; private set; }
        public DateTime fecha_fin { get; private set; }

      

        public ActividadBD(int i, string n, string d, DateTime fi, DateTime ff)
        {
            id = i; nombre = n; descripcion = d; fecha_inicio = fi; fecha_fin = ff;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

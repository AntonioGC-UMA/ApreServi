using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class ForoBD
    {

        public int id { get; private set; }
        public string nombre { get; private set; }
        public string descripcion { get; private set; }
        public int idCurso { get; private set; }
        public int idActividad { get; private set; }       
        public int categoria { get; private set; }
        public ForoBD(int i, string n, string d, int c, int ic, int ia)
        {
            id = i; nombre = n; descripcion = d; idCurso = ic; idActividad = ia; categoria = c;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

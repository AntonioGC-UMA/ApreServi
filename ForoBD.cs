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
        //List<string> foros;
        public int idCurso { get; private set; }

        public ForoBD(int i, string n, string d, int ic)
        {
            id = i; nombre = n; descripcion = d; idCurso = ic;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

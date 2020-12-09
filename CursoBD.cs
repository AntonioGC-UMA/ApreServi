using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class CursoBD
    {

        public int id { get; private set; }
        public string nombre { get; private set; }
        public string descripcion { get; private set; }
        //List<string> foros;

        public CursoBD(int i, string n, string d)
        {
            id = i; nombre = n; descripcion = d;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

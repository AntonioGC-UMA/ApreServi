using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class CursoBD
    {
        public int id { get; private set; }
        string nombre;
        string descripcion;
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

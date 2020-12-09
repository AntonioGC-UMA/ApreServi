using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class PostBD
    {

        public int id { get; private set; }
        public string autor { get; private set; }
        public string contenido { get; private set; }
        //List<string> foros;

        public PostBD(int i, string a, string c)
        {
            id = i; autor = a; contenido = c;
        }

        public override string ToString()
        {
            return autor + " dice:\n" + contenido;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ApreServi
{
    public class NoticiaBD
    {
        public int id { get; private set; }
        public string cuerpo { get; private set; }
        public string titulo { get; private set; }
        public string autor { get; private set; }
        public Image image { get; private set; }
        public DateTime fecha { get; private set; }

        public NoticiaBD(int i, string  c, string t, string a, Image im, DateTime d)
        {
            id = i; cuerpo = c; titulo = t; autor = a; image = im; fecha = d;
        }
    }
}

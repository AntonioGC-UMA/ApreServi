using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class PreguntaBD
    {
        public int id { get; private set; }
        public int idTest { get; private set; }
        public string enunciado { get; private set; }
        public List<string> opciones { get; private set; }
        public int correcta { get; set; }

        public PreguntaBD(int i, int itest, string e, List<string> o, int c)
        {
            id = i; idTest = itest; enunciado = e; opciones = o; correcta = c;
        }

        public override string ToString()
        {
            return enunciado;
        }
    }
}

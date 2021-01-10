using System;
using System.Collections.Generic;
using System.Text;

namespace ApreServi
{
    public class TestBD
    {
        public int id { get; private set; }
        public int idCurso { get; private set; }
        public string nombre { get; private set; }
        public List<PreguntaBD> preguntas { get; private set; }

        public TestBD(int i, int ic, string n, List<PreguntaBD> p)
        {
            id = i; idCurso = ic; nombre = n; preguntas = p;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

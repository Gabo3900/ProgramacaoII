using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class QuadroMedalhas
    {
        private Pais[] paises = new Pais[20];
        private int k;
        public void Inserir(Pais p)
        {
            paises[k++] = p;
        }
        public Pais[] Listar()
        {
            Pais[] t = new Pais[k];
            Array.Copy(paises, t, k);
            Array.Sort(t);
            return t;
        }
    }
}

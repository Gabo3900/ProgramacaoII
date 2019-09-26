using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Pais : IComparable
    {
        private string nome;
        private int ouro;
        private int prata;
        private int bronze;
        public Pais(string n, int o, int p, int b)
        {
            nome = n;
            ouro = o;
            prata = p;
            bronze = b;
        }
        public int CompareTo(object outro)
        {
            Pais w = outro as Pais;
            if (ouro < w.ouro) return 1;
            if (ouro > w.ouro) return -1;

            if (prata < w.prata) return 1;
            if (prata > w.prata) return -1;

            if (bronze < w.bronze) return 1;
            if (bronze > w.bronze) return -1;

            return nome.CompareTo(w.nome);
        }
        public override string ToString()
        {
            return $"{nome} {ouro} {prata} {bronze}";
        }
    }
}

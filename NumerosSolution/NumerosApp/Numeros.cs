using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosApp
{
    class Numeros
    {
        private int inicio;
        private int fim;
        public Numeros(int i, int f)
        {
            inicio = i;
            fim = f;
        }
        public int[] Calcular(bool p, bool i)
        {
            int[] c = new int[fim - inicio + 1];
            int counter = 0;
            for(int a = inicio; a <= fim; a++)
            {
                if (p && a % 2 == 0)
                {
                    c[counter] = a;
                    counter++;
                }
                if (i && a % 2 == 1)
                {
                    c[counter] = a;
                    counter++;
                }
            }
            return c;
        }
    }
}

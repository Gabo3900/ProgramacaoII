using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoApp
{
    class Bingo
    {
        private int numBolas;
        private int[] sorteados;
        private int k;
        public void Iniciar(int numBolas) {
            this.numBolas = numBolas;
            sorteados = new int[numBolas];
        }
        public int Proximo() {
            Random random = new Random();
            for (int i = 0; i <= numBolas; i++) {
                int r = random.Next(numBolas) + 1;
                if (Array.IndexOf(sorteados, r) == -1) {
                    sorteados[k++] = r;
                    return r;
                }
            }
            return -1;
        }
        public int[] Sorteados() {
            int[] b = new int[k];
            Array.Copy(sorteados, b, k);
            Array.Sort(b);
            return b;
        }
    }
}

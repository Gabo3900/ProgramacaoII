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
        private int[] sorteados = new int[100];
        private int k;
        public void Iniciar(int numBolas) { this.numBolas = numBolas; }
        public int Proximo() {
            int r;
            Random random = new Random();
            for (int i = 0; i < numBolas; i++) {
                r = random.Next(numBolas) + 1;
                foreach (int a in Sorteados())
                {
                    if (r == a) break;
                    sorteados[k++] = r;
                    return r;
                }
            }
            return -1;
        }
        public int[] Sorteados() {
            int[] b = new int[k];
            Array.Copy(sorteados, b, k);
            return b;
        }
    }
}

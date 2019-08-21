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
        public void Iniciar(int numBolas) { this.numBolas = numBolas; }
        public int Proximo() {
            int r;
            Random random = new Random();
            for (int i = 0; i < numBolas; i++) {
                r = random.Next(numBolas);
                foreach (int a in Sorteados())
                {
                    if (r == a) break;
                    return r;
                }
            }
            return -1;
        }
        public int[] Sorteados() {

        }
    }
}

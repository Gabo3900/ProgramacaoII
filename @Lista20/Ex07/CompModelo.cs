using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class CompModelo : IComparer<Veiculo>
    {
        public int Compare(Veiculo v1, Veiculo v2)
        {
            if (v1.GetModelo().CompareTo(v2.GetModelo()) != 0)
            {
                return v1.GetModelo().CompareTo(v2.GetModelo());
            }
            return v1.GetPreco().CompareTo(v2.GetPreco());
        }
    }
}

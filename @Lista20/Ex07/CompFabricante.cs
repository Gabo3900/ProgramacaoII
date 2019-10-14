using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07
{
    class CompFabricante : IComparer<Veiculo>
    {
        public int Compare(Veiculo v1, Veiculo v2)
        {
            if (v1.GetFabricante().CompareTo(v2.GetFabricante()) != 0)
            {
                return v1.GetFabricante().CompareTo(v2.GetFabricante());
            }
            return v1.GetModelo().CompareTo(v2.GetModelo());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class DictionnaireContrats
    {
        public SortedDictionary<Int32, Contrat> lesContrats;

        public  DictionnaireContrats()
        {
            lesContrats = new SortedDictionary<int, Contrat>();
        }
    }
}

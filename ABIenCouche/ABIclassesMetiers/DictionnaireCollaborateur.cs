using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class DictionnaireCollaborateur
    {
        public  SortedDictionary<int, Collaborateur> SDCollaborateur;
        
        public DictionnaireCollaborateur()
        {
            SDCollaborateur = new SortedDictionary<int, Collaborateur>();
        }
    }
}

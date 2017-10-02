using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class DictionnaireContrats
    {
        public static SortedDictionary<int, Contrat> lesContrats = new SortedDictionary<int, Contrat>();
        private Collaborateur leColab;
        


        public Collaborateur LeColab { get => leColab; set => leColab = value; }

        public static string AjouterContrat(Contrat leContrat)
        {
            return "";
        }
    }
}

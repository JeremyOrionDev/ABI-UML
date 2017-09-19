﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class ContratStage:Contrat
    {
        public SortedDictionary<Int32, avenantContrat> lesAvenant;
        public ContratStage(String uneEcole,String unMotif,DateTime uneDateDeFin ,String laMission, String leMaitre,Int32 unNumContrat, String uneFonction, String uneQualif,String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat,uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Ecole = uneEcole;
            this.Motif = unMotif;
            this.DateDeFin = uneDateDeFin;
            this.UneMission = laMission;
            this.UnMaitre = leMaitre;
            lesAvenant = new SortedDictionary<int, avenantContrat>();
        }

        private String ecole;
        private String motif;
        private DateTime dateDeFin;
        private String uneMission;
        private String unMaitre;

        public string Ecole
        {
            get
            {
                return ecole;
            }

            set
            {
                ecole = value;
            }
        }

        public string Motif
        {
            get
            {
                return motif;
            }

            set
            {
                motif = value;
            }
        }

        public DateTime DateDeFin
        {
            get
            {
                return dateDeFin;
            }

            set
            {
                dateDeFin = value;
            }
        }

        public string UneMission
        {
            get
            {
                return uneMission;
            }

            set
            {
                uneMission = value;
            }
        }

        public string UnMaitre
        {
            get
            {
                return unMaitre;
            }

            set
            {
                unMaitre = value;
            }
        }
    }
}

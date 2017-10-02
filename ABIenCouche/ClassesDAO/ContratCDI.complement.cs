using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe publique partielle de complément des contrats de type CDI
    /// </summary>
    public partial class ContratCDI:Contrats
    {
        /// <summary>
        /// Constructeur complet duc ontrat de type CDI
        /// </summary>
        /// <param name="unLibelle">Libellé du contrat</param>
        /// <param name="unSalaire">Salaire du collaborateur</param>
        /// <param name="unNumContrat">Numéro du contrat</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneQualif">Qualification du collaborateur</param>
        /// <param name="unStatut">Etat du statut cadre</param>
        /// <param name="leDebut">Date de début du contrat</param>
        public ContratCDI(String unLibelle, Double unSalaire, Int32 unNumContrat, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut,int unId) :
    base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut,unId)
        {

            this.Libelle = unLibelle;
            this.Salaire = unSalaire;

        }
        /// <summary>
        /// Constructeur vide des contrat CDI nécessaire à la classe DAO
        /// </summary>
        public ContratCDI()
        {
        }
    }
}

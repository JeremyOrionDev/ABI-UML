using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe publique partielle de complément pour la classe DAO des contrat interim
    /// </summary>
    public partial class ContratInterim:Contrats
    {
        /// <summary>
        /// Constructeur complet des contrat d'interim
        /// </summary>
        /// <param name="uneAgence">Agence d'interim ayant envoyé le collaborateur</param>
        /// <param name="unMotif">Motif précisant l'origine du contrat</param>
        /// <param name="leSalaire">Le salaire du collaborateur</param>
        /// <param name="uneDateFin">La date de fin du contrat</param>
        /// <param name="unNumContrat">Le numéro du contrat</param>
        /// <param name="uneFonction">La fonction du collaborateur pour le projet</param>
        /// <param name="uneQualif">La qualification du collaborateur</param>
        /// <param name="unLibelle">Le libellé du contrat</param>
        /// <param name="unStatut">L'état du statut cadre du collaborateur</param>
        /// <param name="leDebut">La date de début du contrat</param>
        public ContratInterim(String uneAgence, String unMotif, Double leSalaire, DateTime uneDateFin, Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Agence = uneAgence;
            this.Salaire = leSalaire;
            this.DateFin = uneDateFin;
            this.Motif = unMotif;
        }
        /// <summary>
        /// Constructeur vide nécessaire à la classe DAO
        /// </summary>
        public ContratInterim()
        {
        }
    }
}

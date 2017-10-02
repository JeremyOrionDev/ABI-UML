using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe publique partielle de complément de la classe DAO des contrat de type CDD
    /// </summary>
    public partial class ContratCDD:Contrats
    {
        /// <summary>
        /// Constructeur du contrat CDD vide nécessaire à la classe DAO
        /// </summary>
        public ContratCDD()
        {
        }
        /// <summary>
        /// Constructeur complet de contrat CDD
        /// </summary>
        /// <param name="unLibelle">le libellé du CDD</param>
        /// <param name="uneDateFin">La date de fin du CDD</param>
        /// <param name="unMotif">Le motif du CDD</param>
        /// <param name="unNumContrat">Le numéro de contrat </param>
        /// <param name="uneFonction">La fonction du collaborateur possédant le contrat en cours de construction</param>
        /// <param name="uneQualif">La qualification du collaborateur</param>
        /// <param name="unStatut">L'état du statut cadre ou non cadre du collaborateur</param>
        /// <param name="leDebut">La date de début du contrat</param>
        public ContratCDD(String unLibelle, DateTime uneDateFin, String unMotif, Int32 unNumContrat, String uneFonction,
    String uneQualif, Boolean unStatut, DateTime leDebut, int unId) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut,unId)
        {
            this.DateFin = uneDateFin;
            this.Motif = unMotif;
        }
    }
}

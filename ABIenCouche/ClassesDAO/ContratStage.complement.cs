using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe publique partielle de contrats de type stage
    /// </summary>
    public partial class ContratStage:Contrats
    {
        /// <summary>
        /// nécessaire a la DAO
        /// </summary>
        public ContratStage()
        {
        }
        /// <summary>
        /// constructeur complet des contrats stage
        /// </summary>
        /// <param name="uneEcole">l'école dont dépend le stagiaire</param>
        /// <param name="unMotif">le motif du besoin du contrat</param>
        /// <param name="uneDateDeFin">la date de fin du contrat</param>
        /// <param name="laMission">la mission attribué au stagiaire</param>
        /// <param name="leTuteur">Le tuteur du stagiaire</param>
        /// <param name="unNumContrat">le numéro du contrat</param>
        /// <param name="uneFonction">La fonction du stagiaire</param>
        /// <param name="uneQualif">La qualification du stagiaire</param>
        /// <param name="unLibelle">le libellé du contrat</param>
        /// <param name="unStatut">l'état du statut cadre</param>
        /// <param name="leDebut">la date début du contrat</param>
        public ContratStage(String uneEcole, String unMotif, DateTime uneDateDeFin, String laMission, String leTuteur, Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Ecole = uneEcole;
            this.Motif = unMotif;
            this.DateFin = uneDateDeFin;
            this.Mission = laMission;
            this.Tuteur = leTuteur;
        }
    }
}

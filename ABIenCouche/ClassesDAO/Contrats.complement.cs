using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe publique partielle de contrats en complément pour la classe DAO
    /// </summary>
    public partial class Contrats
    {
        /// <summary>
        /// Constructeur complet des contrats servant de base au classe dérivées
        /// </summary>
        /// <param name="unNumContrat">Numéro du contrat</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneQualif">Qualification du collaborateur</param>
        /// <param name="unLibelle">Libellé du contrat</param>
        /// <param name="unStatut">Etat du statut cadre du collaborateur</param>
        /// <param name="leDebut">La date de début du contrat</param>
        public Contrats(Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut)
        {

            this.DateDebut = leDebut;
            this.Statut = unStatut;
            this.Qualification = uneQualif;
            this.Libelle = unLibelle;
            this.NumContrat = unNumContrat;
            this.Fonction = uneFonction;
        }
        /// <summary>
        /// Le constrcuteur vide des contrats nécessaire à la classe DAO
        /// </summary>
        public Contrats() { }

        public Augmentations Augmentations
        {
            get => default(Augmentations);
            set
            {
            }
        }

        public Avenant Avenant1
        {
            get => default(Avenant);
            set
            {
            }
        }
    }
}

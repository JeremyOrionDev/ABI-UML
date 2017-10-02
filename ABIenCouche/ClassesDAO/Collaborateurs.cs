//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassesDAO
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    /// <summary>
    /// Classe partielle de l'entity framework des collaborateurs
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class Collaborateurs

    {
        /// <summary>
        /// référence du matricule du collaborateur
        /// </summary>
        [DataMember]
        public int matricule { get; set; }
        /// <summary>
        /// référence du nom du collaborateur
        /// </summary>
        [DataMember]
        public string Nom { get; set; }
        /// <summary>
        /// référence du prénom du collaborateur
        /// </summary>
        [DataMember]
        public string Prenom { get; set; }
        /// <summary>
        /// référence de la civilité
        /// </summary>
        [DataMember]
        public string Civilite { get; set; }
        /// <summary>
        /// référence de la rue
        /// </summary>
        [DataMember]
        public string Rue { get; set; }
        /// <summary>
        /// référence de la ville
        /// </summary>
        [DataMember]
        public string Ville { get; set; }
        /// <summary>
        /// référence du code postal
        /// </summary>
        [DataMember]
        public string CodePostal { get; set; }
        /// <summary>
        /// référence du téléphone
        /// </summary>
        [DataMember]
        public string Telephone { get; set; }
        /// <summary>
        /// référence de la situation maritale
        /// </summary>
        [DataMember]
        public string SituationMaritale { get; set; }
        /// <summary>
        /// référence de l'état d'archivage
        /// </summary>
        [DataMember]
        public bool Archive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        ///Collection de contrats du collaborateurs
        [DataMember]
        public virtual ICollection<Contrats> Contrats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        ///collection des augmentations
        public virtual ICollection<Augmentations> Augmentations { get; set; }
    }
}

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
    
    public partial class ContratInterim : Contrats
    {
        /// <summary>
        /// référence de l'agence d'interim envoyant le collaborateur
        /// </summary>
        public string Agence { get; set; }
        /// <summary>
        /// référence du salaire
        /// </summary>
        public double Salaire { get; set; }
        /// <summary>
        /// référence a la date de fin
        /// </summary>
        public System.DateTime DateFin { get; set; }
        /// <summary>
        /// référence au motif
        /// </summary>
        public string Motif { get; set; }
    }
}

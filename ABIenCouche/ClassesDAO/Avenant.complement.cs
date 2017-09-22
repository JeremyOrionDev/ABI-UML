using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe publique partielle d'avenant
    /// </summary>
    public partial class Avenant
    {
        /// <summary>
        /// Constructeur vide d'avenant nécessaire à la classe DAO
        /// </summary>
        public Avenant()
        {
        }
        /// <summary>
        /// Constructeur d'avenant prenant en paramètre l'id, la Date, le Motif, et le Numéro .
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="laDate"></param>
        /// <param name="leMotif"></param>
        /// <param name="leNumero"></param>
        public Avenant(Int32 unId,DateTime laDate,String leMotif,Int32 leNumero)
        {
            this.MotifAvenant = leMotif;
            this.Date = laDate;
            this.idAvenant = unId;
            this.numeroAvenant = leNumero;
        }
    }
}

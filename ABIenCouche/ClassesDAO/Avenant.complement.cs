using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class Avenant
    {
        public Avenant()
        {
        }

        public Avenant(Int32 unId,DateTime laDate,String leMotif,Int32 leNumero)
        {
            this.MotifAvenant = leMotif;
            this.Date = laDate;
            this.idAvenant = unId;
            this.numeroAvenant = leNumero;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public class DonneesDAO
    {
        /// <summary>
        /// dbContext Entity Framework
        /// </summary>
        public static lesCollaborateursContainer DbContextCollaborateurs;

        public lesCollaborateursContainer lesCollaborateursContainer
        {
            get => default(lesCollaborateursContainer);
            set
            {
            }
        }
    }
}

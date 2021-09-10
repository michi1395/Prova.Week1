using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1.Factory
{
    public class Viaggio : IRimborso
    {
        public decimal CalcolaRimborso(Spesa s)
        {
            return s.Importo + 50;
        }
    }
}

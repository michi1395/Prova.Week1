using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1.Handler
{
    class NoApprovedHandler:AbstractHandler
    {
        public override Spesa Handle(Spesa spesa)
        {
            if (spesa.Importo >=2500)
            {
                spesa.Approvazione = false;
                spesa.LvlApprov = "No approved";
                
            }
            return base.Handle(spesa);
        }
    }
}

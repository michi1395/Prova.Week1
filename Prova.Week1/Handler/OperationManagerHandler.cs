using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1.Handler
{
    class OperationManagerHandler:AbstractHandler
    {
        public override Spesa Handle(Spesa spesa)
        {
            if (spesa.Importo >=401 && spesa.Importo<=1000)
            {
                spesa.Approvazione = true;
                spesa.LvlApprov = "Operation Manager";
            }
            return base.Handle(spesa);
        }
    }
}

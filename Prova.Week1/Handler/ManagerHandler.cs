using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1.Handler
{
    public class ManagerHandler:AbstractHandler
    {
        public override Spesa Handle (Spesa spesa)
        {
            if(spesa.Importo<=400)
            {
                spesa.Approvazione = true;
                spesa.LvlApprov = "Manager";
            }
            return base.Handle(spesa);
        }
    }
}

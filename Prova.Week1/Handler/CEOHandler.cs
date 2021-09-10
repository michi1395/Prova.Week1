using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1.Handler
{
    public class CEOHandler:AbstractHandler
    {
        public override Spesa Handle(Spesa spesa)
        {
            if (spesa.Importo > 1000 && spesa.Importo<2500)
            {
                spesa.Approvazione = true;
                spesa.LvlApprov = "CEO";
            }
            return base.Handle(spesa);
        }
    }
}

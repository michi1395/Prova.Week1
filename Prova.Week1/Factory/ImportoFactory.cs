using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prova.Week1.Spesa;

namespace Prova.Week1.Factory
{
    public class ImportoFactory
    {
        public ImportoFactory()
        {

        }
        public IRimborso GetRimborso(Spesa s)
        {
            IRimborso rimborso = null;
            switch ((int)s.Categoria)
            {
                case 0:
                    rimborso = new Viaggio();
                    
                    break;
                case 1:
                    rimborso = new Alloggio();
                    break;
                case 2:
                    rimborso = new Vitto();
                    break;
                case 3:
                    rimborso = new Altro();
                    break;

            }
                return rimborso;
        }



        }
    }

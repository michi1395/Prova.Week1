using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Week1.Handler
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); 
        Spesa Handle(Spesa spesa);
    }
}

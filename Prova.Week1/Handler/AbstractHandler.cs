namespace Prova.Week1.Handler
{
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual Spesa Handle(Spesa spesa)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(spesa);
            }
            return spesa;
        }
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
    }
}

using ChainOfResponsibilityPattern.Models;
namespace ChainOfResponsibilityPattern.Handlers
{
    internal abstract class Handler
    {
        protected Handler? NextHandler;

        public void SetNext(Handler nextHandler)
        {
            NextHandler = nextHandler;
        }

        public abstract void Handle(Request request);
    }
}

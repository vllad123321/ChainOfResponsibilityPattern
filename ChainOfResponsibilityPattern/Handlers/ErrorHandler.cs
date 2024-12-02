using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    internal class ErrorHandler : Handler
    {
        public override void Handle(Request request)
        {
            if (request.Type == RequestType.Error)
            {
                Console.WriteLine($"ErrorHandler: Обработан запрос с сообщением: {request.Content}");
            }
            else
            {
                NextHandler?.Handle(request: request);
            }
        }
    }
}

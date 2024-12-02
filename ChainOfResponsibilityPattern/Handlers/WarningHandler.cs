using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    internal class WarningHandler : Handler
    {
        public override void Handle(Request request)
        {
            if (request.Type == RequestType.Warning)
            {
                Console.WriteLine($"WarningHandler: Обработан запрос с сообщением: {request.Content}");
            }
            else
            {
                NextHandler?.Handle(request);
            }
        }
    }
}

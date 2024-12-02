using ChainOfResponsibilityPattern.Models;

namespace ChainOfResponsibilityPattern.Handlers
{
    internal class InfoHandler : Handler
    {
        public override void Handle(Request request)
        {
            if (request.Type == RequestType.Info)
            {
                Console.WriteLine($"InfoHandler: Обработан запрос с сообщением: {request.Content}");
            }
            else
            {
                NextHandler?.Handle(request: request);
            }
        }
    }
}

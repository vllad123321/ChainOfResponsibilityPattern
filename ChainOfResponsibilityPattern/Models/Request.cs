namespace ChainOfResponsibilityPattern.Models
{
    internal class Request
    {
        public RequestType Type { get; }
        public string Content { get; }

        public Request(RequestType type, string content)
        {
            Type = type;
            Content = content;
        }
    }
}

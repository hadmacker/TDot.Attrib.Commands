namespace TDot.Attrib.Commands.Core.Response
{
    public abstract class ResponseBase : CommandBase, IResponse
    {
        protected ResponseBase(string message) : base(message)
        {
            // If message begins with an encrypted header...
            if (message.StartsWith("50."))
            {
                // decrypt message...
            }
        }
    }
}
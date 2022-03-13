namespace TDot.Attrib.Commands.Core.Request
{
    public abstract class RequestBase: CommandBase, IRequest
    {
        protected RequestBase(string message)
            : base(message)
        {
        }

        public byte[] Build()
        {
            return Encoding.GetBytes(Message);
        }
    }
}
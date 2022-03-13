using System.Text;

namespace TDot.Attrib.Commands.Core
{
    public abstract class CommandBase : ICommand
    {
        private readonly Encoding _encoding = Encoding.ASCII;
        protected Encoding Encoding { get { return _encoding; } }

        protected CommandBase(string message)
        {
            Message = message;
        }

        protected string Message { get; private set; }
    }
}
namespace TDot.Attrib.Commands.Core.Request
{
    [CommandFilter(Pattern="^Hello.*$", Priority=1)]
    public class HelloCommand : RequestBase
    {
        public HelloCommand(string message) : base(message)
        {
        }
    }
}
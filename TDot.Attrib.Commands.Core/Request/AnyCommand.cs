namespace TDot.Attrib.Commands.Core.Request
{
    [CommandFilter(Pattern="^.*$", Priority=-1)]
    public class AnyCommand : RequestBase
    {
        public AnyCommand(string message) : base(message)
        {
        }
    }
}
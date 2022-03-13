namespace TDot.Attrib.Commands.Core.Response
{
    [CommandFilter(Pattern="^.*$", Priority=-1)]
    public class AnyResponse : ResponseBase
    {
        public AnyResponse(string message) : base(message)
        {
        }
    }
}
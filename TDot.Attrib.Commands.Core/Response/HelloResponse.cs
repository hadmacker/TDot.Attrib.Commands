namespace TDot.Attrib.Commands.Core.Response
{
    [CommandFilter(Pattern = "^Hello")]
    public class HelloResponse : ResponseBase
    {
        public HelloResponse(string message) : base(message)
        {
        }
    }
}
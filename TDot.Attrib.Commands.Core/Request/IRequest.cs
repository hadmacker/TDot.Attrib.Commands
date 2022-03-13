namespace TDot.Attrib.Commands.Core.Request
{
    public interface IRequest : ICommand
    {
        byte[] Build();
    }
}
using NUnit.Framework;
using TDot.Attrib.Commands.Core.Request;
using TDot.Attrib.Commands.Core.Response;

namespace TDot.Attrib.Commands.Core.Tests
{
    [TestFixture]
    public class CommandFinder_AllCommands
    {
        [Test]
        public void BestCommand_UsesDefaultCommandWhenNoBetterIsFound()
        {

            var cmd = CommandFinder.For<IRequest>().Create("abc");
            Assert.IsInstanceOf<AnyCommand>(cmd);
        }

        [Test]
        public void BestCommand_UsesPriorityCommandWhenFound()
        {
            var cmd = CommandFinder.For<IRequest>().Create("Hello");
            Assert.IsInstanceOf<HelloCommand>(cmd);
        }

        [Test]
        public void BestCommand_ForResponses_GetsAnyResponse()
        {
            var cmd = CommandFinder.For<IResponse>().Create("abc");
            Assert.IsInstanceOf<AnyResponse>(cmd);
        }

        [Test]
        public void BestCommand_ForResponses_GetsHelloResponse()
        {
            var cmd = CommandFinder.For<IResponse>().Create("Hello");
            Assert.IsInstanceOf<HelloResponse>(cmd);
        }
    }
}
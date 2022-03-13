using System.Text;
using NUnit.Framework;
using TDot.Attrib.Commands.Core.Request;

namespace TDot.Attrib.Commands.Core.Tests
{
    [TestFixture]
    public class HelloCommand_Build
    {
        [Test]
        public void Build_Hello_BuildsCorrectMessage()
        {
            var expected = Encoding.ASCII.GetBytes("Hello");
            var h = new HelloCommand("Hello");
            Assert.AreEqual(expected, h.Build());
        }
    }
}
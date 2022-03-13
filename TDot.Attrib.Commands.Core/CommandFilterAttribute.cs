using System;
using System.Text.RegularExpressions;

namespace TDot.Attrib.Commands.Core
{
    public class CommandFilterAttribute : Attribute
    {
        public string Pattern { get; set; }
        public int Priority { get; set; }

        public bool CanParse(string message)
        {
            return Regex.Match(message, Pattern).Success;
        }
    }
}
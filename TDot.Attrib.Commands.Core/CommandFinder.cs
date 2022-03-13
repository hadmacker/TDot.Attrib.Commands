using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace TDot.Attrib.Commands.Core
{
    /// <summary>
    /// CommandFinder is used to identify classes based on IRequest and IResponse that can parse the message provided. 
    /// It will then choose the identified class having the greatest priority and instantiate it, passing the message into the constructor.
    /// </summary>
    public static class CommandFinder
    {
        public static IEnumerable<Type> For<T>(Assembly assembly = null) where T : ICommand
        {
            return AllCommands(assembly)
                       .Where(a => a.GetInterfaces().Contains(typeof (T)));
        }

        public static IEnumerable<Type> AllCommands(Assembly assembly = null)
        {
            if (assembly == null)
                assembly = Assembly.GetExecutingAssembly();

            return assembly
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof (ICommand)));
        }

        public static ICommand Create(this IEnumerable<Type> types, string message)
        {
            var matchingCommand = (from t in types
                                   let attributes =
                                       t.GetCustomAttributes(typeof (CommandFilterAttribute), true)
                                        .Cast<CommandFilterAttribute>()
                                   where attributes != null
                                         && attributes.Any()
                                         && attributes.All(a => a.CanParse(message))
                                   orderby attributes.Max(a => a.Priority) descending
                                   select t)
                                   .FirstOrDefault();

            return matchingCommand != null
                       ? (ICommand) Activator.CreateInstance(matchingCommand, message)
                       : null;
        }
    }
}
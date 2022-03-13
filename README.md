# TDot.Attrib.Commands

TDot.Attrib.Commands is an attribute-driven solution for dynamic command selection, including prioritization of commands and separation of commands into separate groups through the use of flag interfaces.
Consumers have the option of either manually instantiating a Request or Response class, or they may call the CommandFinder.For<T> method to use reflection to return a collection of all possible requests and responses matching the generic type T. An extension method for the returned collection uses the .NET Activator class and a passed in constructor parameter (named Message) that will find the appropriate request or response based on the best candidate command matching the CommandFilterAttribute’s Regex Pattern and then instantiates the highest priority resulting command. This ensures we can support a “fall-back” mode if a command is not recognized through the use of an “AnyCommand”, accepting the Regex pattern of “^.*$”.


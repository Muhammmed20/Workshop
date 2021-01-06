using System;

namespace Specifications.Attributes.ConsoleDesign.Attributes
{
    public class ForegroundColorAttribute : Attribute
    {
        public ConsoleColor ConsoleColor { get; }

        public ForegroundColorAttribute(ConsoleColor consoleColor)
        {
            ConsoleColor = consoleColor;
        }
    }
}
using System;

namespace Specifications.Attributes.ConsoleDesign.Attributes
{
    public class BackgroundColorAttribute : Attribute
    {
        public ConsoleColor ConsoleColor { get; }
        public BackgroundColorAttribute(ConsoleColor consoleColor)
        {
            ConsoleColor = consoleColor;
        }
    }
}
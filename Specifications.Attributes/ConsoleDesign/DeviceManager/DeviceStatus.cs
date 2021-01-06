using System;
using Specifications.Attributes.ConsoleDesign.Attributes;

namespace Specifications.Attributes.ConsoleDesign.DeviceManager
{
    public enum DeviceStatus
    {
        [BackgroundColor(ConsoleColor.Green)]
        [ForegroundColor(ConsoleColor.Black)]
        Registered,

        [BackgroundColor(ConsoleColor.Red)]
        [ForegroundColor(ConsoleColor.White)]
        PingFailed,

        [BackgroundColor(ConsoleColor.DarkCyan)]
        [ForegroundColor(ConsoleColor.White)]
        PortNotOpen,

        [BackgroundColor(ConsoleColor.DarkRed)]
        [ForegroundColor(ConsoleColor.Black)]
        RegistrationFailed,

        [BackgroundColor(ConsoleColor.DarkGreen)]
        [ForegroundColor(ConsoleColor.White)]
        FoundAndRegistered
    }
}
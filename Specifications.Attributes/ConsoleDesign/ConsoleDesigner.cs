using System;
using System.Collections.Generic;
using Specifications.Attributes.ConsoleDesign.DeviceManager;

namespace Specifications.Attributes.ConsoleDesign
{
    public static class ConsoleDesigner
    {
        public static void Build()
        {
            Console.WriteLine("Outputting current status of all devices...");
            var devices = LoadDevices();

            foreach (var device in devices)
            {

                Console.BackgroundColor = device.Status.GetBackgroundColor();
                Console.ForegroundColor = device.Status.GetForegroundColor();
                Console.WriteLine($"Device : {device.IpAddress}, Status = {device.Status}");
            }

            Console.ResetColor();
            Console.ReadKey();
        }

        private static IEnumerable<Device> LoadDevices()
        {
            return new List<Device>()
            {
                new Device()
                {
                    IpAddress="10.1.187.10",
                    Status = DeviceStatus.Registered
                },
                new Device()
                {
                    IpAddress="10.1.187.12",
                    Status = DeviceStatus.PingFailed
                },
                new Device()
                {
                    IpAddress="10.1.187.23",
                    Status = DeviceStatus.PortNotOpen
                },
                new Device()
                {
                    IpAddress="10.1.187.57",
                    Status = DeviceStatus.RegistrationFailed
                },
                new Device()
                {
                    IpAddress="10.1.187.75",
                    Status = DeviceStatus.FoundAndRegistered
                }
            };
        }
    }
}
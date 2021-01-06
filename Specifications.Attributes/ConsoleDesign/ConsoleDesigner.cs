using System;
using System.Collections.Generic;
using Specifications.Attributes.ConsoleDesign.DeviceManager;

namespace Specifications.Attributes.ConsoleDesign
{
    public static class ConsoleDesigner
    {
        public static void Build()
        {
            Console.WriteLine("Fetching devices");
            var devices = LoadDevices();
            Console.WriteLine("Outputting current status of all devices...");

            Console.ForegroundColor = ConsoleColor.Black;
            foreach (var d in devices)
            {

                Console.BackgroundColor = d.Status.GetBackgroundColor();
                Console.ForegroundColor = d.Status.GetForegroundColor();
                Console.WriteLine($"Device {d.IpAddress} Status={d.Status}");
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
                }
            };
        }
    }
}
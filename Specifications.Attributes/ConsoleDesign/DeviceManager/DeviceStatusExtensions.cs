using System;
//using System.Linq;
//using System.Reflection;
using Specifications.Attributes.ConsoleDesign.Attributes;

namespace Specifications.Attributes.ConsoleDesign.DeviceManager
{
    public static class DeviceStatusExtensions
    {
        private static T GetAttribute<T>(this DeviceStatus status) where T : Attribute
        {
            return (status.GetType()
                .GetMember(Enum.GetName(status.GetType(), status)!)[0]
                .GetCustomAttributes(typeof(T), inherit: false)[0] as T);
        }

        public static ConsoleColor GetBackgroundColor(this DeviceStatus status)
        {
            return status
                .GetAttribute<BackgroundColorAttribute>().ConsoleColor;
        }

        public static ConsoleColor GetForegroundColor(this DeviceStatus status)
        {
            return status
                .GetAttribute<ForegroundColorAttribute>().ConsoleColor;
        }


        //public static ConsoleColor GetBgColor(this DeviceStatus status)
        //{
        //    var deviceStatusType = typeof(DeviceStatus);
        //    var statusName = Enum.GetName(deviceStatusType, status);
        //    var memberInfo = deviceStatusType.GetMember(statusName!);

        //    if (memberInfo.Length != 1)
        //        throw new ArgumentException(
        //                $"DeviceStatus of {status} should only have one memberInfo");

        //    var customAttributes = memberInfo[0].GetCustomAttributes<BackgroundColorAttribute>();
        //    var colorAttribute = customAttributes.FirstOrDefault();

        //    if (colorAttribute == null)
        //        throw new InvalidOperationException(
        //                $"DeviceStatus of {status} has no BackgroundColorAttribute");

        //    return colorAttribute.ConsoleColor;
        //}
    }
}
using Windows.Foundation.Metadata;
using Windows.Phone.Devices.Notification;
using System;
namespace Test
{
    public static partial class Class1
    {
        static VibrationDevice DefaultDevice => VibrationDevice.GetDefault();

        static void PlatformVibrate(TimeSpan duration) =>
            DefaultDevice.Vibrate(duration);
    }
}

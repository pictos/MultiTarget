using AudioToolbox;
using System;

namespace Test
{
    public static partial class Class1
    {
        static void PlatformVibrate(TimeSpan duration) =>
            SystemSound.Vibrate.PlaySystemSound();
    }
}

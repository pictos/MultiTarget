using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public static partial class Class1
    {
        public static void Vibrate()
           => PlatformVibrate(TimeSpan.FromMilliseconds(500));
    }
}

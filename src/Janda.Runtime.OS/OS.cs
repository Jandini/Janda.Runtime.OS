using System;
using System.Runtime.InteropServices;

namespace Janda.Runtime
{
    public static class OS
    {
        public enum Platform
        {
            Windows,
            OSX,
            Linux,
            FreeBSD,
            Unknown
        }

        public static Platform CurrentPlatform { get; private set; } = IsWindows() ? Platform.Windows : IsOSX() ? Platform.OSX : IsLinux() ? Platform.Linux : Platform.Unknown;
        public static bool IsWindows() => RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        public static bool IsOSX() => RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        public static bool IsLinux() => RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        public static bool IsFreeBSD() => RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD);

        public static void When(Action windows = null, Action osx = null, Action linux = null, Action bsd = null)
        {
            if (IsWindows()) windows?.Invoke();
            else if (IsOSX()) osx?.Invoke();
            else if (IsLinux()) linux?.Invoke();
            else if (IsFreeBSD()) bsd?.Invoke();
        }
    }
}

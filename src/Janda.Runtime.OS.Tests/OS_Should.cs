using System;
using System.Runtime.InteropServices;
using Xunit;

namespace Janda.Runtime.Tests
{
    public class OS_Should
    {
        [Fact]
        public void CurrentPlatform_MatchCurrentOSPlatform()
        {        
            switch (OS.CurrentPlatform)
            {
                case OS.Platform.Windows:
                    Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
                    break;
                case OS.Platform.Linux:
                    Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux));
                    break;
                case OS.Platform.OSX:
                    Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.OSX));
                    break;
                case OS.Platform.FreeBSD:
                    Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD));
                    break;
                default:
                    throw new NotSupportedException("Unsupported platform");
            }
        }

        [Fact]
        public void When_NoOSAction_DoNoting()
        {
            OS.When();
        }

        [Fact]
        public void When_OSXAction_MatchOSPlatfromOSX()
        {
            OS.When(
                osx: ()=> { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.OSX)); }
            );
        }

        [Fact]
        public void When_WindowsAction_MatchOSPlatfromWindows()
        {
            OS.When(
                windows: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)); }
            );
        }

        [Fact]
        public void When_LinuxAction_MatchOSPlatformLinux()
        {
            OS.When(
                linux: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)); }
            );
        }

        [Fact]
        public void When_BsdAction_MatchOSPlatformFreeBSD()
        {
            OS.When(
                bsd: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)); }
            );
        }


        [Fact]
        public void When_AllOSActions_MatchTheOSPlatform()
        {
            OS.When(
                windows: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Windows)); },
                osx: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.OSX)); },
                bsd: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD)); },
                linux: () => { Assert.True(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)); }
            );
        }
    }
}

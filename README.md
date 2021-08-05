# Janda.Runtime.OS

[![.NET](https://github.com/Jandini/Janda.Runtime.OS/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Jandini/Janda.Runtime.OS/actions/workflows/dotnet.yml)

Simplify code that executes based on the runtime platform.

`OS.CurrentPlatform`

```C#
switch (OS.CurrentPlatform)
{
    case OS.Platform.Windows:
    	break;
    case OS.Platform.Linux:
    	break;
    case OS.Platform.OSX:
    	break;
    case OS.Platform.FreeBSD:
    	break;
    default:
    	throw new NotSupportedException("Unsupported platform");
}
```



`OS.When`

```C#
OS.When(
    osx: ()=> { Console.WriteLine("Running under OSX"); },
	windows: () => { Console.WriteLine("Running under Windows"); }
);
```


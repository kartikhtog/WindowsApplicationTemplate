# dot net UI framewords

- Windows forms, WPF , UWP, WinUI, Xamarin.Forms , .NET MAUI

- .Net framework only work on windows
- .Net core is cross playform to win, mac, linux
- .Net framework contains core
- Start new project in .net core as they update and are faster and cross platform but if the framework involves UI (WPF or forms), they only run on windows
- Can share code between .netframework and .netcore with .net standard class libraries

## Windows Forms
- .NET framework also later moved to .net core
- also open source now
- Uses GDI+ (Graphics Device Interface)
- GDI uses of Win32 API which sit on top of the windows kernel (uses CPU)
- UI created in C# (c# is written by the visual designer in Visual Studio)

## Windows Presentation Foundations (WPF)
- .net Framework later also moved to .net core
- also open source now
- Use MILCore (media integration layer core)
- Milcore uses DirectX (which makes 3d graphics and powerfull effect possible)
- UI uses XAML

## Universal Windows Platforms (UWP)
- UWP in another hosting model (doesn't use Win32)
- Contains XAML UI framework, XAML Controls
- Native part of Windows 10 and is written in c++
- Can write UWP app in C# or C++
- Runs in a sandbox with means it has restricted access
- Has Activation and lifecycle management
- gets suppended with you minimize

## The windows UI Library (WinUI)
- Turn windows UI into library that me reference as nuget package (Microsoft.UI.Xaml)
- Contains XAML controls
- Contains XAML UI Framework
- Also supports Win32
- Open Source

## WinUI in UWP (use this instead of UWP)
- The mordern way to create UWP app as it UI in reference via nuget package instead of Windows (you might update windows to update UI package the old way)
- Choose or .NET or C++

## WinUI in Desktop (instead of WPF or Windows Forms)
- The mordern way
- can use .net or C++
- Update existing WPF or WinForms using Xaml Inlands


## WinUI in UWP vs WinUI in Desktop (WPF & winForms)
- Write the same Xaml and C# code
- UWP also lets to target HoloLens and Xbox, IoT in addition to PC
- UWP is Sandboxed but Desktop has full access
- UWP can be put on microsft store
- UWP is Activation & lifecycle management
- Desktop app keeps running when minimized

## Cross platform Desktop apps
- Before .net 6
1. Xamarin.iOS
2. Xamarin.Android
3. UWP
4. Xamarin.Forms (works for everythiing in UWP and Xamarin.Android and Xamarin.iOS)
- After .net 6 (renaming)
1. .Net for iOS
2. .Net for Android
3. WinUI
4. Macos
5. Xamarin Forms renamed to .Net Multi-platform App UI (.NET MAUI) , Also contains new features + open source
6. Uno Platform 
  1. Writed code in Xaml and C# and compile
  2. Can be complied to
    1. WinUI
    2. iOS
    3. Android
    4. macOS
    5. **Web**


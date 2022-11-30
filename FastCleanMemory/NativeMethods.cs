// Decompiled with JetBrains decompiler
// Type: WinMemoryCleaner.NativeMethods
// Assembly: WinMemoryCleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6b2fedd337d48392
// MVID: C6DC4AE6-F35B-40BC-B03E-1A665C103BE4
// Assembly location: C:\Users\Roman\Desktop\SCleaner.exe
// XML documentation location: C:\Users\Roman\Desktop\SCleaner.xml

using System;
using System.Runtime.InteropServices;

namespace FastCleanMemory
{
  /// <summary>Windows Native Methods</summary>
  internal static class NativeMethods
  {
    [DllImport("advapi32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool AdjustTokenPrivileges(
      IntPtr tokenHandle,
      [MarshalAs(UnmanagedType.Bool)] bool disableAllPrivileges,
      ref Structs.Windows.TokenPrivileges newState,
      int bufferLength,
      IntPtr previousState,
      IntPtr returnLength);

    [DllImport("psapi.dll", SetLastError = true)]
    internal static extern int EmptyWorkingSet(IntPtr hProcess);

    [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool LookupPrivilegeValue(
      string lpSystemName,
      string lpName,
      ref long lpLuid);

    [DllImport("ntdll.dll", SetLastError = true)]
    internal static extern uint NtSetSystemInformation(int infoClass, IntPtr info, int length);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool SetSystemFileCacheSize(
      IntPtr minimumFileCacheSize,
      IntPtr maximumFileCacheSize,
      int flags);
  }
}

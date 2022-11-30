using Microsoft.VisualBasic.Devices;
using System;
using System.Security.Principal;

namespace FastCleanMemory
{
  /// <summary>Computer Helper</summary>
  internal static class ComputerHelper
  {
    private static readonly ComputerInfo _computer = new ComputerInfo();

    /// <summary>
    /// Determines whether the current operating system is a 64-bit operating system
    /// </summary>
    /// <value>
    ///   <c>true</c> if it 64-bit; otherwise, <c>false</c>.
    /// </value>
    internal static bool Is64Bit => Environment.Is64BitOperatingSystem;

    /// <summary>
    /// Gets a value indicating whether this instance is windows 10 or above.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is windows 10 or above; otherwise, <c>false</c>.
    /// </value>
    internal static bool IsWindows8OrAbove => Environment.OSVersion.Platform == PlatformID.Win32NT && (double) Environment.OSVersion.Version.Major >= 6.2;

    /// <summary>
    /// Gets a value indicating whether this instance is windows vista or above.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is windows vista or above; otherwise, <c>false</c>.
    /// </value>
    internal static bool IsWindowsVistaOrAbove => Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6;

    /// <summary>Gets the memory available.</summary>
    /// <returns></returns>
    internal static long GetMemoryAvailable() => Convert.ToInt64(ComputerHelper._computer.AvailablePhysicalMemory);

    /// <summary>Gets the size of the memory.</summary>
    /// <returns></returns>
    internal static long GetMemorySize() => Convert.ToInt64(ComputerHelper._computer.TotalPhysicalMemory);

    /// <summary>Gets the memory usage.</summary>
    /// <returns></returns>
    internal static long GetMemoryUsage() => Convert.ToInt64(100.0 - (double) ComputerHelper.GetMemoryAvailable() / (double) ComputerHelper.GetMemorySize() * 100.0);

    /// <summary>Sets the increase privilege.</summary>
    /// <param name="privilegeName">Name of the privilege.</param>
    /// <returns></returns>
    internal static bool SetIncreasePrivilege(string privilegeName)
    {
      using (WindowsIdentity current = WindowsIdentity.GetCurrent(TokenAccessLevels.Query | TokenAccessLevels.AdjustPrivileges))
      {
        Structs.Windows.TokenPrivileges newState;
        newState.Count = 1;
        newState.Luid = 0L;
        newState.Attr = 2;
        if (NativeMethods.LookupPrivilegeValue((string) null, privilegeName, ref newState.Luid))
          return NativeMethods.AdjustTokenPrivileges(current.Token, false, ref newState, 0, IntPtr.Zero, IntPtr.Zero) || 0U > 0U;
      }
      return false;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: WinMemoryCleaner.MemoryHelper
// Assembly: WinMemoryCleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6b2fedd337d48392
// MVID: C6DC4AE6-F35B-40BC-B03E-1A665C103BE4
// Assembly location: C:\Users\Roman\Desktop\SCleaner.exe
// XML documentation location: C:\Users\Roman\Desktop\SCleaner.xml

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using FastCleanMemory.Properties;

namespace FastCleanMemory
{
    /// <summary>Memory Helper</summary>

    
internal static class MemoryHelper
{
    /// <summary>Memory clean</summary>
    /// <param name="areas">Memory areas</param>
    
    internal static void Clean(Enums.Memory.Area areas)
    {
      if (areas.HasFlag((Enum) Enums.Memory.Area.ProcessesWorkingSet))
      {
        try
        {
          MemoryHelper.CleanProcessesWorkingSet();
          LogHelper.Info(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} ({1})", (object) Resources.MemoryHelperProcessesWorkingSet, (object) Resources.LogCleaned.ToUpper(CultureInfo.CurrentCulture)), nameof (Clean));
        }
        catch (Exception ex)
        {
          LogHelper.Error(ex, method: nameof (Clean));
        }
      }
      if (areas.HasFlag((Enum) Enums.Memory.Area.SystemWorkingSet))
      {
        try
        {
          MemoryHelper.CleanSystemWorkingSet();
          LogHelper.Info(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} ({1})", (object) Resources.MemoryHelperSystemWorkingSet, (object) Resources.LogCleaned.ToUpper(CultureInfo.CurrentCulture)), nameof (Clean));
        }
        catch (Exception ex)
        {
          LogHelper.Error(ex, method: nameof (Clean));
        }
      }
      if (areas.HasFlag((Enum) Enums.Memory.Area.ModifiedPageList))
      {
        try
        {
          MemoryHelper.CleanModifiedPageList();
          LogHelper.Info(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} ({1})", (object) Resources.MemoryHelperModifiedPageList, (object) Resources.LogCleaned.ToUpper(CultureInfo.CurrentCulture)), nameof (Clean));
        }
        catch (Exception ex)
        {
          LogHelper.Error(ex, method: nameof (Clean));
        }
      }
      if (areas.HasFlag((Enum) Enums.Memory.Area.StandbyList) || areas.HasFlag((Enum) Enums.Memory.Area.StandbyListLowPriority))
      {
        try
        {
          MemoryHelper.CleanStandbyList(areas.HasFlag((Enum) Enums.Memory.Area.StandbyListLowPriority));
          LogHelper.Info(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} ({1})", Settings.MemoryAreas.HasFlag((Enum) Enums.Memory.Area.StandbyListLowPriority) ? (object) Resources.MemoryHelperLowPriorityStandbyList : (object) Resources.MemoryHelperStandbyList, (object) Resources.LogCleaned.ToUpper(CultureInfo.CurrentCulture)), nameof (Clean));
        }
        catch (Exception ex)
        {
          LogHelper.Error(ex, method: nameof (Clean));
        }
      }
      if (!areas.HasFlag((Enum) Enums.Memory.Area.CombinedPageList))
        return;
      try
      {
        MemoryHelper.CleanCombinedPageList();
        LogHelper.Info(string.Format((IFormatProvider) CultureInfo.CurrentCulture, "{0} ({1})", (object) Resources.MemoryHelperCombinedPageList, (object) Resources.LogCleaned.ToUpper(CultureInfo.CurrentCulture)), nameof (Clean));
      }
      catch (Exception ex)
      {
        LogHelper.Error(ex, method: nameof (Clean));
      }
    }
    
    /// <summary>Cleans the combined page list.</summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception"></exception>
    private static void CleanCombinedPageList()
    {
      if (!ComputerHelper.IsWindows8OrAbove)
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperFeatureIsNotSupported, (object) Resources.MemoryHelperCombinedPageList), nameof (CleanCombinedPageList));
      else if (!ComputerHelper.SetIncreasePrivilege("SeProfileSingleProcessPrivilege"))
      {
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperAdminPrivilegeRequired, (object) "SeProfileSingleProcessPrivilege"), nameof (CleanCombinedPageList));
      }
      else
      {
        GCHandle gcHandle = GCHandle.Alloc((object) 0);
        try
        {
          Structs.Windows.MemoryCombineInformationEx combineInformationEx = new Structs.Windows.MemoryCombineInformationEx();
          gcHandle = GCHandle.Alloc((object) combineInformationEx, GCHandleType.Pinned);
          int length = Marshal.SizeOf<Structs.Windows.MemoryCombineInformationEx>(combineInformationEx);
          if (NativeMethods.NtSetSystemInformation(130, gcHandle.AddrOfPinnedObject(), length) != 0U)
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        catch (Win32Exception ex)
        {
          LogHelper.Error((Exception) ex, method: nameof (CleanCombinedPageList));
        }
        finally
        {
          try
          {
            if (gcHandle.IsAllocated)
              gcHandle.Free();
          }
          catch (InvalidOperationException ex)
          {
          }
        }
      }
    }

    /// <summary>Clean the modified page list.</summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception">
    /// </exception>
    private static void CleanModifiedPageList()
    {
      if (!ComputerHelper.IsWindowsVistaOrAbove)
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperFeatureIsNotSupported, (object) Resources.MemoryHelperModifiedPageList), nameof (CleanModifiedPageList));
      else if (!ComputerHelper.SetIncreasePrivilege("SeProfileSingleProcessPrivilege"))
      {
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperAdminPrivilegeRequired, (object) "SeProfileSingleProcessPrivilege"), nameof (CleanModifiedPageList));
      }
      else
      {
        GCHandle gcHandle = GCHandle.Alloc((object) 3, GCHandleType.Pinned);
        try
        {
          if (NativeMethods.NtSetSystemInformation(80, gcHandle.AddrOfPinnedObject(), Marshal.SizeOf<int>(3)) != 0U)
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        catch (Win32Exception ex)
        {
          LogHelper.Error((Exception) ex, method: nameof (CleanModifiedPageList));
        }
        finally
        {
          try
          {
            if (gcHandle.IsAllocated)
              gcHandle.Free();
          }
          catch (InvalidOperationException ex)
          {
          }
        }
      }
    }

    /// <summary>Cleans the standby list.</summary>
    /// <param name="lowPriority">if set to <c>true</c> [low priority].</param>
    /// <exception cref="T:System.ComponentModel.Win32Exception"></exception>
    /// <exception cref="T:System.ComponentModel.Win32Exception"></exception>
    private static void CleanStandbyList(bool lowPriority = false)
    {
      if (!ComputerHelper.IsWindowsVistaOrAbove)
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperFeatureIsNotSupported, (object) Resources.MemoryHelperStandbyList), nameof (CleanStandbyList));
      else if (!ComputerHelper.SetIncreasePrivilege("SeProfileSingleProcessPrivilege"))
      {
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperAdminPrivilegeRequired, (object) "SeProfileSingleProcessPrivilege"), nameof (CleanStandbyList));
      }
      else
      {
        object structure = (object) (lowPriority ? 5 : 4);
        GCHandle gcHandle = GCHandle.Alloc(structure, GCHandleType.Pinned);
        try
        {
          if (NativeMethods.NtSetSystemInformation(80, gcHandle.AddrOfPinnedObject(), Marshal.SizeOf(structure)) != 0U)
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        catch (Win32Exception ex)
        {
          LogHelper.Error((Exception) ex, method: nameof (CleanStandbyList));
        }
        finally
        {
          try
          {
            if (gcHandle.IsAllocated)
              gcHandle.Free();
          }
          catch (InvalidOperationException ex)
          {
          }
        }
      }
    }

    /// <summary>Cleans the system working set.</summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception">
    /// </exception>
    /// <exception cref="T:System.ComponentModel.Win32Exception"></exception>
    private static void CleanSystemWorkingSet()
    {
      if (!ComputerHelper.IsWindowsVistaOrAbove)
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperFeatureIsNotSupported, (object) Resources.MemoryHelperSystemWorkingSet), nameof (CleanSystemWorkingSet));
      else if (!ComputerHelper.SetIncreasePrivilege("SeIncreaseQuotaPrivilege"))
      {
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperAdminPrivilegeRequired, (object) "SeIncreaseQuotaPrivilege"), nameof (CleanSystemWorkingSet));
      }
      else
      {
        GCHandle gcHandle = GCHandle.Alloc((object) 0);
        try
        {
          object structure;
          if (ComputerHelper.Is64Bit)
            structure = (object) new Structs.Windows.SystemCacheInformation64()
            {
              MinimumWorkingSet = -1L,
              MaximumWorkingSet = -1L
            };
          else
            structure = (object) new Structs.Windows.SystemCacheInformation32()
            {
              MinimumWorkingSet = uint.MaxValue,
              MaximumWorkingSet = uint.MaxValue
            };
          gcHandle = GCHandle.Alloc(structure, GCHandleType.Pinned);
          int length = Marshal.SizeOf(structure);
          if (NativeMethods.NtSetSystemInformation(21, gcHandle.AddrOfPinnedObject(), length) != 0U)
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        catch (Win32Exception ex)
        {
          LogHelper.Error((Exception) ex, method: nameof (CleanSystemWorkingSet));
        }
        finally
        {
          try
          {
            if (gcHandle.IsAllocated)
              gcHandle.Free();
          }
          catch (InvalidOperationException ex)
          {
          }
        }
        try
        {
          IntPtr num = IntPtr.Subtract(IntPtr.Zero, 1);
          if (!NativeMethods.SetSystemFileCacheSize(num, num, 0))
            throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        catch (Win32Exception ex)
        {
          LogHelper.Error((Exception) ex, method: nameof (CleanSystemWorkingSet));
        }
      }
    }

    /// <summary>Cleans the processes working set.</summary>
    /// <exception cref="T:System.ComponentModel.Win32Exception"></exception>
    private static void CleanProcessesWorkingSet()
    {
      if (!ComputerHelper.IsWindowsVistaOrAbove)
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperFeatureIsNotSupported, (object) Resources.MemoryHelperProcessesWorkingSet), nameof (CleanProcessesWorkingSet));
      else if (!ComputerHelper.SetIncreasePrivilege("SeDebugPrivilege"))
      {
        LogHelper.Error(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.MemoryHelperAdminPrivilegeRequired, (object) "SeDebugPrivilege"), nameof (CleanProcessesWorkingSet));
      }
      else
      {
        foreach (Process process in ((IEnumerable<Process>) Process.GetProcesses()).Where<Process>((Func<Process, bool>) (process => process != null)))
        {
          try
          {
            using (process)
            {
              if (!process.HasExited)
              {
                if (NativeMethods.EmptyWorkingSet(process.Handle) == 0)
                  throw new Win32Exception(Marshal.GetLastWin32Error());
              }
            }
          }
          catch (InvalidOperationException ex)
          {
          }
          catch (Win32Exception ex)
          {
            if (ex.NativeErrorCode != 5)
              LogHelper.Error((Exception) ex, method: nameof (CleanProcessesWorkingSet));
          }
        }
      }
    }
    
  }
}

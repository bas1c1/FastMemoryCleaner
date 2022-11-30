// Decompiled with JetBrains decompiler
// Type: WinMemoryCleaner.Structs
// Assembly: WinMemoryCleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6b2fedd337d48392
// MVID: C6DC4AE6-F35B-40BC-B03E-1A665C103BE4
// Assembly location: C:\Users\Roman\Desktop\SCleaner.exe
// XML documentation location: C:\Users\Roman\Desktop\SCleaner.xml

using System;
using System.Runtime.InteropServices;

namespace FastCleanMemory
{
  internal static class Structs
  {
    internal static class Windows
    {
      /// <summary>Memory Combine Information Ex</summary>
      [StructLayout(LayoutKind.Sequential, Pack = 1)]
      internal struct MemoryCombineInformationEx
      {
        private readonly IntPtr Handle;
        private readonly IntPtr PagesCombined;
        private readonly IntPtr Flags;
      }

      /// <summary>
      /// System Cache Information structure for x86 working set
      /// </summary>
      [StructLayout(LayoutKind.Sequential, Pack = 1)]
      internal struct SystemCacheInformation32
      {
        private readonly uint CurrentSize;
        private readonly uint PeakSize;
        private readonly uint PageFaultCount;
        internal uint MinimumWorkingSet;
        internal uint MaximumWorkingSet;
        private readonly uint Unused1;
        private readonly uint Unused2;
        private readonly uint Unused3;
        private readonly uint Unused4;
      }

      /// <summary>
      /// System Cache Information structure for x64 working set
      /// </summary>
      [StructLayout(LayoutKind.Sequential, Pack = 1)]
      internal struct SystemCacheInformation64
      {
        private readonly long CurrentSize;
        private readonly long PeakSize;
        private readonly long PageFaultCount;
        internal long MinimumWorkingSet;
        internal long MaximumWorkingSet;
        private readonly long Unused1;
        private readonly long Unused2;
        private readonly long Unused3;
        private readonly long Unused4;
      }

      /// <summary>
      /// Token Privileges structure, used for adjusting token privileges
      /// </summary>
      [StructLayout(LayoutKind.Sequential, Pack = 1)]
      internal struct TokenPrivileges
      {
        internal int Count;
        internal long Luid;
        internal int Attr;
      }
    }
  }
}

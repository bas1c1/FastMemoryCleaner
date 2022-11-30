using Microsoft.Win32;
using System;

namespace FastCleanMemory
{
    internal static class Settings
    {
        internal static Enums.Memory.Area MemoryAreas = Enums.Memory.Area.ProcessesWorkingSet | Enums.Memory.Area.StandbyListLowPriority | Enums.Memory.Area.SystemWorkingSet;

        static Settings() => Settings.Reload();

        private static void Load()
        {
            try
            {
                using (Microsoft.Win32.RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\WinMemoryCleaner"))
                {
                    if (registryKey == null)
                    {
                        Settings.Save();
                    }
                    else
                    {
                        Settings.MemoryAreas = (Enums.Memory.Area)Enum.Parse(typeof(Enums.Memory.Area), Convert.ToString(registryKey.GetValue("MemoryAreas", (object)Settings.MemoryAreas)));
                        if (!Settings.MemoryAreas.HasFlag((Enum)(Enums.Memory.Area.StandbyList | Enums.Memory.Area.StandbyListLowPriority)))
                            return;
                        Settings.MemoryAreas &= ~Enums.Memory.Area.StandbyList;
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, method: nameof(Load));
            }
        }

        private static void Reload()
        {
            Settings.Load();
            Settings.Save();
        }

        internal static void Save()
        {
            try
            {
                using (Microsoft.Win32.RegistryKey subKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\WinMemoryCleaner"))
                    subKey?.SetValue("MemoryAreas", (object)(int)Settings.MemoryAreas);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex, method: nameof(Save));
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FastCleanMemory;

namespace FastCleanMemory
{
    class Program
    {
        public Enums.Memory.Area MemoryAreas
        {
            get => Settings.MemoryAreas;
            set
            {
                if (Settings.MemoryAreas.HasFlag((Enum)value))
                    Settings.MemoryAreas &= ~value;
                else
                    Settings.MemoryAreas |= value;
                switch (value)
                {
                    case Enums.Memory.Area.StandbyList:
                        if (Settings.MemoryAreas.HasFlag((Enum)Enums.Memory.Area.StandbyListLowPriority))
                        {
                            Settings.MemoryAreas &= ~Enums.Memory.Area.StandbyListLowPriority;
                            break;
                        }
                        break;
                    case Enums.Memory.Area.StandbyListLowPriority:
                        if (Settings.MemoryAreas.HasFlag((Enum)Enums.Memory.Area.StandbyList))
                        {
                            Settings.MemoryAreas &= ~Enums.Memory.Area.StandbyList;
                            break;
                        }
                        break;
                }
                Settings.Save();
            }
        }
        static void monitor()
        {
            while (true)
            {
                ManagementObjectSearcher ramMonitor =    //запрос к WMI для получения памяти ПК
                new ManagementObjectSearcher("SELECT TotalVisibleMemorySize,FreePhysicalMemory FROM Win32_OperatingSystem");

                foreach (ManagementObject objram in ramMonitor.Get())
                {
                    ulong totalRam = Convert.ToUInt64(objram["TotalVisibleMemorySize"]);    //общая память ОЗУ
                    ulong busyRam = totalRam - Convert.ToUInt64(objram["FreePhysicalMemory"]);         //занятная память = (total-free)
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine(((busyRam * 100) / totalRam) + "% used\n" + "Memory cleaned - " + DateTime.Now.TimeOfDay);       //вычисляем проценты занятой памяти
                }
            }
        }
        static async Task Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread t = new Thread(monitor);
            t.Start();
            while (true)
            {
                MemoryHelper.Clean(Settings.MemoryAreas);
                System.Threading.Thread.Sleep(300000);
            }
        }
    }
}

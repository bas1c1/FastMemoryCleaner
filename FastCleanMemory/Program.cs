using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FastCleanMemory
{
    class Program
    {
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
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
        /*
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
                    Console.WriteLine(((busyRam * 100) / totalRam) + "% used");       //вычисляем проценты занятой памяти
                }
            }
        } */
        static void Main(string[] args)
        {
            var icon = new NotifyIcon();
            icon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            icon.Visible = true;
            var handle = GetConsoleWindow();
            ShowWindow(handle, 0);
            while (true)
            {
                MemoryHelper.Clean(Settings.MemoryAreas);
                System.Threading.Thread.Sleep(90000);
            }
        }
    }
}

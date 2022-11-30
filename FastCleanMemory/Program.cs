using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        static void Main(string[] args)
        {
            Console.WriteLine("Fast memory cleaner");
            MemoryHelper.Clean(Settings.MemoryAreas);
            Console.WriteLine("Cleaning is complete\nPress any key to exit...");
            Console.Read();
        }
    }
}

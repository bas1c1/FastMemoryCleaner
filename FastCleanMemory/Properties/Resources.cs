// Decompiled with JetBrains decompiler
// Type: WinMemoryCleaner.Properties.Resources
// Assembly: WinMemoryCleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6b2fedd337d48392
// MVID: C6DC4AE6-F35B-40BC-B03E-1A665C103BE4
// Assembly location: C:\Users\Roman\Desktop\SCleaner.exe
// XML documentation location: C:\Users\Roman\Desktop\SCleaner.xml

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FastCleanMemory.Properties
{
  /// <summary>
  ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
  /// </summary>
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  public class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    /// <summary>
    ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static ResourceManager ResourceManager
    {
      get
      {
        if (FastCleanMemory.Properties.Resources.resourceMan == null)
                    FastCleanMemory.Properties.Resources.resourceMan = new ResourceManager("FastCleanMemory.Properties.Resources", typeof (FastCleanMemory.Properties.Resources).Assembly);
        return FastCleanMemory.Properties.Resources.resourceMan;
      }
    }

    /// <summary>
    ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
    ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    public static CultureInfo Culture
    {
      get => FastCleanMemory.Properties.Resources.resourceCulture;
      set => FastCleanMemory.Properties.Resources.resourceCulture = value;
    }

    /// <summary>Ищет локализованную строку, похожую на Cleaned.</summary>
    public static string LogCleaned => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (LogCleaned), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Can not save LOG: {0} (Exception: {1}).
    /// </summary>
    public static string LogHelperCanNotSaveLogException => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (LogHelperCanNotSaveLogException), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>Ищет локализованную строку, похожую на Started.</summary>
    public static string LogStarted => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (LogStarted), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Clean up memory.
    /// </summary>
    public static string MainViewCleanUpMemoryText => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MainViewCleanUpMemoryText), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на This operation requires administrator privileges ({0}).
    /// </summary>
    public static string MemoryHelperAdminPrivilegeRequired => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperAdminPrivilegeRequired), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Combined Page List.
    /// </summary>
    public static string MemoryHelperCombinedPageList => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperCombinedPageList), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на {0} clean is not supported on this operating system version.
    /// </summary>
    public static string MemoryHelperFeatureIsNotSupported => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperFeatureIsNotSupported), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Standby List (Low Priority).
    /// </summary>
    public static string MemoryHelperLowPriorityStandbyList => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperLowPriorityStandbyList), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Modified Page List.
    /// </summary>
    public static string MemoryHelperModifiedPageList => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperModifiedPageList), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Processes Working Set.
    /// </summary>
    public static string MemoryHelperProcessesWorkingSet => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperProcessesWorkingSet), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Standby List.
    /// </summary>
    public static string MemoryHelperStandbyList => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperStandbyList), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на System Working Set.
    /// </summary>
    public static string MemoryHelperSystemWorkingSet => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (MemoryHelperSystemWorkingSet), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>Ищет локализованную строку, похожую на About.</summary>
    public static string SettingAbout => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (SettingAbout), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>Ищет локализованную строку, похожую на Log.</summary>
    public static string SettingLog => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (SettingLog), FastCleanMemory.Properties.Resources.resourceCulture);

    /// <summary>
    ///   Ищет локализованную строку, похожую на Memory Areas.
    /// </summary>
    public static string SettingMemoryAreas => FastCleanMemory.Properties.Resources.ResourceManager.GetString(nameof (SettingMemoryAreas), FastCleanMemory.Properties.Resources.resourceCulture);
  }
}

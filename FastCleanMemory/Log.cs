// Decompiled with JetBrains decompiler
// Type: WinMemoryCleaner.Log
// Assembly: WinMemoryCleaner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=6b2fedd337d48392
// MVID: C6DC4AE6-F35B-40BC-B03E-1A665C103BE4
// Assembly location: C:\Users\Roman\Desktop\SCleaner.exe
// XML documentation location: C:\Users\Roman\Desktop\SCleaner.xml

using System;
using System.Drawing;

namespace FastCleanMemory
{
  /// <summary>Log Item</summary>
  public class Log
  {
    /// <summary>Gets or sets the color.</summary>
    /// <value>The color.</value>
    /*
    public Color Color
    {
      get
      {
        switch (this.Level)
        {
          case Enums.Log.Level.Info:
            return Color.Green;
          case Enums.Log.Level.Warning:
            return Color.Orange;
          case Enums.Log.Level.Error:
            return Color.Red;
          default:
            return Color.Black;
        }
      }
    }*/

    /// <summary>Gets or sets the date time.</summary>
    /// <value>The date time.</value>
    public DateTime DateTime { get; set; }

    /// <summary>Gets or sets the level.</summary>
    /// <value>The level.</value>
    public Enums.Log.Level Level { get; set; }

    /// <summary>Gets or sets the method.</summary>
    /// <value>The method.</value>
    public string Method { get; set; }

    /// <summary>Gets or sets the message.</summary>
    /// <value>The message.</value>
    public string Message { get; set; }

    /// <summary>Converts to string.</summary>
    /// <returns>
    /// A <see cref="T:System.String" /> that represents this instance.
    /// </returns>
    public override string ToString() => string.Format("[{0}] {1}", (object) this.Level, (object) this.Message);
  }
}

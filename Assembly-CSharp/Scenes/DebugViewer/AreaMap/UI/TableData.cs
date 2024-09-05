// Decompiled with JetBrains decompiler
// Type: Scenes.DebugViewer.AreaMap.UI.TableData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Scenes.DebugViewer.AreaMap.UI
{
  [Token(Token = "0x2002F34")]
  internal class TableData : TableDataBase<TableData.Value>
  {
    [Token(Token = "0x6012726")]
    [Address(RVA = "0x2117BA0", Offset = "0x2117BA0", VA = "0x2117BA0")]
    public TableData(List<TableData.Value> values)
    {
    }

    [Token(Token = "0x2002F35")]
    internal struct Value : ITableDataValue
    {
      [Token(Token = "0x400CA72")]
      [FieldOffset(Offset = "0x0")]
      public int id;
      [Token(Token = "0x400CA73")]
      [FieldOffset(Offset = "0x8")]
      public string name;

      [Token(Token = "0x6012727")]
      [Address(RVA = "0x2117BF8", Offset = "0x2117BF8", VA = "0x2117BF8")]
      public Value(int id, string name)
      {
      }
    }
  }
}

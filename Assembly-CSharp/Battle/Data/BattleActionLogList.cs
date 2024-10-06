// Decompiled with JetBrains decompiler
// Type: Battle.Data.BattleActionLogList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.ObjectModel;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002700")]
  public class BattleActionLogList
  {
    [Token(Token = "0x400A6C8")]
    [FieldOffset(Offset = "0x18")]
    private System.Collections.Generic.List<BattleActionLogData> logList;

    [Token(Token = "0x1700334A")]
    public ReadOnlyCollection<BattleActionLogData> List
    {
      [Token(Token = "0x600F1B2"), Address(RVA = "0x41AF4FC", Offset = "0x41AF4FC", VA = "0x41AF4FC")] get
      {
        return (ReadOnlyCollection<BattleActionLogData>) null;
      }
      [Token(Token = "0x600F1B3"), Address(RVA = "0x41AF504", Offset = "0x41AF504", VA = "0x41AF504")] private set
      {
      }
    }

    [Token(Token = "0x600F1B4")]
    [Address(RVA = "0x41AF50C", Offset = "0x41AF50C", VA = "0x41AF50C")]
    public BattleActionLogList()
    {
    }
  }
}

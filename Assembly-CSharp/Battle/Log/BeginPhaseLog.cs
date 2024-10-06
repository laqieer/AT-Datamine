// Decompiled with JetBrains decompiler
// Type: Battle.Log.BeginPhaseLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002507")]
  public sealed class BeginPhaseLog : ILog
  {
    [Token(Token = "0x4009F28")]
    [FieldOffset(Offset = "0x10")]
    private WeakReference<BattlePlayerData> activePlayerRef;

    [Token(Token = "0x170030F3")]
    public LogType LogType
    {
      [Token(Token = "0x600E49C"), Address(RVA = "0x4788330", Offset = "0x4788330", VA = "0x4788330", Slot = "4")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x170030F4")]
    public BattlePlayerData ActivePlayer
    {
      [Token(Token = "0x600E49D"), Address(RVA = "0x4788338", Offset = "0x4788338", VA = "0x4788338")] get
      {
        return (BattlePlayerData) null;
      }
    }

    [Token(Token = "0x600E49E")]
    [Address(RVA = "0x4788398", Offset = "0x4788398", VA = "0x4788398")]
    public BeginPhaseLog(BattlePlayerData player)
    {
    }
  }
}

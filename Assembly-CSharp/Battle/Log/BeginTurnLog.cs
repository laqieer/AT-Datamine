// Decompiled with JetBrains decompiler
// Type: Battle.Log.BeginTurnLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Battle.Log
{
  [Token(Token = "0x2002508")]
  public sealed class BeginTurnLog : ILog
  {
    [Token(Token = "0x170030F5")]
    public int Turn
    {
      [Token(Token = "0x600E49F"), Address(RVA = "0x4788428", Offset = "0x4788428", VA = "0x4788428")] get
      {
        return new int();
      }
      [Token(Token = "0x600E4A0"), Address(RVA = "0x4788430", Offset = "0x4788430", VA = "0x4788430")] private set
      {
      }
    }

    [Token(Token = "0x170030F6")]
    public LogType LogType
    {
      [Token(Token = "0x600E4A1"), Address(RVA = "0x4788438", Offset = "0x4788438", VA = "0x4788438", Slot = "4")] get
      {
        return new LogType();
      }
    }

    [Token(Token = "0x600E4A2")]
    [Address(RVA = "0x4788440", Offset = "0x4788440", VA = "0x4788440")]
    public BeginTurnLog(int turn)
    {
    }
  }
}

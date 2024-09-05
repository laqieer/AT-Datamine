// Decompiled with JetBrains decompiler
// Type: Battle.Commander.UnitController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Commander
{
  [Token(Token = "0x2002614")]
  public class UnitController
  {
    [Token(Token = "0x1700321E")]
    public ManualActionSelector Manual
    {
      [Token(Token = "0x600EB0A"), Address(RVA = "0x4B98FE4", Offset = "0x4B98FE4", VA = "0x4B98FE4")] get
      {
        return (ManualActionSelector) null;
      }
      [Token(Token = "0x600EB0B"), Address(RVA = "0x4B98FEC", Offset = "0x4B98FEC", VA = "0x4B98FEC")] private set
      {
      }
    }

    [Token(Token = "0x1700321F")]
    public AutoActionSelector Auto
    {
      [Token(Token = "0x600EB0C"), Address(RVA = "0x4B98FF4", Offset = "0x4B98FF4", VA = "0x4B98FF4")] get
      {
        return (AutoActionSelector) null;
      }
      [Token(Token = "0x600EB0D"), Address(RVA = "0x4B98FFC", Offset = "0x4B98FFC", VA = "0x4B98FFC")] private set
      {
      }
    }

    [Token(Token = "0x600EB0E")]
    [Address(RVA = "0x4B99004", Offset = "0x4B99004", VA = "0x4B99004")]
    private UnitController()
    {
    }

    [Token(Token = "0x17003220")]
    public bool EnableManual
    {
      [Token(Token = "0x600EB0F"), Address(RVA = "0x4B9900C", Offset = "0x4B9900C", VA = "0x4B9900C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600EB10")]
    [Address(RVA = "0x4B9901C", Offset = "0x4B9901C", VA = "0x4B9901C")]
    public static UnitController CreateLocalUser(BattleCore core, int playerId)
    {
      return (UnitController) null;
    }

    [Token(Token = "0x600EB11")]
    [Address(RVA = "0x4B993A0", Offset = "0x4B993A0", VA = "0x4B993A0")]
    public static UnitController CreateLocalCom(BattleCore core, int playerId)
    {
      return (UnitController) null;
    }

    [Token(Token = "0x600EB12")]
    [Address(RVA = "0x4B8F5B4", Offset = "0x4B8F5B4", VA = "0x4B8F5B4")]
    public static UnitController CreateExpedition(BattleCore core, int playerId)
    {
      return (UnitController) null;
    }
  }
}

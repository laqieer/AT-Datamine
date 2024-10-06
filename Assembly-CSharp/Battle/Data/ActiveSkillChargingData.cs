// Decompiled with JetBrains decompiler
// Type: Battle.Data.ActiveSkillChargingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Data
{
  [Token(Token = "0x2002715")]
  public sealed class ActiveSkillChargingData
  {
    [Token(Token = "0x400A730")]
    [FieldOffset(Offset = "0x28")]
    public SkillParameterData CancelSkill;

    [Token(Token = "0x170033A1")]
    public SkillParameterData ChargeTargetSkill
    {
      [Token(Token = "0x600F29B"), Address(RVA = "0x41B9F04", Offset = "0x41B9F04", VA = "0x41B9F04")] get
      {
        return (SkillParameterData) null;
      }
      [Token(Token = "0x600F29C"), Address(RVA = "0x41B9F0C", Offset = "0x41B9F0C", VA = "0x41B9F0C")] private set
      {
      }
    }

    [Token(Token = "0x170033A2")]
    public (int x, int y)? TargetCoord
    {
      [Token(Token = "0x600F29D"), Address(RVA = "0x41B9F14", Offset = "0x41B9F14", VA = "0x41B9F14")] get
      {
        return new (int, int)?();
      }
      [Token(Token = "0x600F29E"), Address(RVA = "0x41B9F24", Offset = "0x41B9F24", VA = "0x41B9F24")] private set
      {
      }
    }

    [Token(Token = "0x170033A3")]
    public int ChargedCount
    {
      [Token(Token = "0x600F29F"), Address(RVA = "0x41B9F30", Offset = "0x41B9F30", VA = "0x41B9F30")] get
      {
        return new int();
      }
      [Token(Token = "0x600F2A0"), Address(RVA = "0x41B9F38", Offset = "0x41B9F38", VA = "0x41B9F38")] private set
      {
      }
    }

    [Token(Token = "0x170033A4")]
    public bool IsCharging
    {
      [Token(Token = "0x600F2A1"), Address(RVA = "0x41B9F40", Offset = "0x41B9F40", VA = "0x41B9F40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170033A5")]
    public bool HadCharged
    {
      [Token(Token = "0x600F2A2"), Address(RVA = "0x41B9F60", Offset = "0x41B9F60", VA = "0x41B9F60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600F2A3")]
    [Address(RVA = "0x41BA004", Offset = "0x41BA004", VA = "0x41BA004")]
    public ActiveSkillChargingData()
    {
    }

    [Token(Token = "0x600F2A4")]
    [Address(RVA = "0x41BA00C", Offset = "0x41BA00C", VA = "0x41BA00C")]
    public void StartCharging(SkillParameterData skill, (int x, int y)? targetCoord)
    {
    }

    [Token(Token = "0x600F2A5")]
    [Address(RVA = "0x41BA064", Offset = "0x41BA064", VA = "0x41BA064")]
    public void SetChargingData(
      SkillParameterData skill,
      int chargedCount,
      (int x, int y)? targetCoord)
    {
    }

    [Token(Token = "0x600F2A6")]
    [Address(RVA = "0x41BA0B4", Offset = "0x41BA0B4", VA = "0x41BA0B4")]
    public bool Charge(int chargeCount = 1) => new bool();

    [Token(Token = "0x600F2A7")]
    [Address(RVA = "0x41BA100", Offset = "0x41BA100", VA = "0x41BA100")]
    public void StopCharging()
    {
    }

    [Token(Token = "0x600F2A8")]
    [Address(RVA = "0x41BA118", Offset = "0x41BA118", VA = "0x41BA118")]
    public bool IsChargedSkill(SkillParameterData skill) => new bool();

    [Token(Token = "0x600F2A9")]
    [Address(RVA = "0x41BA130", Offset = "0x41BA130", VA = "0x41BA130")]
    public bool IsChargingSkill(SkillParameterData skill) => new bool();

    [Token(Token = "0x600F2AA")]
    [Address(RVA = "0x41BA058", Offset = "0x41BA058", VA = "0x41BA058")]
    public void ChangeTargetCoord((int x, int y)? targetCoord)
    {
    }
  }
}

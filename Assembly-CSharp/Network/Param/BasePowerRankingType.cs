// Decompiled with JetBrains decompiler
// Type: Network.Param.BasePowerRankingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A43")]
  [Serializable]
  public class BasePowerRankingType
  {
    [Token(Token = "0x400704F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x4007050")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int battle_power;
    [Token(Token = "0x4007051")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private UnitStatusesType unit_statuses;
    [Token(Token = "0x4007052")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerRankingProfileType player_profile;

    [Token(Token = "0x17001885")]
    public int Ranking
    {
      [Token(Token = "0x60095E3"), Address(RVA = "0x48EED40", Offset = "0x48EED40", VA = "0x48EED40")] get
      {
        return new int();
      }
      [Token(Token = "0x60095E4"), Address(RVA = "0x48EED48", Offset = "0x48EED48", VA = "0x48EED48")] set
      {
      }
    }

    [Token(Token = "0x17001886")]
    public int BattlePower
    {
      [Token(Token = "0x60095E5"), Address(RVA = "0x48EED50", Offset = "0x48EED50", VA = "0x48EED50")] get
      {
        return new int();
      }
      [Token(Token = "0x60095E6"), Address(RVA = "0x48EED58", Offset = "0x48EED58", VA = "0x48EED58")] set
      {
      }
    }

    [Token(Token = "0x17001887")]
    public UnitStatusesType UnitStatuses
    {
      [Token(Token = "0x60095E7"), Address(RVA = "0x48EED60", Offset = "0x48EED60", VA = "0x48EED60")] get
      {
        return (UnitStatusesType) null;
      }
      [Token(Token = "0x60095E8"), Address(RVA = "0x48EED68", Offset = "0x48EED68", VA = "0x48EED68")] set
      {
      }
    }

    [Token(Token = "0x17001888")]
    public PlayerRankingProfileType PlayerProfile
    {
      [Token(Token = "0x60095E9"), Address(RVA = "0x48EED70", Offset = "0x48EED70", VA = "0x48EED70")] get
      {
        return (PlayerRankingProfileType) null;
      }
      [Token(Token = "0x60095EA"), Address(RVA = "0x48EED78", Offset = "0x48EED78", VA = "0x48EED78")] set
      {
      }
    }

    [Token(Token = "0x60095EB")]
    [Address(RVA = "0x48EED80", Offset = "0x48EED80", VA = "0x48EED80")]
    public BasePowerRankingType()
    {
    }
  }
}

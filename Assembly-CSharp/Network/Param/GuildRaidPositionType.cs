// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildRaidPositionType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A6A")]
  [Serializable]
  public class GuildRaidPositionType
  {
    [Token(Token = "0x4007144")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x4007145")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int boss_style_id;
    [Token(Token = "0x4007146")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int boss_max_hp;
    [Token(Token = "0x4007147")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int total_score;
    [Token(Token = "0x4007148")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<string> now_attack_player_ids;

    [Token(Token = "0x1700197B")]
    public int PositionId
    {
      [Token(Token = "0x60097F5"), Address(RVA = "0x48EFE04", Offset = "0x48EFE04", VA = "0x48EFE04")] get
      {
        return new int();
      }
      [Token(Token = "0x60097F6"), Address(RVA = "0x48EFE0C", Offset = "0x48EFE0C", VA = "0x48EFE0C")] set
      {
      }
    }

    [Token(Token = "0x1700197C")]
    public int BossStyleId
    {
      [Token(Token = "0x60097F7"), Address(RVA = "0x48EFE14", Offset = "0x48EFE14", VA = "0x48EFE14")] get
      {
        return new int();
      }
      [Token(Token = "0x60097F8"), Address(RVA = "0x48EFE1C", Offset = "0x48EFE1C", VA = "0x48EFE1C")] set
      {
      }
    }

    [Token(Token = "0x1700197D")]
    public int BossMaxHp
    {
      [Token(Token = "0x60097F9"), Address(RVA = "0x48EFE24", Offset = "0x48EFE24", VA = "0x48EFE24")] get
      {
        return new int();
      }
      [Token(Token = "0x60097FA"), Address(RVA = "0x48EFE2C", Offset = "0x48EFE2C", VA = "0x48EFE2C")] set
      {
      }
    }

    [Token(Token = "0x1700197E")]
    public int TotalScore
    {
      [Token(Token = "0x60097FB"), Address(RVA = "0x48EFE34", Offset = "0x48EFE34", VA = "0x48EFE34")] get
      {
        return new int();
      }
      [Token(Token = "0x60097FC"), Address(RVA = "0x48EFE3C", Offset = "0x48EFE3C", VA = "0x48EFE3C")] set
      {
      }
    }

    [Token(Token = "0x1700197F")]
    public List<string> NowAttackPlayerIds
    {
      [Token(Token = "0x60097FD"), Address(RVA = "0x48EFE44", Offset = "0x48EFE44", VA = "0x48EFE44")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60097FE"), Address(RVA = "0x48EFE4C", Offset = "0x48EFE4C", VA = "0x48EFE4C")] set
      {
      }
    }

    [Token(Token = "0x60097FF")]
    [Address(RVA = "0x48EFE54", Offset = "0x48EFE54", VA = "0x48EFE54")]
    public GuildRaidPositionType()
    {
    }
  }
}

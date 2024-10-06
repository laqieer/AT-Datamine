// Decompiled with JetBrains decompiler
// Type: Network.Param.GuildRaidPositionDetailType
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
  [Token(Token = "0x2001A69")]
  [Serializable]
  public class GuildRaidPositionDetailType
  {
    [Token(Token = "0x400713E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int position_id;
    [Token(Token = "0x400713F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int boss_style_id;
    [Token(Token = "0x4007140")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int boss_max_hp;
    [Token(Token = "0x4007141")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private int total_score;
    [Token(Token = "0x4007142")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GuildRaidScoreType> score_infos;
    [Token(Token = "0x4007143")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<string> now_attack_player_ids;

    [Token(Token = "0x17001975")]
    public int PositionId
    {
      [Token(Token = "0x60097E8"), Address(RVA = "0x48EFD9C", Offset = "0x48EFD9C", VA = "0x48EFD9C")] get
      {
        return new int();
      }
      [Token(Token = "0x60097E9"), Address(RVA = "0x48EFDA4", Offset = "0x48EFDA4", VA = "0x48EFDA4")] set
      {
      }
    }

    [Token(Token = "0x17001976")]
    public int BossStyleId
    {
      [Token(Token = "0x60097EA"), Address(RVA = "0x48EFDAC", Offset = "0x48EFDAC", VA = "0x48EFDAC")] get
      {
        return new int();
      }
      [Token(Token = "0x60097EB"), Address(RVA = "0x48EFDB4", Offset = "0x48EFDB4", VA = "0x48EFDB4")] set
      {
      }
    }

    [Token(Token = "0x17001977")]
    public int BossMaxHp
    {
      [Token(Token = "0x60097EC"), Address(RVA = "0x48EFDBC", Offset = "0x48EFDBC", VA = "0x48EFDBC")] get
      {
        return new int();
      }
      [Token(Token = "0x60097ED"), Address(RVA = "0x48EFDC4", Offset = "0x48EFDC4", VA = "0x48EFDC4")] set
      {
      }
    }

    [Token(Token = "0x17001978")]
    public int TotalScore
    {
      [Token(Token = "0x60097EE"), Address(RVA = "0x48EFDCC", Offset = "0x48EFDCC", VA = "0x48EFDCC")] get
      {
        return new int();
      }
      [Token(Token = "0x60097EF"), Address(RVA = "0x48EFDD4", Offset = "0x48EFDD4", VA = "0x48EFDD4")] set
      {
      }
    }

    [Token(Token = "0x17001979")]
    public List<GuildRaidScoreType> ScoreInfos
    {
      [Token(Token = "0x60097F0"), Address(RVA = "0x48EFDDC", Offset = "0x48EFDDC", VA = "0x48EFDDC")] get
      {
        return (List<GuildRaidScoreType>) null;
      }
      [Token(Token = "0x60097F1"), Address(RVA = "0x48EFDE4", Offset = "0x48EFDE4", VA = "0x48EFDE4")] set
      {
      }
    }

    [Token(Token = "0x1700197A")]
    public List<string> NowAttackPlayerIds
    {
      [Token(Token = "0x60097F2"), Address(RVA = "0x48EFDEC", Offset = "0x48EFDEC", VA = "0x48EFDEC")] get
      {
        return (List<string>) null;
      }
      [Token(Token = "0x60097F3"), Address(RVA = "0x48EFDF4", Offset = "0x48EFDF4", VA = "0x48EFDF4")] set
      {
      }
    }

    [Token(Token = "0x60097F4")]
    [Address(RVA = "0x48EFDFC", Offset = "0x48EFDFC", VA = "0x48EFDFC")]
    public GuildRaidPositionDetailType()
    {
    }
  }
}

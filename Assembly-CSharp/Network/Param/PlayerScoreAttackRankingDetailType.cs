// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerScoreAttackRankingDetailType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AD6")]
  [Serializable]
  public class PlayerScoreAttackRankingDetailType
  {
    [Token(Token = "0x4007306")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x4007307")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int high_score;
    [Token(Token = "0x4007308")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PlayerScoreAttackProfileType player_profile;
    [Token(Token = "0x4007309")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private PlayerScoreAttackResultScoreType score_attack_result_score;

    [Token(Token = "0x17001B68")]
    public int Ranking
    {
      [Token(Token = "0x6009C11"), Address(RVA = "0x48F2118", Offset = "0x48F2118", VA = "0x48F2118")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C12"), Address(RVA = "0x48F2120", Offset = "0x48F2120", VA = "0x48F2120")] set
      {
      }
    }

    [Token(Token = "0x17001B69")]
    public int HighScore
    {
      [Token(Token = "0x6009C13"), Address(RVA = "0x48F2128", Offset = "0x48F2128", VA = "0x48F2128")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C14"), Address(RVA = "0x48F2130", Offset = "0x48F2130", VA = "0x48F2130")] set
      {
      }
    }

    [Token(Token = "0x17001B6A")]
    public PlayerScoreAttackProfileType PlayerProfile
    {
      [Token(Token = "0x6009C15"), Address(RVA = "0x48F2138", Offset = "0x48F2138", VA = "0x48F2138")] get
      {
        return (PlayerScoreAttackProfileType) null;
      }
      [Token(Token = "0x6009C16"), Address(RVA = "0x48F2140", Offset = "0x48F2140", VA = "0x48F2140")] set
      {
      }
    }

    [Token(Token = "0x17001B6B")]
    public PlayerScoreAttackResultScoreType ScoreAttackResultScore
    {
      [Token(Token = "0x6009C17"), Address(RVA = "0x48F2148", Offset = "0x48F2148", VA = "0x48F2148")] get
      {
        return (PlayerScoreAttackResultScoreType) null;
      }
      [Token(Token = "0x6009C18"), Address(RVA = "0x48F2150", Offset = "0x48F2150", VA = "0x48F2150")] set
      {
      }
    }

    [Token(Token = "0x6009C19")]
    [Address(RVA = "0x48F2158", Offset = "0x48F2158", VA = "0x48F2158")]
    public PlayerScoreAttackRankingDetailType()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerScoreAttackRankingRewardType
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
  [Token(Token = "0x2001AD7")]
  [Serializable]
  public class PlayerScoreAttackRankingRewardType
  {
    [Token(Token = "0x400730A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int score_attack_event_id;
    [Token(Token = "0x400730B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x400730C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int high_score;
    [Token(Token = "0x400730D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<Reward> rewards;

    [Token(Token = "0x17001B6C")]
    public int ScoreAttackEventId
    {
      [Token(Token = "0x6009C1A"), Address(RVA = "0x48F2160", Offset = "0x48F2160", VA = "0x48F2160")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C1B"), Address(RVA = "0x48F2168", Offset = "0x48F2168", VA = "0x48F2168")] set
      {
      }
    }

    [Token(Token = "0x17001B6D")]
    public int Ranking
    {
      [Token(Token = "0x6009C1C"), Address(RVA = "0x48F2170", Offset = "0x48F2170", VA = "0x48F2170")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C1D"), Address(RVA = "0x48F2178", Offset = "0x48F2178", VA = "0x48F2178")] set
      {
      }
    }

    [Token(Token = "0x17001B6E")]
    public int HighScore
    {
      [Token(Token = "0x6009C1E"), Address(RVA = "0x48F2180", Offset = "0x48F2180", VA = "0x48F2180")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C1F"), Address(RVA = "0x48F2188", Offset = "0x48F2188", VA = "0x48F2188")] set
      {
      }
    }

    [Token(Token = "0x17001B6F")]
    public List<Reward> Rewards
    {
      [Token(Token = "0x6009C20"), Address(RVA = "0x48F2190", Offset = "0x48F2190", VA = "0x48F2190")] get
      {
        return (List<Reward>) null;
      }
      [Token(Token = "0x6009C21"), Address(RVA = "0x48F2198", Offset = "0x48F2198", VA = "0x48F2198")] set
      {
      }
    }

    [Token(Token = "0x6009C22")]
    [Address(RVA = "0x48F21A0", Offset = "0x48F21A0", VA = "0x48F21A0")]
    public PlayerScoreAttackRankingRewardType()
    {
    }
  }
}

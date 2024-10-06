// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerScoreAttackRankingType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001AD8")]
  [Serializable]
  public class PlayerScoreAttackRankingType
  {
    [Token(Token = "0x400730E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int score_attack_event_id;
    [Token(Token = "0x400730F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int ranking;
    [Token(Token = "0x4007310")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int high_score;

    [Token(Token = "0x17001B70")]
    public int ScoreAttackEventId
    {
      [Token(Token = "0x6009C23"), Address(RVA = "0x48F21A8", Offset = "0x48F21A8", VA = "0x48F21A8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C24"), Address(RVA = "0x48F21B0", Offset = "0x48F21B0", VA = "0x48F21B0")] set
      {
      }
    }

    [Token(Token = "0x17001B71")]
    public int Ranking
    {
      [Token(Token = "0x6009C25"), Address(RVA = "0x48F21B8", Offset = "0x48F21B8", VA = "0x48F21B8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C26"), Address(RVA = "0x48F21C0", Offset = "0x48F21C0", VA = "0x48F21C0")] set
      {
      }
    }

    [Token(Token = "0x17001B72")]
    public int HighScore
    {
      [Token(Token = "0x6009C27"), Address(RVA = "0x48F21C8", Offset = "0x48F21C8", VA = "0x48F21C8")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C28"), Address(RVA = "0x48F21D0", Offset = "0x48F21D0", VA = "0x48F21D0")] set
      {
      }
    }

    [Token(Token = "0x6009C29")]
    [Address(RVA = "0x48F21D8", Offset = "0x48F21D8", VA = "0x48F21D8")]
    public PlayerScoreAttackRankingType()
    {
    }
  }
}

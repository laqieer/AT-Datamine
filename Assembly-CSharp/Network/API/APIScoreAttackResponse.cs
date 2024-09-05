// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DF0")]
  [Serializable]
  public class APIScoreAttackResponse
  {
    [Token(Token = "0x400802A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int high_score;
    [Token(Token = "0x400802B")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int cumulative_score;
    [Token(Token = "0x400802C")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private List<PlayerScoreAttackRankingDetailType> rankings;
    [Token(Token = "0x400802D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int remain_free_battle_count;

    [Token(Token = "0x17002375")]
    public int HighScore
    {
      [Token(Token = "0x600B11E"), Address(RVA = "0x22DB768", Offset = "0x22DB768", VA = "0x22DB768")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002376")]
    public int CumulativeScore
    {
      [Token(Token = "0x600B11F"), Address(RVA = "0x22DB770", Offset = "0x22DB770", VA = "0x22DB770")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002377")]
    public List<PlayerScoreAttackRankingDetailType> Rankings
    {
      [Token(Token = "0x600B120"), Address(RVA = "0x22DB778", Offset = "0x22DB778", VA = "0x22DB778")] get
      {
        return (List<PlayerScoreAttackRankingDetailType>) null;
      }
    }

    [Token(Token = "0x17002378")]
    public int RemainFreeBattleCount
    {
      [Token(Token = "0x600B121"), Address(RVA = "0x22DB780", Offset = "0x22DB780", VA = "0x22DB780")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600B122")]
    [Address(RVA = "0x22DB788", Offset = "0x22DB788", VA = "0x22DB788")]
    public APIScoreAttackResponse()
    {
    }
  }
}

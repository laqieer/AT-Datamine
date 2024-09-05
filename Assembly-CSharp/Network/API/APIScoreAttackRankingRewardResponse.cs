// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackRankingRewardResponse
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
  [Token(Token = "0x2001E00")]
  [Serializable]
  public class APIScoreAttackRankingRewardResponse
  {
    [Token(Token = "0x4008075")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ScoreAttackRankingRewardType> ranking_rewards;

    [Token(Token = "0x1700239B")]
    public List<ScoreAttackRankingRewardType> RankingRewards
    {
      [Token(Token = "0x600B184"), Address(RVA = "0x22DCD08", Offset = "0x22DCD08", VA = "0x22DCD08")] get
      {
        return (List<ScoreAttackRankingRewardType>) null;
      }
    }

    [Token(Token = "0x600B185")]
    [Address(RVA = "0x22DCD10", Offset = "0x22DCD10", VA = "0x22DCD10")]
    public APIScoreAttackRankingRewardResponse()
    {
    }
  }
}

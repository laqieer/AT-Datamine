// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreAttackRankingRewardPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using Il2CppDummyDll;
using Network.Param;
using System;
using TMPro;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000843")]
  public class ScoreAttackRankingRewardPopup : BaseScoreAttackRewardReceivePopup
  {
    [Token(Token = "0x4002762")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [Header("ランキング")]
    private TextMeshProUGUI ranking;
    [Token(Token = "0x4002763")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private TextMeshProUGUI score;

    [Token(Token = "0x6002F9B")]
    [Address(RVA = "0x3E72210", Offset = "0x3E72210", VA = "0x3E72210")]
    public void Initialize(
      PlayerScoreAttackRankingRewardType scoreAttackRankingReward,
      AssetCachedSpawner spawner,
      Action closeAction)
    {
    }

    [Token(Token = "0x6002F9C")]
    [Address(RVA = "0x3E7251C", Offset = "0x3E7251C", VA = "0x3E7251C")]
    public ScoreAttackRankingRewardPopup()
    {
    }
  }
}

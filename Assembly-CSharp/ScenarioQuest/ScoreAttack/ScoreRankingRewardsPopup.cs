// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreRankingRewardsPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.Param;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000863")]
  public class ScoreRankingRewardsPopup : PopupBase
  {
    [Token(Token = "0x40027C7")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ScoreRankingRewardsPopupItem itemPrefab;

    [Token(Token = "0x6003044")]
    [Address(RVA = "0x3E6E460", Offset = "0x3E6E460", VA = "0x3E6E460")]
    public void Initialize(
      int scoreAttackId,
      List<ScoreAttackRankingRewardType> rankingRewards,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6003045")]
    [Address(RVA = "0x3E77550", Offset = "0x3E77550", VA = "0x3E77550")]
    public ScoreRankingRewardsPopup()
    {
    }
  }
}

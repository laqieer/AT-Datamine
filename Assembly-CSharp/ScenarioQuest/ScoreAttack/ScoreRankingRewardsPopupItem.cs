// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreRankingRewardsPopupItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000866")]
  public class ScoreRankingRewardsPopupItem : MonoBehaviour
  {
    [Token(Token = "0x40027CB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text fromToRankText;
    [Token(Token = "0x40027CC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text currentToRankText;
    [Token(Token = "0x40027CD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text currentToScoreText;
    [Token(Token = "0x40027CE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ItemIcon itemPrefab;

    [Token(Token = "0x600304B")]
    [Address(RVA = "0x3E771D0", Offset = "0x3E771D0", VA = "0x3E771D0")]
    public void Initialize(
      ScoreAttackRankingRewardSetData data,
      ScoreAttackRankingRewardType scoreAttackRankingRewardType,
      AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600304C")]
    [Address(RVA = "0x3E77610", Offset = "0x3E77610", VA = "0x3E77610")]
    public ScoreRankingRewardsPopupItem()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.API;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000868")]
  public class ScoreReward : MonoBehaviour
  {
    [Token(Token = "0x40027D0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI highScoreValue;
    [Token(Token = "0x40027D1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI totalScoreValue;
    [Token(Token = "0x40027D2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ItemIcon nextHighScoreReward;
    [Token(Token = "0x40027D3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject nextHighScoreRewardThreePoints;
    [Token(Token = "0x40027D4")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ItemIcon nextTotalScoreReward;
    [Token(Token = "0x40027D5")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject nextTotalScoreRewardThreePoints;
    [Token(Token = "0x40027D6")]
    [FieldOffset(Offset = "0x48")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40027D7")]
    [FieldOffset(Offset = "0x50")]
    private int scoreAttackId;

    [Token(Token = "0x600304F")]
    [Address(RVA = "0x3E7690C", Offset = "0x3E7690C", VA = "0x3E7690C")]
    public void Initialize(AssetCachedSpawner spawner, int scoreAttackId)
    {
    }

    [Token(Token = "0x6003050")]
    [Address(RVA = "0x3E76A68", Offset = "0x3E76A68", VA = "0x3E76A68")]
    public void Create(APIScoreAttackResponse response)
    {
    }

    [Token(Token = "0x6003051")]
    [Address(RVA = "0x3E77644", Offset = "0x3E77644", VA = "0x3E77644")]
    private void CreateHiScore(
      ScoreAttackEventData scoreAttackEvent,
      List<ScoreAttackScoreRewardSetData> rewardSetDatas,
      int highScore)
    {
    }

    [Token(Token = "0x6003052")]
    [Address(RVA = "0x3E77C90", Offset = "0x3E77C90", VA = "0x3E77C90")]
    private void CreateTotalScore(
      ScoreAttackEventData scoreAttackEvent,
      List<ScoreAttackScoreRewardSetData> rewardSetDatas,
      int cumulativeScore)
    {
    }

    [Token(Token = "0x6003053")]
    [Address(RVA = "0x3E782EC", Offset = "0x3E782EC", VA = "0x3E782EC")]
    public void OpenScoreRewardPopup()
    {
    }

    [Token(Token = "0x6003054")]
    [Address(RVA = "0x3E7830C", Offset = "0x3E7830C", VA = "0x3E7830C")]
    private IEnumerator IEOpenScoreRewardPopup() => (IEnumerator) null;

    [Token(Token = "0x6003055")]
    [Address(RVA = "0x3E7839C", Offset = "0x3E7839C", VA = "0x3E7839C")]
    public ScoreReward()
    {
    }
  }
}

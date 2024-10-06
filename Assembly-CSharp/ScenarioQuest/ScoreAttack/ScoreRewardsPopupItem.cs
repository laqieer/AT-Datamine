// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreRewardsPopupItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x2000874")]
  public class ScoreRewardsPopupItem : MonoBehaviour
  {
    [Token(Token = "0x40027FC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text reachingScoreText;
    [Token(Token = "0x40027FD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ItemIcon itemPrefab;

    [Token(Token = "0x6003080")]
    [Address(RVA = "0x3E79484", Offset = "0x3E79484", VA = "0x3E79484")]
    public void Initialize(ScoreAttackScoreRewardSetData data, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6003081")]
    [Address(RVA = "0x3E79EE4", Offset = "0x3E79EE4", VA = "0x3E79EE4")]
    public ScoreRewardsPopupItem()
    {
    }
  }
}

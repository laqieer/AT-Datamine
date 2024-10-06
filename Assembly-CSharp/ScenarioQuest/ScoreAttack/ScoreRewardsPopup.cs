// Decompiled with JetBrains decompiler
// Type: ScenarioQuest.ScoreAttack.ScoreRewardsPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ScenarioQuest.ScoreAttack
{
  [Token(Token = "0x200086E")]
  public class ScoreRewardsPopup : PopupBase
  {
    [Token(Token = "0x40027E4")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ToggleGroup toggleGroup;
    [Token(Token = "0x40027E5")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private List<ScoreRewardsPopup.Switcher> switchers;
    [Token(Token = "0x40027E6")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ScoreRewardsPopupItem itemPrefab;
    [Token(Token = "0x40027E7")]
    [FieldOffset(Offset = "0xA0")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40027E8")]
    [FieldOffset(Offset = "0xA8")]
    private List<ScoreRewardsPopupItem> hiScoreItems;
    [Token(Token = "0x40027E9")]
    [FieldOffset(Offset = "0xB0")]
    private List<ScoreAttackScoreRewardSetData> hiScoreDataList;
    [Token(Token = "0x40027EA")]
    [FieldOffset(Offset = "0xB8")]
    private List<ScoreRewardsPopupItem> totalScoreItems;
    [Token(Token = "0x40027EB")]
    [FieldOffset(Offset = "0xC0")]
    private List<ScoreAttackScoreRewardSetData> totalScoreDataList;

    [Token(Token = "0x6003069")]
    [Address(RVA = "0x3E785EC", Offset = "0x3E785EC", VA = "0x3E785EC")]
    public void Initialize(int scoreAttackId, AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x600306A")]
    [Address(RVA = "0x3E78A74", Offset = "0x3E78A74", VA = "0x3E78A74")]
    private void CreateHiScoreData(ScoreAttackEventData scoreAttackEvent)
    {
    }

    [Token(Token = "0x600306B")]
    [Address(RVA = "0x3E78F78", Offset = "0x3E78F78", VA = "0x3E78F78")]
    private void CreateTotalScoreData(ScoreAttackEventData scoreAttackEvent)
    {
    }

    [Token(Token = "0x600306C")]
    [Address(RVA = "0x3E796F0", Offset = "0x3E796F0", VA = "0x3E796F0")]
    private void ChangeToggleState()
    {
    }

    [Token(Token = "0x600306D")]
    [Address(RVA = "0x3E79B04", Offset = "0x3E79B04", VA = "0x3E79B04")]
    public ScoreRewardsPopup()
    {
    }

    [Token(Token = "0x200086F")]
    private enum DisplayType
    {
      [Token(Token = "0x40027ED")] HiScore,
      [Token(Token = "0x40027EE")] TotalScore,
    }

    [Token(Token = "0x2000870")]
    [Serializable]
    private class Switcher
    {
      [Token(Token = "0x40027EF")]
      [FieldOffset(Offset = "0x10")]
      [SerializeField]
      private ScoreRewardsPopup.DisplayType type;
      [Token(Token = "0x40027F0")]
      [FieldOffset(Offset = "0x18")]
      [SerializeField]
      private CommonToggle toggle;
      [Token(Token = "0x40027F1")]
      [FieldOffset(Offset = "0x20")]
      [SerializeField]
      private GameObject onObj;
      [Token(Token = "0x40027F2")]
      [FieldOffset(Offset = "0x28")]
      [SerializeField]
      private GameObject offObj;

      [Token(Token = "0x1700070D")]
      public ScoreRewardsPopup.DisplayType DisplayType
      {
        [Token(Token = "0x6003070"), Address(RVA = "0x3E79D04", Offset = "0x3E79D04", VA = "0x3E79D04")] get
        {
          return new ScoreRewardsPopup.DisplayType();
        }
      }

      [Token(Token = "0x1700070E")]
      public CommonToggle Toggle
      {
        [Token(Token = "0x6003071"), Address(RVA = "0x3E79D0C", Offset = "0x3E79D0C", VA = "0x3E79D0C")] get
        {
          return (CommonToggle) null;
        }
      }

      [Token(Token = "0x6003072")]
      [Address(RVA = "0x3E79ABC", Offset = "0x3E79ABC", VA = "0x3E79ABC")]
      public void OnActive(bool isOn)
      {
      }

      [Token(Token = "0x6003073")]
      [Address(RVA = "0x3E79D14", Offset = "0x3E79D14", VA = "0x3E79D14")]
      public Switcher()
      {
      }
    }
  }
}

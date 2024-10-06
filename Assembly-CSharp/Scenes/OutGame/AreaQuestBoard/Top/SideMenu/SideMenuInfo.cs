// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.AreaQuestBoard.Top.SideMenu.SideMenuInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.AreaQuestBoard.Top.SideMenu
{
  [Token(Token = "0x2003906")]
  internal class SideMenuInfo : MonoBehaviour
  {
    [Token(Token = "0x400F945")]
    [FieldOffset(Offset = "0x18")]
    [Header("Top")]
    [SerializeField]
    private GameObject mainQuestLabels;
    [Token(Token = "0x400F946")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject hardIcon;
    [Token(Token = "0x400F947")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject veryHardIcon;
    [Token(Token = "0x400F948")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI questNameText;
    [Token(Token = "0x400F949")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private TextMeshProUGUI recommendCombatPowerText;
    [Token(Token = "0x400F94A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI consumedAPText;
    [Token(Token = "0x400F94B")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private QuestDifficultyIcon difficultyIcon;
    [Token(Token = "0x400F94C")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Image mapImage;
    [Token(Token = "0x400F94D")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject missionParent;
    [Token(Token = "0x400F94E")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] missionProgressIcon;
    [Token(Token = "0x400F94F")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Header("Scroll")]
    private ScrollRect scrollRect;
    [Token(Token = "0x400F950")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private RectTransform scrollContent;
    [Token(Token = "0x400F951")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject scenarioParent;
    [Token(Token = "0x400F952")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI scenarioText;
    [Token(Token = "0x400F953")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RewardListView firstClearRewardListView;
    [Token(Token = "0x400F954")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RewardListView clearRewardListView;
    [Token(Token = "0x400F955")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RewardListView dropRewardListView;
    [Token(Token = "0x400F956")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI victoryConditionText;
    [Token(Token = "0x400F957")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI defeatConditionText;

    [Token(Token = "0x60166A2")]
    [Address(RVA = "0x2082660", Offset = "0x2082660", VA = "0x2082660")]
    public void SetQuestInfo(
      AreaQuestAreaNodeQuestData areaNodeQuestData,
      AreaQuestInfo questInfo,
      bool isEvent,
      Action<RewardTypeEnum, int> openItemDetailAction,
      AssetCachedSpawner assetCachedSpawner)
    {
    }

    [Token(Token = "0x60166A3")]
    [Address(RVA = "0x2083F8C", Offset = "0x2083F8C", VA = "0x2083F8C")]
    private List<StaqData.RewardData> GetDropItemList(AreaQuestInfo questInfo)
    {
      return (List<StaqData.RewardData>) null;
    }

    [Token(Token = "0x60166A4")]
    [Address(RVA = "0x2084840", Offset = "0x2084840", VA = "0x2084840")]
    public SideMenuInfo()
    {
    }
  }
}

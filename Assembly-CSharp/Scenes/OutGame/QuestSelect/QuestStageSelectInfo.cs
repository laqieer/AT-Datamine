// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestStageSelectInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x20033FA")]
  internal class QuestStageSelectInfo : MonoBehaviour
  {
    [Token(Token = "0x400E1EB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private TextMeshProUGUI[] questLabels;
    [Token(Token = "0x400E1EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private TextMeshProUGUI questName;
    [Token(Token = "0x400E1ED")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(3f)]
    [Header("-推奨戦闘力")]
    private TextMeshProUGUI recommendationCombatPowerLabel;
    [Token(Token = "0x400E1EE")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private TextMeshProUGUI recommendationCombatPowerVal;
    [Token(Token = "0x400E1EF")]
    [FieldOffset(Offset = "0x38")]
    [Space(3f)]
    [Header("-消費AP")]
    [SerializeField]
    private TextMeshProUGUI consumedAPLabel;
    [Token(Token = "0x400E1F0")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private TextMeshProUGUI consumedAPVal;
    [Token(Token = "0x400E1F1")]
    [FieldOffset(Offset = "0x48")]
    [Header("-難易度ラベル")]
    [Space(3f)]
    [SerializeField]
    private GameObject hard;
    [Token(Token = "0x400E1F2")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject veryHard;
    [Token(Token = "0x400E1F3")]
    [FieldOffset(Offset = "0x58")]
    [Space(3f)]
    [Header("-難易度設定")]
    [SerializeField]
    private GameObject difficultyIcon;
    [Token(Token = "0x400E1F4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject[] difficultyLevel;
    [Token(Token = "0x400E1F5")]
    [FieldOffset(Offset = "0x68")]
    [Space(3f)]
    [Header("-マップ画像")]
    [SerializeField]
    private Image mapImage;
    [Token(Token = "0x400E1F6")]
    [FieldOffset(Offset = "0x70")]
    [Space(3f)]
    [Header("-ミッション情報")]
    [SerializeField]
    private GameObject missionInfo;
    [Token(Token = "0x400E1F7")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject[] missionProgress;
    [Token(Token = "0x400E1F8")]
    [FieldOffset(Offset = "0x80")]
    [Space(3f)]
    [SerializeField]
    [Header("-クリアー報酬")]
    private TextMeshProUGUI dropItemLabel;
    [Token(Token = "0x400E1F9")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject itemIconObj;
    [Token(Token = "0x400E1FA")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollRect itemScrollRect;
    [Token(Token = "0x400E1FB")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Space(3f)]
    [Header("-勝利,敗北条件")]
    private TextMeshProUGUI victoryConditionLabel;
    [Token(Token = "0x400E1FC")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private TextMeshProUGUI victoryConditionText;
    [Token(Token = "0x400E1FD")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private TextMeshProUGUI defeatConditionLabel;
    [Token(Token = "0x400E1FE")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private TextMeshProUGUI defeatConditionText;
    [Token(Token = "0x400E1FF")]
    [FieldOffset(Offset = "0xB8")]
    private QuestInfo questInfo;
    [Token(Token = "0x400E200")]
    [FieldOffset(Offset = "0xC0")]
    private List<GameObject> viewItemIcons;
    [Token(Token = "0x400E201")]
    [FieldOffset(Offset = "0xC8")]
    private QuestAssetLoader assetLoader;
    [Token(Token = "0x400E202")]
    [FieldOffset(Offset = "0xD0")]
    private Action<RewardTypeEnum, int> itemAction;
    [Token(Token = "0x400E203")]
    [FieldOffset(Offset = "0xD8")]
    private List<BattleRewardDescriptionData> rewardItems;
    [Token(Token = "0x400E204")]
    private const string FIRST_REWARD_ANIM_IN = "FirstRewardBadge_In";
    [Token(Token = "0x400E205")]
    private const string FIRST_REWARD_ANIM_OUT = "FirstRewardBadge_Out";

    [Token(Token = "0x60146DD")]
    [Address(RVA = "0x188F688", Offset = "0x188F688", VA = "0x188F688")]
    public void Initilalize(QuestAssetLoader assetLoader, Action<RewardTypeEnum, int> action)
    {
    }

    [Token(Token = "0x60146DE")]
    [Address(RVA = "0x188F690", Offset = "0x188F690", VA = "0x188F690")]
    public bool IsLoadedAssetBundle() => new bool();

    [Token(Token = "0x60146DF")]
    [Address(RVA = "0x188F6A8", Offset = "0x188F6A8", VA = "0x188F6A8")]
    public void SetQuest(QuestInfo questInfo)
    {
    }

    [Token(Token = "0x60146E0")]
    [Address(RVA = "0x188FA64", Offset = "0x188FA64", VA = "0x188FA64")]
    private void SetupDifficulty(QuestDifficultyTypeEnum difficulty)
    {
    }

    [Token(Token = "0x60146E1")]
    [Address(RVA = "0x188FB28", Offset = "0x188FB28", VA = "0x188FB28")]
    private void SetupMission()
    {
    }

    [Token(Token = "0x60146E2")]
    [Address(RVA = "0x1890050", Offset = "0x1890050", VA = "0x1890050")]
    private void SetupClearReward()
    {
    }

    [Token(Token = "0x60146E3")]
    [Address(RVA = "0x188FAB0", Offset = "0x188FAB0", VA = "0x188FAB0")]
    private IEnumerator LoadQuestMap(int resourceId) => (IEnumerator) null;

    [Token(Token = "0x60146E4")]
    [Address(RVA = "0x1890D0C", Offset = "0x1890D0C", VA = "0x1890D0C")]
    private void TryLoadRewardIcon(BattleRewardDescriptionData reward, ItemIcon icon)
    {
    }

    [Token(Token = "0x60146E5")]
    [Address(RVA = "0x1890F5C", Offset = "0x1890F5C", VA = "0x1890F5C")]
    private IEnumerator LoadRewardIcon(BattleRewardDescriptionData reward, ItemIcon icon)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x60146E6")]
    [Address(RVA = "0x1890BD0", Offset = "0x1890BD0", VA = "0x1890BD0")]
    private void ClearRewardIcons()
    {
    }

    [Token(Token = "0x60146E7")]
    [Address(RVA = "0x1891000", Offset = "0x1891000", VA = "0x1891000")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60146E8")]
    [Address(RVA = "0x1891004", Offset = "0x1891004", VA = "0x1891004")]
    public QuestStageSelectInfo()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestSelect.QuestStageSelectScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.QuestSelect
{
  [Token(Token = "0x2003405")]
  public class QuestStageSelectScene : MonoBehaviour
  {
    [Token(Token = "0x400E22E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup rootCanvasGroup;
    [Token(Token = "0x400E22F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("APGauge")]
    private ApRecoveryHeader apHeader;
    [Token(Token = "0x400E230")]
    [FieldOffset(Offset = "0x28")]
    [Header("クエスト詳細制御")]
    [SerializeField]
    private QuestStageSelectInfoView infoView;
    [Token(Token = "0x400E231")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("クエスト一覧")]
    private HorizontalLayoutGroup questListLayout;
    [Token(Token = "0x400E232")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject questListPageBase;
    [Token(Token = "0x400E233")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float questListScrollDuration;
    [Token(Token = "0x400E234")]
    [FieldOffset(Offset = "0x48")]
    [Header("難易度ボタン")]
    [SerializeField]
    private CommonButton[] BtnDifficultys;
    [Token(Token = "0x400E235")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Header("クエスト一覧ボタン")]
    private GameObject[] BtnQuestListItems;
    [Token(Token = "0x400E237")]
    [FieldOffset(Offset = "0x5C")]
    private QuestTypeEnum questType;
    [Token(Token = "0x400E238")]
    [FieldOffset(Offset = "0x60")]
    private int questPage;
    [Token(Token = "0x400E239")]
    [FieldOffset(Offset = "0x64")]
    private int selectQuestIdx;
    [Token(Token = "0x400E23B")]
    [FieldOffset(Offset = "0x70")]
    private List<QuestStageSelectItem> questItems;
    [Token(Token = "0x400E23C")]
    [FieldOffset(Offset = "0x78")]
    private UITimelineController uITimelineController;
    [Token(Token = "0x400E23D")]
    [FieldOffset(Offset = "0x80")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400E23E")]
    private const string ASSET_QUEST_STAGE_SELECT_IN = "Quest_StageSelect_In";
    [Token(Token = "0x400E23F")]
    private const string ASSET_QUEST_STAGE_SELECT_OUT = "Quest_StageSelect_Out";
    [Token(Token = "0x400E240")]
    private const string TextAssetBundle = "text_system";
    [Token(Token = "0x400E241")]
    private const string TextKeyQuestHard = "Toaster_Quest_Difficulty_Hard";
    [Token(Token = "0x400E242")]
    private const string TextKeyQuestVeryHard = "Toaster_Quest_Difficulty_VeryHard";
    [Token(Token = "0x400E243")]
    private const int QUEST_LIST_VIEW_MAX = 4;
    [Token(Token = "0x400E244")]
    [FieldOffset(Offset = "0x88")]
    private Action<int> questSelectAction;
    [Token(Token = "0x400E245")]
    [FieldOffset(Offset = "0x90")]
    private Action onGlobalMenuOpen;
    [Token(Token = "0x400E246")]
    [FieldOffset(Offset = "0x98")]
    private Action<QuestInfo> onDecidedQuest;
    [Token(Token = "0x400E247")]
    [FieldOffset(Offset = "0xA0")]
    private Action<QuestInfo> onOpenDetail;
    [Token(Token = "0x400E248")]
    [FieldOffset(Offset = "0xA8")]
    private Action onDecidedBack;
    [Token(Token = "0x400E249")]
    [FieldOffset(Offset = "0xB0")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400E24A")]
    [FieldOffset(Offset = "0xB8")]
    private List<QuestStageSelectScene.QuestGroupInfo> questGroups;

    [Token(Token = "0x1700441B")]
    public bool IsInitialized
    {
      [Token(Token = "0x6014716"), Address(RVA = "0x189240C", Offset = "0x189240C", VA = "0x189240C")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014717"), Address(RVA = "0x1892414", Offset = "0x1892414", VA = "0x1892414")] private set
      {
      }
    }

    [Token(Token = "0x1700441C")]
    public bool IsPlayAnimation
    {
      [Token(Token = "0x6014718"), Address(RVA = "0x1892420", Offset = "0x1892420", VA = "0x1892420")] get
      {
        return new bool();
      }
      [Token(Token = "0x6014719"), Address(RVA = "0x1892428", Offset = "0x1892428", VA = "0x1892428")] private set
      {
      }
    }

    [Token(Token = "0x601471A")]
    [Address(RVA = "0x1892434", Offset = "0x1892434", VA = "0x1892434")]
    private void Awake()
    {
    }

    [Token(Token = "0x601471B")]
    [Address(RVA = "0x189249C", Offset = "0x189249C", VA = "0x189249C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601471C")]
    [Address(RVA = "0x18925D0", Offset = "0x18925D0", VA = "0x18925D0")]
    public bool IsTimelineInitialized() => new bool();

    [Token(Token = "0x601471D")]
    [Address(RVA = "0x188EE5C", Offset = "0x188EE5C", VA = "0x188EE5C")]
    public IEnumerator Initialize(
      QuestAssetLoader assetLoader,
      IList<QuestInfo> questList,
      QuestTypeEnum questTypeEnum,
      Action<int> questSelectAction,
      Action onGlobalMenuOpen,
      Action<QuestInfo> onDecidedQuest,
      Action<QuestInfo> onOpenDetail,
      Action onDecidedBack,
      int? initQuestId = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601471E")]
    [Address(RVA = "0x1892614", Offset = "0x1892614", VA = "0x1892614")]
    private void SetupQuestItemList()
    {
    }

    [Token(Token = "0x601471F")]
    [Address(RVA = "0x1892A50", Offset = "0x1892A50", VA = "0x1892A50")]
    private void SetQuesPage(int page)
    {
    }

    [Token(Token = "0x6014720")]
    [Address(RVA = "0x1892D00", Offset = "0x1892D00", VA = "0x1892D00")]
    private IEnumerator QuestItemScroll(float val) => (IEnumerator) null;

    [Token(Token = "0x6014721")]
    [Address(RVA = "0x1892DA0", Offset = "0x1892DA0", VA = "0x1892DA0")]
    private void SetSelectQuest(
      int idx,
      QuestStageSelectScene.EnumInfoChangeAnim changeAnim = QuestStageSelectScene.EnumInfoChangeAnim.Non)
    {
    }

    [Token(Token = "0x6014722")]
    [Address(RVA = "0x188DB6C", Offset = "0x188DB6C", VA = "0x188DB6C")]
    public void PlayToEnableAnimation()
    {
    }

    [Token(Token = "0x6014723")]
    [Address(RVA = "0x188E57C", Offset = "0x188E57C", VA = "0x188E57C")]
    public void PlayToDisableAnimation()
    {
    }

    [Token(Token = "0x6014724")]
    [Address(RVA = "0x1893424", Offset = "0x1893424", VA = "0x1893424")]
    public void OnClickQuestSelect(int idx)
    {
    }

    [Token(Token = "0x6014725")]
    [Address(RVA = "0x18930A4", Offset = "0x18930A4", VA = "0x18930A4")]
    private void InitDifficulty(int selectQuestIdx)
    {
    }

    [Token(Token = "0x6014726")]
    [Address(RVA = "0x1893298", Offset = "0x1893298", VA = "0x1893298")]
    private void SelectDifficulty(QuestDifficultyTypeEnum difficulty)
    {
    }

    [Token(Token = "0x6014727")]
    [Address(RVA = "0x1893498", Offset = "0x1893498", VA = "0x1893498")]
    public void OnClickQuestDifficultyNormal()
    {
    }

    [Token(Token = "0x6014728")]
    [Address(RVA = "0x1893540", Offset = "0x1893540", VA = "0x1893540")]
    public void OnClickQuestDifficultyHard()
    {
    }

    [Token(Token = "0x6014729")]
    [Address(RVA = "0x18936D0", Offset = "0x18936D0", VA = "0x18936D0")]
    public void OnClickQuestDifficultyVeryHard()
    {
    }

    [Token(Token = "0x601472A")]
    [Address(RVA = "0x1893860", Offset = "0x1893860", VA = "0x1893860")]
    public void OnSlideQuestList(float slideLength)
    {
    }

    [Token(Token = "0x601472B")]
    [Address(RVA = "0x1893934", Offset = "0x1893934", VA = "0x1893934")]
    public void OnClickQuestListL()
    {
    }

    [Token(Token = "0x601472C")]
    [Address(RVA = "0x18939CC", Offset = "0x18939CC", VA = "0x18939CC")]
    public void OnClickQuestListR()
    {
    }

    [Token(Token = "0x601472D")]
    [Address(RVA = "0x1893A8C", Offset = "0x1893A8C", VA = "0x1893A8C")]
    public void OnSllideQuestInfo(float slideLength)
    {
    }

    [Token(Token = "0x601472E")]
    [Address(RVA = "0x1893B4C", Offset = "0x1893B4C", VA = "0x1893B4C")]
    public void OnClickQuestInfoPrev()
    {
    }

    [Token(Token = "0x601472F")]
    [Address(RVA = "0x1893BA4", Offset = "0x1893BA4", VA = "0x1893BA4")]
    public void OnClickQuestInfoNext()
    {
    }

    [Token(Token = "0x6014730")]
    [Address(RVA = "0x1893C44", Offset = "0x1893C44", VA = "0x1893C44")]
    public void OnClickQuestDecide()
    {
    }

    [Token(Token = "0x6014731")]
    [Address(RVA = "0x1893CCC", Offset = "0x1893CCC", VA = "0x1893CCC")]
    public void OnClickQuestDetail()
    {
    }

    [Token(Token = "0x6014732")]
    [Address(RVA = "0x1893D54", Offset = "0x1893D54", VA = "0x1893D54")]
    public void OnClickQuestStageBack()
    {
    }

    [Token(Token = "0x6014733")]
    [Address(RVA = "0x1893D70", Offset = "0x1893D70", VA = "0x1893D70")]
    public void OnClickGlobaleMenu()
    {
    }

    [Token(Token = "0x6014734")]
    [Address(RVA = "0x1893D8C", Offset = "0x1893D8C", VA = "0x1893D8C")]
    private void OnClickItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6014735")]
    [Address(RVA = "0x1893DD4", Offset = "0x1893DD4", VA = "0x1893DD4")]
    private void CloseItemDetailPopup()
    {
    }

    [Token(Token = "0x6014736")]
    [Address(RVA = "0x188D308", Offset = "0x188D308", VA = "0x188D308")]
    public void InteractableButton(bool sw)
    {
    }

    [Token(Token = "0x6014737")]
    [Address(RVA = "0x1893DE8", Offset = "0x1893DE8", VA = "0x1893DE8")]
    public QuestStageSelectScene()
    {
    }

    [Token(Token = "0x2003406")]
    private enum EnumInfoChangeAnim
    {
      [Token(Token = "0x400E24C")] Non,
      [Token(Token = "0x400E24D")] Prev,
      [Token(Token = "0x400E24E")] Next,
    }

    [Token(Token = "0x2003407")]
    private class QuestGroupInfo
    {
      [Token(Token = "0x400E24F")]
      [FieldOffset(Offset = "0x10")]
      private QuestInfo[] difficultyInfo;
      [Token(Token = "0x400E250")]
      [FieldOffset(Offset = "0x18")]
      private int[] listIdx;
      [Token(Token = "0x400E251")]
      [FieldOffset(Offset = "0x20")]
      public int groupId;

      [Token(Token = "0x601473A")]
      [Address(RVA = "0x1893EC4", Offset = "0x1893EC4", VA = "0x1893EC4")]
      public QuestGroupInfo(int groupID = 0)
      {
      }

      [Token(Token = "0x1700441D")]
      public QuestDifficultyTypeEnum Difficulty
      {
        [Token(Token = "0x601473B"), Address(RVA = "0x1893F5C", Offset = "0x1893F5C", VA = "0x1893F5C")] get
        {
          return new QuestDifficultyTypeEnum();
        }
        [Token(Token = "0x601473C"), Address(RVA = "0x1893F64", Offset = "0x1893F64", VA = "0x1893F64")] set
        {
        }
      }

      [Token(Token = "0x601473D")]
      [Address(RVA = "0x1893F6C", Offset = "0x1893F6C", VA = "0x1893F6C")]
      public void Set(int idx, QuestInfo info, QuestDifficultyTypeEnum difficulty)
      {
      }

      [Token(Token = "0x601473E")]
      [Address(RVA = "0x1893FF8", Offset = "0x1893FF8", VA = "0x1893FF8")]
      public void InitDifficulty()
      {
      }

      [Token(Token = "0x601473F")]
      [Address(RVA = "0x18933EC", Offset = "0x18933EC", VA = "0x18933EC")]
      public int GetListIdx() => new int();

      [Token(Token = "0x6014740")]
      [Address(RVA = "0x1892A10", Offset = "0x1892A10", VA = "0x1892A10")]
      public QuestInfo GetQuest() => (QuestInfo) null;

      [Token(Token = "0x6014741")]
      [Address(RVA = "0x18940A8", Offset = "0x18940A8", VA = "0x18940A8")]
      public bool IsDifficultyQuest(QuestDifficultyTypeEnum difficulty) => new bool();

      [Token(Token = "0x6014742")]
      [Address(RVA = "0x1893440", Offset = "0x1893440", VA = "0x1893440")]
      public bool IsLockDifficulty(QuestDifficultyTypeEnum difficulty) => new bool();

      [Token(Token = "0x6014743")]
      [Address(RVA = "0x18940E4", Offset = "0x18940E4", VA = "0x18940E4")]
      private QuestDifficultyTypeEnum GetDefaultDifficulty() => new QuestDifficultyTypeEnum();

      [Token(Token = "0x6014744")]
      [Address(RVA = "0x1894198", Offset = "0x1894198", VA = "0x1894198")]
      public bool IsQuest(int questId) => new bool();
    }
  }
}

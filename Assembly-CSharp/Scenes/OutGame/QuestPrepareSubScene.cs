// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.QuestPrepareSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Scene;
using Il2CppDummyDll;
using Scenes.OutGame.APRecovery;
using Scenes.OutGame.Common;
using Scenes.OutGame.LimitedEventQuest;
using Scenes.OutGame.OutGameMenu;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using TeamOrganization;
using TMPro;
using UI;
using UI.Utilities.SerializeUI;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003248")]
  public class QuestPrepareSubScene : SubScene
  {
    [Token(Token = "0x400D6D8")]
    public const string TweenViewPopupIn = "Popup_In";
    [Token(Token = "0x400D6D9")]
    public const string TweenViewPopupOut = "Popup_Out";
    [Token(Token = "0x400D6DA")]
    private const string ASSET_BUNDLE_LOSTREVIVELIST = "ui_page_characterlist";
    [Token(Token = "0x400D6DB")]
    private const string ASSET_LOSTREVIVELIST = "Com_Popup_Base_L_Lost_List";
    [Token(Token = "0x400D6DC")]
    private const string PARTY_SLOT_SPRITE_NAME = "Img_Num_UnitNumber_{0}";
    [Token(Token = "0x400D6DD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    protected RectTransform root;
    [Token(Token = "0x400D6DE")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    protected AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400D6DF")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    protected GameObject[] consumeApObjects;
    [Token(Token = "0x400D6E0")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    protected Text questName;
    [Token(Token = "0x400D6E1")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    protected TextMeshProUGUI memberLimit;
    [Token(Token = "0x400D6E2")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private TextMeshProUGUI memberLimitMax;
    [Token(Token = "0x400D6E3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    protected TextMeshProUGUI guestMenberNum;
    [Token(Token = "0x400D6E4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    protected GameObject guestTitleObj;
    [Token(Token = "0x400D6E5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    protected TextMeshProUGUI guestOnlyPower;
    [Token(Token = "0x400D6E6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    protected GameObject supportObject;
    [Token(Token = "0x400D6E7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    protected GameObject nonSupportObject;
    [Token(Token = "0x400D6E8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    protected TextMeshProUGUI supportOnlyPower;
    [Token(Token = "0x400D6E9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    protected GameObject supportAndTeamPowerObj;
    [Token(Token = "0x400D6EA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    protected GameObject teamOnlyPowerObj;
    [Token(Token = "0x400D6EB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Image noTenValue;
    [Token(Token = "0x400D6EC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Image noValue;
    [Token(Token = "0x400D6ED")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private TextMeshProUGUI partyNameText;
    [Token(Token = "0x400D6EE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private TextMeshProUGUI partyAiText;
    [Token(Token = "0x400D6EF")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    protected TextMeshProUGUI totalPowerText;
    [Token(Token = "0x400D6F0")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    protected TextMeshProUGUI allMemberTotalPowerText;
    [Token(Token = "0x400D6F1")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private TextMeshProUGUI recommendationTotalPowerText;
    [Token(Token = "0x400D6F2")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private string battleSceneName;
    [Token(Token = "0x400D6F3")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    protected GameObject totalPowerAlert;
    [Token(Token = "0x400D6F4")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    protected GameObject understaffedIcon;
    [Token(Token = "0x400D6F5")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    protected GameObject lpRecoverButton;
    [Token(Token = "0x400D6F6")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private GameObject[] partyChangeLeftIcons;
    [Token(Token = "0x400D6F7")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private GameObject[] partyChangeRightIcons;
    [Token(Token = "0x400D6F8")]
    [FieldOffset(Offset = "0x130")]
    [SerializeField]
    private TextMeshProUGUI partyIndexName;
    [Token(Token = "0x400D6F9")]
    [FieldOffset(Offset = "0x138")]
    [SerializeField]
    protected PartyStyleManager partyStyleManager;
    [Token(Token = "0x400D6FA")]
    [FieldOffset(Offset = "0x140")]
    [SerializeField]
    protected PartyItemManager partyItemManager;
    [Token(Token = "0x400D6FB")]
    [FieldOffset(Offset = "0x148")]
    [SerializeField]
    protected QuestPrepareAssetLoader assetLoader;
    [Token(Token = "0x400D6FC")]
    [FieldOffset(Offset = "0x150")]
    [SerializeField]
    protected QuestPrepareAnimation questPrepareAnimation;
    [Token(Token = "0x400D6FD")]
    [FieldOffset(Offset = "0x158")]
    [SerializeField]
    protected GameObject sortieRestrictionsButton;
    [Token(Token = "0x400D6FE")]
    [FieldOffset(Offset = "0x160")]
    [SerializeField]
    protected CommonButton questDetailButton;
    [Token(Token = "0x400D6FF")]
    [FieldOffset(Offset = "0x168")]
    [SerializeField]
    private DotArrayView missionStatusView;
    [Token(Token = "0x400D700")]
    [FieldOffset(Offset = "0x170")]
    [SerializeField]
    private CommonButton itemEditButton;
    [Token(Token = "0x400D701")]
    [FieldOffset(Offset = "0x178")]
    [SerializeField]
    private GameObject rejectItemObj;
    [Token(Token = "0x400D702")]
    [FieldOffset(Offset = "0x180")]
    [SerializeField]
    private ApRecoveryHeader _apHeader;
    [Token(Token = "0x400D703")]
    [FieldOffset(Offset = "0x188")]
    [SerializeField]
    protected GameObject factorShiftObj;
    [Token(Token = "0x400D704")]
    [FieldOffset(Offset = "0x190")]
    [SerializeField]
    private TextMeshProUGUI factorShiftNowValueText;
    [Token(Token = "0x400D705")]
    [FieldOffset(Offset = "0x198")]
    [SerializeField]
    private TextMeshProUGUI factorShiftMaxValueText;
    [Token(Token = "0x400D706")]
    [FieldOffset(Offset = "0x1A0")]
    [SerializeField]
    protected ElementIconView advantageElementIcon;
    [Token(Token = "0x400D707")]
    [FieldOffset(Offset = "0x1A8")]
    [SerializeField]
    private ActiveObjectContainers consumeCostTypeRelatedObjects;
    [Token(Token = "0x400D708")]
    [FieldOffset(Offset = "0x1B0")]
    [SerializeField]
    private StaminaItemPopUpButton staminaItemPopUpButton;
    [Token(Token = "0x400D709")]
    [FieldOffset(Offset = "0x1B8")]
    [SerializeField]
    private GameObject challengeCountObject;
    [Token(Token = "0x400D70A")]
    [FieldOffset(Offset = "0x1C0")]
    [SerializeField]
    private TextMeshProUGUI challengeCountNowValueText;
    [Token(Token = "0x400D70B")]
    [FieldOffset(Offset = "0x1C8")]
    [SerializeField]
    private TextMeshProUGUI challengeCountMaxValueText;
    [Token(Token = "0x400D70C")]
    [FieldOffset(Offset = "0x1D0")]
    [SerializeField]
    private GameObject fleeApCountObject;
    [Token(Token = "0x400D70D")]
    [FieldOffset(Offset = "0x1D8")]
    [SerializeField]
    private TextMeshProUGUI fleeApCountNowValueText;
    [Token(Token = "0x400D70E")]
    [FieldOffset(Offset = "0x1E0")]
    [SerializeField]
    private TextMeshProUGUI fleeApCountMaxValueText;
    [Token(Token = "0x400D70F")]
    [FieldOffset(Offset = "0x1E8")]
    [SerializeField]
    private RectTransform unitScrollContentRect;
    [Token(Token = "0x400D710")]
    [FieldOffset(Offset = "0x1F0")]
    [SerializeField]
    private RectTransform dotScrollContentRect;
    [Token(Token = "0x400D711")]
    [FieldOffset(Offset = "0x1F8")]
    [SerializeField]
    private GameObject teamSizeTypeObj;
    [Token(Token = "0x400D712")]
    [FieldOffset(Offset = "0x200")]
    [SerializeField]
    private TextMeshProUGUI teamSizeTypeText;
    [Token(Token = "0x400D713")]
    [FieldOffset(Offset = "0x208")]
    [SerializeField]
    private CommonButton teamSelectionButton;
    [Token(Token = "0x400D714")]
    [FieldOffset(Offset = "0x210")]
    [SerializeField]
    private GameObject questSkipObject;
    [Token(Token = "0x400D715")]
    [FieldOffset(Offset = "0x218")]
    [SerializeField]
    private CommonButton questSkipIncreaseButton;
    [Token(Token = "0x400D716")]
    [FieldOffset(Offset = "0x220")]
    [SerializeField]
    private CommonButton questSkipReduceButton;
    [Token(Token = "0x400D717")]
    [FieldOffset(Offset = "0x228")]
    [SerializeField]
    private TextMeshProUGUI questSkipText;
    [Token(Token = "0x400D718")]
    [FieldOffset(Offset = "0x230")]
    [SerializeField]
    private GameObject consumeApContainer;
    [Token(Token = "0x400D719")]
    [FieldOffset(Offset = "0x238")]
    [SerializeField]
    private GameObject sortieReadyObj;
    [Token(Token = "0x400D71A")]
    [FieldOffset(Offset = "0x240")]
    [SerializeField]
    private CommonButton sortieReadyButton;
    [Token(Token = "0x400D71B")]
    [FieldOffset(Offset = "0x248")]
    [SerializeField]
    private GameObject sortieNotReadyObj;
    [Token(Token = "0x400D71C")]
    [FieldOffset(Offset = "0x250")]
    [SerializeField]
    private CommonButton sortieNotReadyButton;
    [Token(Token = "0x400D71D")]
    [FieldOffset(Offset = "0x258")]
    [SerializeField]
    private GameObject difficultyIconObj;
    [Token(Token = "0x400D71E")]
    [FieldOffset(Offset = "0x260")]
    protected int deckIndex;
    [Token(Token = "0x400D71F")]
    [FieldOffset(Offset = "0x268")]
    protected BattleConfigPopup battleConfigPopup;
    [Token(Token = "0x400D720")]
    [FieldOffset(Offset = "0x270")]
    private QuestDetailPopup questDetailPopup;
    [Token(Token = "0x400D721")]
    [FieldOffset(Offset = "0x278")]
    protected SortieLimitPopup sortieLimitPopup;
    [Token(Token = "0x400D722")]
    [FieldOffset(Offset = "0x280")]
    private TeamSelectionPopup teamSelectionPopup;
    [Token(Token = "0x400D723")]
    [FieldOffset(Offset = "0x288")]
    private QuestInfo questInfo;
    [Token(Token = "0x400D724")]
    [FieldOffset(Offset = "0x290")]
    private PartyAIView partyAIView;
    [Token(Token = "0x400D725")]
    [FieldOffset(Offset = "0x298")]
    private PartySkillPopup partySkillPopup;
    [Token(Token = "0x400D726")]
    [FieldOffset(Offset = "0x2A0")]
    protected DeckTypeEnum deckType;
    [Token(Token = "0x400D727")]
    [FieldOffset(Offset = "0x2A4")]
    protected bool isLoading;
    [Token(Token = "0x400D728")]
    [FieldOffset(Offset = "0x2A5")]
    protected bool needFadeOnInitialize;
    [Token(Token = "0x400D729")]
    [FieldOffset(Offset = "0x2A8")]
    private int questSkipMaxCount;
    [Token(Token = "0x400D72A")]
    [FieldOffset(Offset = "0x2AC")]
    private int questSkipCount;
    [Token(Token = "0x400D72B")]
    [FieldOffset(Offset = "0x2B0")]
    private bool useApQuest;
    [Token(Token = "0x400D72C")]
    [FieldOffset(Offset = "0x2B1")]
    private bool isOpenPartyFormationScene;
    [Token(Token = "0x400D72D")]
    [FieldOffset(Offset = "0x2B2")]
    private bool isOpenPartySelect;
    [Token(Token = "0x400D72E")]
    [FieldOffset(Offset = "0x2B3")]
    private bool isCallBattleStart;
    [Token(Token = "0x400D72F")]
    [FieldOffset(Offset = "0x2B4")]
    private bool isCallQuestSkip;
    [Token(Token = "0x400D730")]
    [FieldOffset(Offset = "0x2B5")]
    private bool isCallBackScene;
    [Token(Token = "0x400D731")]
    [FieldOffset(Offset = "0x2B6")]
    private bool isGuildRaid;
    [Token(Token = "0x400D732")]
    [FieldOffset(Offset = "0x2B8")]
    private List<string> usedStyleIds;
    [Token(Token = "0x400D733")]
    [FieldOffset(Offset = "0x2C0")]
    private bool isMock;

    [Token(Token = "0x6013996")]
    [Address(RVA = "0x4612410", Offset = "0x4612410", VA = "0x4612410")]
    public static void ChangeScene(QuestTypeEnum questType, int questId, bool needFade = false)
    {
    }

    [Token(Token = "0x6013997")]
    [Address(RVA = "0x46125C8", Offset = "0x46125C8", VA = "0x46125C8")]
    public static void ChangeScene(
      QuestTypeEnum questType,
      int questId,
      int areaQuestNodeId,
      bool needFade = false)
    {
    }

    [Token(Token = "0x6013998")]
    [Address(RVA = "0x46126F0", Offset = "0x46126F0", VA = "0x46126F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6013999")]
    [Address(RVA = "0x4612844", Offset = "0x4612844", VA = "0x4612844")]
    protected void BaseInitialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601399A")]
    [Address(RVA = "0x461284C", Offset = "0x461284C", VA = "0x461284C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x601399B")]
    [Address(RVA = "0x4613C54", Offset = "0x4613C54", VA = "0x4613C54")]
    private bool IsHard() => new bool();

    [Token(Token = "0x601399C")]
    [Address(RVA = "0x46138F4", Offset = "0x46138F4", VA = "0x46138F4")]
    private int GetMaxSkipCount() => new int();

    [Token(Token = "0x601399D")]
    [Address(RVA = "0x46138D8", Offset = "0x46138D8", VA = "0x46138D8")]
    private DeckTypeEnum GetDeckType() => new DeckTypeEnum();

    [Token(Token = "0x601399E")]
    [Address(RVA = "0x4613B20", Offset = "0x4613B20", VA = "0x4613B20")]
    protected void SetMissionStatus(bool[] completeFlags)
    {
    }

    [Token(Token = "0x601399F")]
    [Address(RVA = "0x46140C4", Offset = "0x46140C4", VA = "0x46140C4", Slot = "32")]
    protected virtual void CreateBg()
    {
    }

    [Token(Token = "0x60139A0")]
    [Address(RVA = "0x46141BC", Offset = "0x46141BC", VA = "0x46141BC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x60139A1")]
    [Address(RVA = "0x461424C", Offset = "0x461424C", VA = "0x461424C")]
    private void Update()
    {
    }

    [Token(Token = "0x60139A2")]
    [Address(RVA = "0x461428C", Offset = "0x461428C", VA = "0x461428C", Slot = "22")]
    public override IEnumerator DisableEffect() => (IEnumerator) null;

    [Token(Token = "0x60139A3")]
    [Address(RVA = "0x461431C", Offset = "0x461431C", VA = "0x461431C", Slot = "33")]
    public virtual void UpdateView()
    {
    }

    [Token(Token = "0x60139A4")]
    [Address(RVA = "0x4614510", Offset = "0x4614510", VA = "0x4614510")]
    private int GetNowCostAp() => new int();

    [Token(Token = "0x60139A5")]
    [Address(RVA = "0x46145EC", Offset = "0x46145EC", VA = "0x46145EC")]
    private void SetActiveByLpRecoverButton()
    {
    }

    [Token(Token = "0x60139A6")]
    [Address(RVA = "0x4614624", Offset = "0x4614624", VA = "0x4614624", Slot = "34")]
    protected virtual void UpdateMemberLimitText()
    {
    }

    [Token(Token = "0x60139A7")]
    [Address(RVA = "0x46146D4", Offset = "0x46146D4", VA = "0x46146D4")]
    protected Decks GetCurrectSelectDecks() => (Decks) null;

    [Token(Token = "0x60139A8")]
    [Address(RVA = "0x46147D8", Offset = "0x46147D8", VA = "0x46147D8", Slot = "35")]
    public virtual void OnClickLeftArrow()
    {
    }

    [Token(Token = "0x60139A9")]
    [Address(RVA = "0x46148E0", Offset = "0x46148E0", VA = "0x46148E0", Slot = "36")]
    public virtual void OnClickRightArrow()
    {
    }

    [Token(Token = "0x60139AA")]
    [Address(RVA = "0x46149E8", Offset = "0x46149E8", VA = "0x46149E8")]
    protected void ChangePartyIndexName()
    {
    }

    [Token(Token = "0x60139AB")]
    [Address(RVA = "0x4614BC4", Offset = "0x4614BC4", VA = "0x4614BC4")]
    protected void UpdataPartyName()
    {
    }

    [Token(Token = "0x60139AC")]
    [Address(RVA = "0x4614C04", Offset = "0x4614C04", VA = "0x4614C04")]
    protected void UpdataPartyAIName()
    {
    }

    [Token(Token = "0x60139AD")]
    [Address(RVA = "0x4614C60", Offset = "0x4614C60", VA = "0x4614C60", Slot = "37")]
    protected virtual void UpdateTotalPower()
    {
    }

    [Token(Token = "0x60139AE")]
    [Address(RVA = "0x4614D84", Offset = "0x4614D84", VA = "0x4614D84", Slot = "38")]
    protected virtual void UpdatePartyChange()
    {
    }

    [Token(Token = "0x60139AF")]
    [Address(RVA = "0x4614F08", Offset = "0x4614F08", VA = "0x4614F08")]
    private void UpdateSortieButton()
    {
    }

    [Token(Token = "0x60139B0")]
    [Address(RVA = "0x4614E38", Offset = "0x4614E38", VA = "0x4614E38")]
    protected void SetActiveLeftArrowObject(bool isActive)
    {
    }

    [Token(Token = "0x60139B1")]
    [Address(RVA = "0x4614EA0", Offset = "0x4614EA0", VA = "0x4614EA0")]
    protected void SetActiveRightArrowObject(bool isActive)
    {
    }

    [Token(Token = "0x60139B2")]
    [Address(RVA = "0x4614F74", Offset = "0x4614F74", VA = "0x4614F74")]
    protected void PlayAlert(string text)
    {
    }

    [Token(Token = "0x60139B3")]
    [Address(RVA = "0x4614FF8", Offset = "0x4614FF8", VA = "0x4614FF8")]
    public void OnClickBackButton()
    {
    }

    [Token(Token = "0x60139B4")]
    [Address(RVA = "0x46150C0", Offset = "0x46150C0", VA = "0x46150C0", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x60139B5")]
    [Address(RVA = "0x4615214", Offset = "0x4615214", VA = "0x4615214", Slot = "39")]
    public virtual void OtherUpdate()
    {
    }

    [Token(Token = "0x60139B6")]
    [Address(RVA = "0x461531C", Offset = "0x461531C", VA = "0x461531C")]
    private void OpenObliviaeFirstAttackPopup(Action startBattleAction)
    {
    }

    [Token(Token = "0x60139B7")]
    [Address(RVA = "0x4615724", Offset = "0x4615724", VA = "0x4615724")]
    public void OnClickBattleItemSettings()
    {
    }

    [Token(Token = "0x60139B8")]
    [Address(RVA = "0x4615748", Offset = "0x4615748", VA = "0x4615748")]
    public void OnClickPartySkill()
    {
    }

    [Token(Token = "0x60139B9")]
    [Address(RVA = "0x4615A1C", Offset = "0x4615A1C", VA = "0x4615A1C")]
    private IEnumerator WaitPopupAnimation(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x60139BA")]
    [Address(RVA = "0x4615AAC", Offset = "0x4615AAC", VA = "0x4615AAC")]
    private IEnumerator OnClickPartyAIInternal() => (IEnumerator) null;

    [Token(Token = "0x60139BB")]
    [Address(RVA = "0x4615B3C", Offset = "0x4615B3C", VA = "0x4615B3C")]
    public void OnClickPartyAI()
    {
    }

    [Token(Token = "0x60139BC")]
    [Address(RVA = "0x4615B5C", Offset = "0x4615B5C", VA = "0x4615B5C", Slot = "40")]
    public virtual void OnClickToBattleConfig()
    {
    }

    [Token(Token = "0x60139BD")]
    [Address(RVA = "0x4615E04", Offset = "0x4615E04", VA = "0x4615E04")]
    public void OnClickToAutoEdit()
    {
    }

    [Token(Token = "0x60139BE")]
    [Address(RVA = "0x4615FA8", Offset = "0x4615FA8", VA = "0x4615FA8")]
    public void OnClickToRecoverLp()
    {
    }

    [Token(Token = "0x60139BF")]
    [Address(RVA = "0x4615FB0", Offset = "0x4615FB0", VA = "0x4615FB0")]
    public void OnClickToPartyEdit()
    {
    }

    [Token(Token = "0x60139C0")]
    [Address(RVA = "0x461618C", Offset = "0x461618C", VA = "0x461618C")]
    public void OnClickToGlobalMenu()
    {
    }

    [Token(Token = "0x60139C1")]
    [Address(RVA = "0x4616250", Offset = "0x4616250", VA = "0x4616250")]
    public void OnClickToSortieLimitPopup()
    {
    }

    [Token(Token = "0x60139C2")]
    [Address(RVA = "0x46165C8", Offset = "0x46165C8", VA = "0x46165C8")]
    protected IEnumerator ConnectAPIDeckAISetting(OrganizationTeam team) => (IEnumerator) null;

    [Token(Token = "0x60139C3")]
    [Address(RVA = "0x4616664", Offset = "0x4616664", VA = "0x4616664")]
    private void OnFinishConnect()
    {
    }

    [Token(Token = "0x60139C4")]
    [Address(RVA = "0x4616670", Offset = "0x4616670", VA = "0x4616670")]
    public void OnClickToBattleStart()
    {
    }

    [Token(Token = "0x60139C5")]
    [Address(RVA = "0x4616820", Offset = "0x4616820", VA = "0x4616820")]
    private void CallBattleStartCoroutine(Action<string> onError)
    {
    }

    [Token(Token = "0x60139C6")]
    [Address(RVA = "0x4616840", Offset = "0x4616840", VA = "0x4616840")]
    private IEnumerator CallBattleStart(Action<string> onError) => (IEnumerator) null;

    [Token(Token = "0x60139C7")]
    [Address(RVA = "0x46168D0", Offset = "0x46168D0", VA = "0x46168D0")]
    protected IEnumerator SetLostReviveList(List<Character> chrDataList) => (IEnumerator) null;

    [Token(Token = "0x60139C8")]
    [Address(RVA = "0x461696C", Offset = "0x461696C", VA = "0x461696C")]
    private IEnumerator OpenQuestDetailPopup() => (IEnumerator) null;

    [Token(Token = "0x60139C9")]
    [Address(RVA = "0x46169FC", Offset = "0x46169FC", VA = "0x46169FC")]
    private IEnumerator OpenTeamSelectionPopup() => (IEnumerator) null;

    [Token(Token = "0x60139CA")]
    [Address(RVA = "0x4616A8C", Offset = "0x4616A8C", VA = "0x4616A8C")]
    public void OnIncreaseQuestSkipCountButton()
    {
    }

    [Token(Token = "0x60139CB")]
    [Address(RVA = "0x4616AA8", Offset = "0x4616AA8", VA = "0x4616AA8")]
    public void OnReduceQuestSkipCountButton()
    {
    }

    [Token(Token = "0x60139CC")]
    [Address(RVA = "0x4616AC8", Offset = "0x4616AC8", VA = "0x4616AC8")]
    public void OnQuestSkipButton()
    {
    }

    [Token(Token = "0x60139CD")]
    [Address(RVA = "0x46139F8", Offset = "0x46139F8", VA = "0x46139F8")]
    private void UpdateQuestSkip()
    {
    }

    [Token(Token = "0x60139CE")]
    [Address(RVA = "0x4616BA8", Offset = "0x4616BA8", VA = "0x4616BA8")]
    public void QuestSkip(int skipCount)
    {
    }

    [Token(Token = "0x60139CF")]
    [Address(RVA = "0x4616C20", Offset = "0x4616C20", VA = "0x4616C20")]
    public QuestPrepareSubScene()
    {
    }
  }
}

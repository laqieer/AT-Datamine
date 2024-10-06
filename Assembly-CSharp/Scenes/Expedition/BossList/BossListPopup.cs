// Decompiled with JetBrains decompiler
// Type: Scenes.Expedition.BossList.BossListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.Expedition.BossList.BossDeck;
using Scenes.Expedition.BossList.BossDetail;
using Scenes.Expedition.Main;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.Expedition.BossList
{
  [Token(Token = "0x2002D10")]
  public class BossListPopup : PopupBase
  {
    [Token(Token = "0x400C13B")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton closeButton;
    [Token(Token = "0x400C13C")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton editButton;
    [Token(Token = "0x400C13D")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton bossKillButton;
    [Token(Token = "0x400C13E")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text todayChallengeCount;
    [Token(Token = "0x400C13F")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text todayChallengeMax;
    [Token(Token = "0x400C140")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Image bossImage;
    [Token(Token = "0x400C141")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text bossLevelText;
    [Token(Token = "0x400C142")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text bossStatusText;
    [Token(Token = "0x400C143")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private BossListSideMenuList bossListSideMenuList;
    [Token(Token = "0x400C144")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private RectTransform bossListElementParent;
    [Token(Token = "0x400C145")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private BossListElement bossListElement;
    [Token(Token = "0x400C146")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400C147")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CanvasGroup contents;
    [Token(Token = "0x400C148")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CanvasGroup objDetailRight;
    [Token(Token = "0x400C149")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private CanvasGroup objDetailCenter;
    [Token(Token = "0x400C14A")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private CommonButton detailCloseButton;
    [Token(Token = "0x400C14B")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    private BossDetailElementList bossDetailElementList;
    [Token(Token = "0x400C14C")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    private BossDeckView deckView;
    [Token(Token = "0x400C14D")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    private CommonButton pararaButton;
    [Token(Token = "0x400C14E")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    private CommonButton detailButton;
    [Token(Token = "0x400C14F")]
    [FieldOffset(Offset = "0x128")]
    [SerializeField]
    private VerticalInfiniteScrollView infiniteScrollView;
    [Token(Token = "0x400C150")]
    [FieldOffset(Offset = "0x130")]
    private List<BossListElement.Parameter> bossListElementList;
    [Token(Token = "0x400C151")]
    [FieldOffset(Offset = "0x138")]
    private Color levelColor;
    [Token(Token = "0x400C152")]
    [FieldOffset(Offset = "0x148")]
    private Color coolTimeColor;
    [Token(Token = "0x400C154")]
    [FieldOffset(Offset = "0x160")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400C155")]
    [FieldOffset(Offset = "0x168")]
    private List<PlayerExpeditionStageType> stageTypeList;
    [Token(Token = "0x400C156")]
    [FieldOffset(Offset = "0x170")]
    private int remainChallengeCount;
    [Token(Token = "0x400C157")]
    [FieldOffset(Offset = "0x174")]
    private BossListPopup.RunType runType;
    [Token(Token = "0x400C158")]
    [FieldOffset(Offset = "0x178")]
    private ExpeditionTopScene subSceneExpeditionTop;
    [Token(Token = "0x400C159")]
    [FieldOffset(Offset = "0x180")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400C15A")]
    [FieldOffset(Offset = "0x188")]
    private ExpeditionBossDescriptionData currentExpeditionBossDescription;
    [Token(Token = "0x400C15B")]
    [FieldOffset(Offset = "0x190")]
    private Action<int> OnUpdateTotalCombat;
    [Token(Token = "0x400C15C")]
    [FieldOffset(Offset = "0x198")]
    private Action<int> OnUpdateChallengeBadge;
    [Token(Token = "0x400C15D")]
    [FieldOffset(Offset = "0x1A0")]
    private PopupHandle handleMaxPararaWarnPopup;

    [Token(Token = "0x17003C78")]
    public Action CallbackBossKill
    {
      [Token(Token = "0x6011A27"), Address(RVA = "0x46AD8C0", Offset = "0x46AD8C0", VA = "0x46AD8C0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011A28"), Address(RVA = "0x46AD8C8", Offset = "0x46AD8C8", VA = "0x46AD8C8")] set
      {
      }
    }

    [Token(Token = "0x17003C79")]
    private int SideMenuStageId
    {
      [Token(Token = "0x6011A29"), Address(RVA = "0x46AD8D0", Offset = "0x46AD8D0", VA = "0x46AD8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6011A2A")]
    [Address(RVA = "0x46AD8EC", Offset = "0x46AD8EC", VA = "0x46AD8EC")]
    private void Awake()
    {
    }

    [Token(Token = "0x6011A2B")]
    [Address(RVA = "0x469EFB4", Offset = "0x469EFB4", VA = "0x469EFB4")]
    public IEnumerator InitializeAsync(
      List<PlayerExpeditionStageType> stageTypeList,
      PlayerExpeditionType playerExpedition,
      AssetCachedSpawner assetCachedSpawner,
      ExpeditionTopScene subSceneExpeditionTop,
      int? selectStage = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011A2C")]
    [Address(RVA = "0x46AD998", Offset = "0x46AD998", VA = "0x46AD998", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6011A2D")]
    [Address(RVA = "0x46ADA28", Offset = "0x46ADA28", VA = "0x46ADA28")]
    public void Back()
    {
    }

    [Token(Token = "0x6011A2E")]
    [Address(RVA = "0x46ADAAC", Offset = "0x46ADAAC", VA = "0x46ADAAC")]
    private bool ChangeRunType(BossListPopup.RunType tRun) => new bool();

    [Token(Token = "0x6011A2F")]
    [Address(RVA = "0x46ADACC", Offset = "0x46ADACC", VA = "0x46ADACC")]
    private void ResetRunType(BossListPopup.RunType tRun = BossListPopup.RunType.None)
    {
    }

    [Token(Token = "0x6011A30")]
    [Address(RVA = "0x46ADAD4", Offset = "0x46ADAD4", VA = "0x46ADAD4")]
    private void InitBossList(
      List<PlayerExpeditionStageType> stageTypeList,
      PlayerExpeditionType playerExpedition)
    {
    }

    [Token(Token = "0x6011A31")]
    [Address(RVA = "0x46ADC7C", Offset = "0x46ADC7C", VA = "0x46ADC7C")]
    private void OnBossListSideMenu(int stageId)
    {
    }

    [Token(Token = "0x6011A32")]
    [Address(RVA = "0x46AE1B8", Offset = "0x46AE1B8", VA = "0x46AE1B8")]
    private void UpdateBossDeckView(int stageId, bool startLoad = false)
    {
    }

    [Token(Token = "0x6011A33")]
    [Address(RVA = "0x46AE758", Offset = "0x46AE758", VA = "0x46AE758")]
    private void ChangeBossImage(int stageId)
    {
    }

    [Token(Token = "0x6011A34")]
    [Address(RVA = "0x46AE8DC", Offset = "0x46AE8DC", VA = "0x46AE8DC")]
    private void SelectSideMenu(int stageId)
    {
    }

    [Token(Token = "0x6011A35")]
    [Address(RVA = "0x46ADECC", Offset = "0x46ADECC", VA = "0x46ADECC")]
    private void SetBossImage(int stageId, int bossLevel)
    {
    }

    [Token(Token = "0x6011A36")]
    [Address(RVA = "0x46ADDDC", Offset = "0x46ADDDC", VA = "0x46ADDDC")]
    private int GetClearBossLevel(int stageId) => new int();

    [Token(Token = "0x6011A37")]
    [Address(RVA = "0x46AEAC8", Offset = "0x46AEAC8", VA = "0x46AEAC8")]
    private int GetChallengeBossLevel(int stageId) => new int();

    [Token(Token = "0x6011A38")]
    [Address(RVA = "0x46AE208", Offset = "0x46AE208", VA = "0x46AE208")]
    private void InitBossListElementList(int stageId)
    {
    }

    [Token(Token = "0x6011A39")]
    [Address(RVA = "0x46AED38", Offset = "0x46AED38", VA = "0x46AED38")]
    private void OnChallengeButton(
      int stageId,
      ExpeditionBossDescriptionData bossDescriptionData,
      bool isChallenge)
    {
    }

    [Token(Token = "0x6011A3A")]
    [Address(RVA = "0x46AF998", Offset = "0x46AF998", VA = "0x46AF998")]
    private IEnumerator ChallengeMaxPararaWarnPopupDeparture(
      int stageId,
      ExpeditionBossDescriptionData bossDescriptionData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011A3B")]
    [Address(RVA = "0x46AEED8", Offset = "0x46AEED8", VA = "0x46AEED8")]
    private bool CheckPararaMaxStyle(int stageId, ExpeditionBossDescriptionData bossDescriptionData)
    {
      return new bool();
    }

    [Token(Token = "0x6011A3C")]
    [Address(RVA = "0x46AF1F4", Offset = "0x46AF1F4", VA = "0x46AF1F4")]
    private PopupHandle OpenMaxPararaWarnPopup(Action decideCallback) => (PopupHandle) null;

    [Token(Token = "0x6011A3D")]
    [Address(RVA = "0x46AFA28", Offset = "0x46AFA28", VA = "0x46AFA28")]
    private void OnDetailButton(int stageId)
    {
    }

    [Token(Token = "0x6011A3E")]
    [Address(RVA = "0x46ADA90", Offset = "0x46ADA90", VA = "0x46ADA90")]
    private void CloseDetail()
    {
    }

    [Token(Token = "0x6011A3F")]
    [Address(RVA = "0x46AFD7C", Offset = "0x46AFD7C", VA = "0x46AFD7C")]
    private void OnPararaButton(int stageId, ExpeditionBossDescriptionData bossDescriptionData)
    {
    }

    [Token(Token = "0x6011A40")]
    [Address(RVA = "0x46AFB5C", Offset = "0x46AFB5C", VA = "0x46AFB5C")]
    private void PlayDetailInAnim()
    {
    }

    [Token(Token = "0x6011A41")]
    [Address(RVA = "0x46AFC6C", Offset = "0x46AFC6C", VA = "0x46AFC6C")]
    private void PlayDetailOutAnim()
    {
    }

    [Token(Token = "0x6011A42")]
    [Address(RVA = "0x46ADA74", Offset = "0x46ADA74", VA = "0x46ADA74")]
    private bool GetDetailBlocksRaycasts() => new bool();

    [Token(Token = "0x6011A43")]
    [Address(RVA = "0x46AFB18", Offset = "0x46AFB18", VA = "0x46AFB18")]
    private void SetDetailBlocksRaycasts(bool isEnabled)
    {
    }

    [Token(Token = "0x6011A44")]
    [Address(RVA = "0x46AFEAC", Offset = "0x46AFEAC", VA = "0x46AFEAC")]
    private BossListElement CreateBossListElement() => (BossListElement) null;

    [Token(Token = "0x6011A45")]
    [Address(RVA = "0x46AF5A8", Offset = "0x46AF5A8", VA = "0x46AF5A8")]
    private void RunChallenge(int stageId, ExpeditionBossDescriptionData bossData)
    {
    }

    [Token(Token = "0x6011A46")]
    [Address(RVA = "0x46AFF4C", Offset = "0x46AFF4C", VA = "0x46AFF4C")]
    private IEnumerator GoBossBattle(
      ExpeditionStageData stageData,
      ExpeditionBossDescriptionData bossData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011A47")]
    [Address(RVA = "0x46AFFC8", Offset = "0x46AFFC8", VA = "0x46AFFC8")]
    private void OnBossKillButton()
    {
    }

    [Token(Token = "0x6011A48")]
    [Address(RVA = "0x46AF5EC", Offset = "0x46AF5EC", VA = "0x46AF5EC")]
    private void RunBossKill(int stageId, ExpeditionBossDescriptionData bossData)
    {
    }

    [Token(Token = "0x6011A49")]
    [Address(RVA = "0x46B005C", Offset = "0x46B005C", VA = "0x46B005C")]
    private IEnumerator BossKillCoroutine(
      ExpeditionStageData inputStageData,
      ExpeditionBossDescriptionData inputBossData,
      BossChallengeTypeEnum challengeType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6011A4A")]
    [Address(RVA = "0x46AE01C", Offset = "0x46AE01C", VA = "0x46AE01C")]
    private ExpeditionBossDescriptionData GetCurrentExpeditionBossDescription(
      int stageId,
      int clearBossLevel)
    {
      return (ExpeditionBossDescriptionData) null;
    }

    [Token(Token = "0x6011A4B")]
    [Address(RVA = "0x46AFF44", Offset = "0x46AFF44", VA = "0x46AFF44")]
    private static ExpeditionStageData GetExpeditionStageData(int stageId)
    {
      return (ExpeditionStageData) null;
    }

    [Token(Token = "0x6011A4C")]
    [Address(RVA = "0x46B0110", Offset = "0x46B0110", VA = "0x46B0110")]
    private static ExpeditionStageDescriptionData GetExpeditionStageDescriptionData(
      int stageId,
      int bossLevel)
    {
      return (ExpeditionStageDescriptionData) null;
    }

    [Token(Token = "0x6011A4D")]
    [Address(RVA = "0x46AED20", Offset = "0x46AED20", VA = "0x46AED20")]
    public static List<ExpeditionBossDescriptionData> GetExpeditionBossDescriptionDatas(int stageId)
    {
      return (List<ExpeditionBossDescriptionData>) null;
    }

    [Token(Token = "0x6011A4E")]
    [Address(RVA = "0x46AE8F8", Offset = "0x46AE8F8", VA = "0x46AE8F8")]
    private static ExpeditionBossDescriptionData GetExpeditionBossDescriptionData(
      int stageId,
      int bossLevel)
    {
      return (ExpeditionBossDescriptionData) null;
    }

    [Token(Token = "0x6011A4F")]
    [Address(RVA = "0x46B02E8", Offset = "0x46B02E8", VA = "0x46B02E8")]
    private void OpenOrganization()
    {
    }

    [Token(Token = "0x6011A50")]
    [Address(RVA = "0x46B03E8", Offset = "0x46B03E8", VA = "0x46B03E8")]
    private void UpdateTotalCombat(int totalCombat)
    {
    }

    [Token(Token = "0x6011A51")]
    [Address(RVA = "0x46B0520", Offset = "0x46B0520", VA = "0x46B0520")]
    private void UpdateChallengeBadge(int remainCount)
    {
    }

    [Token(Token = "0x6011A52")]
    [Address(RVA = "0x46B0658", Offset = "0x46B0658", VA = "0x46B0658")]
    public BossListPopup()
    {
    }

    [Token(Token = "0x2002D11")]
    private enum RunType
    {
      [Token(Token = "0x400C15F")] Initialize,
      [Token(Token = "0x400C160")] None,
      [Token(Token = "0x400C161")] DeckEdit,
      [Token(Token = "0x400C162")] Boss,
    }
  }
}

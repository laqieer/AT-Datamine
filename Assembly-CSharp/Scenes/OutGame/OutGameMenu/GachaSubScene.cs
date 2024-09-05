// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GachaSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Gacha;
using GameCore;
using GameCore.Scene;
using GameCore.Tween;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Utility;
using StaqData;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x20039E8")]
  public class GachaSubScene : SubScene
  {
    [Token(Token = "0x400FD5E")]
    public const string SubSceneAssetBundleName = "ui_page_gacha_prefab";
    [Token(Token = "0x400FD5F")]
    public const string SubSceneAssetName = "Com_Gacha_OutFrame";
    [Token(Token = "0x400FD60")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Header("入力制御用")]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400FD61")]
    [FieldOffset(Offset = "0x60")]
    [Tooltip("Tween制御")]
    [Header("アニメーション制御用")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400FD62")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    [Tooltip("タイムライン制御")]
    private UITimelineController timelineController;
    [Token(Token = "0x400FD63")]
    [FieldOffset(Offset = "0x70")]
    [Tooltip("伝晶石")]
    [SerializeField]
    [Header("ヘッダー")]
    private GachaHeaderButtonView coinHeaderView;
    [Token(Token = "0x400FD64")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    [Tooltip("チケット")]
    private GachaHeaderButtonView ticketHeaderView;
    [Token(Token = "0x400FD65")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    [Tooltip("メダル")]
    private GachaHeaderButtonView medalHeaderView;
    [Token(Token = "0x400FD66")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    [Header("ガチャのコンテンツの親")]
    private RectTransform contentRoot;
    [Token(Token = "0x400FD67")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    [Header("ガチャの説明文")]
    private Text textDescription;
    [Token(Token = "0x400FD68")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    [Header("ガチャバナーのリスト")]
    private GachaListView gachaListView;
    [Token(Token = "0x400FD69")]
    [FieldOffset(Offset = "0xA0")]
    [Header("ガチャボタン切り替えタブ")]
    [SerializeField]
    private GachaPayButtonTab gachaPayButtonTab;
    [Token(Token = "0x400FD6A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    [Header("演出スキップ")]
    private Toggle gachaSkipButton;
    [Token(Token = "0x400FD6B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    [Header("ボタン類")]
    [Tooltip("戻るボタン")]
    private Button buttonBack;
    [Token(Token = "0x400FD6C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    [Tooltip("ピックアップボタン")]
    private Button buttonPickup;
    [Token(Token = "0x400FD6D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    [Tooltip("提供割合ボタン")]
    private Button buttonRate;
    [Token(Token = "0x400FD6E")]
    [FieldOffset(Offset = "0xC8")]
    [Tooltip("提供詳細ボタン")]
    [SerializeField]
    private Button buttonDetail;
    [Token(Token = "0x400FD6F")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    [Tooltip("前回の結果ボタン")]
    private Button buttonBeforeResult;
    [Token(Token = "0x400FD70")]
    [FieldOffset(Offset = "0xD8")]
    private GameObject gahcaListItemLimitTimeView;
    [Token(Token = "0x400FD71")]
    [FieldOffset(Offset = "0xE0")]
    private GachaList gachaList;
    [Token(Token = "0x400FD72")]
    [FieldOffset(Offset = "0xE8")]
    private GachaTopView gachaTopView;
    [Token(Token = "0x400FD73")]
    [FieldOffset(Offset = "0xF0")]
    private GachaTop gachaTop;
    [Token(Token = "0x400FD74")]
    [FieldOffset(Offset = "0xF8")]
    private GachaResultView gachaResultView;
    [Token(Token = "0x400FD75")]
    [FieldOffset(Offset = "0x100")]
    private GachaResult gachaResult;
    [Token(Token = "0x400FD76")]
    [FieldOffset(Offset = "0x108")]
    private StoryGachaTop storyGachaTop;
    [Token(Token = "0x400FD77")]
    [FieldOffset(Offset = "0x110")]
    private SelectGachaTopView selectGachaTopView;
    [Token(Token = "0x400FD78")]
    [FieldOffset(Offset = "0x118")]
    private SelectGachaTop selectGachaTop;
    [Token(Token = "0x400FD79")]
    [FieldOffset(Offset = "0x120")]
    private GachaMainModel mainModel;
    [Token(Token = "0x400FD7A")]
    [FieldOffset(Offset = "0x128")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400FD7B")]
    [FieldOffset(Offset = "0x130")]
    private GachaBonusRewardPopup gachaBonusRewardPopup;
    [Token(Token = "0x400FD7C")]
    [FieldOffset(Offset = "0x138")]
    private List<Reward> UnreceivedRewards;
    [Token(Token = "0x400FD7D")]
    [FieldOffset(Offset = "0x140")]
    private GachaResourceProvider resourceProvider;
    [Token(Token = "0x400FD7E")]
    [FieldOffset(Offset = "0x148")]
    private GachaHeaderInfo headerInfo;
    [Token(Token = "0x400FD7F")]
    [FieldOffset(Offset = "0x150")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400FD80")]
    [FieldOffset(Offset = "0x158")]
    private int? firstViewGachaNumber;
    [Token(Token = "0x400FD81")]
    [FieldOffset(Offset = "0x160")]
    private Action<bool> InteractableChanged;
    [Token(Token = "0x400FD82")]
    [FieldOffset(Offset = "0x168")]
    private GachaPlayback gachaPlayback;
    [Token(Token = "0x400FD83")]
    [FieldOffset(Offset = "0x170")]
    private int currentGachaIndex;
    [Token(Token = "0x400FD84")]
    [FieldOffset(Offset = "0x174")]
    private bool hasPickup;
    [Token(Token = "0x400FD85")]
    [FieldOffset(Offset = "0x178")]
    private NewBadgeProxy newBadgeProxy;
    [Token(Token = "0x400FD86")]
    [FieldOffset(Offset = "0x180")]
    private bool isLoadingGacha;

    [Token(Token = "0x17004ABA")]
    private Transform uiRoot
    {
      [Token(Token = "0x6016BD0"), Address(RVA = "0x3F6FFDC", Offset = "0x3F6FFDC", VA = "0x3F6FFDC")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x6016BD1")]
    [Address(RVA = "0x3F6FFE4", Offset = "0x3F6FFE4", VA = "0x3F6FFE4")]
    private bool IsTutorialGacha() => new bool();

    [Token(Token = "0x6016BD2")]
    [Address(RVA = "0x3F7007C", Offset = "0x3F7007C", VA = "0x3F7007C", Slot = "6")]
    public override void Initialize(ChangeSceneParameter param = null)
    {
    }

    [Token(Token = "0x6016BD3")]
    [Address(RVA = "0x3F7014C", Offset = "0x3F7014C", VA = "0x3F7014C", Slot = "8")]
    public override void Disable()
    {
    }

    [Token(Token = "0x6016BD4")]
    [Address(RVA = "0x3F70174", Offset = "0x3F70174", VA = "0x3F70174", Slot = "9")]
    public override void Destroy()
    {
    }

    [Token(Token = "0x6016BD5")]
    [Address(RVA = "0x3F70480", Offset = "0x3F70480", VA = "0x3F70480", Slot = "25")]
    public override void OnBackScene()
    {
    }

    [Token(Token = "0x6016BD6")]
    [Address(RVA = "0x3F706EC", Offset = "0x3F706EC", VA = "0x3F706EC", Slot = "7")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6016BD7")]
    [Address(RVA = "0x3F70754", Offset = "0x3F70754", VA = "0x3F70754")]
    private IEnumerator NotifyReleasedStoryGacha(Action onFinished) => (IEnumerator) null;

    [Token(Token = "0x6016BD8")]
    [Address(RVA = "0x3F707CC", Offset = "0x3F707CC", VA = "0x3F707CC")]
    private IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6016BD9")]
    [Address(RVA = "0x3F70834", Offset = "0x3F70834", VA = "0x3F70834")]
    private IEnumerator LoadGachaList() => (IEnumerator) null;

    [Token(Token = "0x6016BDA")]
    [Address(RVA = "0x3F7089C", Offset = "0x3F7089C", VA = "0x3F7089C")]
    private IEnumerator CreateGachaTopView() => (IEnumerator) null;

    [Token(Token = "0x6016BDB")]
    [Address(RVA = "0x3F70904", Offset = "0x3F70904", VA = "0x3F70904")]
    private IEnumerator CreateGachaResultView() => (IEnumerator) null;

    [Token(Token = "0x6016BDC")]
    [Address(RVA = "0x3F7096C", Offset = "0x3F7096C", VA = "0x3F7096C")]
    private IEnumerator CreateStoryGachaTop() => (IEnumerator) null;

    [Token(Token = "0x6016BDD")]
    [Address(RVA = "0x3F709D4", Offset = "0x3F709D4", VA = "0x3F709D4")]
    private IEnumerator CreateSelectGachaTop() => (IEnumerator) null;

    [Token(Token = "0x6016BDE")]
    [Address(RVA = "0x3F70A3C", Offset = "0x3F70A3C", VA = "0x3F70A3C")]
    private IEnumerator CreatePopupDetailGenerator() => (IEnumerator) null;

    [Token(Token = "0x6016BDF")]
    [Address(RVA = "0x3F70AA4", Offset = "0x3F70AA4", VA = "0x3F70AA4")]
    public void Update()
    {
    }

    [Token(Token = "0x6016BE0")]
    [Address(RVA = "0x3F701A4", Offset = "0x3F701A4", VA = "0x3F701A4")]
    public void Release()
    {
    }

    [Token(Token = "0x6016BE1")]
    [Address(RVA = "0x3F70B4C", Offset = "0x3F70B4C", VA = "0x3F70B4C")]
    private void SetRaycastEnable(bool enable)
    {
    }

    [Token(Token = "0x6016BE2")]
    [Address(RVA = "0x3F705A4", Offset = "0x3F705A4", VA = "0x3F705A4")]
    public void UpdateGachaListView()
    {
    }

    [Token(Token = "0x6016BE3")]
    [Address(RVA = "0x3F70BF8", Offset = "0x3F70BF8", VA = "0x3F70BF8")]
    private void OpenGachaTop(GachaInfoHolder gachaInfoHolder, string gachaName)
    {
    }

    [Token(Token = "0x6016BE4")]
    [Address(RVA = "0x3F70E30", Offset = "0x3F70E30", VA = "0x3F70E30")]
    public void CloseGachaTop()
    {
    }

    [Token(Token = "0x6016BE5")]
    [Address(RVA = "0x3F70E70", Offset = "0x3F70E70", VA = "0x3F70E70")]
    public void OpenGachaResult()
    {
    }

    [Token(Token = "0x6016BE6")]
    [Address(RVA = "0x3F70E90", Offset = "0x3F70E90", VA = "0x3F70E90")]
    private IEnumerator OpenGachaResultSequence() => (IEnumerator) null;

    [Token(Token = "0x6016BE7")]
    [Address(RVA = "0x3F70EF8", Offset = "0x3F70EF8", VA = "0x3F70EF8")]
    private Action GetConsumerLawAction() => (Action) null;

    [Token(Token = "0x6016BE8")]
    [Address(RVA = "0x3F70FC8", Offset = "0x3F70FC8", VA = "0x3F70FC8")]
    private void OnGachaListSelectionChanged(string gachaName, int index)
    {
    }

    [Token(Token = "0x6016BE9")]
    [Address(RVA = "0x3F71068", Offset = "0x3F71068", VA = "0x3F71068")]
    private void RevokeGachaListView()
    {
    }

    [Token(Token = "0x6016BEA")]
    [Address(RVA = "0x3F70FE8", Offset = "0x3F70FE8", VA = "0x3F70FE8")]
    private IEnumerator ChangedGachaAsync(string gachaName, int index) => (IEnumerator) null;

    [Token(Token = "0x6016BEB")]
    [Address(RVA = "0x3F711C8", Offset = "0x3F711C8", VA = "0x3F711C8")]
    public void OpenGachaStartPopup(GachaPaymentModel gachaPaymentModel, bool isOneMore)
    {
    }

    [Token(Token = "0x6016BEC")]
    [Address(RVA = "0x3F7163C", Offset = "0x3F7163C", VA = "0x3F7163C")]
    private void OnPaymentButtonClicked(GachaPaymentModel gachaPaymentModel)
    {
    }

    [Token(Token = "0x6016BED")]
    [Address(RVA = "0x3F7169C", Offset = "0x3F7169C", VA = "0x3F7169C")]
    private void OnPaymentAdvertisementCancel(bool isResult)
    {
    }

    [Token(Token = "0x6016BEE")]
    [Address(RVA = "0x3F716DC", Offset = "0x3F716DC", VA = "0x3F716DC")]
    private void OnPaymentNotEnough(GachaDetailInfo gachaDetailInfo)
    {
    }

    [Token(Token = "0x6016BEF")]
    [Address(RVA = "0x3F716E0", Offset = "0x3F716E0", VA = "0x3F716E0")]
    public void OpenShortagePopup(GachaDetailInfo gachaDetailInfo)
    {
    }

    [Token(Token = "0x6016BF0")]
    [Address(RVA = "0x3F717B4", Offset = "0x3F717B4", VA = "0x3F717B4")]
    private void OnPaymentCompletedFromResult(
      GachaInfo gachaInfo,
      GachaDetailInfo detailInfo,
      GachaResultInfo gachaResultInfo)
    {
    }

    [Token(Token = "0x6016BF1")]
    [Address(RVA = "0x3F71814", Offset = "0x3F71814", VA = "0x3F71814")]
    private void OnPaymentCompleted(
      GachaInfo gachaInfo,
      GachaDetailInfo detailInfo,
      GachaResultInfo gachaResultInfo)
    {
    }

    [Token(Token = "0x6016BF2")]
    [Address(RVA = "0x3F717F4", Offset = "0x3F717F4", VA = "0x3F717F4")]
    public void CloseGachaResult()
    {
    }

    [Token(Token = "0x6016BF3")]
    [Address(RVA = "0x3F71E8C", Offset = "0x3F71E8C", VA = "0x3F71E8C")]
    private void StartGachaEffect(GachaResultInfo gachaResultInfo)
    {
    }

    [Token(Token = "0x6016BF4")]
    [Address(RVA = "0x3F71EAC", Offset = "0x3F71EAC", VA = "0x3F71EAC")]
    private IEnumerator InitializeGacha(GachaResultInfo gachaResultInfo) => (IEnumerator) null;

    [Token(Token = "0x6016BF5")]
    [Address(RVA = "0x3F70B28", Offset = "0x3F70B28", VA = "0x3F70B28")]
    private void UnloadGachaPlayback()
    {
    }

    [Token(Token = "0x6016BF6")]
    [Address(RVA = "0x3F71F20", Offset = "0x3F71F20", VA = "0x3F71F20")]
    private void OnGachaEffectFinished(GachaPlayback gachaPlayback)
    {
    }

    [Token(Token = "0x6016BF7")]
    [Address(RVA = "0x3F7203C", Offset = "0x3F7203C", VA = "0x3F7203C")]
    private void GetGachaResultViewAssetBundles(
      IReadOnlyList<GachaResultDetailInfo> gachaResultInfos)
    {
    }

    [Token(Token = "0x6016BF8")]
    [Address(RVA = "0x3F72758", Offset = "0x3F72758", VA = "0x3F72758")]
    private void OnCoinHeaderClicked(Button button)
    {
    }

    [Token(Token = "0x6016BF9")]
    [Address(RVA = "0x3F727D0", Offset = "0x3F727D0", VA = "0x3F727D0")]
    private void OpenBuyConfirmStonePopup(RectTransform buttonRectTransform)
    {
    }

    [Token(Token = "0x6016BFA")]
    [Address(RVA = "0x3F72870", Offset = "0x3F72870", VA = "0x3F72870")]
    private void OnTicketHeaderClicked(Button button)
    {
    }

    [Token(Token = "0x6016BFB")]
    [Address(RVA = "0x3F72BF8", Offset = "0x3F72BF8", VA = "0x3F72BF8")]
    private void OnMedalHeaderClicked(Button button)
    {
    }

    [Token(Token = "0x6016BFC")]
    [Address(RVA = "0x3F72930", Offset = "0x3F72930", VA = "0x3F72930")]
    private void OpenPossessionList(
      GachaAssetBundleInfo.AssetBundleInfo assetBundleInfo,
      RectTransform buttonRectTransform,
      List<Item> listItemInfos)
    {
    }

    [Token(Token = "0x6016BFD")]
    [Address(RVA = "0x3F72CB8", Offset = "0x3F72CB8", VA = "0x3F72CB8")]
    private void OnItemIconClicked(Item item)
    {
    }

    [Token(Token = "0x6016BFE")]
    [Address(RVA = "0x3F72D10", Offset = "0x3F72D10", VA = "0x3F72D10")]
    private void OnGachaDetailChanged(GachaInfoHolder gachaInfoHolder, string gachaName)
    {
    }

    [Token(Token = "0x6016BFF")]
    [Address(RVA = "0x3F704F0", Offset = "0x3F704F0", VA = "0x3F704F0")]
    private void UpdateHeaderView()
    {
    }

    [Token(Token = "0x6016C00")]
    [Address(RVA = "0x3F7197C", Offset = "0x3F7197C", VA = "0x3F7197C")]
    private void UpdateHeaderView(GachaHeaderInfo headerInfo, GachaTabType groupType)
    {
    }

    [Token(Token = "0x6016C01")]
    [Address(RVA = "0x3F72E00", Offset = "0x3F72E00", VA = "0x3F72E00")]
    public void OpenProvidePopup(string gachaName, int groupId, bool isRatio)
    {
    }

    [Token(Token = "0x6016C02")]
    [Address(RVA = "0x3F72EE8", Offset = "0x3F72EE8", VA = "0x3F72EE8")]
    public void OpenPickupDetail(string gachaName, int groupId)
    {
    }

    [Token(Token = "0x6016C03")]
    [Address(RVA = "0x3F736E0", Offset = "0x3F736E0", VA = "0x3F736E0")]
    public void OpenPreviousResult()
    {
    }

    [Token(Token = "0x6016C04")]
    [Address(RVA = "0x3F73884", Offset = "0x3F73884", VA = "0x3F73884")]
    private void OpenSelectGachaPopup(GachaDetailInfo gachaDetailInfo)
    {
    }

    [Token(Token = "0x6016C05")]
    [Address(RVA = "0x3F71FDC", Offset = "0x3F71FDC", VA = "0x3F71FDC")]
    private void PlayBGOutAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6016C06")]
    [Address(RVA = "0x3F73A18", Offset = "0x3F73A18", VA = "0x3F73A18")]
    private void PlayBGInAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6016C07")]
    [Address(RVA = "0x3F71E2C", Offset = "0x3F71E2C", VA = "0x3F71E2C")]
    private void PlayFrameOutAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6016C08")]
    [Address(RVA = "0x3F73A78", Offset = "0x3F73A78", VA = "0x3F73A78")]
    private void PlayFrameInAnimation(Action onFinished = null)
    {
    }

    [Token(Token = "0x6016C09")]
    [Address(RVA = "0x3F73AD8", Offset = "0x3F73AD8", VA = "0x3F73AD8")]
    private IEnumerator PlayContentInAnimation(
      GachaSubScene.ContentAnimationDirectionType directionType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016C0A")]
    [Address(RVA = "0x3F73B50", Offset = "0x3F73B50", VA = "0x3F73B50")]
    private IEnumerator PlayContentOutAnimation(
      GachaSubScene.ContentAnimationDirectionType directionType)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6016C0B")]
    [Address(RVA = "0x3F73BC8", Offset = "0x3F73BC8", VA = "0x3F73BC8")]
    public void SetInteractable(bool interactable)
    {
    }

    [Token(Token = "0x6016C0C")]
    [Address(RVA = "0x3F73C60", Offset = "0x3F73C60", VA = "0x3F73C60", Slot = "20")]
    public override void BackKeyDownAction()
    {
    }

    [Token(Token = "0x6016C0D")]
    [Address(RVA = "0x3F73CA8", Offset = "0x3F73CA8", VA = "0x3F73CA8")]
    private void SetInteractableButtonBack(bool interactable)
    {
    }

    [Token(Token = "0x6016C0E")]
    [Address(RVA = "0x3F73CC8", Offset = "0x3F73CC8", VA = "0x3F73CC8")]
    private void SetIsSkipGachaPlayback(bool value)
    {
    }

    [Token(Token = "0x6016C0F")]
    [Address(RVA = "0x3F73CE8", Offset = "0x3F73CE8", VA = "0x3F73CE8")]
    public GachaSubScene()
    {
    }

    [Token(Token = "0x20039E9")]
    private enum ContentAnimationDirectionType
    {
      [Token(Token = "0x400FD88")] Left,
      [Token(Token = "0x400FD89")] Right,
    }
  }
}

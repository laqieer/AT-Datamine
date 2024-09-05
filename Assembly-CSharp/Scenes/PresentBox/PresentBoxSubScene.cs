// Decompiled with JetBrains decompiler
// Type: Scenes.PresentBox.PresentBoxSubScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.MasterData;
using GameCore.Tween;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using Scenes.OutGame.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.PresentBox
{
  [Token(Token = "0x2002A36")]
  public class PresentBoxSubScene : GlobalMenuFrontContentsBase
  {
    [Token(Token = "0x400B396")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private CanvasGroup canvasGroup;
    [Token(Token = "0x400B397")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private UITweenGroup tweenGroup;
    [Token(Token = "0x400B398")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button[] modeButton;
    [Token(Token = "0x400B399")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button allReceiveBtn;
    [Token(Token = "0x400B39A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject titleText1;
    [Token(Token = "0x400B39B")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject titleText2;
    [Token(Token = "0x400B39C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x400B39D")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400B39E")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Button leftPageBtn;
    [Token(Token = "0x400B39F")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Button rightPageBtn;
    [Token(Token = "0x400B3A0")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text pageText;
    [Token(Token = "0x400B3A1")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Text pageMaxText;
    [Token(Token = "0x400B3A2")]
    [FieldOffset(Offset = "0x88")]
    private List<PresentBoxListItem> presentBoxList;
    [Token(Token = "0x400B3A3")]
    [FieldOffset(Offset = "0x90")]
    private GameObject presentBoxListItem;
    [Token(Token = "0x400B3A4")]
    [FieldOffset(Offset = "0x98")]
    private int currPageIndex;
    [Token(Token = "0x400B3A5")]
    [FieldOffset(Offset = "0x9C")]
    private int maxPageIndex;
    [Token(Token = "0x400B3A6")]
    [FieldOffset(Offset = "0xA0")]
    private bool isLoadedAssetBundle;
    [Token(Token = "0x400B3A7")]
    [FieldOffset(Offset = "0xA1")]
    private bool isDataOK;
    [Token(Token = "0x400B3A8")]
    [FieldOffset(Offset = "0xA8")]
    private ItemDetailPopupProvider itemDetailPopupGenerator;
    [Token(Token = "0x400B3A9")]
    [FieldOffset(Offset = "0xB0")]
    private List<PlayerPresentType> presentList;
    [Token(Token = "0x400B3AA")]
    [FieldOffset(Offset = "0xB8")]
    private List<PlayerPresentType> expiredPresents;
    [Token(Token = "0x400B3AB")]
    [FieldOffset(Offset = "0xC0")]
    private List<PlayerPresentType> logPresents;
    [Token(Token = "0x400B3AC")]
    [FieldOffset(Offset = "0xC8")]
    private PresentBoxSideMenu presentBoxSideMenu;
    [Token(Token = "0x400B3AD")]
    [FieldOffset(Offset = "0xD0")]
    private UITweenGroup badgeController;
    [Token(Token = "0x400B3AE")]
    [FieldOffset(Offset = "0xD8")]
    private bool refreshAllBadge;
    [Token(Token = "0x400B3AF")]
    [FieldOffset(Offset = "0xE0")]
    private Dictionary<PresentBoxSubScene.TabType, int> presentReceiveCountDic;
    [Token(Token = "0x400B3B0")]
    [FieldOffset(Offset = "0xE8")]
    private AssetCachedSpawner assetCachedSpawner;
    [Token(Token = "0x400B3B1")]
    [FieldOffset(Offset = "0xF0")]
    public ItemConvertCheck convertCheck;
    [Token(Token = "0x400B3B2")]
    public const string SubScenePresentBox = "ui_page_outgame_presentbox";
    [Token(Token = "0x400B3B3")]
    public const string SubScenePresentBoxPrefabName = "Container_PresentBox";
    [Token(Token = "0x400B3B4")]
    public const string SubSceneAssetBundleName = "ui_page_outgame";
    [Token(Token = "0x400B3B5")]
    public const string LOAD_PREFAB_PRESENT_LIST_ITEM = "Content_Present_List";
    [Token(Token = "0x400B3B6")]
    public const string SubScenePresentSideList = "ui_page_header";
    [Token(Token = "0x400B3B7")]
    public const string SubScenePresentSideListPrefabName = "Container_SideMenu_PresentBox";
    [Token(Token = "0x400B3B8")]
    public const string AnimationKeyIn = "Open";
    [Token(Token = "0x400B3B9")]
    public const string AnimationKeyOut = "Close";
    [Token(Token = "0x400B3BA")]
    private const int maxCountInOnePage = 20;
    [Token(Token = "0x400B3BB")]
    [FieldOffset(Offset = "0xF8")]
    public PresentBoxSubScene.TabType currentTypeMode;

    [Token(Token = "0x6010877")]
    [Address(RVA = "0x4C25DDC", Offset = "0x4C25DDC", VA = "0x4C25DDC")]
    private void Update()
    {
    }

    [Token(Token = "0x6010878")]
    [Address(RVA = "0x4C25DF8", Offset = "0x4C25DF8", VA = "0x4C25DF8")]
    protected IEnumerator PlayAnimation(string animationGroupID) => (IEnumerator) null;

    [Token(Token = "0x6010879")]
    [Address(RVA = "0x4C25E94", Offset = "0x4C25E94", VA = "0x4C25E94")]
    private void SetInteractable(bool value)
    {
    }

    [Token(Token = "0x601087A")]
    [Address(RVA = "0x4C25F2C", Offset = "0x4C25F2C", VA = "0x4C25F2C")]
    public void DisableInteractable()
    {
    }

    [Token(Token = "0x601087B")]
    [Address(RVA = "0x4C25F60", Offset = "0x4C25F60", VA = "0x4C25F60")]
    public void EnableInteractable()
    {
    }

    [Token(Token = "0x601087C")]
    [Address(RVA = "0x4C25F94", Offset = "0x4C25F94", VA = "0x4C25F94")]
    private IEnumerator LoadWaitByAssetBundle(string label, Action<string, bool> successAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601087D")]
    [Address(RVA = "0x4C26038", Offset = "0x4C26038", VA = "0x4C26038", Slot = "4")]
    public override void Initialize(Transform left, Scenes.GlobalMenuFrontView.GlobalMenuFrontView view)
    {
    }

    [Token(Token = "0x601087E")]
    [Address(RVA = "0x4C26328", Offset = "0x4C26328", VA = "0x4C26328")]
    public IEnumerator InitializeAsync(bool isToNext) => (IEnumerator) null;

    [Token(Token = "0x601087F")]
    [Address(RVA = "0x4C263CC", Offset = "0x4C263CC", VA = "0x4C263CC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6010880")]
    [Address(RVA = "0x4C26444", Offset = "0x4C26444", VA = "0x4C26444")]
    private IEnumerator RequestPresentBoxList(bool isToNext) => (IEnumerator) null;

    [Token(Token = "0x6010881")]
    [Address(RVA = "0x4C264D4", Offset = "0x4C264D4", VA = "0x4C264D4")]
    private IEnumerator RequestLogPresentList() => (IEnumerator) null;

    [Token(Token = "0x6010882")]
    [Address(RVA = "0x4C26564", Offset = "0x4C26564", VA = "0x4C26564")]
    private IEnumerator RequestReceiveAllPresentBox() => (IEnumerator) null;

    [Token(Token = "0x6010883")]
    [Address(RVA = "0x4C265F4", Offset = "0x4C265F4", VA = "0x4C265F4")]
    private void ExpiredItemLoopShow(List<Reward> lists, Action callback = null)
    {
    }

    [Token(Token = "0x6010884")]
    [Address(RVA = "0x4C26960", Offset = "0x4C26960", VA = "0x4C26960")]
    private IEnumerator RequestPresentConfirmExpiration() => (IEnumerator) null;

    [Token(Token = "0x6010885")]
    [Address(RVA = "0x4C269F0", Offset = "0x4C269F0", VA = "0x4C269F0")]
    protected IEnumerator ShowRewardNofity(
      List<DisplayItemRewardInfoData> infos,
      bool showEffect = true,
      Action onEnd = null,
      bool isPossessionLimit = false,
      bool isConvert = false)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6010886")]
    [Address(RVA = "0x4C266D0", Offset = "0x4C266D0", VA = "0x4C266D0")]
    public void GoToReceivedList(
      List<Reward> receivedItems,
      bool showEffect = true,
      Action onEndCallBack = null,
      bool isPossessionLimit = false,
      bool isConvert = false)
    {
    }

    [Token(Token = "0x6010887")]
    [Address(RVA = "0x4C26ACC", Offset = "0x4C26ACC", VA = "0x4C26ACC")]
    public void UpdatePresentBoxList(List<PlayerPresentType> presentList)
    {
    }

    [Token(Token = "0x6010888")]
    [Address(RVA = "0x4C26AD4", Offset = "0x4C26AD4", VA = "0x4C26AD4")]
    public void RefreshPresentBoxList()
    {
    }

    [Token(Token = "0x6010889")]
    [Address(RVA = "0x4C26E64", Offset = "0x4C26E64", VA = "0x4C26E64")]
    public void RefreshPageInfo(int totalCount)
    {
    }

    [Token(Token = "0x601088A")]
    [Address(RVA = "0x4C2707C", Offset = "0x4C2707C", VA = "0x4C2707C")]
    public int GetCurrentPageIndex() => new int();

    [Token(Token = "0x601088B")]
    [Address(RVA = "0x4C270EC", Offset = "0x4C270EC", VA = "0x4C270EC")]
    public IEnumerator RefreshLogPresentList() => (IEnumerator) null;

    [Token(Token = "0x601088C")]
    [Address(RVA = "0x4C26AD8", Offset = "0x4C26AD8", VA = "0x4C26AD8")]
    private void SetPresentBoxList()
    {
    }

    [Token(Token = "0x601088D")]
    [Address(RVA = "0x4C27300", Offset = "0x4C27300", VA = "0x4C27300")]
    public void SetBadgeState(List<PlayerPresentType> list, PresentBoxSubScene.TabType type)
    {
    }

    [Token(Token = "0x601088E")]
    [Address(RVA = "0x4C2728C", Offset = "0x4C2728C", VA = "0x4C2728C")]
    public IEnumerator ContentsLoadProcess(List<PlayerPresentType> list, Action onFinish)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601088F")]
    [Address(RVA = "0x4C27540", Offset = "0x4C27540", VA = "0x4C27540")]
    private void OnClickRewardItem(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010890")]
    [Address(RVA = "0x4C276E0", Offset = "0x4C276E0", VA = "0x4C276E0")]
    private void OpenItemDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010891")]
    [Address(RVA = "0x4C27728", Offset = "0x4C27728", VA = "0x4C27728")]
    private void CloseDetailPopup()
    {
    }

    [Token(Token = "0x6010892")]
    [Address(RVA = "0x4C27568", Offset = "0x4C27568", VA = "0x4C27568")]
    private void OpenOtherDetailPopup(RewardTypeEnum rewardType, int rewardId)
    {
    }

    [Token(Token = "0x6010893")]
    [Address(RVA = "0x4C27744", Offset = "0x4C27744", VA = "0x4C27744")]
    public void SetChangePageButtonState()
    {
    }

    [Token(Token = "0x6010894")]
    [Address(RVA = "0x4C277A4", Offset = "0x4C277A4", VA = "0x4C277A4")]
    private void ChangeNextPage()
    {
    }

    [Token(Token = "0x6010895")]
    [Address(RVA = "0x4C277E4", Offset = "0x4C277E4", VA = "0x4C277E4")]
    private void ChangePreviouspage()
    {
    }

    [Token(Token = "0x6010896")]
    [Address(RVA = "0x4C27184", Offset = "0x4C27184", VA = "0x4C27184")]
    private void ClearListObj()
    {
    }

    [Token(Token = "0x6010897")]
    [Address(RVA = "0x4C27824", Offset = "0x4C27824", VA = "0x4C27824")]
    private IEnumerator ResetScrollBar() => (IEnumerator) null;

    [Token(Token = "0x6010898")]
    [Address(RVA = "0x4C278B4", Offset = "0x4C278B4", VA = "0x4C278B4")]
    public PresentBoxSubScene()
    {
    }

    [Token(Token = "0x2002A37")]
    public enum TabType
    {
      [Token(Token = "0x400B3BD")] ReceiveTimeLimit,
      [Token(Token = "0x400B3BE")] Receive,
      [Token(Token = "0x400B3BF")] Log,
    }
  }
}

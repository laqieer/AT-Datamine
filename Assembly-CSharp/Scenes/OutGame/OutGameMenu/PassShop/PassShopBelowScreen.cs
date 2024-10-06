// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PassShop.PassShopBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.Popup;
using GlobalMenu;
using Il2CppDummyDll;
using Network;
using Network.Param;
using PurchaseModule.Enum;
using PurchaseModule.Product;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using Staq.Purchase;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.PassShop
{
  [Token(Token = "0x2003B51")]
  public class PassShopBelowScreen : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x40105FB")]
    [FieldOffset(Offset = "0x48")]
    private ShopLoader shopLoader;
    [Token(Token = "0x40105FC")]
    [FieldOffset(Offset = "0x50")]
    private ShopAPIManager shopAPI;
    [Token(Token = "0x40105FD")]
    [FieldOffset(Offset = "0x58")]
    private GameObject baseItemGroupObject;
    [Token(Token = "0x40105FE")]
    [FieldOffset(Offset = "0x60")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x40105FF")]
    [FieldOffset(Offset = "0x68")]
    private GlobalShopBelowScreen.GlobalShopBelowScreenParam shopBelowScreenParam;
    [Token(Token = "0x4010600")]
    [FieldOffset(Offset = "0x70")]
    private PlayerShopArticleType[] nowShopDatas;
    [Token(Token = "0x4010601")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4010602")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private HorizontalLayoutGroup scrollLayout;
    [Token(Token = "0x4010603")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x4010604")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform[] containers;
    [Token(Token = "0x4010605")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x4010606")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x4010607")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RectTransform[] badges;
    [Token(Token = "0x4010608")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private RectTransform[] transfers;
    [Token(Token = "0x4010609")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button[] buttons;
    [Token(Token = "0x401060A")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private CommonButton buttonMedal;
    [Token(Token = "0x401060B")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private CommonButton buttonCoin;
    [Token(Token = "0x401060C")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private CommonButton buttonSpecified;
    [Token(Token = "0x401060D")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private CommonButton buttonPayment;
    [Token(Token = "0x401060E")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x401060F")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x4010610")]
    [FieldOffset(Offset = "0xEC")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x4010611")]
    [FieldOffset(Offset = "0xF0")]
    private float jumpMoveLen;
    [Token(Token = "0x4010612")]
    [FieldOffset(Offset = "0xF4")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x4010613")]
    [FieldOffset(Offset = "0xF8")]
    private GameObject backSpaceObj;
    [Token(Token = "0x4010614")]
    private const float backSpaceObjSize = 1208f;
    [Token(Token = "0x4010615")]
    [FieldOffset(Offset = "0x100")]
    private AssetCachedSpawner cachedSpawner;
    [Token(Token = "0x4010616")]
    [FieldOffset(Offset = "0x108")]
    private GameObject passShopItem;
    [Token(Token = "0x4010617")]
    [FieldOffset(Offset = "0x110")]
    private int nowShopIndex;
    [Token(Token = "0x4010618")]
    [FieldOffset(Offset = "0x114")]
    private int nowShopId;
    [Token(Token = "0x4010619")]
    [FieldOffset(Offset = "0x118")]
    private GameObject itemPurchasePopup;
    [Token(Token = "0x401061A")]
    [FieldOffset(Offset = "0x120")]
    private UITimelineSettingAsset popupSettingAsset;
    [Token(Token = "0x401061B")]
    [FieldOffset(Offset = "0x128")]
    private GameObject itemDetailPopup;
    [Token(Token = "0x401061C")]
    [FieldOffset(Offset = "0x130")]
    private GameObject boxItemDetailPopup;
    [Token(Token = "0x401061D")]
    [FieldOffset(Offset = "0x138")]
    private UITimelineSettingAsset itemDetailSettingAsset;
    [Token(Token = "0x401061E")]
    [FieldOffset(Offset = "0x140")]
    private GameObject itemIconPrefab;
    [Token(Token = "0x401061F")]
    [FieldOffset(Offset = "0x148")]
    private GameObject itemIconTagPrefab;
    [Token(Token = "0x4010620")]
    [FieldOffset(Offset = "0x150")]
    private GameObject afterPurchasePopup;
    [Token(Token = "0x4010621")]
    [FieldOffset(Offset = "0x158")]
    private GameObject passGroupItemPrefab;
    [Token(Token = "0x4010622")]
    [FieldOffset(Offset = "0x160")]
    private GameObject passItemPrefab;
    [Token(Token = "0x4010623")]
    [FieldOffset(Offset = "0x168")]
    private List<GameObject> createdItemGroupObjList;
    [Token(Token = "0x4010624")]
    [FieldOffset(Offset = "0x170")]
    private List<PassShopItem> createdPassShopItemList;
    [Token(Token = "0x4010625")]
    [FieldOffset(Offset = "0x178")]
    private int beforePaid;
    [Token(Token = "0x4010626")]
    [FieldOffset(Offset = "0x17C")]
    private int passId;
    [Token(Token = "0x4010627")]
    [FieldOffset(Offset = "0x180")]
    private bool isInitializeEnd;
    [Token(Token = "0x4010628")]
    [FieldOffset(Offset = "0x181")]
    private bool isUnavailableError;
    [Token(Token = "0x4010629")]
    [FieldOffset(Offset = "0x188")]
    private CommonShopItemData cashShopItemData;
    [Token(Token = "0x401062A")]
    [FieldOffset(Offset = "0x190")]
    private PassItemPurchasePopup purchasePopup;

    [Token(Token = "0x6017557")]
    [Address(RVA = "0x2724D20", Offset = "0x2724D20", VA = "0x2724D20")]
    public void SetHeaderText()
    {
    }

    [Token(Token = "0x6017558")]
    [Address(RVA = "0x2724E94", Offset = "0x2724E94", VA = "0x2724E94", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x6017559")]
    [Address(RVA = "0x27252DC", Offset = "0x27252DC", VA = "0x27252DC", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x601755A")]
    [Address(RVA = "0x2725344", Offset = "0x2725344", VA = "0x2725344")]
    public void OnFinishToGetProductIds(UpdateProductResultCode resultCode)
    {
    }

    [Token(Token = "0x601755B")]
    [Address(RVA = "0x272546C", Offset = "0x272546C", VA = "0x272546C")]
    private IEnumerator SetupTimeline() => (IEnumerator) null;

    [Token(Token = "0x601755C")]
    [Address(RVA = "0x27254D4", Offset = "0x27254D4", VA = "0x27254D4")]
    private IEnumerator TimelineSetting(UITimelineController controller, Action finishAction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601755D")]
    [Address(RVA = "0x2725548", Offset = "0x2725548", VA = "0x2725548")]
    public IEnumerator ConnectUpdateError(NetworkErrorResult errorResult) => (IEnumerator) null;

    [Token(Token = "0x601755E")]
    [Address(RVA = "0x27255B0", Offset = "0x27255B0", VA = "0x27255B0")]
    public void OnClickToShopItem(PlayerShopArticleType articleType, bool isBuy)
    {
    }

    [Token(Token = "0x601755F")]
    [Address(RVA = "0x27259B8", Offset = "0x27259B8", VA = "0x27259B8")]
    private IEnumerator IFPurchase(ProductInfo productInfo, PopupBase popup) => (IEnumerator) null;

    [Token(Token = "0x6017560")]
    [Address(RVA = "0x2725A34", Offset = "0x2725A34", VA = "0x2725A34")]
    public void Purchase(ProductInfo productInfo, PopupBase popup)
    {
    }

    [Token(Token = "0x6017561")]
    [Address(RVA = "0x2725A54", Offset = "0x2725A54", VA = "0x2725A54")]
    private IEnumerator PurchaseInternal(ProductInfo productInfo, PopupBase popup)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017562")]
    [Address(RVA = "0x2725AD0", Offset = "0x2725AD0", VA = "0x2725AD0")]
    private void PurchaseSucceededCallback(FulfillmentTransaction transaction)
    {
    }

    [Token(Token = "0x6017563")]
    [Address(RVA = "0x2725FEC", Offset = "0x2725FEC", VA = "0x2725FEC")]
    private void OpenAfterPopup(
      CommonShopItemData commonShopItemData,
      int before,
      bool isConvertCheck,
      Action onClickClose)
    {
    }

    [Token(Token = "0x6017564")]
    [Address(RVA = "0x27262E0", Offset = "0x27262E0", VA = "0x27262E0")]
    private void OpenOtherDetailPopup(ItemPurchaseData.ItemRewardData rewardData)
    {
    }

    [Token(Token = "0x6017565")]
    [Address(RVA = "0x2726428", Offset = "0x2726428", VA = "0x2726428")]
    public void UpdateShopIndex(int nextShopIndex)
    {
    }

    [Token(Token = "0x6017566")]
    [Address(RVA = "0x2726430", Offset = "0x2726430", VA = "0x2726430")]
    public void UpdateShop(int nextShopIndex)
    {
    }

    [Token(Token = "0x6017567")]
    [Address(RVA = "0x272764C", Offset = "0x272764C", VA = "0x272764C")]
    private IEnumerator UpdateContainer() => (IEnumerator) null;

    [Token(Token = "0x6017568")]
    [Address(RVA = "0x27276B4", Offset = "0x27276B4", VA = "0x27276B4", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6017569")]
    [Address(RVA = "0x27278CC", Offset = "0x27278CC", VA = "0x27278CC", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x601756A")]
    [Address(RVA = "0x2727C48", Offset = "0x2727C48", VA = "0x2727C48")]
    private void OpenPopup(
      ShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      ShopLoader.TimelineType timelineType = ShopLoader.TimelineType.CommonPopupIn,
      Action onFinishAction = null)
    {
    }

    [Token(Token = "0x601756B")]
    [Address(RVA = "0x2725E08", Offset = "0x2725E08", VA = "0x2725E08")]
    private void ClosePopup(
      ShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      ShopLoader.TimelineType timelineType = ShopLoader.TimelineType.CommonPopupOut)
    {
    }

    [Token(Token = "0x601756C")]
    [Address(RVA = "0x2727E60", Offset = "0x2727E60", VA = "0x2727E60")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x601756D")]
    [Address(RVA = "0x2727E6C", Offset = "0x2727E6C", VA = "0x2727E6C")]
    private void UpdateJumpMove()
    {
    }

    [Token(Token = "0x601756E")]
    [Address(RVA = "0x2727EF8", Offset = "0x2727EF8", VA = "0x2727EF8")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x601756F")]
    [Address(RVA = "0x2727F4C", Offset = "0x2727F4C", VA = "0x2727F4C")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x6017570")]
    [Address(RVA = "0x2728208", Offset = "0x2728208", VA = "0x2728208")]
    private void Update()
    {
    }

    [Token(Token = "0x6017571")]
    [Address(RVA = "0x2728298", Offset = "0x2728298", VA = "0x2728298")]
    public void OnClickToSpecifiedCommercialTransactionsAct()
    {
    }

    [Token(Token = "0x6017572")]
    [Address(RVA = "0x27282A0", Offset = "0x27282A0", VA = "0x27282A0")]
    public void OnClickToPaymentServicesAct()
    {
    }

    [Token(Token = "0x6017573")]
    [Address(RVA = "0x27282A8", Offset = "0x27282A8", VA = "0x27282A8")]
    public void OnClickToChangeView()
    {
    }

    [Token(Token = "0x6017574")]
    [Address(RVA = "0x272838C", Offset = "0x272838C", VA = "0x272838C")]
    private void OnClickToChangeMedalView()
    {
    }

    [Token(Token = "0x6017575")]
    [Address(RVA = "0x2728470", Offset = "0x2728470", VA = "0x2728470")]
    private void OnClickButtonCoin()
    {
    }

    [Token(Token = "0x6017576")]
    [Address(RVA = "0x27285A8", Offset = "0x27285A8", VA = "0x27285A8")]
    public PassShopBelowScreen()
    {
    }
  }
}

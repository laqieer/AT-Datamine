// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.GlobalShopBelowScreen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GlobalMenu;
using Il2CppDummyDll;
using Network;
using Network.Param;
using PurchaseModule.Enum;
using PurchaseModule.Product;
using Staq.Purchase;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.Direction;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003B7D")]
  public class GlobalShopBelowScreen : OutGameMenuBelowScreenBase
  {
    [Token(Token = "0x4010707")]
    [FieldOffset(Offset = "0x48")]
    private readonly Dictionary<PaymentTypeEnum, int> viewTypeList;
    [Token(Token = "0x4010708")]
    [FieldOffset(Offset = "0x50")]
    private ShopLoader shopLoader;
    [Token(Token = "0x4010709")]
    [FieldOffset(Offset = "0x58")]
    private ShopAPIManager shopAPI;
    [Token(Token = "0x401070A")]
    [FieldOffset(Offset = "0x60")]
    private UITimelineController uiTimelineController;
    [Token(Token = "0x401070B")]
    [FieldOffset(Offset = "0x68")]
    private GlobalShopBelowScreen.GlobalShopBelowScreenParam shopBelowScreenParam;
    [Token(Token = "0x401070C")]
    [FieldOffset(Offset = "0x70")]
    private int nowShopIndex;
    [Token(Token = "0x401070D")]
    [FieldOffset(Offset = "0x74")]
    private int nowShopId;
    [Token(Token = "0x401070E")]
    [FieldOffset(Offset = "0x78")]
    private PlayerShopArticleType[] nowShopDatas;
    [Token(Token = "0x401070F")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x4010710")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private HorizontalLayoutGroup scrollLayout;
    [Token(Token = "0x4010711")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x4010712")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform[] containers;
    [Token(Token = "0x4010713")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Header header;
    [Token(Token = "0x4010714")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject nothingObj;
    [Token(Token = "0x4010715")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private RectTransform[] badges;
    [Token(Token = "0x4010716")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private RectTransform[] transfers;
    [Token(Token = "0x4010717")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Button[] buttons;
    [Token(Token = "0x4010718")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private AnimationCurve jumpMoveCurve;
    [Token(Token = "0x4010719")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private float jumpMoveTime;
    [Token(Token = "0x401071A")]
    [FieldOffset(Offset = "0xD4")]
    private float jumpMoveTimeCount;
    [Token(Token = "0x401071B")]
    [FieldOffset(Offset = "0xD8")]
    private float jumpMoveLen;
    [Token(Token = "0x401071C")]
    [FieldOffset(Offset = "0xDC")]
    private float jumpMoveSrcVal;
    [Token(Token = "0x401071D")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private CommonButton buttonMedal;
    [Token(Token = "0x401071E")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private CommonButton buttonCoin;
    [Token(Token = "0x401071F")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private CommonButton buttonSpecified;
    [Token(Token = "0x4010720")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private CommonButton buttonPayment;
    [Token(Token = "0x4010721")]
    [FieldOffset(Offset = "0x100")]
    private GameObject backSpaceObj;
    [Token(Token = "0x4010722")]
    private const float backSpaceObjSize = 1208f;
    [Token(Token = "0x4010723")]
    [FieldOffset(Offset = "0x108")]
    private List<GameObject> createdGroupList;
    [Token(Token = "0x4010724")]
    [FieldOffset(Offset = "0x110")]
    private List<ShopItem> createdShopItemList;
    [Token(Token = "0x4010725")]
    [FieldOffset(Offset = "0x118")]
    private DateTime? limitTime;
    [Token(Token = "0x4010726")]
    [FieldOffset(Offset = "0x128")]
    private PlayerShopResetButtonType resetButtonParam;
    [Token(Token = "0x4010727")]
    [FieldOffset(Offset = "0x130")]
    private AssetCachedSpawner cachedSpawner;
    [Token(Token = "0x4010728")]
    [FieldOffset(Offset = "0x138")]
    private ItemPurchaseData cashItemData;
    [Token(Token = "0x4010729")]
    [FieldOffset(Offset = "0x140")]
    private CommonShopItemData cashShopItemData;
    [Token(Token = "0x401072A")]
    [FieldOffset(Offset = "0x148")]
    private int beforePaid;
    [Token(Token = "0x401072B")]
    [FieldOffset(Offset = "0x14C")]
    private int beforeFree;
    [Token(Token = "0x401072C")]
    [FieldOffset(Offset = "0x150")]
    private bool isInitializeEnd;

    [Token(Token = "0x6017661")]
    [Address(RVA = "0x2905E6C", Offset = "0x2905E6C", VA = "0x2905E6C")]
    public void SetHeaderText()
    {
    }

    [Token(Token = "0x6017662")]
    [Address(RVA = "0x2905FE0", Offset = "0x2905FE0", VA = "0x2905FE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017663")]
    [Address(RVA = "0x2906064", Offset = "0x2906064", VA = "0x2906064", Slot = "4")]
    public override void Initialize(ChangeBelowScreenParameter param = null)
    {
    }

    [Token(Token = "0x6017664")]
    [Address(RVA = "0x290654C", Offset = "0x290654C", VA = "0x290654C", Slot = "5")]
    public override IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6017665")]
    [Address(RVA = "0x29065B4", Offset = "0x29065B4", VA = "0x29065B4")]
    private RectTransform GetTargetRectTransform(PaymentTypeEnum paymentType, int paymentId)
    {
      return (RectTransform) null;
    }

    [Token(Token = "0x6017666")]
    [Address(RVA = "0x290666C", Offset = "0x290666C", VA = "0x290666C")]
    private RectTransform GetGroupParent(ShopItem.ProductItemType index) => (RectTransform) null;

    [Token(Token = "0x6017667")]
    [Address(RVA = "0x2906768", Offset = "0x2906768", VA = "0x2906768")]
    public void OnClickShopItem(
      ShopItem.ProductItemType itemType,
      CommonShopItemData commonShopItem)
    {
    }

    [Token(Token = "0x6017668")]
    [Address(RVA = "0x2906EE0", Offset = "0x2906EE0", VA = "0x2906EE0")]
    private void OpenItemPurchasePopup(
      ItemPurchasePopupBase popup,
      ShopLoader.ShopAssetType shopAssetType,
      CommonShopItemData commonShopItem)
    {
    }

    [Token(Token = "0x6017669")]
    [Address(RVA = "0x2906A9C", Offset = "0x2906A9C", VA = "0x2906A9C")]
    private void OpenCashPopup(ItemPurchaseCashPopup popup, CommonShopItemData commonShopItem)
    {
    }

    [Token(Token = "0x601766A")]
    [Address(RVA = "0x29076F4", Offset = "0x29076F4", VA = "0x29076F4")]
    private void OpenRewardDetailPopup(
      ItemDetailPopup popup,
      ItemPurchaseData.ItemRewardData rewardData,
      ShopLoader.ShopAssetType popupType)
    {
    }

    [Token(Token = "0x601766B")]
    [Address(RVA = "0x2907970", Offset = "0x2907970", VA = "0x2907970")]
    private void OpenRewardDetailPopup(
      ItemDetailPopup popup,
      PaymentTypeEnum paymentType,
      ShopLoader.ShopAssetType popupType)
    {
    }

    [Token(Token = "0x601766C")]
    [Address(RVA = "0x2907BE4", Offset = "0x2907BE4", VA = "0x2907BE4")]
    private IEnumerator IFPurchase(ProductInfo productInfo, PopupBase popup) => (IEnumerator) null;

    [Token(Token = "0x601766D")]
    [Address(RVA = "0x2907C60", Offset = "0x2907C60", VA = "0x2907C60")]
    public void Purchase(ProductInfo productInfo)
    {
    }

    [Token(Token = "0x601766E")]
    [Address(RVA = "0x2907C80", Offset = "0x2907C80", VA = "0x2907C80")]
    private IEnumerator PurchaseInternal(ProductInfo productInfo) => (IEnumerator) null;

    [Token(Token = "0x601766F")]
    [Address(RVA = "0x2907CF4", Offset = "0x2907CF4", VA = "0x2907CF4")]
    private void PurchaseSucceededCallback(FulfillmentTransaction transaction)
    {
    }

    [Token(Token = "0x6017670")]
    [Address(RVA = "0x2907EA8", Offset = "0x2907EA8", VA = "0x2907EA8")]
    private void OpenAfterPurchasePopup(
      ItemPurchaseData itemPurchaseData,
      int purchaseCount,
      int beforeFreeCoin,
      int beforePaidCoin,
      bool isConvertCheck,
      Action OnClickClose,
      bool isPaidCoin = false)
    {
    }

    [Token(Token = "0x6017671")]
    [Address(RVA = "0x290818C", Offset = "0x290818C", VA = "0x290818C")]
    private void OpenItemAfterPurchasePopup(
      ItemAfterPurchasePopup popup,
      ShopLoader.ShopAssetType shopAsset,
      ItemPurchaseData itemPurchaseData,
      int purchaseCount,
      int beforeFreeCoin,
      int beforePaidCoin,
      bool isConvertCheck,
      Action OnClickClose,
      bool isPaidCoin = false)
    {
    }

    [Token(Token = "0x6017672")]
    [Address(RVA = "0x2908538", Offset = "0x2908538", VA = "0x2908538")]
    private void DestroyObj()
    {
    }

    [Token(Token = "0x6017673")]
    [Address(RVA = "0x2908884", Offset = "0x2908884", VA = "0x2908884")]
    public void UpdateShopIndex(int nextShopListIndex)
    {
    }

    [Token(Token = "0x6017674")]
    [Address(RVA = "0x290888C", Offset = "0x290888C", VA = "0x290888C")]
    public void UpdateShop(int nextShopListIndex)
    {
    }

    [Token(Token = "0x6017675")]
    [Address(RVA = "0x2909E84", Offset = "0x2909E84", VA = "0x2909E84")]
    private void SetLimitTime(bool isShopExists, PlayerShopResetButtonType resetButtonType)
    {
    }

    [Token(Token = "0x6017676")]
    [Address(RVA = "0x2909F54", Offset = "0x2909F54", VA = "0x2909F54")]
    private IEnumerator UpdateContainer() => (IEnumerator) null;

    [Token(Token = "0x6017677")]
    [Address(RVA = "0x2909FBC", Offset = "0x2909FBC", VA = "0x2909FBC", Slot = "7")]
    public override void Open(string preBelowName)
    {
    }

    [Token(Token = "0x6017678")]
    [Address(RVA = "0x290A1BC", Offset = "0x290A1BC", VA = "0x290A1BC", Slot = "8")]
    public override void Close(string nextBelowName)
    {
    }

    [Token(Token = "0x6017679")]
    [Address(RVA = "0x290A50C", Offset = "0x290A50C", VA = "0x290A50C")]
    public void DummyCatalogOperationPossible(bool flg)
    {
    }

    [Token(Token = "0x601767A")]
    [Address(RVA = "0x290A518", Offset = "0x290A518", VA = "0x290A518")]
    private void UpdateJumpMove()
    {
    }

    [Token(Token = "0x601767B")]
    [Address(RVA = "0x290A5A4", Offset = "0x290A5A4", VA = "0x290A5A4")]
    private void SetJumpMove(float val)
    {
    }

    [Token(Token = "0x601767C")]
    [Address(RVA = "0x290A5F8", Offset = "0x290A5F8", VA = "0x290A5F8")]
    private void ListLabelPlacement(Transform parent, RectTransform badge, RectTransform transfer)
    {
    }

    [Token(Token = "0x601767D")]
    [Address(RVA = "0x290A824", Offset = "0x290A824", VA = "0x290A824")]
    private void Update()
    {
    }

    [Token(Token = "0x601767E")]
    [Address(RVA = "0x290A9F8", Offset = "0x290A9F8", VA = "0x290A9F8")]
    private void ShopUpdate(bool isAutoUpdate)
    {
    }

    [Token(Token = "0x601767F")]
    [Address(RVA = "0x290AF80", Offset = "0x290AF80", VA = "0x290AF80")]
    public IEnumerator ConnectUpdateError(NetworkErrorResult errorResult) => (IEnumerator) null;

    [Token(Token = "0x6017680")]
    [Address(RVA = "0x290AFE8", Offset = "0x290AFE8", VA = "0x290AFE8")]
    public void OnFinishToGetProductIds(UpdateProductResultCode resultCode)
    {
    }

    [Token(Token = "0x6017681")]
    [Address(RVA = "0x290ACA8", Offset = "0x290ACA8", VA = "0x290ACA8")]
    private void OpenReloadStonePopup(PlayerShopResetButtonType resetButton)
    {
    }

    [Token(Token = "0x6017682")]
    [Address(RVA = "0x290B104", Offset = "0x290B104", VA = "0x290B104")]
    private void OpenReloadStonePopup(ReloadStonePopup popup, PlayerShopResetButtonType resetButton)
    {
    }

    [Token(Token = "0x6017683")]
    [Address(RVA = "0x290AE14", Offset = "0x290AE14", VA = "0x290AE14")]
    private void OpenReloadZenyPopup(PlayerShopResetButtonType resetButton)
    {
    }

    [Token(Token = "0x6017684")]
    [Address(RVA = "0x290B310", Offset = "0x290B310", VA = "0x290B310")]
    private void OpenReloadZenyPopup(ReloadZenyPopup popup, PlayerShopResetButtonType resetButton)
    {
    }

    [Token(Token = "0x6017685")]
    [Address(RVA = "0x290AB80", Offset = "0x290AB80", VA = "0x290AB80")]
    private void OpenReloadFreePopup()
    {
    }

    [Token(Token = "0x6017686")]
    [Address(RVA = "0x290B51C", Offset = "0x290B51C", VA = "0x290B51C")]
    private void OpenReloadFreePopup(ReloadFreePopup popup)
    {
    }

    [Token(Token = "0x6017687")]
    [Address(RVA = "0x290B6F8", Offset = "0x290B6F8", VA = "0x290B6F8")]
    public void OpenToShortagePopupByUpdateButton(
      bool isBilling,
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      Action finishAction = null)
    {
    }

    [Token(Token = "0x6017688")]
    [Address(RVA = "0x290B85C", Offset = "0x290B85C", VA = "0x290B85C")]
    public void OpenShortagePopup(
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      Action finishCallback = null)
    {
    }

    [Token(Token = "0x6017689")]
    [Address(RVA = "0x290B9F4", Offset = "0x290B9F4", VA = "0x290B9F4")]
    private void OpenShortagePopup(
      ShortagePopup popup,
      PaymentTypeEnum paymentType,
      int paymentId,
      int paymentAmount,
      Action finishCallback = null)
    {
    }

    [Token(Token = "0x601768A")]
    [Address(RVA = "0x2907684", Offset = "0x2907684", VA = "0x2907684")]
    private IEnumerator WaitPopupAnimation(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x601768B")]
    [Address(RVA = "0x2907408", Offset = "0x2907408", VA = "0x2907408")]
    private void OpenPopup(
      ShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      ShopLoader.TimelineType timelineType = ShopLoader.TimelineType.CommonPopupIn,
      Action onFinish = null)
    {
    }

    [Token(Token = "0x601768C")]
    [Address(RVA = "0x290BBBC", Offset = "0x290BBBC", VA = "0x290BBBC")]
    private void ClosePopup(
      ShopLoader.ShopAssetType shopAssetType,
      PopupBase popup,
      ShopLoader.TimelineType timelineType = ShopLoader.TimelineType.CommonPopupOut)
    {
    }

    [Token(Token = "0x601768D")]
    [Address(RVA = "0x290BDEC", Offset = "0x290BDEC", VA = "0x290BDEC")]
    public void OnClickToSpecifiedCommercialTransactionsAct()
    {
    }

    [Token(Token = "0x601768E")]
    [Address(RVA = "0x290BE18", Offset = "0x290BE18", VA = "0x290BE18")]
    public void OnClickToPaymentServicesAct()
    {
    }

    [Token(Token = "0x601768F")]
    [Address(RVA = "0x290BE44", Offset = "0x290BE44", VA = "0x290BE44")]
    private void OpenOtherDetailPopup(ItemPurchaseData.ItemRewardData rewardData)
    {
    }

    [Token(Token = "0x6017690")]
    [Address(RVA = "0x290BF8C", Offset = "0x290BF8C", VA = "0x290BF8C")]
    public void OnClickToChangeView()
    {
    }

    [Token(Token = "0x6017691")]
    [Address(RVA = "0x290C070", Offset = "0x290C070", VA = "0x290C070")]
    public void OnClickToChangeMedalView()
    {
    }

    [Token(Token = "0x6017692")]
    [Address(RVA = "0x290C154", Offset = "0x290C154", VA = "0x290C154")]
    public void OnClickButtonCoin()
    {
    }

    [Token(Token = "0x6017693")]
    [Address(RVA = "0x290C28C", Offset = "0x290C28C", VA = "0x290C28C")]
    public GlobalShopBelowScreen()
    {
    }

    [Token(Token = "0x2003B7E")]
    public class GlobalShopBelowScreenParam : ChangeBelowScreenParameter
    {
      [Token(Token = "0x401072D")]
      [FieldOffset(Offset = "0x18")]
      private ShopLoader shopLoader;
      [Token(Token = "0x401072E")]
      [FieldOffset(Offset = "0x20")]
      private ShopAPIManager shopAPI;
      [Token(Token = "0x401072F")]
      [FieldOffset(Offset = "0x28")]
      private AssetCachedSpawner cachedSpawner;
      [Token(Token = "0x4010730")]
      [FieldOffset(Offset = "0x30")]
      private int nowShopIndex;
      [Token(Token = "0x4010731")]
      [FieldOffset(Offset = "0x38")]
      private Action<bool> onSetSideButtonActive;
      [Token(Token = "0x4010732")]
      [FieldOffset(Offset = "0x40")]
      private Action<int> onMoveMedalShop;

      [Token(Token = "0x17004C2D")]
      public ShopLoader ShopLoader
      {
        [Token(Token = "0x601769E"), Address(RVA = "0x290C6B8", Offset = "0x290C6B8", VA = "0x290C6B8")] get
        {
          return (ShopLoader) null;
        }
      }

      [Token(Token = "0x17004C2E")]
      public ShopAPIManager ShopAPI
      {
        [Token(Token = "0x601769F"), Address(RVA = "0x290C6C0", Offset = "0x290C6C0", VA = "0x290C6C0")] get
        {
          return (ShopAPIManager) null;
        }
      }

      [Token(Token = "0x17004C2F")]
      public AssetCachedSpawner CachedSpawner
      {
        [Token(Token = "0x60176A0"), Address(RVA = "0x290C6C8", Offset = "0x290C6C8", VA = "0x290C6C8")] get
        {
          return (AssetCachedSpawner) null;
        }
      }

      [Token(Token = "0x17004C30")]
      public int NowShopIndex
      {
        [Token(Token = "0x60176A1"), Address(RVA = "0x290C6D0", Offset = "0x290C6D0", VA = "0x290C6D0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17004C31")]
      public Action<bool> OnSetSideButtonActive
      {
        [Token(Token = "0x60176A2"), Address(RVA = "0x290C6D8", Offset = "0x290C6D8", VA = "0x290C6D8")] get
        {
          return (Action<bool>) null;
        }
      }

      [Token(Token = "0x17004C32")]
      public Action<int> OnMoveMedalShop
      {
        [Token(Token = "0x60176A3"), Address(RVA = "0x290C6E0", Offset = "0x290C6E0", VA = "0x290C6E0")] get
        {
          return (Action<int>) null;
        }
      }

      [Token(Token = "0x60176A4")]
      [Address(RVA = "0x2902898", Offset = "0x2902898", VA = "0x2902898")]
      public GlobalShopBelowScreenParam(
        int nowShopIndex,
        ShopLoader shopLoader,
        ShopAPIManager shopAPI,
        AssetCachedSpawner cachedSpawner,
        Action<bool> onSetSideButtonActive,
        Action<int> onMoveMedalShop)
      {
      }
    }
  }
}

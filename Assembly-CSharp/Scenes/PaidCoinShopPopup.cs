// Decompiled with JetBrains decompiler
// Type: Scenes.PaidCoinShopPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore;
using GameCore.Input;
using GameCore.MasterData;
using GameCore.Popup;
using Il2CppDummyDll;
using Network.API;
using Network.Param;
using PurchaseModule.Product;
using Scenes.OutGame.OutGameMenu.GlobalShop;
using Scenes.OutGame.OutGameMenu.PassShop;
using Staq.Purchase;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes
{
  [Token(Token = "0x2002893")]
  public class PaidCoinShopPopup : PopupBase
  {
    [Token(Token = "0x400AD15")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private CommonButton stoneButton;
    [Token(Token = "0x400AD16")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text allStoneValue;
    [Token(Token = "0x400AD17")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Transform tabParent;
    [Token(Token = "0x400AD18")]
    [FieldOffset(Offset = "0xA0")]
    private List<PaidCoinShopPopupTabItem> tabs;
    [Token(Token = "0x400AD19")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton SpecifiedCommercialTransactionButton;
    [Token(Token = "0x400AD1A")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private CommonButton PaymentServicesButton;
    [Token(Token = "0x400AD1B")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private ScrollRect contentScroll;
    [Token(Token = "0x400AD1C")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Transform smallListParent;
    [Token(Token = "0x400AD1D")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private ScrollRect tabScrollRect;
    [Token(Token = "0x400AD1E")]
    [FieldOffset(Offset = "0xD0")]
    private GameObject smallListItemCol;
    [Token(Token = "0x400AD1F")]
    [FieldOffset(Offset = "0xD8")]
    private GameObject smallListItem;
    [Token(Token = "0x400AD20")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Transform largeListParent;
    [Token(Token = "0x400AD21")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Button cancelButton;
    [Token(Token = "0x400AD22")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject NoneItemDisplayObject;
    [Token(Token = "0x400AD23")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x400AD24")]
    [FieldOffset(Offset = "0x100")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x400AD25")]
    [FieldOffset(Offset = "0x108")]
    private BuyConfirmStonePopup buyConfirmStonePopup;
    [Token(Token = "0x400AD27")]
    [FieldOffset(Offset = "0x118")]
    public Dictionary<string, ProductInfo> products;
    [Token(Token = "0x400AD28")]
    [FieldOffset(Offset = "0x120")]
    private PaidCoinShopPopupItemInfo selectedInfo;
    [Token(Token = "0x400AD29")]
    [FieldOffset(Offset = "0x128")]
    private GameObject tabItem;
    [Token(Token = "0x400AD2A")]
    [FieldOffset(Offset = "0x130")]
    private GameObject singlColItem;
    [Token(Token = "0x400AD2B")]
    [FieldOffset(Offset = "0x138")]
    private GameObject singleItem;
    [Token(Token = "0x400AD2C")]
    [FieldOffset(Offset = "0x140")]
    private GameObject setItem;
    [Token(Token = "0x400AD2D")]
    [FieldOffset(Offset = "0x148")]
    private int beforePaid;
    [Token(Token = "0x400AD2E")]
    [FieldOffset(Offset = "0x14C")]
    private int beforeFreeCommon;
    [Token(Token = "0x400AD2F")]
    [FieldOffset(Offset = "0x150")]
    private Action OnSuccessPurchase;
    [Token(Token = "0x400AD30")]
    [FieldOffset(Offset = "0x158")]
    private bool isInitialized;
    [Token(Token = "0x400AD31")]
    [FieldOffset(Offset = "0x160")]
    public Action closeAction;

    [Token(Token = "0x17003828")]
    public List<Component> components
    {
      [Token(Token = "0x600FF8B"), Address(RVA = "0x40FB61C", Offset = "0x40FB61C", VA = "0x40FB61C")] get
      {
        return (List<Component>) null;
      }
      [Token(Token = "0x600FF8C"), Address(RVA = "0x40FB624", Offset = "0x40FB624", VA = "0x40FB624")] private set
      {
      }
    }

    [Token(Token = "0x600FF8D")]
    [Address(RVA = "0x40FB62C", Offset = "0x40FB62C", VA = "0x40FB62C")]
    private void Awake()
    {
    }

    [Token(Token = "0x600FF8E")]
    [Address(RVA = "0x40FB814", Offset = "0x40FB814", VA = "0x40FB814", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x600FF8F")]
    [Address(RVA = "0x40F8E24", Offset = "0x40F8E24", VA = "0x40F8E24")]
    public void Open(BuyConfirmStonePopup buyConfirmStonePopup)
    {
    }

    [Token(Token = "0x600FF90")]
    [Address(RVA = "0x40F9FF0", Offset = "0x40F9FF0", VA = "0x40F9FF0")]
    public void Open(AssetCachedSpawner spawner = null, Action finishAction = null, int firstViewId = 0)
    {
    }

    [Token(Token = "0x600FF91")]
    [Address(RVA = "0x40FB920", Offset = "0x40FB920", VA = "0x40FB920")]
    private void OpenPopup(int firstViewId = 0)
    {
    }

    [Token(Token = "0x600FF92")]
    [Address(RVA = "0x40FBB18", Offset = "0x40FBB18", VA = "0x40FBB18")]
    private IEnumerator APICoinShopList(int firstViewId) => (IEnumerator) null;

    [Token(Token = "0x600FF93")]
    [Address(RVA = "0x40FBBB8", Offset = "0x40FBBB8", VA = "0x40FBBB8")]
    private void LoadAsset()
    {
    }

    [Token(Token = "0x600FF94")]
    [Address(RVA = "0x40FBDD0", Offset = "0x40FBDD0", VA = "0x40FBDD0")]
    private void CreateTab(APICoinShopListResponse response)
    {
    }

    [Token(Token = "0x600FF95")]
    [Address(RVA = "0x40FC0FC", Offset = "0x40FC0FC", VA = "0x40FC0FC")]
    private void SelectTab(int selectIndex)
    {
    }

    [Token(Token = "0x600FF96")]
    [Address(RVA = "0x40FCAFC", Offset = "0x40FCAFC", VA = "0x40FCAFC")]
    private void SetTabPosition(float selectIndex)
    {
    }

    [Token(Token = "0x600FF97")]
    [Address(RVA = "0x40FC218", Offset = "0x40FC218", VA = "0x40FC218")]
    private void CreateItemsSingle(PlayerCoinShopType coinShopType)
    {
    }

    [Token(Token = "0x600FF98")]
    [Address(RVA = "0x40FCA88", Offset = "0x40FCA88", VA = "0x40FCA88")]
    private IEnumerator CreateItemsSet(PlayerCoinShopType coinShopType) => (IEnumerator) null;

    [Token(Token = "0x600FF99")]
    [Address(RVA = "0x40FC07C", Offset = "0x40FC07C", VA = "0x40FC07C")]
    public static GameObject CreateGameObject(GameObject go, Transform parent) => (GameObject) null;

    [Token(Token = "0x600FF9A")]
    [Address(RVA = "0x40FCDA4", Offset = "0x40FCDA4", VA = "0x40FCDA4")]
    private void OnStoneButton()
    {
    }

    [Token(Token = "0x600FF9B")]
    [Address(RVA = "0x40FCE20", Offset = "0x40FCE20", VA = "0x40FCE20")]
    private void OnOpenSpecifiedCommercialTransaction()
    {
    }

    [Token(Token = "0x600FF9C")]
    [Address(RVA = "0x40FCE28", Offset = "0x40FCE28", VA = "0x40FCE28")]
    private void OnOpenPaymentServices()
    {
    }

    [Token(Token = "0x600FF9D")]
    [Address(RVA = "0x40F78DC", Offset = "0x40F78DC", VA = "0x40F78DC")]
    public void IfPurchase(PaidCoinShopPopupItemInfo info, Action otherCallback)
    {
    }

    [Token(Token = "0x600FF9E")]
    [Address(RVA = "0x40FCE30", Offset = "0x40FCE30", VA = "0x40FCE30")]
    private IEnumerator IEIfPurchase(PaidCoinShopPopupItemInfo info, Action otherCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FF9F")]
    [Address(RVA = "0x40FB024", Offset = "0x40FB024", VA = "0x40FB024")]
    public void Purchase(PaidCoinShopPopupItemInfo info, Action otherCallback)
    {
    }

    [Token(Token = "0x600FFA0")]
    [Address(RVA = "0x40FCED4", Offset = "0x40FCED4", VA = "0x40FCED4")]
    private IEnumerator PurchaseInternal(PaidCoinShopPopupItemInfo info, Action otherCallback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FFA1")]
    [Address(RVA = "0x40FCF78", Offset = "0x40FCF78", VA = "0x40FCF78")]
    private void PurchaseFinishedSucceededCallback(FulfillmentTransaction transaction)
    {
    }

    [Token(Token = "0x600FFA2")]
    [Address(RVA = "0x40FD0A8", Offset = "0x40FD0A8", VA = "0x40FD0A8")]
    private IEnumerator APICoinShopAfterPurchase(FulfillmentTransaction transaction)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FFA3")]
    [Address(RVA = "0x40FD144", Offset = "0x40FD144", VA = "0x40FD144")]
    private void OpenAfterPurchaseDialog(FulfillmentTransaction transaction)
    {
    }

    [Token(Token = "0x600FFA4")]
    [Address(RVA = "0x40FD34C", Offset = "0x40FD34C", VA = "0x40FD34C")]
    private IEnumerator SetItemAfterPurchasePopup(
      ItemAfterPurchasePopup popup,
      int afterPaidCoin,
      int afterFreeCoin)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FFA5")]
    [Address(RVA = "0x40FD3FC", Offset = "0x40FD3FC", VA = "0x40FD3FC")]
    private IEnumerator SetPassItemAfterPurchasePopup(
      PassItemAfterPurchasePopup popup,
      int afterPaidCoin)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600FFA6")]
    [Address(RVA = "0x40FD4A0", Offset = "0x40FD4A0", VA = "0x40FD4A0")]
    private void OpenItemDetailPopup(int rewardId, RewardTypeEnum rewardType, GameObject obj)
    {
    }

    [Token(Token = "0x600FFA7")]
    [Address(RVA = "0x40FD4C8", Offset = "0x40FD4C8", VA = "0x40FD4C8")]
    private void OpenOtherDetailPopup(int rewardId, RewardTypeEnum rewardType, GameObject obj)
    {
    }

    [Token(Token = "0x600FFA8")]
    [Address(RVA = "0x40FD740", Offset = "0x40FD740", VA = "0x40FD740")]
    public PaidCoinShopPopup()
    {
    }

    [Token(Token = "0x2002894")]
    public enum ItemType
    {
      [Token(Token = "0x400AD33")] Single,
      [Token(Token = "0x400AD34")] Set,
      [Token(Token = "0x400AD35")] Pass,
      [Token(Token = "0x400AD36")] Reward,
    }
  }
}

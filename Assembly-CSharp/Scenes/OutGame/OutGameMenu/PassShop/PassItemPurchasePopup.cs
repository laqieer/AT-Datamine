// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.PassShop.PassItemPurchasePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using PurchaseModule.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.PassShop
{
  [Token(Token = "0x2003B42")]
  public class PassItemPurchasePopup : PopupBase
  {
    [Token(Token = "0x40105BA")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x40105BB")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text paidCoinNum;
    [Token(Token = "0x40105BC")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text cost;
    [Token(Token = "0x40105BD")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private RectTransform nonScrollParent;
    [Token(Token = "0x40105BE")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private RectTransform scrollParent;
    [Token(Token = "0x40105BF")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text gettingDayNotes;
    [Token(Token = "0x40105C0")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text gettingDayInfo;
    [Token(Token = "0x40105C1")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text gettingDayRewardInfo;
    [Token(Token = "0x40105C2")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Button buyButton;
    [Token(Token = "0x40105C3")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Button cancelButton;
    [Token(Token = "0x40105C4")]
    [FieldOffset(Offset = "0xD8")]
    public Action OnClickBuyAction;
    [Token(Token = "0x40105C6")]
    [FieldOffset(Offset = "0xE8")]
    protected Dictionary<ItemIcon, int> createdItemIcons;
    [Token(Token = "0x40105C7")]
    [FieldOffset(Offset = "0xF0")]
    private bool isNotCostSufficient;
    [Token(Token = "0x40105C8")]
    [FieldOffset(Offset = "0xF8")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40105C9")]
    [FieldOffset(Offset = "0x100")]
    private CommonShopItemData commonShopItem;
    [Token(Token = "0x40105CA")]
    [FieldOffset(Offset = "0x108")]
    private ItemDetailPopupProvider itemDetailPopup;
    [Token(Token = "0x40105CB")]
    [FieldOffset(Offset = "0x110")]
    private Dictionary<string, ProductInfo> products;

    [Token(Token = "0x17004C08")]
    public Action<ItemPurchaseData.ItemRewardData, bool> OnClickItemAction
    {
      [Token(Token = "0x6017518"), Address(RVA = "0x2722308", Offset = "0x2722308", VA = "0x2722308")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData, bool>) null;
      }
      [Token(Token = "0x6017519"), Address(RVA = "0x2722310", Offset = "0x2722310", VA = "0x2722310")] set
      {
      }
    }

    [Token(Token = "0x601751A")]
    [Address(RVA = "0x2722318", Offset = "0x2722318", VA = "0x2722318")]
    public void SetAssetSpawner(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x601751B")]
    [Address(RVA = "0x2722320", Offset = "0x2722320", VA = "0x2722320")]
    private void SetDayNotes(int day)
    {
    }

    [Token(Token = "0x601751C")]
    [Address(RVA = "0x272240C", Offset = "0x272240C", VA = "0x272240C")]
    private void SetDayInfo(int day)
    {
    }

    [Token(Token = "0x601751D")]
    [Address(RVA = "0x27224F8", Offset = "0x27224F8", VA = "0x27224F8")]
    private void SetDarRewardInfo(int day)
    {
    }

    [Token(Token = "0x601751E")]
    [Address(RVA = "0x27225E4", Offset = "0x27225E4", VA = "0x27225E4")]
    public void Open(
      AssetCachedSpawner spawner,
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info)
    {
    }

    [Token(Token = "0x601751F")]
    [Address(RVA = "0x2722A04", Offset = "0x2722A04", VA = "0x2722A04")]
    private void SetOnClick(
      PaidCoinShopPopupItemInfo info,
      PaidCoinShopPopup paidCoinShopPopup,
      Dictionary<string, ProductInfo> products)
    {
    }

    [Token(Token = "0x6017520")]
    [Address(RVA = "0x2722AD0", Offset = "0x2722AD0", VA = "0x2722AD0")]
    private IEnumerator CreateItems(
      AssetCachedSpawner spawner,
      int loginBonusId,
      ProductInfo productInfo,
      int paidCount)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017521")]
    [Address(RVA = "0x2722B90", Offset = "0x2722B90", VA = "0x2722B90")]
    public void SetData(
      CommonShopItemData commonShopItem,
      bool isBuy,
      GameObject passGroupItemPrefab,
      GameObject passItemPrefab,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6017522")]
    [Address(RVA = "0x2723080", Offset = "0x2723080", VA = "0x2723080")]
    private void CreateItems(
      ProductInfo productInfo,
      int paidCount,
      int loginBounsId,
      GameObject passGroupItemPrefab,
      GameObject passItemPrefab,
      AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x6017523")]
    [Address(RVA = "0x2723938", Offset = "0x2723938", VA = "0x2723938")]
    public void OnClickItem(AssetCachedSpawner spawner, RewardTypeEnum type, int id)
    {
    }

    [Token(Token = "0x6017524")]
    [Address(RVA = "0x2723AF8", Offset = "0x2723AF8", VA = "0x2723AF8")]
    public void OnClickItem(AssetCachedSpawner spawner, PaymentTypeEnum type, int id)
    {
    }

    [Token(Token = "0x6017525")]
    [Address(RVA = "0x2723C40", Offset = "0x2723C40", VA = "0x2723C40")]
    private void FalseButtonInteractable()
    {
    }

    [Token(Token = "0x6017526")]
    [Address(RVA = "0x2722964", Offset = "0x2722964", VA = "0x2722964")]
    private void SetStoneTextNum()
    {
    }

    [Token(Token = "0x6017527")]
    [Address(RVA = "0x2723C78", Offset = "0x2723C78", VA = "0x2723C78")]
    private void OnClickToBuy(ProductInfo productInfo)
    {
    }

    [Token(Token = "0x6017528")]
    [Address(RVA = "0x2723DFC", Offset = "0x2723DFC", VA = "0x2723DFC")]
    public PassItemPurchasePopup()
    {
    }
  }
}

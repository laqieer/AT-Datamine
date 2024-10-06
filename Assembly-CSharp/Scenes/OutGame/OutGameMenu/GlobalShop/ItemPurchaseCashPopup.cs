// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ItemPurchaseCashPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.MasterData;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using Network.Param;
using PurchaseModule.Product;
using System;
using System.Collections;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BB0")]
  public class ItemPurchaseCashPopup : PopupBase
  {
    [Token(Token = "0x40107FB")]
    private const string THUMB_PREFAB_LABEL = "ui_common_thumb";
    [Token(Token = "0x40107FC")]
    [FieldOffset(Offset = "0x88")]
    private AssetCachedSpawner spawner;
    [Token(Token = "0x40107FD")]
    [FieldOffset(Offset = "0x90")]
    private ProductInfo productInfo;
    [Token(Token = "0x40107FE")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x40107FF")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text posessionStoneNum;
    [Token(Token = "0x4010800")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text limitDayText;
    [Token(Token = "0x4010801")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private GameObject limitDayObj;
    [Token(Token = "0x4010802")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text limitTimeText;
    [Token(Token = "0x4010803")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private GameObject[] limitCommonGroup;
    [Token(Token = "0x4010804")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Image paidIcon;
    [Token(Token = "0x4010805")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text paidText;
    [Token(Token = "0x4010806")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x4010807")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text paymentText;
    [Token(Token = "0x4010808")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private Button buyButton;
    [Token(Token = "0x4010809")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x401080A")]
    [FieldOffset(Offset = "0xF8")]
    private ItemPurchaseData shopItemData;
    [Token(Token = "0x401080B")]
    [FieldOffset(Offset = "0x100")]
    private ItemIcon freeIcon;
    [Token(Token = "0x401080C")]
    [FieldOffset(Offset = "0x108")]
    private ItemDetailPopupProvider itemDetailPopup;

    [Token(Token = "0x17004C44")]
    public Action<ItemPurchaseData.ItemRewardData> OnClickItemAction
    {
      [Token(Token = "0x6017772"), Address(RVA = "0x2655018", Offset = "0x2655018", VA = "0x2655018")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData>) null;
      }
      [Token(Token = "0x6017773"), Address(RVA = "0x2655020", Offset = "0x2655020", VA = "0x2655020")] set
      {
      }
    }

    [Token(Token = "0x17004C45")]
    public Action<bool> OnClickStoneAction
    {
      [Token(Token = "0x6017774"), Address(RVA = "0x2655028", Offset = "0x2655028", VA = "0x2655028")] get
      {
        return (Action<bool>) null;
      }
      [Token(Token = "0x6017775"), Address(RVA = "0x2655030", Offset = "0x2655030", VA = "0x2655030")] set
      {
      }
    }

    [Token(Token = "0x17004C46")]
    public Action<ProductInfo> OnConfirm
    {
      [Token(Token = "0x6017776"), Address(RVA = "0x2655038", Offset = "0x2655038", VA = "0x2655038")] get
      {
        return (Action<ProductInfo>) null;
      }
      [Token(Token = "0x6017777"), Address(RVA = "0x2655040", Offset = "0x2655040", VA = "0x2655040")] set
      {
      }
    }

    [Token(Token = "0x17004C47")]
    public BirthdayRegistrationPopup BirthdayRegistrationPopup
    {
      [Token(Token = "0x6017778"), Address(RVA = "0x2655048", Offset = "0x2655048", VA = "0x2655048")] get
      {
        return (BirthdayRegistrationPopup) null;
      }
      [Token(Token = "0x6017779"), Address(RVA = "0x2655050", Offset = "0x2655050", VA = "0x2655050")] private set
      {
      }
    }

    [Token(Token = "0x601777A")]
    [Address(RVA = "0x2655058", Offset = "0x2655058", VA = "0x2655058")]
    private void RemoveItem()
    {
    }

    [Token(Token = "0x601777B")]
    [Address(RVA = "0x26550FC", Offset = "0x26550FC", VA = "0x26550FC")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601777C")]
    [Address(RVA = "0x2655100", Offset = "0x2655100", VA = "0x2655100")]
    private string GetAssetName(RewardTypeEnum rewardType) => (string) null;

    [Token(Token = "0x601777D")]
    [Address(RVA = "0x2655184", Offset = "0x2655184", VA = "0x2655184")]
    public void SetAssetSpawner(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x601777E")]
    [Address(RVA = "0x265518C", Offset = "0x265518C", VA = "0x265518C")]
    private IEnumerator CreateThumb(
      ItemPurchaseData.ItemRewardData rewardData,
      AssetCachedSpawner spawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x601777F")]
    [Address(RVA = "0x2655230", Offset = "0x2655230", VA = "0x2655230")]
    public void OnClickItem(AssetCachedSpawner spawner, RewardTypeEnum type, int id)
    {
    }

    [Token(Token = "0x6017780")]
    [Address(RVA = "0x26553F0", Offset = "0x26553F0", VA = "0x26553F0")]
    public IEnumerator Open(
      AssetCachedSpawner spawner,
      PaidCoinShopPopup paidCoinShopPopup,
      PaidCoinShopPopupItemInfo info)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017781")]
    [Address(RVA = "0x26554A0", Offset = "0x26554A0", VA = "0x26554A0")]
    private IEnumerator SettingCoin(
      int paidCoinCount,
      int freeCoinCount,
      AssetCachedSpawner spawner)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017782")]
    [Address(RVA = "0x2655550", Offset = "0x2655550", VA = "0x2655550")]
    private void ButtonSetting(ProductInfo info, Action closeAction = null)
    {
    }

    [Token(Token = "0x6017783")]
    [Address(RVA = "0x26556B4", Offset = "0x26556B4", VA = "0x26556B4")]
    private void SetLimitObject(bool isLimited, string endTime)
    {
    }

    [Token(Token = "0x6017784")]
    [Address(RVA = "0x2655A14", Offset = "0x2655A14", VA = "0x2655A14")]
    private void SetOnClick(PaidCoinShopPopupItemInfo info, PaidCoinShopPopup paidCoinShopPopup)
    {
    }

    [Token(Token = "0x6017785")]
    [Address(RVA = "0x2655AD8", Offset = "0x2655AD8", VA = "0x2655AD8")]
    public IEnumerator SetData(
      ProductInfo info,
      ItemPurchaseData shopItemData,
      PlayerShopType playerShop,
      Action closeAction = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6017786")]
    [Address(RVA = "0x2655B90", Offset = "0x2655B90", VA = "0x2655B90")]
    private void FalseButtonInteractable()
    {
    }

    [Token(Token = "0x6017787")]
    [Address(RVA = "0x2655BC8", Offset = "0x2655BC8", VA = "0x2655BC8")]
    public void OnClickToConfirm(ProductInfo info)
    {
    }

    [Token(Token = "0x6017788")]
    [Address(RVA = "0x2655E08", Offset = "0x2655E08", VA = "0x2655E08")]
    public ItemPurchaseCashPopup()
    {
    }
  }
}

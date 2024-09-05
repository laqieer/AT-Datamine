// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ItemPurchasePopupBase
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
using StaqData;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BBD")]
  public abstract class ItemPurchasePopupBase : PopupBase
  {
    [Token(Token = "0x4010846")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    protected Text productName;
    [Token(Token = "0x4010847")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    protected ItemIcon baseItemIcon;
    [Token(Token = "0x4010848")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    protected RectTransform itemParent;
    [Token(Token = "0x4010849")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    protected GameObject limitObj;
    [Token(Token = "0x401084A")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    protected Text limitDateTxt;
    [Token(Token = "0x401084B")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    protected Text limitDataDayTxt;
    [Token(Token = "0x401084C")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    protected Text limitDateTimeTxt;
    [Token(Token = "0x401084D")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    protected Text maxCountTxt;
    [Token(Token = "0x401084E")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    protected Text selecedCountTxt;
    [Token(Token = "0x401084F")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    protected GameObject fluctButtonObj;
    [Token(Token = "0x4010850")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    protected LongPressButton plusButton;
    [Token(Token = "0x4010851")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    protected LongPressButton minusButton;
    [Token(Token = "0x4010852")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    protected CommonButton plusMaxButton;
    [Token(Token = "0x4010853")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    protected CommonButton minusResetButton;
    [Token(Token = "0x4010854")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    protected RectTransform alertUiParent;
    [Token(Token = "0x4010855")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    protected Text unitCostTxt;
    [Token(Token = "0x4010856")]
    [FieldOffset(Offset = "0x108")]
    [SerializeField]
    protected Text totalCostTxt;
    [Token(Token = "0x4010857")]
    [FieldOffset(Offset = "0x110")]
    [SerializeField]
    protected Text cancelTxt;
    [Token(Token = "0x4010858")]
    [FieldOffset(Offset = "0x118")]
    [SerializeField]
    protected Text confirmTxt;
    [Token(Token = "0x4010859")]
    [FieldOffset(Offset = "0x120")]
    [SerializeField]
    protected CommonButton confirmButton;
    [Token(Token = "0x401085D")]
    [FieldOffset(Offset = "0x140")]
    protected AssetCachedSpawner cachedSpawner;
    [Token(Token = "0x401085E")]
    [FieldOffset(Offset = "0x148")]
    private int maxItemNum;
    [Token(Token = "0x401085F")]
    [FieldOffset(Offset = "0x14C")]
    protected int addItemNum;
    [Token(Token = "0x4010860")]
    [FieldOffset(Offset = "0x150")]
    protected ItemPurchasePopupBase.ViewType viewType;
    [Token(Token = "0x4010861")]
    [FieldOffset(Offset = "0x154")]
    protected bool isNotCostSufficient;
    [Token(Token = "0x4010862")]
    [FieldOffset(Offset = "0x158")]
    protected ItemPurchaseData itemPurchaseData;
    [Token(Token = "0x4010863")]
    [FieldOffset(Offset = "0x160")]
    protected Dictionary<ItemIcon, int> createdItemIcons;
    [Token(Token = "0x4010864")]
    [FieldOffset(Offset = "0x168")]
    protected Dictionary<StyleThumb, int> createdStyleThumbs;
    [Token(Token = "0x4010865")]
    [FieldOffset(Offset = "0x170")]
    protected Dictionary<MindequipmentThumb, int> createdMindEquipThumbs;
    [Token(Token = "0x4010866")]
    [FieldOffset(Offset = "0x178")]
    protected DateTime? limitTime;

    [Token(Token = "0x17004C50")]
    public Action<int> OnBuyAction
    {
      [Token(Token = "0x60177BF"), Address(RVA = "0x2657FF8", Offset = "0x2657FF8", VA = "0x2657FF8")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x60177C0"), Address(RVA = "0x2658000", Offset = "0x2658000", VA = "0x2658000")] set
      {
      }
    }

    [Token(Token = "0x17004C51")]
    public Action<PaymentTypeEnum, int, int, Action> OnInsufficientFundsAction
    {
      [Token(Token = "0x60177C1"), Address(RVA = "0x2658008", Offset = "0x2658008", VA = "0x2658008")] get
      {
        return (Action<PaymentTypeEnum, int, int, Action>) null;
      }
      [Token(Token = "0x60177C2"), Address(RVA = "0x2658010", Offset = "0x2658010", VA = "0x2658010")] set
      {
      }
    }

    [Token(Token = "0x17004C52")]
    public Action<ItemPurchaseData.ItemRewardData> OnClickItemAction
    {
      [Token(Token = "0x60177C3"), Address(RVA = "0x2658018", Offset = "0x2658018", VA = "0x2658018")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData>) null;
      }
      [Token(Token = "0x60177C4"), Address(RVA = "0x2658020", Offset = "0x2658020", VA = "0x2658020")] set
      {
      }
    }

    [Token(Token = "0x60177C5")]
    [Address(RVA = "0x2653D0C", Offset = "0x2653D0C", VA = "0x2653D0C", Slot = "10")]
    protected virtual void SetButtonText()
    {
    }

    [Token(Token = "0x60177C6")]
    [Address(RVA = "0x2658028", Offset = "0x2658028", VA = "0x2658028")]
    public void SetAssetCachedSpawner(AssetCachedSpawner cachedSpawner)
    {
    }

    [Token(Token = "0x60177C7")]
    [Address(RVA = "0x2658030", Offset = "0x2658030", VA = "0x2658030", Slot = "11")]
    protected virtual void ClearItemList()
    {
    }

    [Token(Token = "0x60177C8")]
    [Address(RVA = "0x26584E4", Offset = "0x26584E4", VA = "0x26584E4", Slot = "12")]
    protected virtual void SetItem(ItemPurchaseData.ItemRewardData[] itemRewards)
    {
    }

    [Token(Token = "0x60177C9")]
    [Address(RVA = "0x2658AD8", Offset = "0x2658AD8", VA = "0x2658AD8", Slot = "13")]
    public virtual void PlayAlertUI()
    {
    }

    [Token(Token = "0x60177CA")]
    protected abstract void SetCostData(int amount);

    [Token(Token = "0x60177CB")]
    [Address(RVA = "0x2658C2C", Offset = "0x2658C2C", VA = "0x2658C2C")]
    private void SetPurchaseData(int nextValue)
    {
    }

    [Token(Token = "0x60177CC")]
    [Address(RVA = "0x2654720", Offset = "0x2654720", VA = "0x2654720", Slot = "15")]
    protected virtual void SetCountByMinus(bool isCountMax = false)
    {
    }

    [Token(Token = "0x60177CD")]
    [Address(RVA = "0x26547A4", Offset = "0x26547A4", VA = "0x26547A4")]
    protected void SetCountByMinus(int possessionValue, bool isCountMax = false)
    {
    }

    [Token(Token = "0x60177CE")]
    [Address(RVA = "0x2658C94", Offset = "0x2658C94", VA = "0x2658C94")]
    protected void SetActiveFluctButton(bool is_active)
    {
    }

    [Token(Token = "0x60177CF")]
    [Address(RVA = "0x2658D2C", Offset = "0x2658D2C", VA = "0x2658D2C")]
    public void OnPlusLongPress()
    {
    }

    [Token(Token = "0x60177D0")]
    [Address(RVA = "0x2658D30", Offset = "0x2658D30", VA = "0x2658D30")]
    public void OnPlusClick()
    {
    }

    [Token(Token = "0x60177D1")]
    [Address(RVA = "0x2658D74", Offset = "0x2658D74", VA = "0x2658D74")]
    public void OnPlusMaxClick()
    {
    }

    [Token(Token = "0x60177D2")]
    [Address(RVA = "0x2658DA8", Offset = "0x2658DA8", VA = "0x2658DA8")]
    public void OnMinusLongPress()
    {
    }

    [Token(Token = "0x60177D3")]
    [Address(RVA = "0x2658DC0", Offset = "0x2658DC0", VA = "0x2658DC0")]
    public void OnMinusClick()
    {
    }

    [Token(Token = "0x60177D4")]
    [Address(RVA = "0x2658DD8", Offset = "0x2658DD8", VA = "0x2658DD8")]
    public void OnMinusResetClick()
    {
    }

    [Token(Token = "0x60177D5")]
    [Address(RVA = "0x2658DE0", Offset = "0x2658DE0", VA = "0x2658DE0")]
    private void SetButtonCallback()
    {
    }

    [Token(Token = "0x60177D6")]
    [Address(RVA = "0x26590B0", Offset = "0x26590B0", VA = "0x26590B0")]
    public void SetData(
      ItemPurchasePopupBase.ViewType viewType,
      ItemPurchaseData itemPurchaseData,
      PlayerShopType playerShop)
    {
    }

    [Token(Token = "0x60177D7")]
    [Address(RVA = "0x2659470", Offset = "0x2659470", VA = "0x2659470")]
    private void UpdateLimitTimeObj(TimeSpan timeSpan)
    {
    }

    [Token(Token = "0x60177D8")]
    [Address(RVA = "0x265973C", Offset = "0x265973C", VA = "0x265973C", Slot = "16")]
    protected virtual void UpdateCost()
    {
    }

    [Token(Token = "0x60177D9")]
    [Address(RVA = "0x2659740", Offset = "0x2659740", VA = "0x2659740")]
    public void OnClickToConfrimButton()
    {
    }

    [Token(Token = "0x60177DA")]
    [Address(RVA = "0x2659844", Offset = "0x2659844", VA = "0x2659844")]
    public void OnClickToItemDescription(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x60177DB")]
    [Address(RVA = "0x26598F4", Offset = "0x26598F4", VA = "0x26598F4")]
    private void Update()
    {
    }

    [Token(Token = "0x60177DC")]
    [Address(RVA = "0x2659A94", Offset = "0x2659A94", VA = "0x2659A94")]
    private void SetupStyleThumb(int styleId, StyleThumb styleThumb)
    {
    }

    [Token(Token = "0x60177DD")]
    [Address(RVA = "0x2659CB8", Offset = "0x2659CB8", VA = "0x2659CB8")]
    private void SetupMindEquipmentThumb(int mindEquipmentId, MindequipmentThumb mindequipmentThumb)
    {
    }

    [Token(Token = "0x60177DE")]
    [Address(RVA = "0x2659E94", Offset = "0x2659E94", VA = "0x2659E94")]
    public void OnClickToStyleThumb(StyleThumb styleThumb)
    {
    }

    [Token(Token = "0x60177DF")]
    [Address(RVA = "0x2659F44", Offset = "0x2659F44", VA = "0x2659F44")]
    public void OnClickToMindEquipThumb(MindequipmentThumb mindequipmentThumb)
    {
    }

    [Token(Token = "0x60177E0")]
    [Address(RVA = "0x2658670", Offset = "0x2658670", VA = "0x2658670")]
    protected void SetItemThumb(
      int index,
      ItemPurchaseData.ItemRewardData itemRewardData,
      ItemUtility.Parameter rewardParam)
    {
    }

    [Token(Token = "0x60177E1")]
    [Address(RVA = "0x265485C", Offset = "0x265485C", VA = "0x265485C")]
    protected ItemPurchasePopupBase()
    {
    }

    [Token(Token = "0x2003BBE")]
    public enum ViewType
    {
      [Token(Token = "0x4010868")] Single,
      [Token(Token = "0x4010869")] Set,
    }
  }
}

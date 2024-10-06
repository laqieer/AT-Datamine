// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.ItemAfterPurchasePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Data;
using GameCore;
using GameCore.Input;
using GameCore.Popup;
using GameCore.UIControls;
using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;
using UI.ItemDetail;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BA7")]
  public class ItemAfterPurchasePopup : PopupBase
  {
    [Token(Token = "0x40107C3")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private ItemIcon baseItemIcon;
    [Token(Token = "0x40107C4")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private RectTransform itemIconParent;
    [Token(Token = "0x40107C5")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text afterPurchaseTxt;
    [Token(Token = "0x40107C6")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text beforeFreeCoinTxt;
    [Token(Token = "0x40107C7")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text afterFreeCoinTxt;
    [Token(Token = "0x40107C8")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text beforePaidCoinTxt;
    [Token(Token = "0x40107C9")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text afterPaidCoinTxt;
    [Token(Token = "0x40107CA")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text closeButtonTxt;
    [Token(Token = "0x40107CB")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Image paidStoneIcon;
    [Token(Token = "0x40107CC")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Text rewardPaidStoneNum;
    [Token(Token = "0x40107CD")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Image freeStoneIcon;
    [Token(Token = "0x40107CE")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text rewardFreeStoneNum;
    [Token(Token = "0x40107CF")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private GameObject presentPaidStone;
    [Token(Token = "0x40107D0")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private GameObject presentFreeStone;
    [Token(Token = "0x40107D1")]
    [FieldOffset(Offset = "0xF8")]
    [SerializeField]
    private GameObject itemListRoot;
    [Token(Token = "0x40107D2")]
    [FieldOffset(Offset = "0x100")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40107D3")]
    [FieldOffset(Offset = "0x108")]
    protected Dictionary<ItemIcon, int> createdItemIcons;
    [Token(Token = "0x40107D4")]
    [FieldOffset(Offset = "0x110")]
    private Dictionary<StyleThumb, int> createdStyleThumbs;
    [Token(Token = "0x40107D5")]
    [FieldOffset(Offset = "0x118")]
    private Dictionary<MindequipmentThumb, int> createdMindEquipThumbs;
    [Token(Token = "0x40107D8")]
    [FieldOffset(Offset = "0x130")]
    private AssetCachedSpawner cachedSpawner;
    [Token(Token = "0x40107D9")]
    [FieldOffset(Offset = "0x138")]
    private ItemPurchaseData itemPurchaseData;
    [Token(Token = "0x40107DA")]
    [FieldOffset(Offset = "0x140")]
    private ItemDetailPopupProvider popupProvider;

    [Token(Token = "0x17004C42")]
    public Action OnClickToClose
    {
      [Token(Token = "0x6017743"), Address(RVA = "0x26519D8", Offset = "0x26519D8", VA = "0x26519D8")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6017744"), Address(RVA = "0x26519E0", Offset = "0x26519E0", VA = "0x26519E0")] set
      {
      }
    }

    [Token(Token = "0x17004C43")]
    public Action<ItemPurchaseData.ItemRewardData> OnClickItemAction
    {
      [Token(Token = "0x6017745"), Address(RVA = "0x26519E8", Offset = "0x26519E8", VA = "0x26519E8")] get
      {
        return (Action<ItemPurchaseData.ItemRewardData>) null;
      }
      [Token(Token = "0x6017746"), Address(RVA = "0x26519F0", Offset = "0x26519F0", VA = "0x26519F0")] set
      {
      }
    }

    [Token(Token = "0x6017747")]
    [Address(RVA = "0x26519F8", Offset = "0x26519F8", VA = "0x26519F8")]
    private void Awake()
    {
    }

    [Token(Token = "0x6017748")]
    [Address(RVA = "0x2651A74", Offset = "0x2651A74", VA = "0x2651A74")]
    public void SetAssetCacheSpawner(AssetCachedSpawner spawner)
    {
    }

    [Token(Token = "0x6017749")]
    [Address(RVA = "0x2651A7C", Offset = "0x2651A7C", VA = "0x2651A7C")]
    public void SetAfterPurchaseByAddCoin(
      ItemPurchaseData itemPurchaseData,
      int purchaseCount,
      int beforeFreeCoin,
      int afterFreeCoin,
      int beforePaidCoin,
      int afterPaidCoin,
      ItemDetailPopupProvider detailPopup = null)
    {
    }

    [Token(Token = "0x601774A")]
    [Address(RVA = "0x2652334", Offset = "0x2652334", VA = "0x2652334")]
    public void SetAfterPuchaseByMedal(ItemPurchaseData itemPurchaseData, int purchaseCount)
    {
    }

    [Token(Token = "0x601774B")]
    [Address(RVA = "0x2652578", Offset = "0x2652578", VA = "0x2652578")]
    public void SetAfterPurchase(ItemPurchaseData itemPurchaseData, int purchaseCount)
    {
    }

    [Token(Token = "0x601774C")]
    [Address(RVA = "0x26527BC", Offset = "0x26527BC", VA = "0x26527BC", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x601774D")]
    [Address(RVA = "0x2651FA0", Offset = "0x2651FA0", VA = "0x2651FA0")]
    private void SetAfterPurchaseInternal(ItemPurchaseData itemPurchaseData, int purchaseCount)
    {
    }

    [Token(Token = "0x601774E")]
    [Address(RVA = "0x26527D8", Offset = "0x26527D8", VA = "0x26527D8")]
    private void RemoveThumb()
    {
    }

    [Token(Token = "0x601774F")]
    [Address(RVA = "0x265311C", Offset = "0x265311C", VA = "0x265311C")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017750")]
    [Address(RVA = "0x2653120", Offset = "0x2653120", VA = "0x2653120")]
    private void OnClickToStyleThumb(StyleThumb styleThumb)
    {
    }

    [Token(Token = "0x6017751")]
    [Address(RVA = "0x26531D0", Offset = "0x26531D0", VA = "0x26531D0")]
    private void OnClickToMindEquipThumb(MindequipmentThumb mindequipmentThumb)
    {
    }

    [Token(Token = "0x6017752")]
    [Address(RVA = "0x2653280", Offset = "0x2653280", VA = "0x2653280")]
    private void OnClickToItemDescription(ItemIcon itemIcon)
    {
    }

    [Token(Token = "0x6017753")]
    [Address(RVA = "0x2653358", Offset = "0x2653358", VA = "0x2653358")]
    private void SetupStyleThumb(int styleId, StyleThumb styleThumb)
    {
    }

    [Token(Token = "0x6017754")]
    [Address(RVA = "0x265357C", Offset = "0x265357C", VA = "0x265357C")]
    private void SetupMindEquipmentThumb(int mindEquipmentId, MindequipmentThumb mindequipmentThumb)
    {
    }

    [Token(Token = "0x6017755")]
    [Address(RVA = "0x2652C8C", Offset = "0x2652C8C", VA = "0x2652C8C")]
    private void SetItemThumb(
      ItemPurchaseData.ItemRewardData itemRewardData,
      ItemUtility.Parameter rewardParam,
      int purchaseCount,
      int index)
    {
    }

    [Token(Token = "0x6017756")]
    [Address(RVA = "0x2653768", Offset = "0x2653768", VA = "0x2653768")]
    public ItemAfterPurchasePopup()
    {
    }
  }
}

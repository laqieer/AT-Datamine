// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031F8")]
  public class ItemListPopup : PopupBase
  {
    [Token(Token = "0x400D548")]
    private const string InDetailName = "Popup_In";
    [Token(Token = "0x400D549")]
    private const string OutDetailName = "Popup_Out";
    [Token(Token = "0x400D54A")]
    private const string ItemListAtlasAssetBundleName = "2dassets_ui_itemlist";
    [Token(Token = "0x400D54B")]
    public const string ItemListDetailPopupPrefabName = "Container_Itemlist_DetailWIndow";
    [Token(Token = "0x400D54C")]
    public const string ItemListSellCntPopupPrefabName = "Container_Itemlist_SellCntWIndow";
    [Token(Token = "0x400D54D")]
    public const string ItemListSellConfrimPopupPrefabName = "Container_Itemlist_ConfirmWindow";
    [Token(Token = "0x400D54E")]
    private const int ITEM_SELL_MAX_COUNT = 10;
    [Token(Token = "0x400D54F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400D550")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400D551")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private ItemListScrolCell itemBase;
    [Token(Token = "0x400D552")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Button modeChangeButton;
    [Token(Token = "0x400D553")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private GameObject sellObj;
    [Token(Token = "0x400D554")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Button sellItemClearButton;
    [Token(Token = "0x400D555")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Button sellButton;
    [Token(Token = "0x400D556")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text sellItemCountText;
    [Token(Token = "0x400D557")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text totalSellPriceText;
    [Token(Token = "0x400D558")]
    [FieldOffset(Offset = "0xD0")]
    private List<ItemListScrolCell> enableItems;
    [Token(Token = "0x400D559")]
    [FieldOffset(Offset = "0xD8")]
    private List<ItemListScrolCell> disableItems;
    [Token(Token = "0x400D55A")]
    [FieldOffset(Offset = "0xE0")]
    private ItemListDetailPopup itemListDetailPopupPrefab;
    [Token(Token = "0x400D55B")]
    [FieldOffset(Offset = "0xE8")]
    private ItemListDetailPopup itemListDetailPopup;
    [Token(Token = "0x400D55C")]
    [FieldOffset(Offset = "0xF0")]
    private ItemListSellCntPopup itemListSellCntPopupPrefab;
    [Token(Token = "0x400D55D")]
    [FieldOffset(Offset = "0xF8")]
    private ItemListSellCntPopup itemListSellCntPopup;
    [Token(Token = "0x400D55E")]
    [FieldOffset(Offset = "0x100")]
    private ItemListConfrimPopup itemListSellConfrimPopupPrefab;
    [Token(Token = "0x400D55F")]
    [FieldOffset(Offset = "0x108")]
    private ItemListConfrimPopup itemListSellConfrimPopup;
    [Token(Token = "0x400D560")]
    [FieldOffset(Offset = "0x110")]
    private bool isSellMode;
    [Token(Token = "0x400D561")]
    [FieldOffset(Offset = "0x114")]
    private int sellItemCount;

    [Token(Token = "0x17004107")]
    public Action OnClickToCloseAction
    {
      [Token(Token = "0x6013803"), Address(RVA = "0x49BA5B0", Offset = "0x49BA5B0", VA = "0x49BA5B0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x6013804"), Address(RVA = "0x49BA5B8", Offset = "0x49BA5B8", VA = "0x49BA5B8")] set
      {
      }
    }

    [Token(Token = "0x6013805")]
    [Address(RVA = "0x49BA5C0", Offset = "0x49BA5C0", VA = "0x49BA5C0")]
    public void InitPopup()
    {
    }

    [Token(Token = "0x6013806")]
    [Address(RVA = "0x49BB778", Offset = "0x49BB778", VA = "0x49BB778")]
    private void UpdateItemListCell(IReadOnlyList<ItemListData> inventoryList)
    {
    }

    [Token(Token = "0x6013807")]
    [Address(RVA = "0x49BC1F8", Offset = "0x49BC1F8", VA = "0x49BC1F8", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6013808")]
    [Address(RVA = "0x49BC214", Offset = "0x49BC214", VA = "0x49BC214")]
    public void OnSelectItem(ItemListData itemData)
    {
    }

    [Token(Token = "0x6013809")]
    [Address(RVA = "0x49BC564", Offset = "0x49BC564", VA = "0x49BC564")]
    private void ShowItemDetailPopup(ItemListData itemData)
    {
    }

    [Token(Token = "0x601380A")]
    [Address(RVA = "0x49BC224", Offset = "0x49BC224", VA = "0x49BC224")]
    private void ShowItemSellCntPopup(ItemListData itemData)
    {
    }

    [Token(Token = "0x601380B")]
    [Address(RVA = "0x49BCEFC", Offset = "0x49BCEFC", VA = "0x49BCEFC")]
    private void ResetSellCount()
    {
    }

    [Token(Token = "0x601380C")]
    [Address(RVA = "0x49BD124", Offset = "0x49BD124", VA = "0x49BD124")]
    private void OnClickModeChange()
    {
    }

    [Token(Token = "0x601380D")]
    [Address(RVA = "0x49BD3B8", Offset = "0x49BD3B8", VA = "0x49BD3B8")]
    private void OnClickSaleItemClear()
    {
    }

    [Token(Token = "0x601380E")]
    [Address(RVA = "0x49BD3BC", Offset = "0x49BD3BC", VA = "0x49BD3BC")]
    private void OnClickSell()
    {
    }

    [Token(Token = "0x601380F")]
    [Address(RVA = "0x49BD8D0", Offset = "0x49BD8D0", VA = "0x49BD8D0")]
    protected IEnumerator ConnectAPIItemSell(Action finishAction) => (IEnumerator) null;

    [Token(Token = "0x6013810")]
    [Address(RVA = "0x49BBB54", Offset = "0x49BBB54", VA = "0x49BBB54")]
    private void Calibrate(int requiredCount)
    {
    }

    [Token(Token = "0x6013811")]
    [Address(RVA = "0x49BBDA4", Offset = "0x49BBDA4", VA = "0x49BBDA4")]
    private void Refill(int requiredCount)
    {
    }

    [Token(Token = "0x6013812")]
    [Address(RVA = "0x49BBFCC", Offset = "0x49BBFCC", VA = "0x49BBFCC")]
    private void UpdateSellUI()
    {
    }

    [Token(Token = "0x6013813")]
    [Address(RVA = "0x49BA884", Offset = "0x49BA884", VA = "0x49BA884")]
    private List<ItemListData> GetItemList() => (List<ItemListData>) null;

    [Token(Token = "0x6013814")]
    [Address(RVA = "0x49BDA20", Offset = "0x49BDA20", VA = "0x49BDA20")]
    public ItemListPopup()
    {
    }
  }
}

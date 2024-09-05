// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListSellCntPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x2003201")]
  public class ItemListSellCntPopup : PopupBase
  {
    [Token(Token = "0x400D59E")]
    public const string RarelityIconSpriteAtlasAssetBundleName = "2dassets_ui_spriteatlases";
    [Token(Token = "0x400D59F")]
    public const string RarelityIconSpriteAtlasName = "ItemList_Rarelity_Atlas";
    [Token(Token = "0x400D5A0")]
    private const string RarelityAssetFormat = "Itemlist_SPR_RareLity_{0:00}";
    [Token(Token = "0x400D5A1")]
    private const int ITEM_SELL_MAX_COUNT = 999;
    [Token(Token = "0x400D5A2")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400D5A3")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text itemNameText;
    [Token(Token = "0x400D5A4")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text itemAmountText;
    [Token(Token = "0x400D5A5")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text itemFlavorText;
    [Token(Token = "0x400D5A6")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Image itemIcon;
    [Token(Token = "0x400D5A7")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Image rarelityIcon;
    [Token(Token = "0x400D5A8")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Text nawMoneyText;
    [Token(Token = "0x400D5A9")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private Text nawSellPrice;
    [Token(Token = "0x400D5AA")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private Text totalMoney;
    [Token(Token = "0x400D5AB")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private Slider ItemSellSlider;
    [Token(Token = "0x400D5AC")]
    [FieldOffset(Offset = "0xD8")]
    [SerializeField]
    private Text itemSellCnt;
    [Token(Token = "0x400D5AD")]
    [FieldOffset(Offset = "0xE0")]
    [SerializeField]
    private Text itemSellMax;
    [Token(Token = "0x400D5AE")]
    [FieldOffset(Offset = "0xE8")]
    [SerializeField]
    private LongPressButton itemSellAddButton;
    [Token(Token = "0x400D5AF")]
    [FieldOffset(Offset = "0xF0")]
    [SerializeField]
    private LongPressButton itemSellDecButton;
    [Token(Token = "0x400D5B2")]
    [FieldOffset(Offset = "0x108")]
    private ItemListData itemData;
    [Token(Token = "0x400D5B3")]
    [FieldOffset(Offset = "0x110")]
    private int sellCount;
    [Token(Token = "0x400D5B4")]
    [FieldOffset(Offset = "0x114")]
    private int nawMoney;
    [Token(Token = "0x400D5B5")]
    [FieldOffset(Offset = "0x118")]
    private int sellMaxCount;

    [Token(Token = "0x17004115")]
    public Action OnClickToCloseAction
    {
      [Token(Token = "0x6013859"), Address(RVA = "0x49BF4F0", Offset = "0x49BF4F0", VA = "0x49BF4F0")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601385A"), Address(RVA = "0x49BF4F8", Offset = "0x49BF4F8", VA = "0x49BF4F8")] set
      {
      }
    }

    [Token(Token = "0x17004116")]
    public Action OnClickToPositiveAction
    {
      [Token(Token = "0x601385B"), Address(RVA = "0x49BF500", Offset = "0x49BF500", VA = "0x49BF500")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601385C"), Address(RVA = "0x49BF508", Offset = "0x49BF508", VA = "0x49BF508")] set
      {
      }
    }

    [Token(Token = "0x601385D")]
    [Address(RVA = "0x49BC82C", Offset = "0x49BC82C", VA = "0x49BC82C")]
    public void InitPopup(ItemListData itemData)
    {
    }

    [Token(Token = "0x601385E")]
    [Address(RVA = "0x49BF510", Offset = "0x49BF510", VA = "0x49BF510")]
    private void ChangeSellMoneyText()
    {
    }

    [Token(Token = "0x601385F")]
    [Address(RVA = "0x49BF638", Offset = "0x49BF638", VA = "0x49BF638")]
    private void OnSliderValueChanged(float value)
    {
    }

    [Token(Token = "0x6013860")]
    [Address(RVA = "0x49BF6DC", Offset = "0x49BF6DC", VA = "0x49BF6DC")]
    private void OnClickItemSellAddButton()
    {
    }

    [Token(Token = "0x6013861")]
    [Address(RVA = "0x49BF724", Offset = "0x49BF724", VA = "0x49BF724")]
    private void OnLongPressItemSellAddButton()
    {
    }

    [Token(Token = "0x6013862")]
    [Address(RVA = "0x49BF76C", Offset = "0x49BF76C", VA = "0x49BF76C")]
    private void OnClickItemSellDecButton()
    {
    }

    [Token(Token = "0x6013863")]
    [Address(RVA = "0x49BF7CC", Offset = "0x49BF7CC", VA = "0x49BF7CC")]
    private void OnLongPressItemSellDecButton()
    {
    }

    [Token(Token = "0x6013864")]
    [Address(RVA = "0x49BF82C", Offset = "0x49BF82C", VA = "0x49BF82C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6013865")]
    [Address(RVA = "0x49BF848", Offset = "0x49BF848", VA = "0x49BF848")]
    public void OnClickPositive()
    {
    }

    [Token(Token = "0x6013866")]
    [Address(RVA = "0x49BF884", Offset = "0x49BF884", VA = "0x49BF884")]
    public ItemListSellCntPopup()
    {
    }
  }
}

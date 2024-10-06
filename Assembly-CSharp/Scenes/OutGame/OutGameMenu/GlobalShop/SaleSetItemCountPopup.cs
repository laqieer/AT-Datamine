// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.SaleSetItemCountPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BC7")]
  public class SaleSetItemCountPopup : PopupBase
  {
    [Token(Token = "0x401088E")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Text itemName;
    [Token(Token = "0x401088F")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private GameObject wraningObj;
    [Token(Token = "0x4010890")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x4010891")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x4010892")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x4010893")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x4010894")]
    [FieldOffset(Offset = "0xB8")]
    private SelectSaleCounter selectSaleCounter;
    [Token(Token = "0x4010895")]
    [FieldOffset(Offset = "0xC0")]
    private GameObject itemIconPrefab;

    [Token(Token = "0x17004C59")]
    public Action<int> OnSaleAction
    {
      [Token(Token = "0x6017809"), Address(RVA = "0x265AC54", Offset = "0x265AC54", VA = "0x265AC54")] get
      {
        return (Action<int>) null;
      }
      [Token(Token = "0x601780A"), Address(RVA = "0x265AC5C", Offset = "0x265AC5C", VA = "0x265AC5C")] set
      {
      }
    }

    [Token(Token = "0x17004C5A")]
    public Action<ItemListData> OnClickItemAction
    {
      [Token(Token = "0x601780B"), Address(RVA = "0x265AC64", Offset = "0x265AC64", VA = "0x265AC64")] get
      {
        return (Action<ItemListData>) null;
      }
      [Token(Token = "0x601780C"), Address(RVA = "0x265AC6C", Offset = "0x265AC6C", VA = "0x265AC6C")] set
      {
      }
    }

    [Token(Token = "0x601780D")]
    [Address(RVA = "0x265AC74", Offset = "0x265AC74", VA = "0x265AC74")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x601780E")]
    [Address(RVA = "0x265AD18", Offset = "0x265AD18", VA = "0x265AD18")]
    public void SetResourceData(
      GameObject itemIconPrefab,
      SelectSaleCounter selectSaleCounterPrefab)
    {
    }

    [Token(Token = "0x601780F")]
    [Address(RVA = "0x265AE04", Offset = "0x265AE04", VA = "0x265AE04")]
    public void SetData(ItemListData itemListData, int selectedCount, int salePrice)
    {
    }

    [Token(Token = "0x6017810")]
    [Address(RVA = "0x265B1D8", Offset = "0x265B1D8", VA = "0x265B1D8")]
    public void OnClickToConfirm()
    {
    }

    [Token(Token = "0x6017811")]
    [Address(RVA = "0x265B210", Offset = "0x265B210", VA = "0x265B210", Slot = "9")]
    public override void Close()
    {
    }

    [Token(Token = "0x6017812")]
    [Address(RVA = "0x265B254", Offset = "0x265B254", VA = "0x265B254")]
    public SaleSetItemCountPopup()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.GlobalShop.CheckSalePopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Input;
using GameCore.Popup;
using Il2CppDummyDll;
using Scenes.OutGame.OutGameMenu.GlobalShop.SalePopupContent;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Scenes.OutGame.OutGameMenu.GlobalShop
{
  [Token(Token = "0x2003BA6")]
  public class CheckSalePopup : PopupBase
  {
    [Token(Token = "0x40107BD")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private RectTransform content;
    [Token(Token = "0x40107BE")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private CommonButton cancelButton;
    [Token(Token = "0x40107BF")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private CommonButton confirmButton;
    [Token(Token = "0x40107C0")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private BackKeyHandlerComponent backKeyHandlerComponent;
    [Token(Token = "0x40107C2")]
    [FieldOffset(Offset = "0xB0")]
    private SaleCheckContainer createdSaleCheckContainer;

    [Token(Token = "0x17004C41")]
    public Action OnClickToSaleAction
    {
      [Token(Token = "0x601773D"), Address(RVA = "0x2651674", Offset = "0x2651674", VA = "0x2651674")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x601773E"), Address(RVA = "0x265167C", Offset = "0x265167C", VA = "0x265167C")] set
      {
      }
    }

    [Token(Token = "0x601773F")]
    [Address(RVA = "0x2651684", Offset = "0x2651684", VA = "0x2651684")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6017740")]
    [Address(RVA = "0x2651728", Offset = "0x2651728", VA = "0x2651728")]
    public void SetData(
      Dictionary<ItemListData, int> saleCountMap,
      bool isExchangeOnly,
      GameObject itemIconPrefab,
      SaleCheckContainer saleCheckContainer)
    {
    }

    [Token(Token = "0x6017741")]
    [Address(RVA = "0x26519B4", Offset = "0x26519B4", VA = "0x26519B4")]
    public void OnClickToSaleButton()
    {
    }

    [Token(Token = "0x6017742")]
    [Address(RVA = "0x26519D0", Offset = "0x26519D0", VA = "0x26519D0")]
    public CheckSalePopup()
    {
    }
  }
}

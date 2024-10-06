// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListDetailPopup
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
  [Token(Token = "0x20031F7")]
  public class ItemListDetailPopup : PopupBase
  {
    [Token(Token = "0x400D540")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400D541")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text itemNameText;
    [Token(Token = "0x400D542")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text itemAmountText;
    [Token(Token = "0x400D543")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text itemMaxAmountText;
    [Token(Token = "0x400D544")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text itemSellPriceText;
    [Token(Token = "0x400D545")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text itemFlavorText;
    [Token(Token = "0x400D546")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private Image itemIcon;

    [Token(Token = "0x17004106")]
    public Action OnClickToCloseAction
    {
      [Token(Token = "0x60137FE"), Address(RVA = "0x49BA368", Offset = "0x49BA368", VA = "0x49BA368")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60137FF"), Address(RVA = "0x49BA370", Offset = "0x49BA370", VA = "0x49BA370")] set
      {
      }
    }

    [Token(Token = "0x6013800")]
    [Address(RVA = "0x49BA378", Offset = "0x49BA378", VA = "0x49BA378")]
    public void InitPopup(ItemListData itemData)
    {
    }

    [Token(Token = "0x6013801")]
    [Address(RVA = "0x49BA58C", Offset = "0x49BA58C", VA = "0x49BA58C", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x6013802")]
    [Address(RVA = "0x49BA5A8", Offset = "0x49BA5A8", VA = "0x49BA5A8")]
    public ItemListDetailPopup()
    {
    }
  }
}

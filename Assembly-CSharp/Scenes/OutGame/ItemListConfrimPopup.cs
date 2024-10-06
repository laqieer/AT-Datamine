// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.ItemListConfrimPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Scenes.OutGame
{
  [Token(Token = "0x20031F5")]
  public class ItemListConfrimPopup : PopupBase
  {
    [Token(Token = "0x400D532")]
    private const int ITEM_SELL_MAX_COUNT = 10;
    [Token(Token = "0x400D533")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private Button closeButton;
    [Token(Token = "0x400D534")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text itemRarityText;
    [Token(Token = "0x400D535")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private Text itemConfrimText;
    [Token(Token = "0x400D536")]
    [FieldOffset(Offset = "0xA0")]
    [SerializeField]
    private Text itemSellNum;
    [Token(Token = "0x400D537")]
    [FieldOffset(Offset = "0xA8")]
    [SerializeField]
    private Text itemSellNumMax;
    [Token(Token = "0x400D538")]
    [FieldOffset(Offset = "0xB0")]
    [SerializeField]
    private Text itemSellPrice;
    [Token(Token = "0x400D539")]
    [FieldOffset(Offset = "0xB8")]
    [SerializeField]
    private ItemListScrolCell itemBase;
    [Token(Token = "0x400D53C")]
    [FieldOffset(Offset = "0xD0")]
    private List<ItemListScrolCell> enableItems;
    [Token(Token = "0x400D53D")]
    [FieldOffset(Offset = "0xD8")]
    private List<ItemListScrolCell> disableItems;

    [Token(Token = "0x17004104")]
    public Action OnClickToCloseAction
    {
      [Token(Token = "0x60137F1"), Address(RVA = "0x49B9014", Offset = "0x49B9014", VA = "0x49B9014")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60137F2"), Address(RVA = "0x49B901C", Offset = "0x49B901C", VA = "0x49B901C")] set
      {
      }
    }

    [Token(Token = "0x17004105")]
    public Action OnClickToPositiveAction
    {
      [Token(Token = "0x60137F3"), Address(RVA = "0x49B9024", Offset = "0x49B9024", VA = "0x49B9024")] get
      {
        return (Action) null;
      }
      [Token(Token = "0x60137F4"), Address(RVA = "0x49B902C", Offset = "0x49B902C", VA = "0x49B902C")] set
      {
      }
    }

    [Token(Token = "0x60137F5")]
    [Address(RVA = "0x49B9034", Offset = "0x49B9034", VA = "0x49B9034")]
    public void InitPopup(IReadOnlyList<ItemListData> inventoryList)
    {
    }

    [Token(Token = "0x60137F6")]
    [Address(RVA = "0x49BA1D4", Offset = "0x49BA1D4", VA = "0x49BA1D4", Slot = "5")]
    public override void OnClickClose()
    {
    }

    [Token(Token = "0x60137F7")]
    [Address(RVA = "0x49BA1F0", Offset = "0x49BA1F0", VA = "0x49BA1F0")]
    public void OnClickPositive()
    {
    }

    [Token(Token = "0x60137F8")]
    [Address(RVA = "0x49B9A44", Offset = "0x49B9A44", VA = "0x49B9A44")]
    private void Calibrate(int requiredCount)
    {
    }

    [Token(Token = "0x60137F9")]
    [Address(RVA = "0x49B9C94", Offset = "0x49B9C94", VA = "0x49B9C94")]
    private void Refill(int requiredCount)
    {
    }

    [Token(Token = "0x60137FA")]
    [Address(RVA = "0x49BA20C", Offset = "0x49BA20C", VA = "0x49BA20C")]
    public ItemListConfrimPopup()
    {
    }
  }
}

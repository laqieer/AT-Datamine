// Decompiled with JetBrains decompiler
// Type: Gacha.PossessionListItemPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001553")]
  internal class PossessionListItemPresenter : IPossessionListItemPresenter
  {
    [Token(Token = "0x40061F6")]
    private const string PossessionNumTextFormat = "<color=positive>{0}</color>";
    [Token(Token = "0x40061F7")]
    private const string PossessionNumTextHasLimitFormat = "<color=positive>{0}</color>/{1}";
    [Token(Token = "0x40061F8")]
    [FieldOffset(Offset = "0x10")]
    private PossessionListItemView view;
    [Token(Token = "0x40061F9")]
    [FieldOffset(Offset = "0x18")]
    private Item item;
    [Token(Token = "0x40061FA")]
    [FieldOffset(Offset = "0x20")]
    private Action<Item> itemIconClicked;

    [Token(Token = "0x60078C2")]
    [Address(RVA = "0x44FDA4C", Offset = "0x44FDA4C", VA = "0x44FDA4C")]
    public PossessionListItemPresenter(
      PossessionListItemView view,
      Item item,
      Action<Item> itemIconClicked)
    {
    }

    [Token(Token = "0x60078C3")]
    [Address(RVA = "0x44FDA88", Offset = "0x44FDA88", VA = "0x44FDA88", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60078C4")]
    [Address(RVA = "0x44FDF28", Offset = "0x44FDF28", VA = "0x44FDF28", Slot = "5")]
    public void ItemIconClicked()
    {
    }

    [Token(Token = "0x60078C5")]
    [Address(RVA = "0x44FDD18", Offset = "0x44FDD18", VA = "0x44FDD18")]
    private string GetPossessionNumText(PossessionAmountInfo amountInfo) => (string) null;
  }
}

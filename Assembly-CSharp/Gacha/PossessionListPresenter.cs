// Decompiled with JetBrains decompiler
// Type: Gacha.PossessionListPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using StaqData;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gacha
{
  [Token(Token = "0x2001557")]
  internal class PossessionListPresenter : IPossessionListPresenter
  {
    [Token(Token = "0x4006205")]
    [FieldOffset(Offset = "0x10")]
    private PossessionListView view;
    [Token(Token = "0x4006206")]
    [FieldOffset(Offset = "0x18")]
    private List<Item> items;
    [Token(Token = "0x4006207")]
    [FieldOffset(Offset = "0x20")]
    private Action<Item> itemIconClicked;

    [Token(Token = "0x60078DE")]
    [Address(RVA = "0x44FE41C", Offset = "0x44FE41C", VA = "0x44FE41C")]
    public PossessionListPresenter(
      PossessionListView view,
      List<Item> items,
      Action<Item> itemIconClicked)
    {
    }

    [Token(Token = "0x60078DF")]
    [Address(RVA = "0x44FE458", Offset = "0x44FE458", VA = "0x44FE458", Slot = "5")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60078E0")]
    [Address(RVA = "0x44FE790", Offset = "0x44FE790", VA = "0x44FE790", Slot = "4")]
    public void AssignPossessionListItemPresenter(PossessionListItemView view, int index)
    {
    }

    [Token(Token = "0x60078E1")]
    [Address(RVA = "0x44FE844", Offset = "0x44FE844", VA = "0x44FE844", Slot = "7")]
    public void CloseButtonClicked()
    {
    }

    [Token(Token = "0x60078E2")]
    [Address(RVA = "0x44FE968", Offset = "0x44FE968", VA = "0x44FE968", Slot = "8")]
    public void OutOfRangeButtonClicked()
    {
    }

    [Token(Token = "0x60078E3")]
    [Address(RVA = "0x44FE980", Offset = "0x44FE980", VA = "0x44FE980", Slot = "9")]
    public void Open()
    {
    }

    [Token(Token = "0x60078E4")]
    [Address(RVA = "0x44FEAA4", Offset = "0x44FEAA4", VA = "0x44FEAA4", Slot = "10")]
    public void CloseAnimationFinished()
    {
    }

    [Token(Token = "0x60078E5")]
    [Address(RVA = "0x44FEB18", Offset = "0x44FEB18", VA = "0x44FEB18", Slot = "11")]
    public void OpenAnimationFinished()
    {
    }

    [Token(Token = "0x60078E6")]
    [Address(RVA = "0x44FEB1C", Offset = "0x44FEB1C", VA = "0x44FEB1C", Slot = "6")]
    public void JumpButtonClicked()
    {
    }
  }
}

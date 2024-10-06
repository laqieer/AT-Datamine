// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDSimpleCoinPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x200199D")]
  internal class FgGIDSimpleCoinPresenter : IFgGIDSimpleCoinPresenter
  {
    [Token(Token = "0x4006DEB")]
    [FieldOffset(Offset = "0x10")]
    private FgGIDSimpleCoinView view;
    [Token(Token = "0x4006DEC")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDCoinModel model;
    [Token(Token = "0x4006DED")]
    [FieldOffset(Offset = "0x20")]
    private FgGIDMissionDataManager manager;
    [Token(Token = "0x4006DEE")]
    [FieldOffset(Offset = "0x28")]
    private FgGIDMissionLoader loader;
    [Token(Token = "0x4006DEF")]
    [FieldOffset(Offset = "0x30")]
    public Action DetailButtonClickEvent;
    [Token(Token = "0x4006DF0")]
    [FieldOffset(Offset = "0x38")]
    public Action FgGIDCoinShopButtonClickEvent;

    [Token(Token = "0x6009220")]
    [Address(RVA = "0x4D0C420", Offset = "0x4D0C420", VA = "0x4D0C420")]
    public FgGIDSimpleCoinPresenter(
      FgGIDSimpleCoinView view,
      FgGIDMissionDataManager manager,
      FgGIDMissionLoader loader)
    {
    }

    [Token(Token = "0x6009221")]
    [Address(RVA = "0x4D0F3A4", Offset = "0x4D0F3A4", VA = "0x4D0F3A4", Slot = "6")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6009222")]
    [Address(RVA = "0x4D0F5A8", Offset = "0x4D0F5A8", VA = "0x4D0F5A8", Slot = "4")]
    public void DetailButtonClicked()
    {
    }

    [Token(Token = "0x6009223")]
    [Address(RVA = "0x4D0F5C4", Offset = "0x4D0F5C4", VA = "0x4D0F5C4", Slot = "5")]
    public void FgGIDCoinShopButtonClicked()
    {
    }

    [Token(Token = "0x6009224")]
    [Address(RVA = "0x4D0F5E0", Offset = "0x4D0F5E0", VA = "0x4D0F5E0")]
    private void OnCoinDataChanged(FgGIDCoinModel model)
    {
    }
  }
}

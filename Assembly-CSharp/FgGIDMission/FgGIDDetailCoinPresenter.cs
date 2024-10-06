// Decompiled with JetBrains decompiler
// Type: FgGIDMission.FgGIDDetailCoinPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FgGIDMission
{
  [Token(Token = "0x2001993")]
  public class FgGIDDetailCoinPresenter : IFgGIDDetailCoinPresenter
  {
    [Token(Token = "0x4006DD7")]
    [FieldOffset(Offset = "0x10")]
    private FgGIDDetailCoinView view;
    [Token(Token = "0x4006DD8")]
    [FieldOffset(Offset = "0x18")]
    private FgGIDCoinModel model;

    [Token(Token = "0x60091FB")]
    [Address(RVA = "0x4D0CC44", Offset = "0x4D0CC44", VA = "0x4D0CC44")]
    public FgGIDDetailCoinPresenter(FgGIDDetailCoinView view, FgGIDCoinModel model)
    {
    }

    [Token(Token = "0x60091FC")]
    [Address(RVA = "0x4D0DC64", Offset = "0x4D0DC64", VA = "0x4D0DC64", Slot = "5")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60091FD")]
    [Address(RVA = "0x4D0DF98", Offset = "0x4D0DF98", VA = "0x4D0DF98", Slot = "4")]
    public void AssignListItemPresenter(FgGIDDetailCoinListItemView view, int index)
    {
    }
  }
}

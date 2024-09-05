// Decompiled with JetBrains decompiler
// Type: Scenes.OutGame.OutGameMenu.AdVideoStartPopupPresenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.OutGame.OutGameMenu
{
  [Token(Token = "0x200397F")]
  internal class AdVideoStartPopupPresenter : IAdVideoStartPopupPresenter
  {
    [Token(Token = "0x400FB30")]
    [FieldOffset(Offset = "0x10")]
    private AdVideoStartPopup view;
    [Token(Token = "0x400FB31")]
    [FieldOffset(Offset = "0x18")]
    public Action DecisionButtonClicked;
    [Token(Token = "0x400FB32")]
    [FieldOffset(Offset = "0x20")]
    public Action CancelButtonClicked;
    [Token(Token = "0x400FB33")]
    [FieldOffset(Offset = "0x28")]
    private string title;
    [Token(Token = "0x400FB34")]
    [FieldOffset(Offset = "0x30")]
    private string explanation;
    [Token(Token = "0x400FB35")]
    [FieldOffset(Offset = "0x38")]
    private int resetTimeHour;
    [Token(Token = "0x400FB36")]
    [FieldOffset(Offset = "0x3C")]
    private int remainCount;

    [Token(Token = "0x601699D")]
    [Address(RVA = "0x42F2F38", Offset = "0x42F2F38", VA = "0x42F2F38")]
    public AdVideoStartPopupPresenter(
      AdVideoStartPopup view,
      string title,
      string explanation,
      int resetTimeHour,
      int remainCount)
    {
    }

    [Token(Token = "0x601699E")]
    [Address(RVA = "0x42F2F88", Offset = "0x42F2F88", VA = "0x42F2F88")]
    public void ScheduleSet(DateTime beginAt, DateTime endAt)
    {
    }

    [Token(Token = "0x601699F")]
    [Address(RVA = "0x42F3068", Offset = "0x42F3068", VA = "0x42F3068", Slot = "4")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60169A0")]
    [Address(RVA = "0x42F33C8", Offset = "0x42F33C8", VA = "0x42F33C8")]
    private void Decide()
    {
    }

    [Token(Token = "0x60169A1")]
    [Address(RVA = "0x42F34AC", Offset = "0x42F34AC", VA = "0x42F34AC")]
    private void Cancel()
    {
    }
  }
}

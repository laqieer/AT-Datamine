// Decompiled with JetBrains decompiler
// Type: Scenes.Story.PocketBook.PocketBookCommonPopupHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Scenes.Story.PocketBook
{
  [Token(Token = "0x2002D9D")]
  public class PocketBookCommonPopupHandler
  {
    [Token(Token = "0x400C41A")]
    [FieldOffset(Offset = "0x10")]
    private PocketBookCommonPopup popup;
    [Token(Token = "0x400C41B")]
    [FieldOffset(Offset = "0x18")]
    private PocketBookAnimation animation;
    [Token(Token = "0x400C41C")]
    [FieldOffset(Offset = "0x20")]
    private PocketBookLoader loader;
    [Token(Token = "0x400C41D")]
    [FieldOffset(Offset = "0x0")]
    private static bool isBusy;
    [Token(Token = "0x400C41E")]
    [FieldOffset(Offset = "0x28")]
    private string text;
    [Token(Token = "0x400C41F")]
    [FieldOffset(Offset = "0x30")]
    private string positiveButtonText;

    [Token(Token = "0x17003CF5")]
    public bool IsBusy
    {
      [Token(Token = "0x6011D7B"), Address(RVA = "0x3FA5238", Offset = "0x3FA5238", VA = "0x3FA5238")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17003CF6")]
    public MessageIDTable MessageIDTable
    {
      [Token(Token = "0x6011D7C"), Address(RVA = "0x3FA3CE4", Offset = "0x3FA3CE4", VA = "0x3FA3CE4")] get
      {
        return (MessageIDTable) null;
      }
    }

    [Token(Token = "0x17003CF7")]
    public Action OnConfirmAction
    {
      [Token(Token = "0x6011D7D"), Address(RVA = "0x3FA5280", Offset = "0x3FA5280", VA = "0x3FA5280")] private get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011D7E"), Address(RVA = "0x3FA5288", Offset = "0x3FA5288", VA = "0x3FA5288")] set
      {
      }
    }

    [Token(Token = "0x17003CF8")]
    public Action OnCancelAction
    {
      [Token(Token = "0x6011D7F"), Address(RVA = "0x3FA5290", Offset = "0x3FA5290", VA = "0x3FA5290")] private get
      {
        return (Action) null;
      }
      [Token(Token = "0x6011D80"), Address(RVA = "0x3FA5298", Offset = "0x3FA5298", VA = "0x3FA5298")] set
      {
      }
    }

    [Token(Token = "0x6011D81")]
    [Address(RVA = "0x3FA3918", Offset = "0x3FA3918", VA = "0x3FA3918")]
    public PocketBookCommonPopupHandler(
      PocketBookCommonPopup popup,
      PocketBookAnimation animation,
      PocketBookLoader loader)
    {
    }

    [Token(Token = "0x6011D82")]
    [Address(RVA = "0x3FA52A0", Offset = "0x3FA52A0", VA = "0x3FA52A0")]
    public void SetText(string text)
    {
    }

    [Token(Token = "0x6011D83")]
    [Address(RVA = "0x3FA52A8", Offset = "0x3FA52A8", VA = "0x3FA52A8")]
    public void SetPositiveText(string positiveText)
    {
    }

    [Token(Token = "0x6011D84")]
    [Address(RVA = "0x3FA3D10", Offset = "0x3FA3D10", VA = "0x3FA3D10")]
    public void Show()
    {
    }

    [Token(Token = "0x6011D85")]
    [Address(RVA = "0x3FA53D4", Offset = "0x3FA53D4", VA = "0x3FA53D4")]
    private void OnConfirm()
    {
    }

    [Token(Token = "0x6011D86")]
    [Address(RVA = "0x3FA5604", Offset = "0x3FA5604", VA = "0x3FA5604")]
    private void OnCancel()
    {
    }

    [Token(Token = "0x6011D87")]
    [Address(RVA = "0x3FA570C", Offset = "0x3FA570C", VA = "0x3FA570C")]
    private void Clear()
    {
    }
  }
}

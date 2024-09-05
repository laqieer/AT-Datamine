// Decompiled with JetBrains decompiler
// Type: Scenes.Option.AccountDelete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.Option
{
  [Token(Token = "0x2002A5B")]
  public static class AccountDelete
  {
    [Token(Token = "0x400B449")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string> UNNECESSARY_TITLE;
    [Token(Token = "0x400B44A")]
    [FieldOffset(Offset = "0x8")]
    private static Func<string> DELETED_TITLE;
    [Token(Token = "0x400B44B")]
    [FieldOffset(Offset = "0x10")]
    private static Func<string> FIRST_DELETED_BODY;
    [Token(Token = "0x400B44C")]
    [FieldOffset(Offset = "0x18")]
    private static Func<string> SECOND_DELETED_BODY;
    [Token(Token = "0x400B44D")]
    [FieldOffset(Offset = "0x20")]
    private static Func<string> THIRD_DELETED_BODY;
    [Token(Token = "0x400B44E")]
    [FieldOffset(Offset = "0x28")]
    private static Func<string> RESULT_DELETED_TITLE;
    [Token(Token = "0x400B44F")]
    [FieldOffset(Offset = "0x30")]
    private static Func<string> CANCEL_BUTTON_NAME;
    [Token(Token = "0x400B450")]
    [FieldOffset(Offset = "0x38")]
    private static Func<string> DECIDE_BUTTON_NAME;
    [Token(Token = "0x400B451")]
    [FieldOffset(Offset = "0x40")]
    private static Func<string> AGREE_BUTTON_NAME;
    [Token(Token = "0x400B452")]
    [FieldOffset(Offset = "0x48")]
    private static Func<string> DELETE_BUTTON_NAME;
    [Token(Token = "0x400B453")]
    [FieldOffset(Offset = "0x50")]
    private static Func<string> CLOSE_BUTTON_NAME;

    [Token(Token = "0x6010946")]
    [Address(RVA = "0x4C2CCF8", Offset = "0x4C2CCF8", VA = "0x4C2CCF8")]
    public static IEnumerator DoAccountDelete() => (IEnumerator) null;

    [Token(Token = "0x6010947")]
    [Address(RVA = "0x4C2CD80", Offset = "0x4C2CD80", VA = "0x4C2CD80")]
    public static PopupHandle AccountDeleteConfirmationPopupOpen(
      AccountDeleteConfirmationPopup accountDeleteConfirmationPopup,
      CommonPopupContent popupContent,
      Action outOfRangeAction,
      params CommonButtonContent[] contents)
    {
      return (PopupHandle) null;
    }

    [Token(Token = "0x6010948")]
    [Address(RVA = "0x4C2CED0", Offset = "0x4C2CED0", VA = "0x4C2CED0")]
    private static int GetCurrentUnixTime() => new int();

    [Token(Token = "0x6010949")]
    [Address(RVA = "0x4C2CFB4", Offset = "0x4C2CFB4", VA = "0x4C2CFB4")]
    static AccountDelete()
    {
    }

    [Token(Token = "0x2002A5C")]
    private enum State
    {
      [Token(Token = "0x400B455")] Wait,
      [Token(Token = "0x400B456")] Next,
      [Token(Token = "0x400B457")] End,
    }
  }
}

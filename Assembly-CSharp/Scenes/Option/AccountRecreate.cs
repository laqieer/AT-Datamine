// Decompiled with JetBrains decompiler
// Type: Scenes.Option.AccountRecreate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using staq;
using StaqData;
using System;
using System.Collections;

#nullable disable
namespace Scenes.Option
{
  [Token(Token = "0x2002A60")]
  public static class AccountRecreate
  {
    [Token(Token = "0x400B466")]
    [FieldOffset(Offset = "0x0")]
    private static Func<string> UNNECESSARY_TITLE;
    [Token(Token = "0x400B467")]
    [FieldOffset(Offset = "0x8")]
    private static Func<string> FIRST_DELETED_TITLE;
    [Token(Token = "0x400B468")]
    [FieldOffset(Offset = "0x10")]
    private static Func<string> SECOND_DELETED_TITLE;
    [Token(Token = "0x400B469")]
    [FieldOffset(Offset = "0x18")]
    private static Func<string> RESULT_DELETED_TITLE;
    [Token(Token = "0x400B46A")]
    [FieldOffset(Offset = "0x20")]
    private static Func<string> CANCEL_BUTTON_NAME;
    [Token(Token = "0x400B46B")]
    [FieldOffset(Offset = "0x28")]
    private static Func<string> DECIDE_BUTTON_NAME;
    [Token(Token = "0x400B46C")]
    [FieldOffset(Offset = "0x30")]
    private static Func<string> SECOND_DECIDE_BUTTON_NAME;
    [Token(Token = "0x400B46D")]
    [FieldOffset(Offset = "0x38")]
    private static Func<string> CLOSE_BUTTON_NAME;

    [Token(Token = "0x17003998")]
    private static SaveDataManager SaveData
    {
      [Token(Token = "0x6010972"), Address(RVA = "0x4C2F314", Offset = "0x4C2F314", VA = "0x4C2F314")] get
      {
        return (SaveDataManager) null;
      }
    }

    [Token(Token = "0x17003999")]
    private static RuntimeDataManager RuntimeData
    {
      [Token(Token = "0x6010973"), Address(RVA = "0x4C2F380", Offset = "0x4C2F380", VA = "0x4C2F380")] get
      {
        return (RuntimeDataManager) null;
      }
    }

    [Token(Token = "0x6010974")]
    [Address(RVA = "0x4C2F3C0", Offset = "0x4C2F3C0", VA = "0x4C2F3C0")]
    private static bool CanRecreatAccount() => new bool();

    [Token(Token = "0x6010975")]
    [Address(RVA = "0x4C2F49C", Offset = "0x4C2F49C", VA = "0x4C2F49C")]
    public static IEnumerator DoAccountRecreate() => (IEnumerator) null;

    [Token(Token = "0x6010976")]
    [Address(RVA = "0x4C2F524", Offset = "0x4C2F524", VA = "0x4C2F524")]
    public static void ClearRecreateStatus()
    {
    }

    [Token(Token = "0x6010977")]
    [Address(RVA = "0x4C2F5DC", Offset = "0x4C2F5DC", VA = "0x4C2F5DC")]
    public static bool IsRecreateStatus() => new bool();

    [Token(Token = "0x6010978")]
    [Address(RVA = "0x4C2F660", Offset = "0x4C2F660", VA = "0x4C2F660")]
    public static bool IsEnableTutorialSkipInRecreateStatus() => new bool();

    [Token(Token = "0x6010979")]
    [Address(RVA = "0x4C2F6E4", Offset = "0x4C2F6E4", VA = "0x4C2F6E4")]
    public static IEnumerator OnRecreateAccountTutorialSkipped() => (IEnumerator) null;

    [Token(Token = "0x601097A")]
    [Address(RVA = "0x4C2F76C", Offset = "0x4C2F76C", VA = "0x4C2F76C")]
    public static void OnRecreateAccountTutorialNotSkipped()
    {
    }

    [Token(Token = "0x601097B")]
    [Address(RVA = "0x4C2F7D4", Offset = "0x4C2F7D4", VA = "0x4C2F7D4")]
    static AccountRecreate()
    {
    }

    [Token(Token = "0x2002A61")]
    private enum State
    {
      [Token(Token = "0x400B46F")] Next,
      [Token(Token = "0x400B470")] End,
    }
  }
}

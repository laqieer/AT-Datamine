// Decompiled with JetBrains decompiler
// Type: Scenes.Title.TitleStartup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Scenes.Title
{
  [Token(Token = "0x20028F4")]
  public class TitleStartup
  {
    [Token(Token = "0x400AEB1")]
    [FieldOffset(Offset = "0x10")]
    private Func<string> TERMS_TITLE;
    [Token(Token = "0x400AEB2")]
    [FieldOffset(Offset = "0x18")]
    private Func<string> DISAGREE_TITLE;
    [Token(Token = "0x400AEB3")]
    [FieldOffset(Offset = "0x20")]
    private Func<string> AGREE_BUTTON_NAME;
    [Token(Token = "0x400AEB4")]
    [FieldOffset(Offset = "0x28")]
    private Func<string> DISAGREE_BUTTON_NAME;
    [Token(Token = "0x400AEB5")]
    [FieldOffset(Offset = "0x30")]
    private Func<string> CLOSE_BUTTON_NAME;
    [Token(Token = "0x400AEB6")]
    [FieldOffset(Offset = "0x38")]
    public bool agree;

    [Token(Token = "0x60101CB")]
    [Address(RVA = "0x4172CE0", Offset = "0x4172CE0", VA = "0x4172CE0")]
    public IEnumerator OpenTermsOfService() => (IEnumerator) null;

    [Token(Token = "0x60101CC")]
    [Address(RVA = "0x4172D70", Offset = "0x4172D70", VA = "0x4172D70")]
    public IEnumerator OpenDisagree() => (IEnumerator) null;

    [Token(Token = "0x60101CD")]
    [Address(RVA = "0x4172E00", Offset = "0x4172E00", VA = "0x4172E00")]
    public TitleStartup()
    {
    }
  }
}

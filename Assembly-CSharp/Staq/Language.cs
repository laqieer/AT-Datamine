// Decompiled with JetBrains decompiler
// Type: staq.Language
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace staq
{
  [Token(Token = "0x2003C44")]
  public class Language
  {
    [Token(Token = "0x4010B79")]
    public const string JA = "ja";
    [Token(Token = "0x4010B7A")]
    public const string EN = "en";
    [Token(Token = "0x4010B7B")]
    public const string ZH = "zh";
    [Token(Token = "0x4010B7C")]
    public const string DefaultLanguage = "ja";
    [Token(Token = "0x4010B7D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly Dictionary<string, LanguageParam> Languages;

    [Token(Token = "0x6017B20")]
    [Address(RVA = "0x238BC4C", Offset = "0x238BC4C", VA = "0x238BC4C")]
    public static string GetCodeBySystemLanguageCode(SystemLanguage sysLanguageCode)
    {
      return (string) null;
    }

    [Token(Token = "0x6017B21")]
    [Address(RVA = "0x238BE74", Offset = "0x238BE74", VA = "0x238BE74")]
    public static LanguageEnum GetIdByLanguageCode(string languageCode) => new LanguageEnum();

    [Token(Token = "0x6017B22")]
    [Address(RVA = "0x238BF20", Offset = "0x238BF20", VA = "0x238BF20")]
    public Language()
    {
    }

    [Token(Token = "0x6017B23")]
    [Address(RVA = "0x238BF28", Offset = "0x238BF28", VA = "0x238BF28")]
    static Language()
    {
    }
  }
}

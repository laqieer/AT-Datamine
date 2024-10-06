// Decompiled with JetBrains decompiler
// Type: GameCore.Font.TMPFontInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using TMPro;

#nullable disable
namespace GameCore.Font
{
  [Token(Token = "0x200145F")]
  [Serializable]
  public class TMPFontInfo
  {
    [Token(Token = "0x4005DDA")]
    [FieldOffset(Offset = "0x10")]
    public FontManager.FontLabel label;
    [Token(Token = "0x4005DDB")]
    [FieldOffset(Offset = "0x18")]
    public TMP_FontAsset font;

    [Token(Token = "0x60072D9")]
    [Address(RVA = "0x4052F5C", Offset = "0x4052F5C", VA = "0x4052F5C")]
    public TMPFontInfo()
    {
    }
  }
}

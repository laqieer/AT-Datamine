// Decompiled with JetBrains decompiler
// Type: GameCore.Font.FontInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace GameCore.Font
{
  [Token(Token = "0x200145E")]
  [Serializable]
  public class FontInfo
  {
    [Token(Token = "0x4005DD8")]
    [FieldOffset(Offset = "0x10")]
    public FontManager.FontLabel label;
    [Token(Token = "0x4005DD9")]
    [FieldOffset(Offset = "0x18")]
    public UnityEngine.Font font;

    [Token(Token = "0x60072D8")]
    [Address(RVA = "0x4052F54", Offset = "0x4052F54", VA = "0x4052F54")]
    public FontInfo()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaFogControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using UnityEngine;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB5")]
  [MoonSharpUserData]
  public class LuaFogControl : LuaSignal
  {
    [Token(Token = "0x4011316")]
    [FieldOffset(Offset = "0x18")]
    private bool defaultActive;
    [Token(Token = "0x4011317")]
    [FieldOffset(Offset = "0x1C")]
    private FogMode defaultMode;
    [Token(Token = "0x4011318")]
    [FieldOffset(Offset = "0x20")]
    private Color defaultColor;
    [Token(Token = "0x4011319")]
    [FieldOffset(Offset = "0x30")]
    private float defaultFogStart;
    [Token(Token = "0x401131A")]
    [FieldOffset(Offset = "0x34")]
    private float defaultForEnd;
    [Token(Token = "0x401131B")]
    [FieldOffset(Offset = "0x38")]
    private float defaultDensity;

    [Token(Token = "0x6019412")]
    [Address(RVA = "0x2FF1918", Offset = "0x2FF1918", VA = "0x2FF1918")]
    public LuaFogControl()
    {
    }

    [Token(Token = "0x6019413")]
    [Address(RVA = "0x2FF199C", Offset = "0x2FF199C", VA = "0x2FF199C")]
    public void Reset()
    {
    }

    [Token(Token = "0x6019414")]
    [Address(RVA = "0x2FF19F4", Offset = "0x2FF19F4", VA = "0x2FF19F4")]
    public void Enable()
    {
    }

    [Token(Token = "0x6019415")]
    [Address(RVA = "0x2FF1A00", Offset = "0x2FF1A00", VA = "0x2FF1A00")]
    public void Disable()
    {
    }

    [Token(Token = "0x6019416")]
    [Address(RVA = "0x2FF1A0C", Offset = "0x2FF1A0C", VA = "0x2FF1A0C")]
    public void SetLinearFogParameter(string fogColorCode, float start, float end)
    {
    }

    [Token(Token = "0x6019417")]
    [Address(RVA = "0x2FF1A94", Offset = "0x2FF1A94", VA = "0x2FF1A94")]
    public void SetExponentialFogParameter(string fogColorCode, float density)
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaCommonPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB0")]
  [MoonSharpUserData]
  public class LuaCommonPopup : LuaSignal, IDisposable
  {
    [Token(Token = "0x4011310")]
    [FieldOffset(Offset = "0x18")]
    private Adv2Manager.OnProccessSignal signal;

    [Token(Token = "0x60193E9")]
    [Address(RVA = "0x2FEF9C4", Offset = "0x2FEF9C4", VA = "0x2FEF9C4")]
    public LuaCommonPopup()
    {
    }

    [Token(Token = "0x60193EA")]
    [Address(RVA = "0x2FEFA2C", Offset = "0x2FEFA2C", VA = "0x2FEFA2C", Slot = "5")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60193EB")]
    [Address(RVA = "0x2FEFA3C", Offset = "0x2FEFA3C", VA = "0x2FEFA3C")]
    public LuaSignalMini SystemPopupOpenSmallNarrow(string messageTag) => (LuaSignalMini) null;

    [Token(Token = "0x60193EC")]
    [Address(RVA = "0x2FEFAC8", Offset = "0x2FEFAC8", VA = "0x2FEFAC8")]
    public LuaSignalMini SystemPopupOpenSmallNarrowDirect(string message) => (LuaSignalMini) null;

    [Token(Token = "0x60193ED")]
    [Address(RVA = "0x2FEFD34", Offset = "0x2FEFD34", VA = "0x2FEFD34")]
    public LuaSignalMini OpenMediumDirect(string title, string message) => (LuaSignalMini) null;

    [Token(Token = "0x60193EE")]
    [Address(RVA = "0x2FEFFA8", Offset = "0x2FEFFA8", VA = "0x2FEFFA8")]
    public LuaSignalMini OpenMedium(string titleTag, string messageTag) => (LuaSignalMini) null;

    [Token(Token = "0x60193EF")]
    [Address(RVA = "0x2FF0068", Offset = "0x2FF0068", VA = "0x2FF0068")]
    private void Close()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaSkipPopup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.Popup;
using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB1")]
  [MoonSharpUserData]
  public class LuaSkipPopup : LuaSignal, IDisposable
  {
    [Token(Token = "0x4011311")]
    [FieldOffset(Offset = "0x18")]
    private Adv2Manager.OnProccessSignal signal;
    [Token(Token = "0x4011312")]
    [FieldOffset(Offset = "0x20")]
    private bool isSkip;
    [Token(Token = "0x4011313")]
    [FieldOffset(Offset = "0x28")]
    private PopupHandle opennedHadle;

    [Token(Token = "0x60193F0")]
    [Address(RVA = "0x2FF0114", Offset = "0x2FF0114", VA = "0x2FF0114")]
    public LuaSkipPopup()
    {
    }

    [Token(Token = "0x60193F1")]
    [Address(RVA = "0x2FF017C", Offset = "0x2FF017C", VA = "0x2FF017C", Slot = "5")]
    public void Dispose()
    {
    }

    [Token(Token = "0x60193F2")]
    [Address(RVA = "0x2FF018C", Offset = "0x2FF018C", VA = "0x2FF018C")]
    public LuaSignalMini Open() => (LuaSignalMini) null;

    [Token(Token = "0x60193F3")]
    [Address(RVA = "0x2FF05A4", Offset = "0x2FF05A4", VA = "0x2FF05A4")]
    private void Close()
    {
    }

    [Token(Token = "0x60193F4")]
    [Address(RVA = "0x2FF06D4", Offset = "0x2FF06D4", VA = "0x2FF06D4")]
    private void Skip()
    {
    }

    [Token(Token = "0x60193F5")]
    [Address(RVA = "0x2FF06E0", Offset = "0x2FF06E0", VA = "0x2FF06E0")]
    private void Cancel()
    {
    }

    [Token(Token = "0x60193F6")]
    [Address(RVA = "0x2FF06E8", Offset = "0x2FF06E8", VA = "0x2FF06E8")]
    public bool IsSkepped() => new bool();
  }
}

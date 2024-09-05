// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaSignal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System.Collections.Generic;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EE2")]
  [MoonSharpUserData]
  public class LuaSignal
  {
    [Token(Token = "0x40113B0")]
    [FieldOffset(Offset = "0x10")]
    protected List<Adv2Manager.OnProccessSignal> proccessSignals;

    [Token(Token = "0x6019667")]
    [Address(RVA = "0x37342E8", Offset = "0x37342E8", VA = "0x37342E8")]
    public void AddSignal(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x6019668")]
    [Address(RVA = "0x3734390", Offset = "0x3734390", VA = "0x3734390")]
    public void AddSignals(List<Adv2Manager.OnProccessSignal> signals)
    {
    }

    [Token(Token = "0x6019669")]
    [Address(RVA = "0x37343E8", Offset = "0x37343E8", VA = "0x37343E8")]
    public void RemoveSignal(LuaSignalMini luaSignal)
    {
    }

    [Token(Token = "0x601966A")]
    [Address(RVA = "0x3734444", Offset = "0x3734444", VA = "0x3734444")]
    public bool IsProccessing() => new bool();

    [Token(Token = "0x601966B")]
    [Address(RVA = "0x373450C", Offset = "0x373450C", VA = "0x373450C", Slot = "4")]
    public virtual void Empty(bool isRemoveObject)
    {
    }

    [Token(Token = "0x601966C")]
    [Address(RVA = "0x3734510", Offset = "0x3734510", VA = "0x3734510")]
    public LuaSignal()
    {
    }
  }
}

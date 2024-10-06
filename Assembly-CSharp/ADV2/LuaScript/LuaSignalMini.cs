// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaSignalMini
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EE3")]
  [MoonSharpUserData]
  public class LuaSignalMini
  {
    [Token(Token = "0x40113B1")]
    [FieldOffset(Offset = "0x10")]
    protected Adv2Manager.OnProccessSignal proccessSignal;

    [Token(Token = "0x170051F4")]
    public Adv2Manager.OnProccessSignal ProccessSignal
    {
      [Token(Token = "0x601966D"), Address(RVA = "0x373458C", Offset = "0x373458C", VA = "0x373458C")] get
      {
        return (Adv2Manager.OnProccessSignal) null;
      }
    }

    [Token(Token = "0x601966E")]
    [Address(RVA = "0x3734594", Offset = "0x3734594", VA = "0x3734594")]
    public LuaSignalMini(Adv2Manager.OnProccessSignal signal)
    {
    }

    [Token(Token = "0x601966F")]
    [Address(RVA = "0x37345BC", Offset = "0x37345BC", VA = "0x37345BC")]
    public bool IsProccessing() => new bool();
  }
}

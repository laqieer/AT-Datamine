// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.Adv2LuaNetworkConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EBA")]
  [MoonSharpUserData]
  public class Adv2LuaNetworkConnection : LuaSignal
  {
    [Token(Token = "0x401133E")]
    [FieldOffset(Offset = "0x18")]
    private Adv2Manager.OnProccessSignal waitAPI;
    [Token(Token = "0x4011340")]
    [FieldOffset(Offset = "0x28")]
    public object Result;

    [Token(Token = "0x170051D5")]
    public Adv2LuaNetworkConnection.APICallOnAdv DelegateCallAPI
    {
      [Token(Token = "0x6019469"), Address(RVA = "0x2FF5354", Offset = "0x2FF5354", VA = "0x2FF5354")] private get
      {
        return (Adv2LuaNetworkConnection.APICallOnAdv) null;
      }
      [Token(Token = "0x601946A"), Address(RVA = "0x2FF535C", Offset = "0x2FF535C", VA = "0x2FF535C")] set
      {
      }
    }

    [Token(Token = "0x601946B")]
    [Address(RVA = "0x2FF5364", Offset = "0x2FF5364", VA = "0x2FF5364")]
    public Adv2LuaNetworkConnection()
    {
    }

    [Token(Token = "0x601946C")]
    [Address(RVA = "0x2FF53DC", Offset = "0x2FF53DC", VA = "0x2FF53DC")]
    public void SetResult(object result)
    {
    }

    [Token(Token = "0x601946D")]
    [Address(RVA = "0x2FF53E4", Offset = "0x2FF53E4", VA = "0x2FF53E4")]
    public void CallApi()
    {
    }

    [Token(Token = "0x2003EBB")]
    public delegate void APICallOnAdv(Adv2Manager.OnProccessSignal signal);
  }
}

// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaDebug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using System.Collections.Generic;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EB2")]
  [MoonSharpUserData]
  public class LuaDebug : LuaSequence
  {
    [Token(Token = "0x4011314")]
    [FieldOffset(Offset = "0x48")]
    protected Adv2DebugFilePlayer debugPlayer;

    [Token(Token = "0x60193F7")]
    [Address(RVA = "0x2FF06F0", Offset = "0x2FF06F0", VA = "0x2FF06F0")]
    public LuaDebug(Adv2Manager manager)
    {
    }

    [Token(Token = "0x60193F8")]
    [Address(RVA = "0x2FF0864", Offset = "0x2FF0864", VA = "0x2FF0864")]
    protected void CreateDictionary(ref Dictionary<string, string> output, DynValue table)
    {
    }

    [Token(Token = "0x60193F9")]
    [Address(RVA = "0x2FF0C24", Offset = "0x2FF0C24", VA = "0x2FF0C24")]
    public void CreateUiPathTable(DynValue table)
    {
    }

    [Token(Token = "0x60193FA")]
    [Address(RVA = "0x2FF0C44", Offset = "0x2FF0C44", VA = "0x2FF0C44")]
    public void CreateAnimationListPathTable(DynValue table)
    {
    }

    [Token(Token = "0x60193FB")]
    [Address(RVA = "0x2FF0C64", Offset = "0x2FF0C64", VA = "0x2FF0C64")]
    public void CreateFacialListPathTable(DynValue table)
    {
    }
  }
}

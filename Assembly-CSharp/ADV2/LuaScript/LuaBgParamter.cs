// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaBgParamter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EA4")]
  [MoonSharpUserData]
  public class LuaBgParamter : LuaObject
  {
    [Token(Token = "0x40112EA")]
    [FieldOffset(Offset = "0x38")]
    private BGParameters bgParameters;

    [Token(Token = "0x6019394")]
    [Address(RVA = "0x2FECCC0", Offset = "0x2FECCC0", VA = "0x2FECCC0")]
    public LuaBgParamter(Adv2Object instance)
    {
    }

    [Token(Token = "0x6019395")]
    [Address(RVA = "0x2FECDBC", Offset = "0x2FECDBC", VA = "0x2FECDBC")]
    public void SetBgParameter(bool enable, float blendFactor, string colorCode)
    {
    }
  }
}

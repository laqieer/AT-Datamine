// Decompiled with JetBrains decompiler
// Type: ADV2.LuaScript.LuaParameterUpResultUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace ADV2.LuaScript
{
  [Token(Token = "0x2003EBE")]
  [MoonSharpUserData]
  public class LuaParameterUpResultUI : LuaSignal
  {
    [Token(Token = "0x4011347")]
    [FieldOffset(Offset = "0x18")]
    private Adv2ParameterUpResultUI advObject;

    [Token(Token = "0x60194B6")]
    [Address(RVA = "0x2FF6CB8", Offset = "0x2FF6CB8", VA = "0x2FF6CB8")]
    public LuaParameterUpResultUI(
      Adv2ParameterUpResultUI instance,
      Adv2ParameterUpResultDialogUI dialogInstance)
    {
    }

    [Token(Token = "0x60194B7")]
    [Address(RVA = "0x2FF6CF0", Offset = "0x2FF6CF0", VA = "0x2FF6CF0")]
    public void SetActive(bool isActive)
    {
    }

    [Token(Token = "0x60194B8")]
    [Address(RVA = "0x2FF6D10", Offset = "0x2FF6D10", VA = "0x2FF6D10")]
    public void Prepare(LuaSequence.ParamControl.HumanParameter humanParam, LuaHuman character)
    {
    }

    [Token(Token = "0x60194B9")]
    [Address(RVA = "0x2FF6D34", Offset = "0x2FF6D34", VA = "0x2FF6D34")]
    public LuaSignalMini Play() => (LuaSignalMini) null;
  }
}

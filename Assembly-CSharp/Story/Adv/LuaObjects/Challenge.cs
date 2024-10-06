// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.Challenge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using GameCore.MasterData;
using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x2000767")]
  [MoonSharpUserData]
  public class Challenge
  {
    [Token(Token = "0x40021D8")]
    [FieldOffset(Offset = "0x10")]
    public bool Result;
    [Token(Token = "0x40021D9")]
    [FieldOffset(Offset = "0x18")]
    public string Message;
    [Token(Token = "0x40021DA")]
    [FieldOffset(Offset = "0x20")]
    private int reward;

    [Token(Token = "0x600296C")]
    [Address(RVA = "0x367B8B8", Offset = "0x367B8B8", VA = "0x367B8B8")]
    public Challenge(StoryFacilityDifficultyData difficulty)
    {
    }

    [Token(Token = "0x600296D")]
    [Address(RVA = "0x367FFAC", Offset = "0x367FFAC", VA = "0x367FFAC")]
    public LuaSequence.ParamControl.HumanParameter GetHumanParam()
    {
      return (LuaSequence.ParamControl.HumanParameter) null;
    }
  }
}

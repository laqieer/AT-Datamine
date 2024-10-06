// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.MenuItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using ADV2.LuaScript;
using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x200075D")]
  [MoonSharpUserData]
  public class MenuItem
  {
    [Token(Token = "0x40021B8")]
    [FieldOffset(Offset = "0x10")]
    public string TextValue;
    [Token(Token = "0x40021B9")]
    [FieldOffset(Offset = "0x18")]
    public int IntValue;
    [Token(Token = "0x40021BA")]
    [FieldOffset(Offset = "0x1C")]
    public int ID;
    [Token(Token = "0x40021BB")]
    [FieldOffset(Offset = "0x20")]
    public bool Enable;

    [Token(Token = "0x600295B")]
    [Address(RVA = "0x367FC38", Offset = "0x367FC38", VA = "0x367FC38")]
    public LuaSequence.ParamControl.HumanParameter GetHumanParam()
    {
      return (LuaSequence.ParamControl.HumanParameter) null;
    }

    [Token(Token = "0x600295C")]
    [Address(RVA = "0x367C08C", Offset = "0x367C08C", VA = "0x367C08C")]
    public MenuItem()
    {
    }
  }
}

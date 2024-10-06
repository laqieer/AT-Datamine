// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.BuffItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x2000760")]
  [MoonSharpUserData]
  public class BuffItem
  {
    [Token(Token = "0x40021C2")]
    [FieldOffset(Offset = "0x10")]
    public string TextValue;
    [Token(Token = "0x40021C3")]
    [FieldOffset(Offset = "0x18")]
    public string TextFlavor;
    [Token(Token = "0x40021C4")]
    [FieldOffset(Offset = "0x20")]
    public int IntValue;
    [Token(Token = "0x40021C5")]
    [FieldOffset(Offset = "0x24")]
    public int ItemId;

    [Token(Token = "0x600295F")]
    [Address(RVA = "0x367D09C", Offset = "0x367D09C", VA = "0x367D09C")]
    public BuffItem()
    {
    }
  }
}

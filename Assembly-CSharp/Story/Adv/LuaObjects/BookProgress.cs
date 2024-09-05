// Decompiled with JetBrains decompiler
// Type: Story.Adv.LuaObjects.BookProgress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;

#nullable disable
namespace Story.Adv.LuaObjects
{
  [Token(Token = "0x2000763")]
  [MoonSharpUserData]
  public class BookProgress
  {
    [Token(Token = "0x40021D0")]
    [FieldOffset(Offset = "0x10")]
    public int Current;
    [Token(Token = "0x40021D1")]
    [FieldOffset(Offset = "0x14")]
    public int Max;
    [Token(Token = "0x40021D2")]
    [FieldOffset(Offset = "0x18")]
    public Reaction[] Reactions;

    [Token(Token = "0x6002968")]
    [Address(RVA = "0x367F45C", Offset = "0x367F45C", VA = "0x367F45C")]
    public BookProgress()
    {
    }
  }
}

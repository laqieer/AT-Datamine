// Decompiled with JetBrains decompiler
// Type: Story.Adv.StoryMainQuest.ReadBookAdvLuaFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MoonSharp.Interpreter;
using Story.Adv.Facility;
using Story.Adv.LuaObjects;

#nullable disable
namespace Story.Adv.StoryMainQuest
{
  [Token(Token = "0x2000753")]
  public class ReadBookAdvLuaFunction
  {
    [Token(Token = "0x1700061F")]
    public ReadBookAdvLuaFunction.Object Obj
    {
      [Token(Token = "0x6002904"), Address(RVA = "0x367A4B4", Offset = "0x367A4B4", VA = "0x367A4B4")] get
      {
        return (ReadBookAdvLuaFunction.Object) null;
      }
      [Token(Token = "0x6002905"), Address(RVA = "0x367A4BC", Offset = "0x367A4BC", VA = "0x367A4BC")] private set
      {
      }
    }

    [Token(Token = "0x6002906")]
    [Address(RVA = "0x367A3C8", Offset = "0x367A3C8", VA = "0x367A3C8")]
    public void Initialize()
    {
    }

    [Token(Token = "0x6002907")]
    [Address(RVA = "0x367A3C0", Offset = "0x367A3C0", VA = "0x367A3C0")]
    public ReadBookAdvLuaFunction()
    {
    }

    [Token(Token = "0x2000754")]
    [MoonSharpUserData]
    public class Object
    {
      [Token(Token = "0x400219E")]
      [FieldOffset(Offset = "0x10")]
      private LuaFunction.Object facilityObject;

      [Token(Token = "0x17000620")]
      public bool HaveReadableBook
      {
        [Token(Token = "0x6002908"), Address(RVA = "0x367A528", Offset = "0x367A528", VA = "0x367A528")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x6002909")]
      [Address(RVA = "0x367A54C", Offset = "0x367A54C", VA = "0x367A54C")]
      public Book[] GetUserBooks() => (Book[]) null;

      [Token(Token = "0x600290A")]
      [Address(RVA = "0x367A4C4", Offset = "0x367A4C4", VA = "0x367A4C4")]
      public Object()
      {
      }
    }
  }
}

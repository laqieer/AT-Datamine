// Decompiled with JetBrains decompiler
// Type: Story.Tracker.Logic.Handle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Tracker.Logic
{
  [Token(Token = "0x20005E7")]
  public struct Handle
  {
    [Token(Token = "0x170004D7")]
    public Handle.IDType Type
    {
      [Token(Token = "0x600223F"), Address(RVA = "0x2D9E394", Offset = "0x2D9E394", VA = "0x2D9E394")] readonly get
      {
        return new Handle.IDType();
      }
      [Token(Token = "0x6002240"), Address(RVA = "0x2D9E39C", Offset = "0x2D9E39C", VA = "0x2D9E39C")] private set
      {
      }
    }

    [Token(Token = "0x170004D8")]
    public int ID
    {
      [Token(Token = "0x6002241"), Address(RVA = "0x2D9E3A4", Offset = "0x2D9E3A4", VA = "0x2D9E3A4")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x6002242"), Address(RVA = "0x2D9E3AC", Offset = "0x2D9E3AC", VA = "0x2D9E3AC")] private set
      {
      }
    }

    [Token(Token = "0x6002243")]
    [Address(RVA = "0x2D9E3B4", Offset = "0x2D9E3B4", VA = "0x2D9E3B4")]
    public Handle(Handle.IDType type, int id)
    {
    }

    [Token(Token = "0x6002244")]
    [Address(RVA = "0x2D9E3BC", Offset = "0x2D9E3BC", VA = "0x2D9E3BC", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6002245")]
    [Address(RVA = "0x2D9E448", Offset = "0x2D9E448", VA = "0x2D9E448", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6002246")]
    [Address(RVA = "0x2D9E4D0", Offset = "0x2D9E4D0", VA = "0x2D9E4D0")]
    public bool Equals(Handle other) => new bool();

    [Token(Token = "0x6002247")]
    [Address(RVA = "0x2D9E4F8", Offset = "0x2D9E4F8", VA = "0x2D9E4F8")]
    public static bool operator ==(Handle left, Handle right) => new bool();

    [Token(Token = "0x6002248")]
    [Address(RVA = "0x2D9E518", Offset = "0x2D9E518", VA = "0x2D9E518")]
    public static bool operator !=(Handle left, Handle right) => new bool();

    [Token(Token = "0x20005E8")]
    public enum IDType
    {
      [Token(Token = "0x4001D65")] AreaEventQuest,
      [Token(Token = "0x4001D66")] SubQuest,
      [Token(Token = "0x4001D67")] AreaEventQuestTask,
      [Token(Token = "0x4001D68")] SubQuestTask,
    }
  }
}

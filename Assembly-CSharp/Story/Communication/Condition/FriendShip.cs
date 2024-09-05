// Decompiled with JetBrains decompiler
// Type: Story.Communication.Condition.FriendShip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Story.Communication.Condition
{
  [Token(Token = "0x20006B7")]
  public struct FriendShip : IRangeCondition
  {
    [Token(Token = "0x1700059A")]
    public int Min
    {
      [Token(Token = "0x600260A"), Address(RVA = "0x2F3FD00", Offset = "0x2F3FD00", VA = "0x2F3FD00", Slot = "4")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600260B"), Address(RVA = "0x2F3FD08", Offset = "0x2F3FD08", VA = "0x2F3FD08")] private set
      {
      }
    }

    [Token(Token = "0x1700059B")]
    public int Max
    {
      [Token(Token = "0x600260C"), Address(RVA = "0x2F3FD10", Offset = "0x2F3FD10", VA = "0x2F3FD10", Slot = "5")] readonly get
      {
        return new int();
      }
      [Token(Token = "0x600260D"), Address(RVA = "0x2F3FD18", Offset = "0x2F3FD18", VA = "0x2F3FD18")] private set
      {
      }
    }

    [Token(Token = "0x1700059C")]
    public bool IsDefault
    {
      [Token(Token = "0x600260E"), Address(RVA = "0x2F3FD20", Offset = "0x2F3FD20", VA = "0x2F3FD20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600260F")]
    [Address(RVA = "0x2F3FD34", Offset = "0x2F3FD34", VA = "0x2F3FD34")]
    public FriendShip(int value)
    {
    }

    [Token(Token = "0x6002610")]
    [Address(RVA = "0x2F3FD3C", Offset = "0x2F3FD3C", VA = "0x2F3FD3C")]
    public FriendShip(int min, int max)
    {
    }
  }
}

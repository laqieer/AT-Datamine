// Decompiled with JetBrains decompiler
// Type: Story.Communication.CommunicationStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.Communication.Condition;

#nullable disable
namespace Story.Communication
{
  [Token(Token = "0x20006B3")]
  public class CommunicationStatus
  {
    [Token(Token = "0x17000593")]
    public int UnitID
    {
      [Token(Token = "0x60025F5"), Address(RVA = "0x2F3F7C4", Offset = "0x2F3F7C4", VA = "0x2F3F7C4")] get
      {
        return new int();
      }
      [Token(Token = "0x60025F6"), Address(RVA = "0x2F3F7CC", Offset = "0x2F3F7CC", VA = "0x2F3F7CC")] private set
      {
      }
    }

    [Token(Token = "0x17000594")]
    public CommunicationStatus.Count FriendShip
    {
      [Token(Token = "0x60025F7"), Address(RVA = "0x2F3F7D4", Offset = "0x2F3F7D4", VA = "0x2F3F7D4")] get
      {
        return (CommunicationStatus.Count) null;
      }
      [Token(Token = "0x60025F8"), Address(RVA = "0x2F3F7DC", Offset = "0x2F3F7DC", VA = "0x2F3F7DC")] private set
      {
      }
    }

    [Token(Token = "0x17000595")]
    public CommunicationStatus.Count Communication
    {
      [Token(Token = "0x60025F9"), Address(RVA = "0x2F3F7E4", Offset = "0x2F3F7E4", VA = "0x2F3F7E4")] get
      {
        return (CommunicationStatus.Count) null;
      }
      [Token(Token = "0x60025FA"), Address(RVA = "0x2F3F7EC", Offset = "0x2F3F7EC", VA = "0x2F3F7EC")] private set
      {
      }
    }

    [Token(Token = "0x60025FB")]
    [Address(RVA = "0x2F3F7F4", Offset = "0x2F3F7F4", VA = "0x2F3F7F4")]
    public CommunicationStatus(int unitID)
    {
    }

    [Token(Token = "0x20006B4")]
    public class Count
    {
      [Token(Token = "0x17000596")]
      public int Value
      {
        [Token(Token = "0x60025FC"), Address(RVA = "0x2F3F8C0", Offset = "0x2F3F8C0", VA = "0x2F3F8C0")] get
        {
          return new int();
        }
        [Token(Token = "0x60025FD"), Address(RVA = "0x2F3F8C8", Offset = "0x2F3F8C8", VA = "0x2F3F8C8")] private set
        {
        }
      }

      [Token(Token = "0x60025FE")]
      [Address(RVA = "0x2F3F898", Offset = "0x2F3F898", VA = "0x2F3F898")]
      public Count(int defaultValue = 0)
      {
      }

      [Token(Token = "0x60025FF")]
      [Address(RVA = "0x2F3F8D0", Offset = "0x2F3F8D0", VA = "0x2F3F8D0")]
      public void Increase()
      {
      }

      [Token(Token = "0x6002600")]
      [Address(RVA = "0x2F3F8E0", Offset = "0x2F3F8E0", VA = "0x2F3F8E0")]
      public void Increase(int add)
      {
      }

      [Token(Token = "0x6002601")]
      [Address(RVA = "0x2F3F958", Offset = "0x2F3F958", VA = "0x2F3F958")]
      public bool Reached(IRangeCondition condition) => new bool();
    }
  }
}

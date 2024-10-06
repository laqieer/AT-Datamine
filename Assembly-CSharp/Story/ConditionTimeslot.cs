// Decompiled with JetBrains decompiler
// Type: Story.ConditionTimeslot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000533")]
  public struct ConditionTimeslot
  {
    [Token(Token = "0x4001B68")]
    [FieldOffset(Offset = "0x0")]
    public int ID;

    [Token(Token = "0x6001E25")]
    [Address(RVA = "0x29FC078", Offset = "0x29FC078", VA = "0x29FC078")]
    public ConditionTimeslot(int id)
    {
    }

    [Token(Token = "0x6001E26")]
    [Address(RVA = "0x29FC080", Offset = "0x29FC080", VA = "0x29FC080")]
    public bool IsMatch(StoryTimeSlotTypeEnum timeslot) => new bool();

    [Token(Token = "0x1700040C")]
    public bool IsContainMorning
    {
      [Token(Token = "0x6001E27"), Address(RVA = "0x29FC0A8", Offset = "0x29FC0A8", VA = "0x29FC0A8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700040D")]
    public bool IsContainAfternoon
    {
      [Token(Token = "0x6001E28"), Address(RVA = "0x29FC0B4", Offset = "0x29FC0B4", VA = "0x29FC0B4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700040E")]
    public bool IsContainAfterSchool
    {
      [Token(Token = "0x6001E29"), Address(RVA = "0x29FC0C0", Offset = "0x29FC0C0", VA = "0x29FC0C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700040F")]
    public bool IsContainNight
    {
      [Token(Token = "0x6001E2A"), Address(RVA = "0x29FC0CC", Offset = "0x29FC0CC", VA = "0x29FC0CC")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000410")]
    public bool IsContainAM
    {
      [Token(Token = "0x6001E2B"), Address(RVA = "0x29FC0D8", Offset = "0x29FC0D8", VA = "0x29FC0D8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000411")]
    public bool IsContainPM
    {
      [Token(Token = "0x6001E2C"), Address(RVA = "0x29FC0E4", Offset = "0x29FC0E4", VA = "0x29FC0E4")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000412")]
    public bool IsContainEvening
    {
      [Token(Token = "0x6001E2D"), Address(RVA = "0x29FC0F0", Offset = "0x29FC0F0", VA = "0x29FC0F0")] get
      {
        return new bool();
      }
    }
  }
}

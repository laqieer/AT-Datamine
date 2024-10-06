// Decompiled with JetBrains decompiler
// Type: Story.ConditionDate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x2000532")]
  public struct ConditionDate
  {
    [Token(Token = "0x4001B67")]
    [FieldOffset(Offset = "0x0")]
    public int ID;

    [Token(Token = "0x6001E1C")]
    [Address(RVA = "0x29FBFF4", Offset = "0x29FBFF4", VA = "0x29FBFF4")]
    public ConditionDate(int id)
    {
    }

    [Token(Token = "0x6001E1D")]
    [Address(RVA = "0x29FBFFC", Offset = "0x29FBFFC", VA = "0x29FBFFC")]
    public bool IsMatch(DayofweekEnum dayofweek) => new bool();

    [Token(Token = "0x17000405")]
    public bool IsContainMonday
    {
      [Token(Token = "0x6001E1E"), Address(RVA = "0x29FC024", Offset = "0x29FC024", VA = "0x29FC024")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000406")]
    public bool IsContainTuesday
    {
      [Token(Token = "0x6001E1F"), Address(RVA = "0x29FC030", Offset = "0x29FC030", VA = "0x29FC030")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000407")]
    public bool IsContainWednesday
    {
      [Token(Token = "0x6001E20"), Address(RVA = "0x29FC03C", Offset = "0x29FC03C", VA = "0x29FC03C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000408")]
    public bool IsContainThursday
    {
      [Token(Token = "0x6001E21"), Address(RVA = "0x29FC048", Offset = "0x29FC048", VA = "0x29FC048")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000409")]
    public bool IsContainFriday
    {
      [Token(Token = "0x6001E22"), Address(RVA = "0x29FC054", Offset = "0x29FC054", VA = "0x29FC054")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700040A")]
    public bool IsContainSaturday
    {
      [Token(Token = "0x6001E23"), Address(RVA = "0x29FC060", Offset = "0x29FC060", VA = "0x29FC060")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700040B")]
    public bool IsContainSunday
    {
      [Token(Token = "0x6001E24"), Address(RVA = "0x29FC06C", Offset = "0x29FC06C", VA = "0x29FC06C")] get
      {
        return new bool();
      }
    }
  }
}

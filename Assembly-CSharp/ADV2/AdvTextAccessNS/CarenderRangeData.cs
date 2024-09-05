// Decompiled with JetBrains decompiler
// Type: ADV2.AdvTextAccessNS.CarenderRangeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace ADV2.AdvTextAccessNS
{
  [Token(Token = "0x2003EFC")]
  public class CarenderRangeData
  {
    [Token(Token = "0x17005203")]
    public int FromYearId
    {
      [Token(Token = "0x6019744"), Address(RVA = "0x373EFEC", Offset = "0x373EFEC", VA = "0x373EFEC")] get
      {
        return new int();
      }
      [Token(Token = "0x6019745"), Address(RVA = "0x373EFF4", Offset = "0x373EFF4", VA = "0x373EFF4")] set
      {
      }
    }

    [Token(Token = "0x17005204")]
    public int FromMonth
    {
      [Token(Token = "0x6019746"), Address(RVA = "0x373EFFC", Offset = "0x373EFFC", VA = "0x373EFFC")] get
      {
        return new int();
      }
      [Token(Token = "0x6019747"), Address(RVA = "0x373F004", Offset = "0x373F004", VA = "0x373F004")] set
      {
      }
    }

    [Token(Token = "0x17005205")]
    public int FromDate
    {
      [Token(Token = "0x6019748"), Address(RVA = "0x373F00C", Offset = "0x373F00C", VA = "0x373F00C")] get
      {
        return new int();
      }
      [Token(Token = "0x6019749"), Address(RVA = "0x373F014", Offset = "0x373F014", VA = "0x373F014")] set
      {
      }
    }

    [Token(Token = "0x17005206")]
    public int ToYearId
    {
      [Token(Token = "0x601974A"), Address(RVA = "0x373F01C", Offset = "0x373F01C", VA = "0x373F01C")] get
      {
        return new int();
      }
      [Token(Token = "0x601974B"), Address(RVA = "0x373F024", Offset = "0x373F024", VA = "0x373F024")] set
      {
      }
    }

    [Token(Token = "0x17005207")]
    public int ToMonth
    {
      [Token(Token = "0x601974C"), Address(RVA = "0x373F02C", Offset = "0x373F02C", VA = "0x373F02C")] get
      {
        return new int();
      }
      [Token(Token = "0x601974D"), Address(RVA = "0x373F034", Offset = "0x373F034", VA = "0x373F034")] set
      {
      }
    }

    [Token(Token = "0x17005208")]
    public int ToDate
    {
      [Token(Token = "0x601974E"), Address(RVA = "0x373F03C", Offset = "0x373F03C", VA = "0x373F03C")] get
      {
        return new int();
      }
      [Token(Token = "0x601974F"), Address(RVA = "0x373F044", Offset = "0x373F044", VA = "0x373F044")] set
      {
      }
    }

    [Token(Token = "0x6019750")]
    [Address(RVA = "0x373F04C", Offset = "0x373F04C", VA = "0x373F04C")]
    public bool IsInRange(CanederTimingData data) => new bool();

    [Token(Token = "0x6019751")]
    [Address(RVA = "0x373F0C0", Offset = "0x373F0C0", VA = "0x373F0C0")]
    public CarenderRangeData(StoryMainQuestCalendarData fromData, StoryMainQuestCalendarData toData)
    {
    }
  }
}

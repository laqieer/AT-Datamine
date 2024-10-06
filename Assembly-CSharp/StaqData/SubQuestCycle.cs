// Decompiled with JetBrains decompiler
// Type: StaqData.SubQuestCycle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020E2")]
  public class SubQuestCycle
  {
    [Token(Token = "0x4008B54")]
    [FieldOffset(Offset = "0x18")]
    private SubQuestCycle.Cycle cycle;

    [Token(Token = "0x17002AD2")]
    public int LastReceiptSequenceID
    {
      [Token(Token = "0x600C72E"), Address(RVA = "0x1CDCF20", Offset = "0x1CDCF20", VA = "0x1CDCF20")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002AD3")]
    public bool ShouldReset
    {
      [Token(Token = "0x600C72F"), Address(RVA = "0x1CDCF28", Offset = "0x1CDCF28", VA = "0x1CDCF28")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17002AD4")]
    public bool NoRepeat
    {
      [Token(Token = "0x600C730"), Address(RVA = "0x1CDCF70", Offset = "0x1CDCF70", VA = "0x1CDCF70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C731")]
    [Address(RVA = "0x1CDCFEC", Offset = "0x1CDCFEC", VA = "0x1CDCFEC")]
    public SubQuestCycle(
      StorySubQuestCycleTypeEnum cycleType,
      DayofweekEnum weeklyCycleDayofweek,
      int monthlyCycleDay,
      int lastReceiptSequenceID)
    {
    }

    [Token(Token = "0x20020E3")]
    private abstract class Cycle
    {
      [Token(Token = "0x17002AD5")]
      public int LastReceiptSequenceID
      {
        [Token(Token = "0x600C732"), Address(RVA = "0x1CDD1CC", Offset = "0x1CDD1CC", VA = "0x1CDD1CC")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002AD6")]
      public abstract bool ShouldReset { [Token(Token = "0x600C733")] get; }

      [Token(Token = "0x17002AD7")]
      public abstract bool IsResetNextCycle { [Token(Token = "0x600C734")] get; }

      [Token(Token = "0x600C735")]
      [Address(RVA = "0x1CDD1D4", Offset = "0x1CDD1D4", VA = "0x1CDD1D4")]
      public Cycle(int lastReceiptSequenceID)
      {
      }

      [Token(Token = "0x20020E4")]
      protected struct Days
      {
        [Token(Token = "0x17002AD8")]
        public readonly StoryMainQuestCalendarData LastDay
        {
          [Token(Token = "0x600C736"), Address(RVA = "0x1CDD1FC", Offset = "0x1CDD1FC", VA = "0x1CDD1FC")] get
          {
            return (StoryMainQuestCalendarData) null;
          }
        }

        [Token(Token = "0x17002AD9")]
        public readonly StoryMainQuestCalendarData CurrentDay
        {
          [Token(Token = "0x600C737"), Address(RVA = "0x1CDD204", Offset = "0x1CDD204", VA = "0x1CDD204")] get
          {
            return (StoryMainQuestCalendarData) null;
          }
        }

        [Token(Token = "0x600C738")]
        [Address(RVA = "0x1CDD20C", Offset = "0x1CDD20C", VA = "0x1CDD20C")]
        public Days(int lastReceiptSequenceID)
        {
        }
      }
    }

    [Token(Token = "0x20020E5")]
    private class NoCycle : SubQuestCycle.Cycle
    {
      [Token(Token = "0x17002ADA")]
      public override bool ShouldReset
      {
        [Token(Token = "0x600C739"), Address(RVA = "0x1CDD364", Offset = "0x1CDD364", VA = "0x1CDD364", Slot = "4")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002ADB")]
      public override bool IsResetNextCycle
      {
        [Token(Token = "0x600C73A"), Address(RVA = "0x1CDD374", Offset = "0x1CDD374", VA = "0x1CDD374", Slot = "5")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C73B")]
      [Address(RVA = "0x1CDD124", Offset = "0x1CDD124", VA = "0x1CDD124")]
      public NoCycle(int lastReceiptSequenceID)
      {
      }
    }

    [Token(Token = "0x20020E6")]
    private class Immediately : SubQuestCycle.Cycle
    {
      [Token(Token = "0x17002ADC")]
      public override bool ShouldReset
      {
        [Token(Token = "0x600C73C"), Address(RVA = "0x1CDD37C", Offset = "0x1CDD37C", VA = "0x1CDD37C", Slot = "4")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002ADD")]
      public override bool IsResetNextCycle
      {
        [Token(Token = "0x600C73D"), Address(RVA = "0x1CDD384", Offset = "0x1CDD384", VA = "0x1CDD384", Slot = "5")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C73E")]
      [Address(RVA = "0x1CDD14C", Offset = "0x1CDD14C", VA = "0x1CDD14C")]
      public Immediately(int lastReceiptSequenceID)
      {
      }
    }

    [Token(Token = "0x20020E7")]
    private class Weekly : SubQuestCycle.Cycle
    {
      [Token(Token = "0x4008B58")]
      private const int WEEK_TO_DAY = 7;
      [Token(Token = "0x4008B59")]
      [FieldOffset(Offset = "0x14")]
      private DayofweekEnum dayofweek;

      [Token(Token = "0x17002ADE")]
      public override bool ShouldReset
      {
        [Token(Token = "0x600C73F"), Address(RVA = "0x1CDD38C", Offset = "0x1CDD38C", VA = "0x1CDD38C", Slot = "4")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002ADF")]
      public override bool IsResetNextCycle
      {
        [Token(Token = "0x600C740"), Address(RVA = "0x1CDD4A4", Offset = "0x1CDD4A4", VA = "0x1CDD4A4", Slot = "5")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C741")]
      [Address(RVA = "0x1CDD174", Offset = "0x1CDD174", VA = "0x1CDD174")]
      public Weekly(int lastReceiptSequenceID, DayofweekEnum dayofweek)
      {
      }

      [Token(Token = "0x600C742")]
      [Address(RVA = "0x1CDD450", Offset = "0x1CDD450", VA = "0x1CDD450")]
      private int GetCycleID(StoryMainQuestCalendarData day) => new int();
    }

    [Token(Token = "0x20020E8")]
    private class Monthly : SubQuestCycle.Cycle
    {
      [Token(Token = "0x4008B5A")]
      [FieldOffset(Offset = "0x14")]
      private int day;
      [Token(Token = "0x4008B5B")]
      private const int MONTHLY_DAYS = 31;

      [Token(Token = "0x17002AE0")]
      public override bool ShouldReset
      {
        [Token(Token = "0x600C743"), Address(RVA = "0x1CDD4AC", Offset = "0x1CDD4AC", VA = "0x1CDD4AC", Slot = "4")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17002AE1")]
      public override bool IsResetNextCycle
      {
        [Token(Token = "0x600C744"), Address(RVA = "0x1CDD56C", Offset = "0x1CDD56C", VA = "0x1CDD56C", Slot = "5")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x600C745")]
      [Address(RVA = "0x1CDD1A0", Offset = "0x1CDD1A0", VA = "0x1CDD1A0")]
      public Monthly(int lastReceiptSequenceID, int day)
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Story.YearMonthDayCalendarTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story.Calendar;
using System.Collections;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005C6")]
  public class YearMonthDayCalendarTransition
  {
    [Token(Token = "0x4001CAE")]
    [FieldOffset(Offset = "0x10")]
    private (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar)? prev;
    [Token(Token = "0x4001CAF")]
    [FieldOffset(Offset = "0x28")]
    private (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar) next;
    [Token(Token = "0x4001CB0")]
    [FieldOffset(Offset = "0x38")]
    private CalendarController calendarController;

    [Token(Token = "0x6002131")]
    [Address(RVA = "0x2D953DC", Offset = "0x2D953DC", VA = "0x2D953DC")]
    public YearMonthDayCalendarTransition(
      (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar) current)
    {
    }

    [Token(Token = "0x6002132")]
    [Address(RVA = "0x2D955C8", Offset = "0x2D955C8", VA = "0x2D955C8")]
    public YearMonthDayCalendarTransition(
      (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar) prev,
      (StoryMainQuestSequenceData sequence, StoryMainQuestCalendarData calendar) next)
    {
    }

    [Token(Token = "0x6002133")]
    [Address(RVA = "0x2D95410", Offset = "0x2D95410", VA = "0x2D95410")]
    public void RegisterOnSetup(IContentTaskHandler transitionSetup)
    {
    }

    [Token(Token = "0x6002134")]
    [Address(RVA = "0x2D954EC", Offset = "0x2D954EC", VA = "0x2D954EC")]
    public void RegisterOnWith(IContentTaskHandler transitionWith)
    {
    }

    [Token(Token = "0x20005C7")]
    public class Setup : IContentTask
    {
      [Token(Token = "0x4001CB1")]
      [FieldOffset(Offset = "0x10")]
      private YearMonthDayCalendarTransition entity;
      [Token(Token = "0x4001CB2")]
      [FieldOffset(Offset = "0x18")]
      private bool loaded;

      [Token(Token = "0x170004A0")]
      private CalendarController calendarController
      {
        [Token(Token = "0x6002135"), Address(RVA = "0x2D970F8", Offset = "0x2D970F8", VA = "0x2D970F8")] get
        {
          return (CalendarController) null;
        }
        [Token(Token = "0x6002136"), Address(RVA = "0x2D97114", Offset = "0x2D97114", VA = "0x2D97114")] set
        {
        }
      }

      [Token(Token = "0x6002137")]
      [Address(RVA = "0x2D970A8", Offset = "0x2D970A8", VA = "0x2D970A8")]
      public Setup(YearMonthDayCalendarTransition entity)
      {
      }

      [Token(Token = "0x6002138")]
      [Address(RVA = "0x2D97130", Offset = "0x2D97130", VA = "0x2D97130", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6002139")]
      [Address(RVA = "0x2D97140", Offset = "0x2D97140", VA = "0x2D97140", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x600213A")]
      [Address(RVA = "0x2D97144", Offset = "0x2D97144", VA = "0x2D97144", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x600213B")]
      [Address(RVA = "0x2D971D4", Offset = "0x2D971D4", VA = "0x2D971D4")]
      public IEnumerator LoadAssetBundle() => (IEnumerator) null;

      [Token(Token = "0x600213C")]
      [Address(RVA = "0x2D97264", Offset = "0x2D97264", VA = "0x2D97264")]
      private IEnumerator InitializeCalendarController() => (IEnumerator) null;
    }

    [Token(Token = "0x20005CB")]
    public class Play : IContentTask
    {
      [Token(Token = "0x4001CBC")]
      [FieldOffset(Offset = "0x10")]
      private YearMonthDayCalendarTransition entity;
      [Token(Token = "0x4001CBD")]
      [FieldOffset(Offset = "0x18")]
      private bool playFinished;

      [Token(Token = "0x170004A7")]
      private CalendarController calendarController
      {
        [Token(Token = "0x600214F"), Address(RVA = "0x2D977A4", Offset = "0x2D977A4", VA = "0x2D977A4")] get
        {
          return (CalendarController) null;
        }
        [Token(Token = "0x6002150"), Address(RVA = "0x2D977C0", Offset = "0x2D977C0", VA = "0x2D977C0")] set
        {
        }
      }

      [Token(Token = "0x6002151")]
      [Address(RVA = "0x2D970D0", Offset = "0x2D970D0", VA = "0x2D970D0")]
      public Play(YearMonthDayCalendarTransition entity)
      {
      }

      [Token(Token = "0x6002152")]
      [Address(RVA = "0x2D977DC", Offset = "0x2D977DC", VA = "0x2D977DC", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6002153")]
      [Address(RVA = "0x2D977EC", Offset = "0x2D977EC", VA = "0x2D977EC", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x6002154")]
      [Address(RVA = "0x2D977F0", Offset = "0x2D977F0", VA = "0x2D977F0", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6002155")]
      [Address(RVA = "0x2D97880", Offset = "0x2D97880", VA = "0x2D97880")]
      private void OnAnimatinoFinish()
      {
      }
    }
  }
}

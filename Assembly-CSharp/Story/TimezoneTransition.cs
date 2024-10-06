// Decompiled with JetBrains decompiler
// Type: Story.TimezoneTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine.Playables;

#nullable disable
namespace Story
{
  [Token(Token = "0x20005BD")]
  public class TimezoneTransition
  {
    [Token(Token = "0x4001C9A")]
    [FieldOffset(Offset = "0x10")]
    private TimezoneTransition.Timezone prev;
    [Token(Token = "0x4001C9B")]
    [FieldOffset(Offset = "0x30")]
    private TimezoneTransition.Timezone next;

    [Token(Token = "0x60020F7")]
    [Address(RVA = "0x2D957F4", Offset = "0x2D957F4", VA = "0x2D957F4")]
    public TimezoneTransition(TimezoneTransition.Timezone prev, TimezoneTransition.Timezone next)
    {
    }

    [Token(Token = "0x60020F8")]
    [Address(RVA = "0x2D9582C", Offset = "0x2D9582C", VA = "0x2D9582C")]
    public void RegisterOnSetup(IContentTaskHandler transitionSetup)
    {
    }

    [Token(Token = "0x60020F9")]
    [Address(RVA = "0x2D95908", Offset = "0x2D95908", VA = "0x2D95908")]
    public void RegisterOnWith(IContentTaskHandler transitionWith)
    {
    }

    [Token(Token = "0x20005BE")]
    public class Setup : IContentTask
    {
      [Token(Token = "0x4001C9C")]
      [FieldOffset(Offset = "0x10")]
      private TimezoneTransition entity;

      [Token(Token = "0x60020FA")]
      [Address(RVA = "0x2D95B24", Offset = "0x2D95B24", VA = "0x2D95B24")]
      public Setup(TimezoneTransition entity)
      {
      }

      [Token(Token = "0x60020FB")]
      [Address(RVA = "0x2D95B74", Offset = "0x2D95B74", VA = "0x2D95B74", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x60020FC")]
      [Address(RVA = "0x2D95B7C", Offset = "0x2D95B7C", VA = "0x2D95B7C", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x60020FD")]
      [Address(RVA = "0x2D95C04", Offset = "0x2D95C04", VA = "0x2D95C04", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }
    }

    [Token(Token = "0x20005C0")]
    public class Play : IContentTask
    {
      [Token(Token = "0x4001C9F")]
      [FieldOffset(Offset = "0x10")]
      private TimezoneTransition entity;
      [Token(Token = "0x4001CA0")]
      [FieldOffset(Offset = "0x18")]
      private bool playFinished;

      [Token(Token = "0x6002104")]
      [Address(RVA = "0x2D95B4C", Offset = "0x2D95B4C", VA = "0x2D95B4C")]
      public Play(TimezoneTransition entity)
      {
      }

      [Token(Token = "0x6002105")]
      [Address(RVA = "0x2D95C84", Offset = "0x2D95C84", VA = "0x2D95C84", Slot = "6")]
      private bool Story\u002EIContentTask\u002EIsBusy() => new bool();

      [Token(Token = "0x6002106")]
      [Address(RVA = "0x2D95C94", Offset = "0x2D95C94", VA = "0x2D95C94", Slot = "4")]
      private IEnumerator Story\u002EIContentTask\u002EStart() => (IEnumerator) null;

      [Token(Token = "0x6002107")]
      [Address(RVA = "0x2D95D24", Offset = "0x2D95D24", VA = "0x2D95D24")]
      private int GetTimeZoneImageID(int sequenceID) => new int();

      [Token(Token = "0x6002108")]
      [Address(RVA = "0x2D961B0", Offset = "0x2D961B0", VA = "0x2D961B0")]
      private static bool isTimeZoneElapsedParam(
        StoryMainQuestSequenceData sequenceData,
        StoryMainQuestTimeZoneElapsedGroupData groupData)
      {
        return new bool();
      }

      [Token(Token = "0x6002109")]
      [Address(RVA = "0x2D96430", Offset = "0x2D96430", VA = "0x2D96430", Slot = "5")]
      private void Story\u002EIContentTask\u002EUpdate()
      {
      }

      [Token(Token = "0x600210A")]
      [Address(RVA = "0x2D96434", Offset = "0x2D96434", VA = "0x2D96434")]
      private void TimeLineFinish(PlayableDirector playableDirector)
      {
      }

      [Token(Token = "0x600210B")]
      [Address(RVA = "0x2D964C0", Offset = "0x2D964C0", VA = "0x2D964C0")]
      private IEnumerator TimeLineFinishInternal() => (IEnumerator) null;

      [Token(Token = "0x600210C")]
      [Address(RVA = "0x2D96550", Offset = "0x2D96550", VA = "0x2D96550")]
      private void FinishToOutAnimation()
      {
      }

      [Token(Token = "0x600210D")]
      [Address(RVA = "0x2D96704", Offset = "0x2D96704", VA = "0x2D96704")]
      private IEnumerator AnimationStart() => (IEnumerator) null;
    }

    [Token(Token = "0x20005C4")]
    public struct Timezone
    {
      [Token(Token = "0x1700049B")]
      public int SequenceID
      {
        [Token(Token = "0x6002122"), Address(RVA = "0x2D96D9C", Offset = "0x2D96D9C", VA = "0x2D96D9C")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6002123"), Address(RVA = "0x2D96DA4", Offset = "0x2D96DA4", VA = "0x2D96DA4")] set
        {
        }
      }

      [Token(Token = "0x1700049C")]
      public int ID
      {
        [Token(Token = "0x6002124"), Address(RVA = "0x2D96DAC", Offset = "0x2D96DAC", VA = "0x2D96DAC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6002125"), Address(RVA = "0x2D96DB4", Offset = "0x2D96DB4", VA = "0x2D96DB4")] set
        {
        }
      }

      [Token(Token = "0x1700049D")]
      public int Index
      {
        [Token(Token = "0x6002126"), Address(RVA = "0x2D96DBC", Offset = "0x2D96DBC", VA = "0x2D96DBC")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6002127"), Address(RVA = "0x2D96DC4", Offset = "0x2D96DC4", VA = "0x2D96DC4")] set
        {
        }
      }

      [Token(Token = "0x1700049E")]
      public string Text
      {
        [Token(Token = "0x6002128"), Address(RVA = "0x2D96DCC", Offset = "0x2D96DCC", VA = "0x2D96DCC")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x6002129"), Address(RVA = "0x2D96DD4", Offset = "0x2D96DD4", VA = "0x2D96DD4")] set
        {
        }
      }

      [Token(Token = "0x1700049F")]
      public string TextAlternate
      {
        [Token(Token = "0x600212A"), Address(RVA = "0x2D96DDC", Offset = "0x2D96DDC", VA = "0x2D96DDC")] readonly get
        {
          return (string) null;
        }
        [Token(Token = "0x600212B"), Address(RVA = "0x2D96DE4", Offset = "0x2D96DE4", VA = "0x2D96DE4")] set
        {
        }
      }

      [Token(Token = "0x600212C")]
      [Address(RVA = "0x2D9566C", Offset = "0x2D9566C", VA = "0x2D9566C")]
      public static TimezoneTransition.Timezone Create(int sequenceID, StoryTimeSlotTypeEnum type)
      {
        return new TimezoneTransition.Timezone();
      }
    }
  }
}

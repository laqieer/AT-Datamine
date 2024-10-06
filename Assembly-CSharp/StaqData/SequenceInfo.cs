// Decompiled with JetBrains decompiler
// Type: StaqData.SequenceInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using Story;
using System;
using System.Collections.Generic;

#nullable disable
namespace StaqData
{
  [Token(Token = "0x20020C9")]
  public sealed class SequenceInfo
  {
    [Token(Token = "0x4008B2B")]
    [FieldOffset(Offset = "0x10")]
    private int sequenceID;
    [Token(Token = "0x4008B2C")]
    [FieldOffset(Offset = "0x14")]
    private int prevSequenceID;
    [Token(Token = "0x4008B2D")]
    [FieldOffset(Offset = "0x18")]
    private int nextSequenceID;

    [Token(Token = "0x17002A8A")]
    [Obsolete("see RuntimeDataManager.Instance.Story.StoryChapterSequence.Chart.ChartID")]
    public int ChapterID
    {
      [Token(Token = "0x600C698"), Address(RVA = "0x1CD8040", Offset = "0x1CD8040", VA = "0x1CD8040")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A8B")]
    public int SequenceID
    {
      [Token(Token = "0x600C699"), Address(RVA = "0x1CD80C8", Offset = "0x1CD80C8", VA = "0x1CD80C8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A8C")]
    public int PrevSequenceID
    {
      [Token(Token = "0x600C69A"), Address(RVA = "0x1CD80D0", Offset = "0x1CD80D0", VA = "0x1CD80D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17002A8D")]
    public int NextSequenceID
    {
      [Token(Token = "0x600C69B"), Address(RVA = "0x1CD80D8", Offset = "0x1CD80D8", VA = "0x1CD80D8")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x14000132")]
    private event Action OnChange
    {
      [Token(Token = "0x600C69C"), Address(RVA = "0x1CD80E0", Offset = "0x1CD80E0", VA = "0x1CD80E0")] add
      {
      }
      [Token(Token = "0x600C69D"), Address(RVA = "0x1CD817C", Offset = "0x1CD817C", VA = "0x1CD817C")] remove
      {
      }
    }

    [Token(Token = "0x17002A8E")]
    public StoryID StoryID
    {
      [Token(Token = "0x600C69E"), Address(RVA = "0x1CD8218", Offset = "0x1CD8218", VA = "0x1CD8218")] get
      {
        return new StoryID();
      }
      [Token(Token = "0x600C69F"), Address(RVA = "0x1CD8220", Offset = "0x1CD8220", VA = "0x1CD8220")] private set
      {
      }
    }

    [Token(Token = "0x600C6A0")]
    [Address(RVA = "0x1CD8228", Offset = "0x1CD8228", VA = "0x1CD8228")]
    public SequenceInfo(StoryID storyID, int sequenceID)
    {
    }

    [Token(Token = "0x600C6A1")]
    [Address(RVA = "0x1CD832C", Offset = "0x1CD832C", VA = "0x1CD832C")]
    public void Initialize(StoryID storyID, int sequenceID)
    {
    }

    [Token(Token = "0x600C6A2")]
    [Address(RVA = "0x1CD8338", Offset = "0x1CD8338", VA = "0x1CD8338")]
    public void Set(int sequenceID)
    {
    }

    [Token(Token = "0x600C6A3")]
    [Address(RVA = "0x1CD8340", Offset = "0x1CD8340", VA = "0x1CD8340")]
    private void ChangeSequence()
    {
    }

    [Token(Token = "0x600C6A4")]
    [Address(RVA = "0x1CD8374", Offset = "0x1CD8374", VA = "0x1CD8374")]
    public void DebugSet(int sequenceID)
    {
    }

    [Token(Token = "0x600C6A5")]
    [Address(RVA = "0x1CD8380", Offset = "0x1CD8380", VA = "0x1CD8380", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x20020CA")]
    public class SequenceHandler
    {
      [Token(Token = "0x4008B30")]
      [FieldOffset(Offset = "0x10")]
      private SequenceInfo sequence;

      [Token(Token = "0x600C6A6")]
      [Address(RVA = "0x1CD8444", Offset = "0x1CD8444", VA = "0x1CD8444")]
      public SequenceHandler(SequenceInfo sequence)
      {
      }

      [Token(Token = "0x600C6A7")]
      [Address(RVA = "0x1CD846C", Offset = "0x1CD846C", VA = "0x1CD846C")]
      public void StartSequence()
      {
      }

      [Token(Token = "0x600C6A8")]
      [Address(RVA = "0x1CD854C", Offset = "0x1CD854C", VA = "0x1CD854C")]
      public bool IsValidNextSequence() => new bool();

      [Token(Token = "0x600C6A9")]
      [Address(RVA = "0x1CD8498", Offset = "0x1CD8498", VA = "0x1CD8498")]
      public void ChangeSequence()
      {
      }

      [Token(Token = "0x600C6AA")]
      [Address(RVA = "0x1CD8614", Offset = "0x1CD8614", VA = "0x1CD8614")]
      public void ChangeHeader()
      {
      }
    }

    [Token(Token = "0x20020CB")]
    public sealed class StoryChapterSequence : 
      SequenceInfo.StoryChapterSequence.ISequence,
      SequenceInfo.StoryChapterSequence.IAdvSequence,
      SequenceInfo.StoryChapterSequence.IBattleSequence,
      SequenceInfo.StoryChapterSequence.ITutorialBattleSequence,
      SequenceInfo.StoryChapterSequence.IFreeActionSequence,
      SequenceInfo.StoryChapterSequence.IAreaEventFreeActionSequence,
      SequenceInfo.StoryChapterSequence.IBookAdv,
      SequenceInfo.StoryChapterSequence.IEnding
    {
      [Token(Token = "0x4008B31")]
      [FieldOffset(Offset = "0x10")]
      private SequenceInfo sequence;

      [Token(Token = "0x17002A8F")]
      private int sequenceID
      {
        [Token(Token = "0x600C6AB"), Address(RVA = "0x1CD869C", Offset = "0x1CD869C", VA = "0x1CD869C")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A90")]
      private int prevSequenceID
      {
        [Token(Token = "0x600C6AC"), Address(RVA = "0x1CD86B8", Offset = "0x1CD86B8", VA = "0x1CD86B8")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A91")]
      private int nextSequenceID
      {
        [Token(Token = "0x600C6AD"), Address(RVA = "0x1CD86D4", Offset = "0x1CD86D4", VA = "0x1CD86D4")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17002A92")]
      public StoryMainQuestSequenceData CurrentSequence
      {
        [Token(Token = "0x600C6AE"), Address(RVA = "0x1CD86F0", Offset = "0x1CD86F0", VA = "0x1CD86F0")] get
        {
          return (StoryMainQuestSequenceData) null;
        }
      }

      [Token(Token = "0x17002A93")]
      public StoryMainQuestSequenceData PrevSequence
      {
        [Token(Token = "0x600C6AF"), Address(RVA = "0x1CD8794", Offset = "0x1CD8794", VA = "0x1CD8794")] get
        {
          return (StoryMainQuestSequenceData) null;
        }
      }

      [Token(Token = "0x17002A94")]
      public StoryMainQuestSequenceData NextSequence
      {
        [Token(Token = "0x600C6B0"), Address(RVA = "0x1CD8838", Offset = "0x1CD8838", VA = "0x1CD8838")] get
        {
          return (StoryMainQuestSequenceData) null;
        }
      }

      [Token(Token = "0x17002A95")]
      public StoryMainQuestCalendarData CurrentCalendar
      {
        [Token(Token = "0x600C6B1"), Address(RVA = "0x1CD88DC", Offset = "0x1CD88DC", VA = "0x1CD88DC")] get
        {
          return (StoryMainQuestCalendarData) null;
        }
      }

      [Token(Token = "0x17002A96")]
      public StoryMainQuestCalendarData PrevCalendar
      {
        [Token(Token = "0x600C6B2"), Address(RVA = "0x1CD88F8", Offset = "0x1CD88F8", VA = "0x1CD88F8")] get
        {
          return (StoryMainQuestCalendarData) null;
        }
      }

      [Token(Token = "0x17002A97")]
      public StoryMainQuestCalendarData NextCalendar
      {
        [Token(Token = "0x600C6B3"), Address(RVA = "0x1CD8918", Offset = "0x1CD8918", VA = "0x1CD8918")] get
        {
          return (StoryMainQuestCalendarData) null;
        }
      }

      [Token(Token = "0x600C6B4")]
      [Address(RVA = "0x1CD6E2C", Offset = "0x1CD6E2C", VA = "0x1CD6E2C")]
      public bool CheckCalendar(int begin, int end) => new bool();

      [Token(Token = "0x17002A98")]
      public SequenceInfo.StoryChapterSequence.Info CurrentInfo
      {
        [Token(Token = "0x600C6B5"), Address(RVA = "0x1CD8938", Offset = "0x1CD8938", VA = "0x1CD8938")] get
        {
          return new SequenceInfo.StoryChapterSequence.Info();
        }
      }

      [Token(Token = "0x17002A99")]
      public SequenceInfo.StoryChapterSequence.Info PrevInfo
      {
        [Token(Token = "0x600C6B6"), Address(RVA = "0x1CD897C", Offset = "0x1CD897C", VA = "0x1CD897C")] get
        {
          return new SequenceInfo.StoryChapterSequence.Info();
        }
      }

      [Token(Token = "0x17002A9A")]
      public SequenceInfo.StoryChapterSequence.Info NextInfo
      {
        [Token(Token = "0x600C6B7"), Address(RVA = "0x1CD89A8", Offset = "0x1CD89A8", VA = "0x1CD89A8")] get
        {
          return new SequenceInfo.StoryChapterSequence.Info();
        }
      }

      [Token(Token = "0x600C6B8")]
      [Address(RVA = "0x1CD89D4", Offset = "0x1CD89D4", VA = "0x1CD89D4")]
      public SequenceInfo.StoryChapterSequence.ISequence AsSequence()
      {
        return (SequenceInfo.StoryChapterSequence.ISequence) null;
      }

      [Token(Token = "0x17002A9B")]
      public SequenceInfo.StoryChapterSequence.IAdvSequence Adv
      {
        [Token(Token = "0x600C6B9"), Address(RVA = "0x1CD8A70", Offset = "0x1CD8A70", VA = "0x1CD8A70")] get
        {
          return (SequenceInfo.StoryChapterSequence.IAdvSequence) null;
        }
      }

      [Token(Token = "0x17002A9C")]
      public SequenceInfo.StoryChapterSequence.IBattleSequence Battle
      {
        [Token(Token = "0x600C6BA"), Address(RVA = "0x1CD8A98", Offset = "0x1CD8A98", VA = "0x1CD8A98")] get
        {
          return (SequenceInfo.StoryChapterSequence.IBattleSequence) null;
        }
      }

      [Token(Token = "0x17002A9D")]
      public SequenceInfo.StoryChapterSequence.ITutorialBattleSequence TutorialBattle
      {
        [Token(Token = "0x600C6BB"), Address(RVA = "0x1CD8AC0", Offset = "0x1CD8AC0", VA = "0x1CD8AC0")] get
        {
          return (SequenceInfo.StoryChapterSequence.ITutorialBattleSequence) null;
        }
      }

      [Token(Token = "0x17002A9E")]
      public SequenceInfo.StoryChapterSequence.IFreeActionSequence FreeAction
      {
        [Token(Token = "0x600C6BC"), Address(RVA = "0x1CD6AC4", Offset = "0x1CD6AC4", VA = "0x1CD6AC4")] get
        {
          return (SequenceInfo.StoryChapterSequence.IFreeActionSequence) null;
        }
      }

      [Token(Token = "0x17002A9F")]
      public SequenceInfo.StoryChapterSequence.IAreaEventFreeActionSequence AreaEventFreeAction
      {
        [Token(Token = "0x600C6BD"), Address(RVA = "0x1CD8AE8", Offset = "0x1CD8AE8", VA = "0x1CD8AE8")] get
        {
          return (SequenceInfo.StoryChapterSequence.IAreaEventFreeActionSequence) null;
        }
      }

      [Token(Token = "0x17002AA0")]
      public SequenceInfo.StoryChapterSequence.IBookAdv BookAdv
      {
        [Token(Token = "0x600C6BE"), Address(RVA = "0x1CD8B38", Offset = "0x1CD8B38", VA = "0x1CD8B38")] get
        {
          return (SequenceInfo.StoryChapterSequence.IBookAdv) null;
        }
      }

      [Token(Token = "0x17002AA1")]
      public SequenceInfo.StoryChapterSequence.IEnding Ending
      {
        [Token(Token = "0x600C6BF"), Address(RVA = "0x1CD8B10", Offset = "0x1CD8B10", VA = "0x1CD8B10")] get
        {
          return (SequenceInfo.StoryChapterSequence.IEnding) null;
        }
      }

      [Token(Token = "0x17002AA2")]
      private AdvDemoInfoData StaqData\u002ESequenceInfo\u002EStoryChapterSequence\u002EIAdvSequence\u002EDemoInfo
      {
        [Token(Token = "0x600C6C0"), Address(RVA = "0x1CD8B60", Offset = "0x1CD8B60", VA = "0x1CD8B60", Slot = "4")] get
        {
          return (AdvDemoInfoData) null;
        }
      }

      [Token(Token = "0x17002AA3")]
      private StoryFreeActionSettingData StaqData\u002ESequenceInfo\u002EStoryChapterSequence\u002EIFreeActionSequence\u002ESetting
      {
        [Token(Token = "0x600C6C1"), Address(RVA = "0x1CD8C0C", Offset = "0x1CD8C0C", VA = "0x1CD8C0C", Slot = "7")] get
        {
          return (StoryFreeActionSettingData) null;
        }
      }

      [Token(Token = "0x17002AA4")]
      private IStoryQuestData StaqData\u002ESequenceInfo\u002EStoryChapterSequence\u002EIBattleSequence\u002EMainQuest
      {
        [Token(Token = "0x600C6C2"), Address(RVA = "0x1CD8CB8", Offset = "0x1CD8CB8", VA = "0x1CD8CB8", Slot = "5")] get
        {
          return (IStoryQuestData) null;
        }
      }

      [Token(Token = "0x17002AA5")]
      private IStoryQuestData StaqData\u002ESequenceInfo\u002EStoryChapterSequence\u002EITutorialBattleSequence\u002EMainQuest
      {
        [Token(Token = "0x600C6C3"), Address(RVA = "0x1CD8DB8", Offset = "0x1CD8DB8", VA = "0x1CD8DB8", Slot = "6")] get
        {
          return (IStoryQuestData) null;
        }
      }

      [Token(Token = "0x17002AA6")]
      private IStoryQuestData mainQuest
      {
        [Token(Token = "0x600C6C4"), Address(RVA = "0x1CD8CBC", Offset = "0x1CD8CBC", VA = "0x1CD8CBC")] get
        {
          return (IStoryQuestData) null;
        }
      }

      [Token(Token = "0x600C6C5")]
      [Address(RVA = "0x1CD8E30", Offset = "0x1CD8E30", VA = "0x1CD8E30", Slot = "8")]
      public int GetFreeActionPlayerCharaSwitchPatternID(StoryFreeActionSettingData setting)
      {
        return new int();
      }

      [Token(Token = "0x17002AA7")]
      public IEnumerable<int> RouteIDs
      {
        [Token(Token = "0x600C6C6"), Address(RVA = "0x1CD9318", Offset = "0x1CD9318", VA = "0x1CD9318")] get
        {
          return (IEnumerable<int>) null;
        }
      }

      [Token(Token = "0x600C6C7")]
      [Address(RVA = "0x1CD93A8", Offset = "0x1CD93A8", VA = "0x1CD93A8")]
      public ITransitionDirection CreateTransitionDirection() => (ITransitionDirection) null;

      [Token(Token = "0x600C6C8")]
      [Address(RVA = "0x1CD9434", Offset = "0x1CD9434", VA = "0x1CD9434")]
      public StoryChapterSequence(SequenceInfo sequence)
      {
      }

      [Token(Token = "0x600C6C9")]
      [Address(RVA = "0x1CD94D4", Offset = "0x1CD94D4", VA = "0x1CD94D4")]
      private void InvokeCalendarChange()
      {
      }

      [Token(Token = "0x600C6CA")]
      [Address(RVA = "0x1CD9564", Offset = "0x1CD9564", VA = "0x1CD9564", Slot = "9")]
      private StoryFreeActionAreaData StaqData\u002ESequenceInfo\u002EStoryChapterSequence\u002EIFreeActionSequence\u002ESearchArea(
        int objectID)
      {
        return (StoryFreeActionAreaData) null;
      }

      [Token(Token = "0x20020CC")]
      public interface ISequence
      {
      }

      [Token(Token = "0x20020CD")]
      public interface IAdvSequence : SequenceInfo.StoryChapterSequence.ISequence
      {
        [Token(Token = "0x17002AA8")]
        AdvDemoInfoData DemoInfo { [Token(Token = "0x600C6CB")] get; }
      }

      [Token(Token = "0x20020CE")]
      public interface IBattleSequence : SequenceInfo.StoryChapterSequence.ISequence
      {
        [Token(Token = "0x17002AA9")]
        IStoryQuestData MainQuest { [Token(Token = "0x600C6CC")] get; }
      }

      [Token(Token = "0x20020CF")]
      public interface ITutorialBattleSequence : SequenceInfo.StoryChapterSequence.ISequence
      {
        [Token(Token = "0x17002AAA")]
        IStoryQuestData MainQuest { [Token(Token = "0x600C6CD")] get; }
      }

      [Token(Token = "0x20020D0")]
      public interface IFreeActionSequence : SequenceInfo.StoryChapterSequence.ISequence
      {
        [Token(Token = "0x17002AAB")]
        StoryFreeActionSettingData Setting { [Token(Token = "0x600C6CE")] get; }

        [Token(Token = "0x600C6CF")]
        int GetFreeActionPlayerCharaSwitchPatternID(StoryFreeActionSettingData setting);

        [Token(Token = "0x600C6D0")]
        StoryFreeActionAreaData SearchArea(int objectID);
      }

      [Token(Token = "0x20020D1")]
      public interface IAreaEventFreeActionSequence : 
        SequenceInfo.StoryChapterSequence.IFreeActionSequence,
        SequenceInfo.StoryChapterSequence.ISequence
      {
      }

      [Token(Token = "0x20020D2")]
      public interface IBookAdv : 
        SequenceInfo.StoryChapterSequence.IAdvSequence,
        SequenceInfo.StoryChapterSequence.ISequence
      {
      }

      [Token(Token = "0x20020D3")]
      public interface IEnding : 
        SequenceInfo.StoryChapterSequence.IAdvSequence,
        SequenceInfo.StoryChapterSequence.ISequence
      {
      }

      [Token(Token = "0x20020D4")]
      public struct Info
      {
        [Token(Token = "0x17002AAC")]
        public StoryTimeSlotTypeEnum TimeSlot
        {
          [Token(Token = "0x600C6D1"), Address(RVA = "0x1CD9A00", Offset = "0x1CD9A00", VA = "0x1CD9A00")] readonly get
          {
            return new StoryTimeSlotTypeEnum();
          }
          [Token(Token = "0x600C6D2"), Address(RVA = "0x1CD9A08", Offset = "0x1CD9A08", VA = "0x1CD9A08")] set
          {
          }
        }

        [Token(Token = "0x17002AAD")]
        public StoryWeatherTypeEnum Weather
        {
          [Token(Token = "0x600C6D3"), Address(RVA = "0x1CD9A10", Offset = "0x1CD9A10", VA = "0x1CD9A10")] readonly get
          {
            return new StoryWeatherTypeEnum();
          }
          [Token(Token = "0x600C6D4"), Address(RVA = "0x1CD9A18", Offset = "0x1CD9A18", VA = "0x1CD9A18")] set
          {
          }
        }

        [Token(Token = "0x600C6D5")]
        [Address(RVA = "0x1CD8964", Offset = "0x1CD8964", VA = "0x1CD8964")]
        public Info(StoryMainQuestSequenceData sequence)
        {
        }
      }

      [Token(Token = "0x20020D5")]
      public class DirectorFactory : IContentDirectorFactory
      {
        [Token(Token = "0x600C6D6")]
        [Address(RVA = "0x1CD9A20", Offset = "0x1CD9A20", VA = "0x1CD9A20", Slot = "4")]
        public IContentDirector Create(PlayingStoryInfo playingStory) => (IContentDirector) null;

        [Token(Token = "0x600C6D7")]
        [Address(RVA = "0x1CDA258", Offset = "0x1CDA258", VA = "0x1CDA258")]
        public DirectorFactory()
        {
        }
      }

      [Token(Token = "0x20020D6")]
      public class YearMonthDayTransitionHandler : ITransitionDirection
      {
        [Token(Token = "0x4008B34")]
        [FieldOffset(Offset = "0x10")]
        private SequenceInfo.StoryChapterSequence sequence;

        [Token(Token = "0x600C6D8")]
        [Address(RVA = "0x1CD940C", Offset = "0x1CD940C", VA = "0x1CD940C")]
        public YearMonthDayTransitionHandler(SequenceInfo.StoryChapterSequence sequence)
        {
        }

        [Token(Token = "0x600C6D9")]
        [Address(RVA = "0x1CDA260", Offset = "0x1CDA260", VA = "0x1CDA260", Slot = "4")]
        private void Story\u002EITransitionDirection\u002ETransitionOnStart(
          IContentTaskHandler transitionSetup,
          IContentTaskHandler transitionWith)
        {
        }

        [Token(Token = "0x600C6DA")]
        [Address(RVA = "0x1CDA294", Offset = "0x1CDA294", VA = "0x1CDA294", Slot = "5")]
        private void Story\u002EITransitionDirection\u002ETransitionOnEnd(
          IContentTaskHandler transitionSetup,
          IContentTaskHandler transitionWith)
        {
        }
      }

      [Token(Token = "0x20020D7")]
      public class XDayTransitionHandler : ITransitionDirection
      {
        [Token(Token = "0x4008B35")]
        [FieldOffset(Offset = "0x10")]
        private SequenceInfo.StoryChapterSequence sequence;

        [Token(Token = "0x600C6DB")]
        [Address(RVA = "0x1CDA298", Offset = "0x1CDA298", VA = "0x1CDA298")]
        public XDayTransitionHandler(SequenceInfo.StoryChapterSequence sequence)
        {
        }

        [Token(Token = "0x600C6DC")]
        [Address(RVA = "0x1CDA2C0", Offset = "0x1CDA2C0", VA = "0x1CDA2C0", Slot = "4")]
        private void Story\u002EITransitionDirection\u002ETransitionOnStart(
          IContentTaskHandler transitionSetup,
          IContentTaskHandler transitionWith)
        {
        }

        [Token(Token = "0x600C6DD")]
        [Address(RVA = "0x1CDA2F4", Offset = "0x1CDA2F4", VA = "0x1CDA2F4", Slot = "5")]
        private void Story\u002EITransitionDirection\u002ETransitionOnEnd(
          IContentTaskHandler transitionSetup,
          IContentTaskHandler transitionWith)
        {
        }
      }
    }
  }
}

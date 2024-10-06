// Decompiled with JetBrains decompiler
// Type: Story.FreeMapDirector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story
{
  [Token(Token = "0x200056B")]
  public class FreeMapDirector : IContentDirector
  {
    [Token(Token = "0x4001BEC")]
    [FieldOffset(Offset = "0x18")]
    private ContentFreeMap content;

    [Token(Token = "0x17000449")]
    public ContentTaskList WithTransitionIn
    {
      [Token(Token = "0x6001F40"), Address(RVA = "0x2A02A2C", Offset = "0x2A02A2C", VA = "0x2A02A2C", Slot = "4")] get
      {
        return (ContentTaskList) null;
      }
    }

    [Token(Token = "0x6001F41")]
    [Address(RVA = "0x2A02A34", Offset = "0x2A02A34", VA = "0x2A02A34")]
    public FreeMapDirector(IFreeMapDirection direction)
    {
    }

    [Token(Token = "0x6001F42")]
    [Address(RVA = "0x2A02ADC", Offset = "0x2A02ADC", VA = "0x2A02ADC", Slot = "6")]
    public void Initialize(IStoryContentSystem contentSystem)
    {
    }

    [Token(Token = "0x6001F43")]
    [Address(RVA = "0x2A02BB4", Offset = "0x2A02BB4", VA = "0x2A02BB4", Slot = "9")]
    public void Abort()
    {
    }

    [Token(Token = "0x6001F44")]
    [Address(RVA = "0x2A02BD4", Offset = "0x2A02BD4", VA = "0x2A02BD4", Slot = "7")]
    public void Start()
    {
    }

    [Token(Token = "0x6001F45")]
    [Address(RVA = "0x2A02BFC", Offset = "0x2A02BFC", VA = "0x2A02BFC", Slot = "8")]
    public void Update()
    {
    }

    [Token(Token = "0x6001F46")]
    [Address(RVA = "0x2A02C1C", Offset = "0x2A02C1C", VA = "0x2A02C1C", Slot = "5")]
    public Content GetContent() => (Content) null;

    [Token(Token = "0x200056C")]
    public struct Default : IFreeMapDirection, IDirection
    {
      [Token(Token = "0x1700044A")]
      public int ChapterID
      {
        [Token(Token = "0x6001F47"), Address(RVA = "0x2A02C24", Offset = "0x2A02C24", VA = "0x2A02C24")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6001F48"), Address(RVA = "0x2A02C2C", Offset = "0x2A02C2C", VA = "0x2A02C2C")] private set
        {
        }
      }

      [Token(Token = "0x1700044B")]
      public int SequenceID
      {
        [Token(Token = "0x6001F49"), Address(RVA = "0x2A02C34", Offset = "0x2A02C34", VA = "0x2A02C34")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6001F4A"), Address(RVA = "0x2A02C3C", Offset = "0x2A02C3C", VA = "0x2A02C3C")] private set
        {
        }
      }

      [Token(Token = "0x1700044C")]
      public int FreeActionSettingID
      {
        [Token(Token = "0x6001F4B"), Address(RVA = "0x2A02C44", Offset = "0x2A02C44", VA = "0x2A02C44")] readonly get
        {
          return new int();
        }
        [Token(Token = "0x6001F4C"), Address(RVA = "0x2A02C4C", Offset = "0x2A02C4C", VA = "0x2A02C4C")] private set
        {
        }
      }

      [Token(Token = "0x6001F4D")]
      [Address(RVA = "0x2A02C54", Offset = "0x2A02C54", VA = "0x2A02C54")]
      public Default(int chapterID, int sequenceID, int freeActionSettingID)
      {
      }

      [Token(Token = "0x6001F4E")]
      [Address(RVA = "0x2A02C60", Offset = "0x2A02C60", VA = "0x2A02C60", Slot = "4")]
      public StoryChapterData GetChapter() => (StoryChapterData) null;

      [Token(Token = "0x6001F4F")]
      [Address(RVA = "0x2A02CFC", Offset = "0x2A02CFC", VA = "0x2A02CFC", Slot = "5")]
      public StoryMainQuestSequenceData GetSequence() => (StoryMainQuestSequenceData) null;

      [Token(Token = "0x6001F50")]
      [Address(RVA = "0x2A02D98", Offset = "0x2A02D98", VA = "0x2A02D98", Slot = "6")]
      public StoryFreeActionSettingData GetSetting() => (StoryFreeActionSettingData) null;
    }
  }
}

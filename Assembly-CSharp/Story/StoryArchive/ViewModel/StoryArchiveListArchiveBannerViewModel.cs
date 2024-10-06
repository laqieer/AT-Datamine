// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.ViewModel.StoryArchiveListArchiveBannerViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.StoryArchive.ViewModel
{
  [Token(Token = "0x2000644")]
  public class StoryArchiveListArchiveBannerViewModel
  {
    [Token(Token = "0x4001E93")]
    [FieldOffset(Offset = "0x10")]
    public string Title;
    [Token(Token = "0x4001E94")]
    [FieldOffset(Offset = "0x18")]
    public int ArchiveId;
    [Token(Token = "0x4001E95")]
    [FieldOffset(Offset = "0x1C")]
    public StoryReplayMonthTypeEnum MonthTypeEnum;
    [Token(Token = "0x4001E96")]
    [FieldOffset(Offset = "0x20")]
    public bool IsLocked;
    [Token(Token = "0x4001E97")]
    [FieldOffset(Offset = "0x21")]
    public bool IsNew;
    [Token(Token = "0x4001E98")]
    [FieldOffset(Offset = "0x24")]
    public int DayNumber;
    [Token(Token = "0x4001E99")]
    [FieldOffset(Offset = "0x28")]
    public StoryDayOfWeekData DayOfWeek;

    [Token(Token = "0x600242F")]
    [Address(RVA = "0x2F2F058", Offset = "0x2F2F058", VA = "0x2F2F058")]
    public StoryArchiveListArchiveBannerViewModel(
      string title,
      int archiveId,
      StoryReplayMonthTypeEnum storyReplayMonthTypeEnum,
      bool isLocked,
      bool isNew,
      int dayNumber,
      StoryDayOfWeekData dayOfWeek)
    {
    }
  }
}

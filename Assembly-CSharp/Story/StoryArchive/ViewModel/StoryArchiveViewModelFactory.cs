// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.ViewModel.StoryArchiveViewModelFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Story.StoryArchive.ViewModel
{
  [Token(Token = "0x2000648")]
  public class StoryArchiveViewModelFactory
  {
    [Token(Token = "0x4001EB3")]
    private const string STORY_TEXT_AB_NAME = "text_masterdata_story";

    [Token(Token = "0x6002433")]
    [Address(RVA = "0x2F2F11C", Offset = "0x2F2F11C", VA = "0x2F2F11C")]
    public StoryArchiveListViewModel CreateListViewModel(StoryReplayCategoryTypeEnum categoryType)
    {
      return (StoryArchiveListViewModel) null;
    }

    [Token(Token = "0x6002434")]
    [Address(RVA = "0x2F2F30C", Offset = "0x2F2F30C", VA = "0x2F2F30C")]
    public List<StoryArchiveListArchiveBannerViewModel> CreateArchiveBannerViewModel(
      StoryReplayCategoryTypeEnum categoryType,
      StoryReplayMonthTypeEnum monthType)
    {
      return (List<StoryArchiveListArchiveBannerViewModel>) null;
    }

    [Token(Token = "0x6002435")]
    [Address(RVA = "0x2F2FC48", Offset = "0x2F2FC48", VA = "0x2F2FC48")]
    private List<StoryReplayEntryData> GetAllReplayEntryByCategory(
      StoryReplayCategoryTypeEnum categoryType)
    {
      return (List<StoryReplayEntryData>) null;
    }

    [Token(Token = "0x6002436")]
    [Address(RVA = "0x2F2F958", Offset = "0x2F2F958", VA = "0x2F2F958")]
    private List<StoryReplayEntryData> GetPlayableStoryReplayEntryByCategory(
      StoryReplayCategoryTypeEnum categoryType)
    {
      return (List<StoryReplayEntryData>) null;
    }

    [Token(Token = "0x6002437")]
    [Address(RVA = "0x2F2FF48", Offset = "0x2F2FF48", VA = "0x2F2FF48")]
    private List<int> GetPlayableReplayEntryIdList() => (List<int>) null;

    [Token(Token = "0x6002438")]
    [Address(RVA = "0x2F302F8", Offset = "0x2F302F8", VA = "0x2F302F8")]
    public List<StoryArchiveListMonthBannerViewModel> CreateMonthBannerViewModel(
      StoryReplayCategoryTypeEnum categoryType)
    {
      return (List<StoryArchiveListMonthBannerViewModel>) null;
    }

    [Token(Token = "0x6002439")]
    [Address(RVA = "0x2F30604", Offset = "0x2F30604", VA = "0x2F30604")]
    private bool HasAnyUncheckedReplay(
      StoryReplayCategoryTypeEnum categoryType,
      StoryReplayMonthTypeEnum monthType)
    {
      return new bool();
    }

    [Token(Token = "0x600243A")]
    [Address(RVA = "0x2F308C0", Offset = "0x2F308C0", VA = "0x2F308C0")]
    private bool HasAnyUncheckedReplayWhole(StoryReplayCategoryTypeEnum categoryType) => new bool();

    [Token(Token = "0x600243B")]
    [Address(RVA = "0x2F30B00", Offset = "0x2F30B00", VA = "0x2F30B00")]
    public StoryArchiveTopViewModel CreateTopViewModel() => (StoryArchiveTopViewModel) null;

    [Token(Token = "0x600243C")]
    [Address(RVA = "0x2F31928", Offset = "0x2F31928", VA = "0x2F31928")]
    public StoryArchiveViewModelFactory()
    {
    }
  }
}

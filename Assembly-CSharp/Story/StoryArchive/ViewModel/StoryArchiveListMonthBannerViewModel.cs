// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.ViewModel.StoryArchiveListMonthBannerViewModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;

#nullable disable
namespace Story.StoryArchive.ViewModel
{
  [Token(Token = "0x2000645")]
  public class StoryArchiveListMonthBannerViewModel
  {
    [Token(Token = "0x4001E9A")]
    [FieldOffset(Offset = "0x10")]
    public bool IsSomethingNew;
    [Token(Token = "0x4001E9B")]
    [FieldOffset(Offset = "0x14")]
    public StoryReplayMonthTypeEnum MonthId;
    [Token(Token = "0x4001E9C")]
    [FieldOffset(Offset = "0x18")]
    public bool IsLocked;
    [Token(Token = "0x4001E9D")]
    [FieldOffset(Offset = "0x19")]
    public bool IsNothing;

    [Token(Token = "0x6002430")]
    [Address(RVA = "0x2F2F0C4", Offset = "0x2F2F0C4", VA = "0x2F2F0C4")]
    public StoryArchiveListMonthBannerViewModel(
      bool isSomethingNew,
      StoryReplayMonthTypeEnum monthId,
      bool isLocked,
      bool isNothing)
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.UIState.StoryArchiveViewState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story.StoryArchive.UIState
{
  [Token(Token = "0x200065B")]
  public class StoryArchiveViewState : BaseStoryArchiveViewState
  {
    [Token(Token = "0x4001EE1")]
    [FieldOffset(Offset = "0x24")]
    private StoryReplayCategoryTypeEnum categoryTypeEnum;
    [Token(Token = "0x4001EE2")]
    [FieldOffset(Offset = "0x28")]
    private StoryArchiveViewState.InitialState initialState;

    [Token(Token = "0x6002485")]
    [Address(RVA = "0x2F32914", Offset = "0x2F32914", VA = "0x2F32914")]
    public StoryArchiveViewState(
      StoryReplayCategoryTypeEnum categoryType,
      ActionContext actionContext,
      bool startBySeptember = false,
      StoryArchiveViewState.InitialState initialState = null)
    {
    }

    [Token(Token = "0x6002486")]
    [Address(RVA = "0x2F3295C", Offset = "0x2F3295C", VA = "0x2F3295C", Slot = "6")]
    protected override IEnumerator SetupBeforeAnimation() => (IEnumerator) null;

    [Token(Token = "0x6002487")]
    [Address(RVA = "0x2F329EC", Offset = "0x2F329EC", VA = "0x2F329EC")]
    private void OnSelectMonth(StoryReplayMonthTypeEnum monthTypeEnum)
    {
    }

    [Token(Token = "0x6002488")]
    [Address(RVA = "0x2F32A38", Offset = "0x2F32A38", VA = "0x2F32A38")]
    private IEnumerator OnSelectMonthAsync(StoryReplayMonthTypeEnum monthTypeEnum)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002489")]
    [Address(RVA = "0x2F32AD8", Offset = "0x2F32AD8", VA = "0x2F32AD8")]
    private void OnClickArchive(int replayId)
    {
    }

    [Token(Token = "0x200065C")]
    public class InitialState
    {
      [Token(Token = "0x4001EE3")]
      [FieldOffset(Offset = "0x10")]
      public int ArchiveId;
      [Token(Token = "0x4001EE4")]
      [FieldOffset(Offset = "0x14")]
      public StoryReplayMonthTypeEnum MonthTypeEnum;

      [Token(Token = "0x600248A")]
      [Address(RVA = "0x2F32AFC", Offset = "0x2F32AFC", VA = "0x2F32AFC")]
      public InitialState()
      {
      }
    }
  }
}

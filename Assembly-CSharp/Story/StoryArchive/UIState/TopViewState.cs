// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.UIState.TopViewState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Story.StoryArchive.ViewModel;
using System.Collections;

#nullable disable
namespace Story.StoryArchive.UIState
{
  [Token(Token = "0x2000660")]
  public class TopViewState : IStoryArchiveViewState
  {
    [Token(Token = "0x4001EEF")]
    private const string ContainerAssetBundleName = "ui_page_scenario_reminiscence";
    [Token(Token = "0x4001EF0")]
    private const string ContainerAssetName = "Scenario_Reminiscence";
    [Token(Token = "0x4001EF1")]
    [FieldOffset(Offset = "0x10")]
    private ActionContext actionContext;
    [Token(Token = "0x4001EF2")]
    [FieldOffset(Offset = "0x18")]
    private StoryArchiveTopView topView;

    [Token(Token = "0x6002499")]
    [Address(RVA = "0x2F321E8", Offset = "0x2F321E8", VA = "0x2F321E8")]
    public TopViewState(ActionContext actionContext)
    {
    }

    [Token(Token = "0x600249A")]
    [Address(RVA = "0x2F33030", Offset = "0x2F33030", VA = "0x2F33030", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x600249B")]
    [Address(RVA = "0x2F330C0", Offset = "0x2F330C0", VA = "0x2F330C0")]
    private IEnumerator PlayUnlockAnimation(StoryArchiveTopViewModel viewModel)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600249C")]
    [Address(RVA = "0x2F3315C", Offset = "0x2F3315C", VA = "0x2F3315C")]
    private void OnPressScenarioBanner(
      StoryArchiveTopScenarioBanner.ScenarioType scenarioType)
    {
    }

    [Token(Token = "0x600249D")]
    [Address(RVA = "0x2F33360", Offset = "0x2F33360", VA = "0x2F33360", Slot = "5")]
    public IEnumerator EndAsync() => (IEnumerator) null;
  }
}

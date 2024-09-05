// Decompiled with JetBrains decompiler
// Type: Story.StoryArchive.UIState.BaseStoryArchiveViewState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Story.StoryArchive.UIState
{
  [Token(Token = "0x2000654")]
  public class BaseStoryArchiveViewState : IStoryArchiveViewState
  {
    [Token(Token = "0x4001ED1")]
    private const string ContainerAssetBundleName = "ui_page_scenario_reminiscence";
    [Token(Token = "0x4001ED2")]
    private const string ContainerAssetName = "Scenario_Reminiscence_List";
    [Token(Token = "0x4001ED3")]
    [FieldOffset(Offset = "0x10")]
    protected StoryArchiveListView listView;
    [Token(Token = "0x4001ED4")]
    [FieldOffset(Offset = "0x18")]
    protected ActionContext actionContext;
    [Token(Token = "0x4001ED5")]
    [FieldOffset(Offset = "0x20")]
    protected bool startBySeptember;

    [Token(Token = "0x6002464")]
    [Address(RVA = "0x2F32084", Offset = "0x2F32084", VA = "0x2F32084")]
    public BaseStoryArchiveViewState(ActionContext actionContext, bool startBySeptember)
    {
    }

    [Token(Token = "0x6002465")]
    [Address(RVA = "0x2F320B4", Offset = "0x2F320B4", VA = "0x2F320B4", Slot = "4")]
    public IEnumerator InitializeAsync() => (IEnumerator) null;

    [Token(Token = "0x6002466")]
    [Address(RVA = "0x2F32144", Offset = "0x2F32144", VA = "0x2F32144")]
    private void OnBack()
    {
    }

    [Token(Token = "0x6002467")]
    [Address(RVA = "0x2F32210", Offset = "0x2F32210", VA = "0x2F32210", Slot = "6")]
    protected virtual IEnumerator SetupBeforeAnimation() => (IEnumerator) null;

    [Token(Token = "0x6002468")]
    [Address(RVA = "0x2F32298", Offset = "0x2F32298", VA = "0x2F32298", Slot = "5")]
    public IEnumerator EndAsync() => (IEnumerator) null;
  }
}

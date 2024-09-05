// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.TutorialMainSubPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001820")]
  public class TutorialMainSubPhase : MainSubPhase<TutorialModaState>
  {
    [Token(Token = "0x400695B")]
    [FieldOffset(Offset = "0x30")]
    private TutorialMainSubPhase.FlowState nowflowState;
    [Token(Token = "0x400695C")]
    [FieldOffset(Offset = "0x38")]
    private FreeMap.State.ModeState.PhaseUpdater<PhaseBase> phaseUpdate;

    [Token(Token = "0x600887C")]
    [Address(RVA = "0x43DDFA0", Offset = "0x43DDFA0", VA = "0x43DDFA0")]
    public TutorialMainSubPhase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainPhase mainPhase)
    {
    }

    [Token(Token = "0x600887D")]
    [Address(RVA = "0x43DE010", Offset = "0x43DE010", VA = "0x43DE010", Slot = "4")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x600887E")]
    [Address(RVA = "0x43DE20C", Offset = "0x43DE20C", VA = "0x43DE20C", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x600887F")]
    [Address(RVA = "0x43DE21C", Offset = "0x43DE21C", VA = "0x43DE21C")]
    public PhaseBase CreateNextPhaseWhenEnded() => (PhaseBase) null;

    [Token(Token = "0x6008880")]
    [Address(RVA = "0x43DE0C4", Offset = "0x43DE0C4", VA = "0x43DE0C4")]
    private PhaseBase CreatePhase(TutorialMainSubPhase.FlowState flowstate) => (PhaseBase) null;

    [Token(Token = "0x2001821")]
    private enum FlowState
    {
      [Token(Token = "0x400695E")] MoveBeforeDisplayedTalk,
      [Token(Token = "0x400695F")] MoveBeforeTalkActionEnded,
      [Token(Token = "0x4006960")] MoveBeforeDisplayedEscape,
      [Token(Token = "0x4006961")] MoveBeforeAfterEscapeStartActionEnded,
      [Token(Token = "0x4006962")] EspaceEndStage,
    }

    [Token(Token = "0x2001822")]
    public enum ActionTrigger
    {
      [Token(Token = "0x4006964")] None,
      [Token(Token = "0x4006965")] Icon,
      [Token(Token = "0x4006966")] AreaChange,
      [Token(Token = "0x4006967")] AreaChangeDisplayIcon,
    }
  }
}

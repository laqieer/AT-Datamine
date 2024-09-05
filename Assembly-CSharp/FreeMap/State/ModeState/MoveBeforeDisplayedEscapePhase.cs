// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MoveBeforeDisplayedEscapePhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001834")]
  public class MoveBeforeDisplayedEscapePhase : MoveActionTutorialPhaseBase
  {
    [Token(Token = "0x60088E2")]
    [Address(RVA = "0x43DE26C", Offset = "0x43DE26C", VA = "0x43DE26C")]
    public MoveBeforeDisplayedEscapePhase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainSubPhase mainPhase)
    {
    }

    [Token(Token = "0x60088E3")]
    [Address(RVA = "0x43E0CA8", Offset = "0x43E0CA8", VA = "0x43E0CA8", Slot = "7")]
    protected override IEnumerator SetupAndStartSequence() => (IEnumerator) null;

    [Token(Token = "0x60088E4")]
    [Address(RVA = "0x43E0D38", Offset = "0x43E0D38", VA = "0x43E0D38", Slot = "10")]
    protected override TutorialMainSubPhase.ActionTrigger GetEndTriggerData()
    {
      return new TutorialMainSubPhase.ActionTrigger();
    }

    [Token(Token = "0x60088E5")]
    [Address(RVA = "0x43E0D40", Offset = "0x43E0D40", VA = "0x43E0D40", Slot = "9")]
    protected override TutorialPlayerAreaOperation CreatePlayerOperation()
    {
      return (TutorialPlayerAreaOperation) null;
    }
  }
}

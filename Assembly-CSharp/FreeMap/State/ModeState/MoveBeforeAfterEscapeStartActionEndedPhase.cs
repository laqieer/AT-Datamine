// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MoveBeforeAfterEscapeStartActionEndedPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001836")]
  public class MoveBeforeAfterEscapeStartActionEndedPhase : MoveActionTutorialPhaseBase
  {
    [Token(Token = "0x60088ED")]
    [Address(RVA = "0x43DE270", Offset = "0x43DE270", VA = "0x43DE270")]
    public MoveBeforeAfterEscapeStartActionEndedPhase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainSubPhase mainPhase)
    {
    }

    [Token(Token = "0x60088EE")]
    [Address(RVA = "0x43E1180", Offset = "0x43E1180", VA = "0x43E1180", Slot = "7")]
    protected override IEnumerator SetupAndStartSequence() => (IEnumerator) null;

    [Token(Token = "0x60088EF")]
    [Address(RVA = "0x43E1210", Offset = "0x43E1210", VA = "0x43E1210", Slot = "10")]
    protected override TutorialMainSubPhase.ActionTrigger GetEndTriggerData()
    {
      return new TutorialMainSubPhase.ActionTrigger();
    }

    [Token(Token = "0x60088F0")]
    [Address(RVA = "0x43E1218", Offset = "0x43E1218", VA = "0x43E1218", Slot = "9")]
    protected override TutorialPlayerAreaOperation CreatePlayerOperation()
    {
      return (TutorialPlayerAreaOperation) null;
    }
  }
}

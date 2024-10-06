// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MoveBeforeTalkActionEndedPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001831")]
  public class MoveBeforeTalkActionEndedPhase : MoveActionTutorialPhaseBase
  {
    [Token(Token = "0x60088D3")]
    [Address(RVA = "0x43DE268", Offset = "0x43DE268", VA = "0x43DE268")]
    public MoveBeforeTalkActionEndedPhase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainSubPhase mainPhase)
    {
    }

    [Token(Token = "0x60088D4")]
    [Address(RVA = "0x43E07A8", Offset = "0x43E07A8", VA = "0x43E07A8", Slot = "7")]
    protected override IEnumerator SetupAndStartSequence() => (IEnumerator) null;

    [Token(Token = "0x60088D5")]
    [Address(RVA = "0x43E0838", Offset = "0x43E0838", VA = "0x43E0838", Slot = "10")]
    protected override TutorialMainSubPhase.ActionTrigger GetEndTriggerData()
    {
      return new TutorialMainSubPhase.ActionTrigger();
    }

    [Token(Token = "0x60088D6")]
    [Address(RVA = "0x43E0840", Offset = "0x43E0840", VA = "0x43E0840", Slot = "9")]
    protected override TutorialPlayerAreaOperation CreatePlayerOperation()
    {
      return (TutorialPlayerAreaOperation) null;
    }
  }
}

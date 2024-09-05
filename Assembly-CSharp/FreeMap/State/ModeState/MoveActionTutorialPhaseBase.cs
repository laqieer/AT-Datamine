// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MoveActionTutorialPhaseBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001839")]
  public abstract class MoveActionTutorialPhaseBase : PhaseBase
  {
    [Token(Token = "0x40069AC")]
    [FieldOffset(Offset = "0x18")]
    protected List<TutorialMainSubPhase.ActionTrigger> actionedTriggers;
    [Token(Token = "0x40069AD")]
    [FieldOffset(Offset = "0x20")]
    protected TutorialPlayerAreaOperation op;
    [Token(Token = "0x40069AE")]
    [FieldOffset(Offset = "0x28")]
    protected bool isEnded;
    [Token(Token = "0x40069AF")]
    [FieldOffset(Offset = "0x30")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x40069B0")]
    [FieldOffset(Offset = "0x38")]
    protected TutorialModaState state;
    [Token(Token = "0x40069B1")]
    [FieldOffset(Offset = "0x40")]
    protected TutorialMainSubPhase mainPhase;

    [Token(Token = "0x60088FC")]
    [Address(RVA = "0x43E0704", Offset = "0x43E0704", VA = "0x43E0704")]
    public MoveActionTutorialPhaseBase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainSubPhase mainPhase)
    {
    }

    [Token(Token = "0x60088FD")]
    [Address(RVA = "0x43E1680", Offset = "0x43E1680", VA = "0x43E1680", Slot = "4")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x60088FE")]
    [Address(RVA = "0x43E16BC", Offset = "0x43E16BC", VA = "0x43E16BC", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x60088FF")]
    protected abstract IEnumerator SetupAndStartSequence();

    [Token(Token = "0x6008900")]
    [Address(RVA = "0x43E16CC", Offset = "0x43E16CC", VA = "0x43E16CC", Slot = "8")]
    protected virtual IEnumerator MainSequence() => (IEnumerator) null;

    [Token(Token = "0x6008901")]
    protected abstract TutorialPlayerAreaOperation CreatePlayerOperation();

    [Token(Token = "0x6008902")]
    [Address(RVA = "0x43E175C", Offset = "0x43E175C", VA = "0x43E175C")]
    protected void AddEnd(FreeMapProcess process, TutorialMainSubPhase.ActionTrigger trigger)
    {
    }

    [Token(Token = "0x6008903")]
    [Address(RVA = "0x43E1838", Offset = "0x43E1838", VA = "0x43E1838")]
    protected bool IsMatchTrigger() => new bool();

    [Token(Token = "0x6008904")]
    protected abstract TutorialMainSubPhase.ActionTrigger GetEndTriggerData();
  }
}

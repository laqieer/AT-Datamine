// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.TutorialPlayerAreaOperation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.Parameter.UIParam;
using FreeMap.State.Process;
using Il2CppDummyDll;
using System;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200182D")]
  public class TutorialPlayerAreaOperation : IPlayerAreaOperationEvent
  {
    [Token(Token = "0x400698C")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapStateManager entity;
    [Token(Token = "0x400698D")]
    [FieldOffset(Offset = "0x18")]
    private Action<FreeMapProcess, TutorialMainSubPhase.ActionTrigger> endedMethod;
    [Token(Token = "0x400698E")]
    [FieldOffset(Offset = "0x20")]
    private bool isTransitionUIDetect;
    [Token(Token = "0x400698F")]
    [FieldOffset(Offset = "0x21")]
    private bool isTransitionUIDetected;
    [Token(Token = "0x4006990")]
    [FieldOffset(Offset = "0x28")]
    private TutorialModaState state;

    [Token(Token = "0x60088B7")]
    [Address(RVA = "0x43DFBFC", Offset = "0x43DFBFC", VA = "0x43DFBFC")]
    public TutorialPlayerAreaOperation(
      FreeMapStateManager entity,
      TutorialModaState state,
      Action<FreeMapProcess, TutorialMainSubPhase.ActionTrigger> end,
      bool isTransitionUIDetect)
    {
    }

    [Token(Token = "0x60088B8")]
    [Address(RVA = "0x43DFC40", Offset = "0x43DFC40", VA = "0x43DFC40")]
    public void Start()
    {
    }

    [Token(Token = "0x60088B9")]
    [Address(RVA = "0x43DFD50", Offset = "0x43DFD50", VA = "0x43DFD50")]
    public void OnUpdate()
    {
    }

    [Token(Token = "0x60088BA")]
    [Address(RVA = "0x43DFDF0", Offset = "0x43DFDF0", VA = "0x43DFDF0")]
    private void AddEnd(FreeMapProcess process, TutorialMainSubPhase.ActionTrigger actionTrigger)
    {
    }

    [Token(Token = "0x60088BB")]
    [Address(RVA = "0x43DFC44", Offset = "0x43DFC44", VA = "0x43DFC44")]
    private void StartPlayerOperation()
    {
    }

    [Token(Token = "0x60088BC")]
    [Address(RVA = "0x43DFE34", Offset = "0x43DFE34", VA = "0x43DFE34")]
    private void StopPlayerOperation()
    {
    }

    [Token(Token = "0x60088BD")]
    [Address(RVA = "0x43DFFE0", Offset = "0x43DFFE0", VA = "0x43DFFE0")]
    public void OnEnded()
    {
    }

    [Token(Token = "0x60088BE")]
    [Address(RVA = "0x43DFFE8", Offset = "0x43DFFE8", VA = "0x43DFFE8")]
    private void OnExecuteClosedEvent(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x60088BF")]
    [Address(RVA = "0x43E000C", Offset = "0x43E000C", VA = "0x43E000C")]
    private void OnIconEventExecute(FreeMapUIParamBase param)
    {
    }

    [Token(Token = "0x60088C0")]
    [Address(RVA = "0x43E0088", Offset = "0x43E0088", VA = "0x43E0088", Slot = "4")]
    public void FastTravel(ITransitionEvent transition, FreeMapUIParamBase targetParam)
    {
    }

    [Token(Token = "0x60088C1")]
    [Address(RVA = "0x43DFFEC", Offset = "0x43DFFEC", VA = "0x43DFFEC", Slot = "5")]
    public void AutoMoveToEvent(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x60088C2")]
    [Address(RVA = "0x43E0094", Offset = "0x43E0094", VA = "0x43E0094", Slot = "6")]
    public void GotoTarget(FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x60088C3")]
    [Address(RVA = "0x43E0164", Offset = "0x43E0164", VA = "0x43E0164", Slot = "7")]
    public void ChangeAreaAndAutoMove(ITransitionEvent transition, FreeMapUIParamBase target)
    {
    }

    [Token(Token = "0x60088C4")]
    [Address(RVA = "0x43E0170", Offset = "0x43E0170", VA = "0x43E0170", Slot = "8")]
    public void OnAutoMoveFinish(FreeMapUIParamBase param)
    {
    }
  }
}

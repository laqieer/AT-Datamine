// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.FreeMapModeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001808")]
  public class FreeMapModeState : StoryModeStateBase
  {
    [Token(Token = "0x4006939")]
    [FieldOffset(Offset = "0x20")]
    private StoryMainPhase main;
    [Token(Token = "0x400693A")]
    [FieldOffset(Offset = "0x28")]
    private InitializeStatePhase<StoryModeStateBase> initializePhase;

    [Token(Token = "0x60087FA")]
    [Address(RVA = "0x43D8C64", Offset = "0x43D8C64", VA = "0x43D8C64")]
    public FreeMapModeState(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60087FB")]
    [Address(RVA = "0x43D8CB4", Offset = "0x43D8CB4", VA = "0x43D8CB4", Slot = "4")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x60087FC")]
    [Address(RVA = "0x43D9030", Offset = "0x43D9030", VA = "0x43D9030", Slot = "5")]
    public override bool IsPreStartEnded() => new bool();

    [Token(Token = "0x60087FD")]
    [Address(RVA = "0x43D9078", Offset = "0x43D9078", VA = "0x43D9078", Slot = "18")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x60087FE")]
    [Address(RVA = "0x43D90C8", Offset = "0x43D90C8", VA = "0x43D90C8", Slot = "19")]
    protected override void OnEnd()
    {
    }
  }
}

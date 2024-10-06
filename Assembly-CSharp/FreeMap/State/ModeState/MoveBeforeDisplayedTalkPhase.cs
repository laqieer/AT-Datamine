// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MoveBeforeDisplayedTalkPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200182F")]
  public class MoveBeforeDisplayedTalkPhase : PhaseBase
  {
    [Token(Token = "0x4006994")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x4006995")]
    [FieldOffset(Offset = "0x20")]
    protected TutorialModaState state;
    [Token(Token = "0x4006996")]
    [FieldOffset(Offset = "0x28")]
    protected TutorialMainSubPhase mainPhase;

    [Token(Token = "0x60088C9")]
    [Address(RVA = "0x43DE22C", Offset = "0x43DE22C", VA = "0x43DE22C")]
    public MoveBeforeDisplayedTalkPhase(
      FreeMapStateManager entity,
      TutorialModaState state,
      TutorialMainSubPhase mainPhase)
    {
    }

    [Token(Token = "0x60088CA")]
    [Address(RVA = "0x43E0260", Offset = "0x43E0260", VA = "0x43E0260", Slot = "4")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x60088CB")]
    [Address(RVA = "0x43E02FC", Offset = "0x43E02FC", VA = "0x43E02FC", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x60088CC")]
    [Address(RVA = "0x43E0294", Offset = "0x43E0294", VA = "0x43E0294")]
    private IEnumerator Sequence() => (IEnumerator) null;
  }
}

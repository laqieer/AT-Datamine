// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.FinalizeStatePhase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001801")]
  public class FinalizeStatePhase<T> : PhaseBase where T : ModeStateBase
  {
    [Token(Token = "0x4006933")]
    [FieldOffset(Offset = "0x0")]
    private FreeMapProcess process;
    [Token(Token = "0x4006934")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x4006935")]
    [FieldOffset(Offset = "0x0")]
    protected T state;

    [Token(Token = "0x60087E0")]
    public FinalizeStatePhase(FreeMapStateManager entity, T state, FreeMapProcess process)
    {
    }

    [Token(Token = "0x60087E1")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x60087E2")]
    protected override void OnUpdate()
    {
    }
  }
}

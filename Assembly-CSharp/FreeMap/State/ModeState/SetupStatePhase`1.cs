// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.SetupStatePhase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x20017FE")]
  public class SetupStatePhase<T> : PhaseBase where T : ModeStateBase
  {
    [Token(Token = "0x4006928")]
    [FieldOffset(Offset = "0x0")]
    private FreeMapProcess setupprocess;
    [Token(Token = "0x4006929")]
    [FieldOffset(Offset = "0x0")]
    protected MainPhase<T> mainPhase;
    [Token(Token = "0x400692A")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x400692B")]
    [FieldOffset(Offset = "0x0")]
    protected T state;

    [Token(Token = "0x60087D7")]
    public SetupStatePhase(
      FreeMapStateManager entity,
      T state,
      FreeMapProcess process,
      MainPhase<T> mainPhase)
    {
    }

    [Token(Token = "0x60087D8")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x60087D9")]
    protected override sealed void OnUpdate()
    {
    }

    [Token(Token = "0x60087DA")]
    protected virtual void OnSetupEnd()
    {
    }
  }
}

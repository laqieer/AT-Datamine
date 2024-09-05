// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MainPhase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x20017FF")]
  public abstract class MainPhase<T> : PhaseBase where T : ModeStateBase
  {
    [Token(Token = "0x400692C")]
    [FieldOffset(Offset = "0x0")]
    private FreeMap.State.ModeState.PhaseUpdater<MainSubPhase<T>> phaseUpdate;
    [Token(Token = "0x400692D")]
    [FieldOffset(Offset = "0x0")]
    protected MainSubPhase<T> startPhase;
    [Token(Token = "0x400692E")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x400692F")]
    [FieldOffset(Offset = "0x0")]
    protected T state;

    [Token(Token = "0x60087DB")]
    public MainPhase(FreeMapStateManager entity, T state)
    {
    }

    [Token(Token = "0x60087DC")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x60087DD")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x60087DE")]
    public virtual void End()
    {
    }
  }
}

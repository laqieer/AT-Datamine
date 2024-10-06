// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.MainSubPhase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001800")]
  public abstract class MainSubPhase<T> : PhaseBase where T : ModeStateBase
  {
    [Token(Token = "0x4006930")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x4006931")]
    [FieldOffset(Offset = "0x0")]
    protected T state;
    [Token(Token = "0x4006932")]
    [FieldOffset(Offset = "0x0")]
    protected MainPhase<T> mainPhase;

    [Token(Token = "0x60087DF")]
    public MainSubPhase(FreeMapStateManager entity, T state, MainPhase<T> phase)
    {
    }
  }
}

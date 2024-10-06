// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.InitializeStatePhase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x20017FB")]
  public class InitializeStatePhase<T> : PhaseBase where T : ModeStateBase
  {
    [Token(Token = "0x4006921")]
    [FieldOffset(Offset = "0x0")]
    private FreeMapProcess process;
    [Token(Token = "0x4006922")]
    [FieldOffset(Offset = "0x0")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x4006923")]
    [FieldOffset(Offset = "0x0")]
    protected T state;
    [Token(Token = "0x4006924")]
    [FieldOffset(Offset = "0x0")]
    private SetupStatePhase<T> setupPhase;

    [Token(Token = "0x1700157C")]
    public bool Initialized
    {
      [Token(Token = "0x60087C7")] get => new bool();
      [Token(Token = "0x60087C8")] private set
      {
      }
    }

    [Token(Token = "0x60087C9")]
    public InitializeStatePhase(
      FreeMapStateManager entity,
      T state,
      FreeMapProcess process,
      SetupStatePhase<T> setupPhase)
    {
    }

    [Token(Token = "0x60087CA")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x60087CB")]
    protected override sealed void OnUpdate()
    {
    }

    [Token(Token = "0x60087CC")]
    public void OnStart()
    {
    }

    [Token(Token = "0x60087CD")]
    public static FreeMapProcess CreateStoryInitializeProcess(FreeMapStateManager entity)
    {
      return (FreeMapProcess) null;
    }

    [Token(Token = "0x20017FC")]
    private class StoryInitializeProcess : FreeMapProcess
    {
      [Token(Token = "0x60087CE")]
      public StoryInitializeProcess(FreeMapStateManager entity)
      {
      }

      [Token(Token = "0x60087CF")]
      public override void Begin()
      {
      }

      [Token(Token = "0x60087D0")]
      private IEnumerator AsyncOperation() => (IEnumerator) null;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.StorySetupStatePhase`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200180A")]
  public class StorySetupStatePhase<T> : SetupStatePhase<T> where T : ModeStateBase
  {
    [Token(Token = "0x6008804")]
    public StorySetupStatePhase(
      FreeMapStateManager entity,
      T state,
      FreeMapProcess process,
      MainPhase<T> mainPhase)
    {
    }
  }
}

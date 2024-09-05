// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.PlayerAreaOperationStartPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001819")]
  public class PlayerAreaOperationStartPhase : MainSubPhase<StoryModeStateBase>
  {
    [Token(Token = "0x400694B")]
    [FieldOffset(Offset = "0x30")]
    private bool entered;
    [Token(Token = "0x400694C")]
    [FieldOffset(Offset = "0x38")]
    private FreeMapProcess process;

    [Token(Token = "0x6008847")]
    [Address(RVA = "0x43DB918", Offset = "0x43DB918", VA = "0x43DB918")]
    public PlayerAreaOperationStartPhase(
      FreeMapStateManager entity,
      StoryModeStateBase state,
      MainPhase<StoryModeStateBase> main,
      FreeMapProcess process = null)
    {
    }

    [Token(Token = "0x6008848")]
    [Address(RVA = "0x43DC8B4", Offset = "0x43DC8B4", VA = "0x43DC8B4", Slot = "4")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x6008849")]
    [Address(RVA = "0x43DC8E8", Offset = "0x43DC8E8", VA = "0x43DC8E8", Slot = "5")]
    protected override void OnUpdate()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.PlayerAreaOperationPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.State.Process;
using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200180B")]
  public class PlayerAreaOperationPhase : MainSubPhase<StoryModeStateBase>
  {
    [Token(Token = "0x400693D")]
    [FieldOffset(Offset = "0x30")]
    private PlayerAreaOperation op;
    [Token(Token = "0x400693E")]
    [FieldOffset(Offset = "0x38")]
    private bool isEnded;

    [Token(Token = "0x6008805")]
    [Address(RVA = "0x43D94D0", Offset = "0x43D94D0", VA = "0x43D94D0")]
    public PlayerAreaOperationPhase(
      FreeMapStateManager entity,
      StoryModeStateBase state,
      MainPhase<StoryModeStateBase> main)
    {
    }

    [Token(Token = "0x6008806")]
    [Address(RVA = "0x43D9540", Offset = "0x43D9540", VA = "0x43D9540", Slot = "4")]
    protected override void OnEnter()
    {
    }

    [Token(Token = "0x6008807")]
    [Address(RVA = "0x43D9644", Offset = "0x43D9644", VA = "0x43D9644")]
    protected PlayerAreaOperation CreatePlayerOperation() => (PlayerAreaOperation) null;

    [Token(Token = "0x6008808")]
    [Address(RVA = "0x43D96FC", Offset = "0x43D96FC", VA = "0x43D96FC", Slot = "5")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x6008809")]
    [Address(RVA = "0x43D97BC", Offset = "0x43D97BC", VA = "0x43D97BC")]
    private void AddEnd(FreeMapProcess process)
    {
    }
  }
}

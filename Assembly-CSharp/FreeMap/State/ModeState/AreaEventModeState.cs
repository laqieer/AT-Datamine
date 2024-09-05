// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.AreaEventModeState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x2001809")]
  public class AreaEventModeState : StoryModeStateBase
  {
    [Token(Token = "0x400693B")]
    [FieldOffset(Offset = "0x20")]
    private StoryMainPhase main;
    [Token(Token = "0x400693C")]
    [FieldOffset(Offset = "0x28")]
    private InitializeStatePhase<StoryModeStateBase> initializePhase;

    [Token(Token = "0x60087FF")]
    [Address(RVA = "0x43D9128", Offset = "0x43D9128", VA = "0x43D9128")]
    public AreaEventModeState(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x6008800")]
    [Address(RVA = "0x43D9150", Offset = "0x43D9150", VA = "0x43D9150", Slot = "4")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6008801")]
    [Address(RVA = "0x43D93D8", Offset = "0x43D93D8", VA = "0x43D93D8", Slot = "5")]
    public override bool IsPreStartEnded() => new bool();

    [Token(Token = "0x6008802")]
    [Address(RVA = "0x43D9420", Offset = "0x43D9420", VA = "0x43D9420", Slot = "18")]
    protected override void OnStart()
    {
    }

    [Token(Token = "0x6008803")]
    [Address(RVA = "0x43D9470", Offset = "0x43D9470", VA = "0x43D9470", Slot = "19")]
    protected override void OnEnd()
    {
    }
  }
}

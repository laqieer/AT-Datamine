// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.StoryModeStateBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x200181A")]
  public abstract class StoryModeStateBase : ModeStateBase
  {
    [Token(Token = "0x600884A")]
    [Address(RVA = "0x43D8C8C", Offset = "0x43D8C8C", VA = "0x43D8C8C")]
    public StoryModeStateBase(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x600884B")]
    [Address(RVA = "0x43DC9A4", Offset = "0x43DC9A4", VA = "0x43DC9A4", Slot = "6")]
    public override sealed void Start()
    {
    }

    [Token(Token = "0x600884C")]
    [Address(RVA = "0x43DCAEC", Offset = "0x43DCAEC", VA = "0x43DCAEC", Slot = "18")]
    protected virtual void OnStart()
    {
    }

    [Token(Token = "0x600884D")]
    [Address(RVA = "0x43DCAF0", Offset = "0x43DCAF0", VA = "0x43DCAF0", Slot = "7")]
    public override sealed void End()
    {
    }

    [Token(Token = "0x600884E")]
    [Address(RVA = "0x43DCC38", Offset = "0x43DCC38", VA = "0x43DCC38", Slot = "19")]
    protected virtual void OnEnd()
    {
    }

    [Token(Token = "0x600884F")]
    [Address(RVA = "0x43DCC3C", Offset = "0x43DCC3C", VA = "0x43DCC3C", Slot = "8")]
    protected override void OnUpdate()
    {
    }

    [Token(Token = "0x6008850")]
    [Address(RVA = "0x43DCC40", Offset = "0x43DCC40", VA = "0x43DCC40", Slot = "17")]
    public override bool IsFinalized() => new bool();

    [Token(Token = "0x6008851")]
    [Address(RVA = "0x43DCC88", Offset = "0x43DCC88", VA = "0x43DCC88", Slot = "9")]
    public override void FreeMapUIShow()
    {
    }

    [Token(Token = "0x6008852")]
    [Address(RVA = "0x43DCEF8", Offset = "0x43DCEF8", VA = "0x43DCEF8", Slot = "10")]
    public override void FreeMapUIRefreshActionPlaying()
    {
    }

    [Token(Token = "0x6008853")]
    [Address(RVA = "0x43DD0CC", Offset = "0x43DD0CC", VA = "0x43DD0CC", Slot = "11")]
    public override void FreeMapUIHide()
    {
    }

    [Token(Token = "0x6008854")]
    [Address(RVA = "0x43DD2A0", Offset = "0x43DD2A0", VA = "0x43DD2A0", Slot = "14")]
    public override void FreeMapTrackerUIInteractEnable()
    {
    }

    [Token(Token = "0x6008855")]
    [Address(RVA = "0x43DD2C4", Offset = "0x43DD2C4", VA = "0x43DD2C4", Slot = "15")]
    public override void FreeMapTrackerUIInteractDisable()
    {
    }

    [Token(Token = "0x6008856")]
    [Address(RVA = "0x43DD2E8", Offset = "0x43DD2E8", VA = "0x43DD2E8", Slot = "12")]
    public override void FreeMapHeaderUIInteractEnable()
    {
    }

    [Token(Token = "0x6008857")]
    [Address(RVA = "0x43DD360", Offset = "0x43DD360", VA = "0x43DD360", Slot = "13")]
    public override void FreeMapHeaderUIInteractDisable()
    {
    }
  }
}

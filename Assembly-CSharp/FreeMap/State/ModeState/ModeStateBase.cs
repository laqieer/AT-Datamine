// Decompiled with JetBrains decompiler
// Type: FreeMap.State.ModeState.ModeStateBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace FreeMap.State.ModeState
{
  [Token(Token = "0x20017FA")]
  public abstract class ModeStateBase
  {
    [Token(Token = "0x400691E")]
    [FieldOffset(Offset = "0x10")]
    protected FreeMapStateManager entity;
    [Token(Token = "0x400691F")]
    [FieldOffset(Offset = "0x18")]
    private PhaseUpdater<PhaseBase> phaseUpdate;

    [Token(Token = "0x60087B5")]
    [Address(RVA = "0x43D8980", Offset = "0x43D8980", VA = "0x43D8980")]
    public ModeStateBase(FreeMapStateManager entity)
    {
    }

    [Token(Token = "0x60087B6")]
    [Address(RVA = "0x43D89A8", Offset = "0x43D89A8", VA = "0x43D89A8")]
    protected void FirstPhase(PhaseBase first)
    {
    }

    [Token(Token = "0x60087B7")]
    public abstract void PreStart();

    [Token(Token = "0x60087B8")]
    public abstract bool IsPreStartEnded();

    [Token(Token = "0x60087B9")]
    public abstract void Start();

    [Token(Token = "0x60087BA")]
    public abstract void End();

    [Token(Token = "0x60087BB")]
    [Address(RVA = "0x43D8A2C", Offset = "0x43D8A2C", VA = "0x43D8A2C")]
    public void Update()
    {
    }

    [Token(Token = "0x60087BC")]
    protected abstract void OnUpdate();

    [Token(Token = "0x60087BD")]
    public abstract void FreeMapUIShow();

    [Token(Token = "0x60087BE")]
    public abstract void FreeMapUIRefreshActionPlaying();

    [Token(Token = "0x60087BF")]
    public abstract void FreeMapUIHide();

    [Token(Token = "0x60087C0")]
    public abstract void FreeMapHeaderUIInteractEnable();

    [Token(Token = "0x60087C1")]
    public abstract void FreeMapHeaderUIInteractDisable();

    [Token(Token = "0x60087C2")]
    public abstract void FreeMapTrackerUIInteractEnable();

    [Token(Token = "0x60087C3")]
    public abstract void FreeMapTrackerUIInteractDisable();

    [Token(Token = "0x60087C4")]
    [Address(RVA = "0x43D8B34", Offset = "0x43D8B34", VA = "0x43D8B34", Slot = "16")]
    public virtual void FreeMapActionIconInvisible()
    {
    }

    [Token(Token = "0x60087C5")]
    public abstract bool IsFinalized();

    [Token(Token = "0x60087C6")]
    protected bool PhaseIs<T>() where T : PhaseBase => new bool();
  }
}

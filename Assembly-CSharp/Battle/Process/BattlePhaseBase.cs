// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattlePhaseBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Il2CppDummyDll;
using System;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200265A")]
  public abstract class BattlePhaseBase : IProcess<PhaseCode>, IDisposable, IStepUpdate
  {
    [Token(Token = "0x400A497")]
    [FieldOffset(Offset = "0x10")]
    protected IProcessOwner<PhaseCode> owner;

    [Token(Token = "0x1700327F")]
    public BattleCore Core
    {
      [Token(Token = "0x600ED78"), Address(RVA = "0x449CEA4", Offset = "0x449CEA4", VA = "0x449CEA4")] get
      {
        return (BattleCore) null;
      }
      [Token(Token = "0x600ED79"), Address(RVA = "0x449CEAC", Offset = "0x449CEAC", VA = "0x449CEAC")] protected set
      {
      }
    }

    [Token(Token = "0x17003280")]
    protected IDirector mainDirector
    {
      [Token(Token = "0x600ED7A"), Address(RVA = "0x449CEB4", Offset = "0x449CEB4", VA = "0x449CEB4")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x17003281")]
    protected BoardData board
    {
      [Token(Token = "0x600ED7B"), Address(RVA = "0x449CED0", Offset = "0x449CED0", VA = "0x449CED0")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003282")]
    protected BattleConfigData config
    {
      [Token(Token = "0x600ED7C"), Address(RVA = "0x449CEEC", Offset = "0x449CEEC", VA = "0x449CEEC")] get
      {
        return (BattleConfigData) null;
      }
    }

    [Token(Token = "0x17003283")]
    public bool IsActive
    {
      [Token(Token = "0x600ED7D"), Address(RVA = "0x449CF08", Offset = "0x449CF08", VA = "0x449CF08", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600ED7E"), Address(RVA = "0x449CF10", Offset = "0x449CF10", VA = "0x449CF10")] private set
      {
      }
    }

    [Token(Token = "0x600ED7F")]
    [Address(RVA = "0x449CF1C", Offset = "0x449CF1C", VA = "0x449CF1C", Slot = "10")]
    public virtual void Initialize(IProcessOwner<PhaseCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600ED80")]
    [Address(RVA = "0x449CF2C", Offset = "0x449CF2C", VA = "0x449CF2C", Slot = "11")]
    protected virtual void Finish(PhaseCode nextProcess)
    {
    }

    [Token(Token = "0x600ED81")]
    [Address(RVA = "0x449CFE0", Offset = "0x449CFE0", VA = "0x449CFE0", Slot = "12")]
    public virtual void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600ED82")]
    [Address(RVA = "0x449CFE4", Offset = "0x449CFE4", VA = "0x449CFE4", Slot = "13")]
    public virtual void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600ED83")]
    [Address(RVA = "0x449CFE8", Offset = "0x449CFE8", VA = "0x449CFE8", Slot = "14")]
    public virtual void Dispose()
    {
    }

    [Token(Token = "0x600ED84")]
    public abstract void Step(float delta);

    [Token(Token = "0x600ED85")]
    [Address(RVA = "0x449CFF0", Offset = "0x449CFF0", VA = "0x449CFF0")]
    protected bool GoToEndIfWinOrLose() => new bool();

    [Token(Token = "0x600ED86")]
    [Address(RVA = "0x449D058", Offset = "0x449D058", VA = "0x449D058")]
    protected BattlePhaseBase()
    {
    }
  }
}

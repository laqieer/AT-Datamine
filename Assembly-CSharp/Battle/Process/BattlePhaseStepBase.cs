// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattlePhaseStepBase
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
  [Token(Token = "0x2002667")]
  public abstract class BattlePhaseStepBase : IProcess<PhaseStepCode>, IDisposable, IStepUpdate
  {
    [Token(Token = "0x400A4B9")]
    [FieldOffset(Offset = "0x10")]
    protected IProcessOwner<PhaseStepCode> owner;

    [Token(Token = "0x17003284")]
    public BattleCore Core
    {
      [Token(Token = "0x600EDA7"), Address(RVA = "0x449E9D8", Offset = "0x449E9D8", VA = "0x449E9D8")] get
      {
        return (BattleCore) null;
      }
      [Token(Token = "0x600EDA8"), Address(RVA = "0x449E9E0", Offset = "0x449E9E0", VA = "0x449E9E0")] protected set
      {
      }
    }

    [Token(Token = "0x17003285")]
    protected IDirector mainDirector
    {
      [Token(Token = "0x600EDA9"), Address(RVA = "0x449E9E8", Offset = "0x449E9E8", VA = "0x449E9E8")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x17003286")]
    protected BoardData board
    {
      [Token(Token = "0x600EDAA"), Address(RVA = "0x449EA04", Offset = "0x449EA04", VA = "0x449EA04")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003287")]
    protected BattleConfigData config
    {
      [Token(Token = "0x600EDAB"), Address(RVA = "0x449EA20", Offset = "0x449EA20", VA = "0x449EA20")] get
      {
        return (BattleConfigData) null;
      }
    }

    [Token(Token = "0x17003288")]
    public bool IsActive
    {
      [Token(Token = "0x600EDAC"), Address(RVA = "0x449EA3C", Offset = "0x449EA3C", VA = "0x449EA3C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EDAD"), Address(RVA = "0x449EA44", Offset = "0x449EA44", VA = "0x449EA44")] private set
      {
      }
    }

    [Token(Token = "0x17003289")]
    protected BattlePlayerData activePlayer
    {
      [Token(Token = "0x600EDAE"), Address(RVA = "0x449EA50", Offset = "0x449EA50", VA = "0x449EA50")] get
      {
        return (BattlePlayerData) null;
      }
    }

    [Token(Token = "0x600EDAF")]
    [Address(RVA = "0x449EA74", Offset = "0x449EA74", VA = "0x449EA74", Slot = "10")]
    public virtual void Initialize(IProcessOwner<PhaseStepCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600EDB0")]
    [Address(RVA = "0x449EA84", Offset = "0x449EA84", VA = "0x449EA84", Slot = "11")]
    protected virtual void Finish(PhaseStepCode nextProcess)
    {
    }

    [Token(Token = "0x600EDB1")]
    [Address(RVA = "0x449EB38", Offset = "0x449EB38", VA = "0x449EB38", Slot = "12")]
    public virtual void Dispose()
    {
    }

    [Token(Token = "0x600EDB2")]
    public abstract void Step(float delta);

    [Token(Token = "0x600EDB3")]
    [Address(RVA = "0x449EBF8", Offset = "0x449EBF8", VA = "0x449EBF8")]
    protected bool GoToEndIfWinOrLose() => new bool();

    [Token(Token = "0x600EDB4")]
    [Address(RVA = "0x449ECD0", Offset = "0x449ECD0", VA = "0x449ECD0", Slot = "14")]
    public virtual void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600EDB5")]
    [Address(RVA = "0x449ECD4", Offset = "0x449ECD4", VA = "0x449ECD4", Slot = "15")]
    public virtual void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600EDB6")]
    [Address(RVA = "0x449ECD8", Offset = "0x449ECD8", VA = "0x449ECD8")]
    protected BattlePhaseStepBase()
    {
    }
  }
}

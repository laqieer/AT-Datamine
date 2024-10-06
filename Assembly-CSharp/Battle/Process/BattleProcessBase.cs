// Decompiled with JetBrains decompiler
// Type: Battle.Process.BattleProcessBase
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
  [Token(Token = "0x2002637")]
  public abstract class BattleProcessBase : IProcess<ProcessCode>, IDisposable, IStepUpdate
  {
    [Token(Token = "0x400A437")]
    [FieldOffset(Offset = "0x10")]
    protected IProcessOwner<ProcessCode> owner;

    [Token(Token = "0x17003260")]
    public BattleCore Core
    {
      [Token(Token = "0x600ECBC"), Address(RVA = "0x448C760", Offset = "0x448C760", VA = "0x448C760")] get
      {
        return (BattleCore) null;
      }
      [Token(Token = "0x600ECBD"), Address(RVA = "0x448C768", Offset = "0x448C768", VA = "0x448C768")] protected set
      {
      }
    }

    [Token(Token = "0x17003261")]
    protected IDirector mainDirector
    {
      [Token(Token = "0x600ECBE"), Address(RVA = "0x448C044", Offset = "0x448C044", VA = "0x448C044")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x17003262")]
    protected BoardData board
    {
      [Token(Token = "0x600ECBF"), Address(RVA = "0x448C770", Offset = "0x448C770", VA = "0x448C770")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003263")]
    protected BattleConfigData config
    {
      [Token(Token = "0x600ECC0"), Address(RVA = "0x448C334", Offset = "0x448C334", VA = "0x448C334")] get
      {
        return (BattleConfigData) null;
      }
    }

    [Token(Token = "0x17003264")]
    public bool IsActive
    {
      [Token(Token = "0x600ECC1"), Address(RVA = "0x448C78C", Offset = "0x448C78C", VA = "0x448C78C", Slot = "4")] get
      {
        return new bool();
      }
      [Token(Token = "0x600ECC2"), Address(RVA = "0x448C794", Offset = "0x448C794", VA = "0x448C794")] private set
      {
      }
    }

    [Token(Token = "0x600ECC3")]
    [Address(RVA = "0x448BF5C", Offset = "0x448BF5C", VA = "0x448BF5C", Slot = "10")]
    public virtual void Initialize(IProcessOwner<ProcessCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600ECC4")]
    [Address(RVA = "0x448C7A0", Offset = "0x448C7A0", VA = "0x448C7A0", Slot = "11")]
    protected virtual void Finish(ProcessCode nextProcess)
    {
    }

    [Token(Token = "0x600ECC5")]
    [Address(RVA = "0x448C060", Offset = "0x448C060", VA = "0x448C060", Slot = "12")]
    public virtual void Dispose()
    {
    }

    [Token(Token = "0x600ECC6")]
    public abstract void Step(float delta);

    [Token(Token = "0x600ECC7")]
    [Address(RVA = "0x448C854", Offset = "0x448C854", VA = "0x448C854", Slot = "14")]
    public virtual void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600ECC8")]
    [Address(RVA = "0x448C858", Offset = "0x448C858", VA = "0x448C858", Slot = "15")]
    public virtual void OnApplicationPause(bool isPaused)
    {
    }

    [Token(Token = "0x600ECC9")]
    [Address(RVA = "0x448BED8", Offset = "0x448BED8", VA = "0x448BED8")]
    protected BattleProcessBase()
    {
    }
  }
}

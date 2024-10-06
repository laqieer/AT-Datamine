// Decompiled with JetBrains decompiler
// Type: Battle.Command.CommandBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A3")]
  public abstract class CommandBase
  {
    [Token(Token = "0x4009D28")]
    [FieldOffset(Offset = "0x10")]
    protected BattleCore core;
    [Token(Token = "0x4009D2A")]
    [FieldOffset(Offset = "0x20")]
    public CommandBase.OnFinishedCallback OnFinished;

    [Token(Token = "0x17003045")]
    protected IDirector mainDirector
    {
      [Token(Token = "0x600E101"), Address(RVA = "0x425608C", Offset = "0x425608C", VA = "0x425608C")] get
      {
        return (IDirector) null;
      }
    }

    [Token(Token = "0x17003046")]
    protected BoardData board
    {
      [Token(Token = "0x600E102"), Address(RVA = "0x42560A8", Offset = "0x42560A8", VA = "0x42560A8")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003047")]
    protected BattleConfigData config
    {
      [Token(Token = "0x600E103"), Address(RVA = "0x42560C4", Offset = "0x42560C4", VA = "0x42560C4")] get
      {
        return (BattleConfigData) null;
      }
    }

    [Token(Token = "0x17003048")]
    public bool IsActive
    {
      [Token(Token = "0x600E104"), Address(RVA = "0x42560E0", Offset = "0x42560E0", VA = "0x42560E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E105"), Address(RVA = "0x42560E8", Offset = "0x42560E8", VA = "0x42560E8")] private set
      {
      }
    }

    [Token(Token = "0x600E106")]
    [Address(RVA = "0x42560F4", Offset = "0x42560F4", VA = "0x42560F4")]
    protected CommandBase(BattleCore core)
    {
    }

    [Token(Token = "0x600E107")]
    public abstract bool Validate();

    [Token(Token = "0x600E108")]
    [Address(RVA = "0x425611C", Offset = "0x425611C", VA = "0x425611C", Slot = "5")]
    public virtual void Prepare()
    {
    }

    [Token(Token = "0x600E109")]
    [Address(RVA = "0x4256120", Offset = "0x4256120", VA = "0x4256120")]
    public void Execute()
    {
    }

    [Token(Token = "0x600E10A")]
    protected abstract void ExecuteInternal();

    [Token(Token = "0x600E10B")]
    [Address(RVA = "0x4256140", Offset = "0x4256140", VA = "0x4256140", Slot = "7")]
    public virtual void Complete(bool complete)
    {
    }

    [Token(Token = "0x600E10C")]
    protected abstract void CompleteInternal();

    [Token(Token = "0x600E10D")]
    protected abstract void CanceledInternal();

    [Token(Token = "0x20024A4")]
    public delegate void OnFinishedCallback(CommandBase command, bool canceled);
  }
}

// Decompiled with JetBrains decompiler
// Type: Battle.Command.DoubleCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024A8")]
  public sealed class DoubleCommand : UnitCommandBase
  {
    [Token(Token = "0x1700304D")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E11D"), Address(RVA = "0x4256794", Offset = "0x4256794", VA = "0x4256794", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x1700304E")]
    public UnitParameterData TargetUnit
    {
      [Token(Token = "0x600E11E"), Address(RVA = "0x425679C", Offset = "0x425679C", VA = "0x425679C")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600E11F"), Address(RVA = "0x42567A4", Offset = "0x42567A4", VA = "0x42567A4")] private set
      {
      }
    }

    [Token(Token = "0x1700304F")]
    public GridData TargetGrid
    {
      [Token(Token = "0x600E120"), Address(RVA = "0x42567AC", Offset = "0x42567AC", VA = "0x42567AC")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600E121"), Address(RVA = "0x42567B4", Offset = "0x42567B4", VA = "0x42567B4")] private set
      {
      }
    }

    [Token(Token = "0x600E122")]
    [Address(RVA = "0x42567BC", Offset = "0x42567BC", VA = "0x42567BC")]
    public DoubleCommand(
      BattleCore core,
      UnitParameterData owner,
      UnitParameterData targetUnit,
      GridData targetGrid)
    {
    }

    [Token(Token = "0x600E123")]
    [Address(RVA = "0x4256800", Offset = "0x4256800", VA = "0x4256800", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E124")]
    [Address(RVA = "0x42568A8", Offset = "0x42568A8", VA = "0x42568A8", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E125")]
    [Address(RVA = "0x4256910", Offset = "0x4256910", VA = "0x4256910", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E126")]
    [Address(RVA = "0x4256B24", Offset = "0x4256B24", VA = "0x4256B24", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E127")]
    [Address(RVA = "0x4256B50", Offset = "0x4256B50", VA = "0x4256B50", Slot = "9")]
    protected override void CanceledInternal()
    {
    }
  }
}

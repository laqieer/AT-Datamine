// Decompiled with JetBrains decompiler
// Type: Battle.Command.ReleaseDoubleCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Il2CppDummyDll;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024AF")]
  public sealed class ReleaseDoubleCommand : UnitCommandBase
  {
    [Token(Token = "0x17003058")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E171"), Address(RVA = "0x425E264", Offset = "0x425E264", VA = "0x425E264", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x17003059")]
    public GridData ReleaseTargetGrid
    {
      [Token(Token = "0x600E172"), Address(RVA = "0x425E26C", Offset = "0x425E26C", VA = "0x425E26C")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600E173"), Address(RVA = "0x425E274", Offset = "0x425E274", VA = "0x425E274")] private set
      {
      }
    }

    [Token(Token = "0x1700305A")]
    public UnitParameterData ReleasedUnit
    {
      [Token(Token = "0x600E174"), Address(RVA = "0x425E27C", Offset = "0x425E27C", VA = "0x425E27C")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600E175"), Address(RVA = "0x425E284", Offset = "0x425E284", VA = "0x425E284")] private set
      {
      }
    }

    [Token(Token = "0x600E176")]
    [Address(RVA = "0x425E28C", Offset = "0x425E28C", VA = "0x425E28C")]
    public ReleaseDoubleCommand(BattleCore core, UnitParameterData owner, GridData targetGrid)
    {
    }

    [Token(Token = "0x600E177")]
    [Address(RVA = "0x425E2CC", Offset = "0x425E2CC", VA = "0x425E2CC", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E178")]
    [Address(RVA = "0x425E378", Offset = "0x425E378", VA = "0x425E378", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E179")]
    [Address(RVA = "0x425E3A4", Offset = "0x425E3A4", VA = "0x425E3A4", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E17A")]
    [Address(RVA = "0x425E714", Offset = "0x425E714", VA = "0x425E714", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E17B")]
    [Address(RVA = "0x425E740", Offset = "0x425E740", VA = "0x425E740", Slot = "9")]
    protected override void CanceledInternal()
    {
    }

    [Token(Token = "0x600E17C")]
    [Address(RVA = "0x425E5E4", Offset = "0x425E5E4", VA = "0x425E5E4")]
    private void UpdateReleaseUnitGroundOffset()
    {
    }
  }
}

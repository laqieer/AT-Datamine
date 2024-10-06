// Decompiled with JetBrains decompiler
// Type: Battle.Command.MoveCommand
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Command
{
  [Token(Token = "0x20024AE")]
  public class MoveCommand : UnitCommandBase
  {
    [Token(Token = "0x4009D46")]
    [FieldOffset(Offset = "0x40")]
    protected GridData targetGrid;
    [Token(Token = "0x4009D47")]
    [FieldOffset(Offset = "0x48")]
    private MovableAreaSearcher searcher;
    [Token(Token = "0x4009D48")]
    [FieldOffset(Offset = "0x50")]
    private Stack<GridData> route;
    [Token(Token = "0x4009D49")]
    [FieldOffset(Offset = "0x58")]
    protected int moveDistance;
    [Token(Token = "0x4009D4A")]
    [FieldOffset(Offset = "0x60")]
    private SkillParameterData useSkillParam;
    [Token(Token = "0x4009D4B")]
    [FieldOffset(Offset = "0x68")]
    private AttackableAreaSearcher attackableArea;
    [Token(Token = "0x4009D4C")]
    [FieldOffset(Offset = "0x70")]
    private bool noAnimation;

    [Token(Token = "0x17003056")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E166"), Address(RVA = "0x425DA6C", Offset = "0x425DA6C", VA = "0x425DA6C", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x17003057")]
    public GridData MoveTargetGrid
    {
      [Token(Token = "0x600E167"), Address(RVA = "0x425DA74", Offset = "0x425DA74", VA = "0x425DA74")] get
      {
        return (GridData) null;
      }
    }

    [Token(Token = "0x600E168")]
    [Address(RVA = "0x425DA7C", Offset = "0x425DA7C", VA = "0x425DA7C")]
    public MoveCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData targetGrid,
      MovableAreaSearcher searcher,
      bool noAnime = false)
    {
    }

    [Token(Token = "0x600E169")]
    [Address(RVA = "0x425DAD0", Offset = "0x425DAD0", VA = "0x425DAD0")]
    public MoveCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData targetGrid,
      MovableAreaSearcher searcher,
      SkillParameterData useSkill,
      AttackableAreaSearcher attackableArea,
      bool noAnime = false)
    {
    }

    [Token(Token = "0x600E16A")]
    [Address(RVA = "0x425DB38", Offset = "0x425DB38", VA = "0x425DB38", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E16B")]
    [Address(RVA = "0x425DBCC", Offset = "0x425DBCC", VA = "0x425DBCC", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E16C")]
    [Address(RVA = "0x425DE68", Offset = "0x425DE68", VA = "0x425DE68", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E16D")]
    [Address(RVA = "0x425DD40", Offset = "0x425DD40", VA = "0x425DD40")]
    private Stack<GridData> CreateRouteGrids() => (Stack<GridData>) null;

    [Token(Token = "0x600E16E")]
    [Address(RVA = "0x425E048", Offset = "0x425E048", VA = "0x425E048", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E16F")]
    [Address(RVA = "0x425E074", Offset = "0x425E074", VA = "0x425E074", Slot = "9")]
    protected override void CanceledInternal()
    {
    }
  }
}

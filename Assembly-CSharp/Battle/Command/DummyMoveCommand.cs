// Decompiled with JetBrains decompiler
// Type: Battle.Command.DummyMoveCommand
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
  [Token(Token = "0x20024AB")]
  public class DummyMoveCommand : UnitCommandBase
  {
    [Token(Token = "0x4009D3B")]
    [FieldOffset(Offset = "0x40")]
    protected GridData moveFrom;
    [Token(Token = "0x4009D3C")]
    [FieldOffset(Offset = "0x48")]
    protected GridData moveTo;
    [Token(Token = "0x4009D3D")]
    [FieldOffset(Offset = "0x50")]
    private MovableAreaSearcher orgSearcher;
    [Token(Token = "0x4009D3E")]
    [FieldOffset(Offset = "0x58")]
    private MovableAreaSearcher dummySearcher;
    [Token(Token = "0x4009D3F")]
    [FieldOffset(Offset = "0x60")]
    private Stack<GridData> route;
    [Token(Token = "0x4009D40")]
    [FieldOffset(Offset = "0x68")]
    private bool noAnimation;

    [Token(Token = "0x17003052")]
    public override CommandType CommandType
    {
      [Token(Token = "0x600E146"), Address(RVA = "0x425BF24", Offset = "0x425BF24", VA = "0x425BF24", Slot = "10")] get
      {
        return new CommandType();
      }
    }

    [Token(Token = "0x600E147")]
    [Address(RVA = "0x425BF2C", Offset = "0x425BF2C", VA = "0x425BF2C")]
    public DummyMoveCommand(
      BattleCore core,
      UnitParameterData owner,
      GridData moveFrom,
      GridData moveTo,
      MovableAreaSearcher orgSearcher,
      bool noAnime = false)
    {
    }

    [Token(Token = "0x600E148")]
    [Address(RVA = "0x425BF88", Offset = "0x425BF88", VA = "0x425BF88", Slot = "4")]
    public override bool Validate() => new bool();

    [Token(Token = "0x600E149")]
    [Address(RVA = "0x425BF90", Offset = "0x425BF90", VA = "0x425BF90", Slot = "5")]
    public override void Prepare()
    {
    }

    [Token(Token = "0x600E14A")]
    [Address(RVA = "0x425C204", Offset = "0x425C204", VA = "0x425C204", Slot = "6")]
    protected override void ExecuteInternal()
    {
    }

    [Token(Token = "0x600E14B")]
    [Address(RVA = "0x425BFCC", Offset = "0x425BFCC", VA = "0x425BFCC")]
    private Stack<GridData> CreateRouteGrids() => (Stack<GridData>) null;

    [Token(Token = "0x600E14C")]
    [Address(RVA = "0x425C3D8", Offset = "0x425C3D8", VA = "0x425C3D8")]
    private int CalcRealMoveDistance() => new int();

    [Token(Token = "0x600E14D")]
    [Address(RVA = "0x425C600", Offset = "0x425C600", VA = "0x425C600", Slot = "8")]
    protected override void CompleteInternal()
    {
    }

    [Token(Token = "0x600E14E")]
    [Address(RVA = "0x425C604", Offset = "0x425C604", VA = "0x425C604", Slot = "9")]
    protected override void CanceledInternal()
    {
    }

    [Token(Token = "0x600E14F")]
    [Address(RVA = "0x425C510", Offset = "0x425C510", VA = "0x425C510")]
    public PathSearcher2D.NodeValidationCallback GetMovableSearchTargetValidator()
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }

    [Token(Token = "0x600E150")]
    [Address(RVA = "0x425C588", Offset = "0x425C588", VA = "0x425C588")]
    public PathSearcher2D.NodeValidationCallback GetOccupiableSearchTargetValidator()
    {
      return (PathSearcher2D.NodeValidationCallback) null;
    }
  }
}

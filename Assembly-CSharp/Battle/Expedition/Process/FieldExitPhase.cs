// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.FieldExitPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Staging;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x2002603")]
  public class FieldExitPhase : BattlePhaseBase
  {
    [Token(Token = "0x400A336")]
    private const int ExitOffset = 5;
    [Token(Token = "0x400A337")]
    [FieldOffset(Offset = "0x24")]
    private FieldExitPhase.State state;

    [Token(Token = "0x600EAB0")]
    [Address(RVA = "0x4B96020", Offset = "0x4B96020", VA = "0x4B96020", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600EAB1")]
    [Address(RVA = "0x4B96028", Offset = "0x4B96028", VA = "0x4B96028", Slot = "15")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EAB2")]
    [Address(RVA = "0x4B96460", Offset = "0x4B96460", VA = "0x4B96460")]
    private void GoToNextBattle(List<StagingDirector.ISequence> exitSeqs)
    {
    }

    [Token(Token = "0x600EAB3")]
    [Address(RVA = "0x4B962F0", Offset = "0x4B962F0", VA = "0x4B962F0")]
    private MoveGridSequence CreateExitMoveSequence(
      UnitParameterData targetUnit,
      MovableAreaSearcher movable)
    {
      return (MoveGridSequence) null;
    }

    [Token(Token = "0x600EAB4")]
    [Address(RVA = "0x4B966B0", Offset = "0x4B966B0", VA = "0x4B966B0")]
    private Stack<GridData> CreateRouteGrids(
      UnitParameterData targetUnit,
      GridData targetGrid,
      MovableAreaSearcher movable)
    {
      return (Stack<GridData>) null;
    }

    [Token(Token = "0x600EAB5")]
    [Address(RVA = "0x4B9423C", Offset = "0x4B9423C", VA = "0x4B9423C")]
    public FieldExitPhase()
    {
    }

    [Token(Token = "0x2002604")]
    protected enum State
    {
      [Token(Token = "0x400A339")] Staging,
      [Token(Token = "0x400A33A")] Exit,
    }
  }
}

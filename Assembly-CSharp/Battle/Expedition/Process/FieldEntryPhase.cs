// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.FieldEntryPhase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using Battle.Process;
using Battle.RouteSearch;
using Battle.Staging;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x2002600")]
  public class FieldEntryPhase : BeginBattlePhase
  {
    [Token(Token = "0x400A331")]
    private const int EntryOffset = 5;
    [Token(Token = "0x400A332")]
    [FieldOffset(Offset = "0x28")]
    private UnitCreator unitCreator;

    [Token(Token = "0x600EAA0")]
    [Address(RVA = "0x4B9438C", Offset = "0x4B9438C", VA = "0x4B9438C", Slot = "10")]
    public override void Initialize(IProcessOwner<PhaseCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600EAA1")]
    [Address(RVA = "0x4B9459C", Offset = "0x4B9459C", VA = "0x4B9459C")]
    private void ResetBoard(BattleCore core)
    {
    }

    [Token(Token = "0x600EAA2")]
    [Address(RVA = "0x4B94CC0", Offset = "0x4B94CC0", VA = "0x4B94CC0")]
    private void SetupBoard(BattlePlayerData user, BattlePlayerData com)
    {
    }

    [Token(Token = "0x600EAA3")]
    [Address(RVA = "0x4B950E4", Offset = "0x4B950E4", VA = "0x4B950E4")]
    private void SortieAllUnit()
    {
    }

    [Token(Token = "0x600EAA4")]
    [Address(RVA = "0x4B94668", Offset = "0x4B94668", VA = "0x4B94668")]
    private BattlePlayerData CreateAlly(out List<GridObject> startGrids) => (BattlePlayerData) null;

    [Token(Token = "0x600EAA5")]
    [Address(RVA = "0x4B94B28", Offset = "0x4B94B28", VA = "0x4B94B28")]
    private BattlePlayerData CreateEnemy() => (BattlePlayerData) null;

    [Token(Token = "0x600EAA6")]
    [Address(RVA = "0x4B957BC", Offset = "0x4B957BC", VA = "0x4B957BC", Slot = "16")]
    protected override void SetupStartStaging()
    {
    }

    [Token(Token = "0x600EAA7")]
    [Address(RVA = "0x4B95880", Offset = "0x4B95880", VA = "0x4B95880")]
    private void StartEntryMoveSequence()
    {
    }

    [Token(Token = "0x600EAA8")]
    [Address(RVA = "0x4B95D58", Offset = "0x4B95D58", VA = "0x4B95D58")]
    private MoveGridSequence CreateEntryMoveSequence(
      UnitParameterData targetUnit,
      MovableAreaSearcher movable)
    {
      return (MoveGridSequence) null;
    }

    [Token(Token = "0x600EAA9")]
    [Address(RVA = "0x4B95EA0", Offset = "0x4B95EA0", VA = "0x4B95EA0")]
    private Stack<GridData> CreateRouteGrids(
      GridData startGrid,
      GridData targetGrid,
      MovableAreaSearcher movable)
    {
      return (Stack<GridData>) null;
    }

    [Token(Token = "0x600EAAA")]
    [Address(RVA = "0x4B94234", Offset = "0x4B94234", VA = "0x4B94234")]
    public FieldEntryPhase()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Battle.Expedition.Process.BossReadyProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data.Board;
using Battle.Grid;
using Battle.Process;
using Battle.Stage;
using Battle.Unit;
using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Battle.Expedition.Process
{
  [Token(Token = "0x20025E9")]
  public sealed class BossReadyProcess : BattleProcessBase, IStageEventHandler
  {
    [Token(Token = "0x400A2F0")]
    [FieldOffset(Offset = "0x24")]
    private BossReadyProcess.State currentState;
    [Token(Token = "0x400A2F1")]
    [FieldOffset(Offset = "0x28")]
    private Actor.Direction allyDirection;
    [Token(Token = "0x400A2F2")]
    [FieldOffset(Offset = "0x30")]
    private BossReadyProcess.PlacementData selectedUnitData;
    [Token(Token = "0x400A2F3")]
    [FieldOffset(Offset = "0x38")]
    private Action<int> onSelectUnitCallback;
    [Token(Token = "0x400A2F4")]
    [FieldOffset(Offset = "0x40")]
    private Action<int> onUnSelectUnitCallback;
    [Token(Token = "0x400A2F5")]
    [FieldOffset(Offset = "0x48")]
    private Action<int> onLongPressUnitCallback;
    [Token(Token = "0x400A2F6")]
    [FieldOffset(Offset = "0x50")]
    private UnitCreator unitCreator;
    [Token(Token = "0x400A2F7")]
    [FieldOffset(Offset = "0x58")]
    private bool isDisabledSelectGrid;

    [Token(Token = "0x600EA2B")]
    [Address(RVA = "0x4B8C5A8", Offset = "0x4B8C5A8", VA = "0x4B8C5A8", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> owner, BattleCore core)
    {
    }

    [Token(Token = "0x600EA2C")]
    [Address(RVA = "0x4B8CD04", Offset = "0x4B8CD04", VA = "0x4B8CD04", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EA2D")]
    [Address(RVA = "0x4B8CDE4", Offset = "0x4B8CDE4", VA = "0x4B8CDE4")]
    private void Exit()
    {
    }

    [Token(Token = "0x600EA2E")]
    [Address(RVA = "0x4B8D20C", Offset = "0x4B8D20C", VA = "0x4B8D20C")]
    private void ResetCursor()
    {
    }

    [Token(Token = "0x600EA2F")]
    [Address(RVA = "0x4B8D7AC", Offset = "0x4B8D7AC", VA = "0x4B8D7AC")]
    public void Cancel()
    {
    }

    [Token(Token = "0x600EA30")]
    [Address(RVA = "0x4B8D7B0", Offset = "0x4B8D7B0", VA = "0x4B8D7B0")]
    public void EndProcess()
    {
    }

    [Token(Token = "0x600EA31")]
    [Address(RVA = "0x4B8D7BC", Offset = "0x4B8D7BC", VA = "0x4B8D7BC")]
    public void SetUnitActionCallback(
      Action<int> onSelectUnit,
      Action<int> onUnSelectUnit,
      Action<int> onLongPressUnit)
    {
    }

    [Token(Token = "0x600EA32")]
    [Address(RVA = "0x4B8D7C8", Offset = "0x4B8D7C8", VA = "0x4B8D7C8")]
    public void RePlaceUnit(
      List<PlayerExpeditionStageBossPartyUnitType> partyUnits)
    {
    }

    [Token(Token = "0x600EA33")]
    [Address(RVA = "0x4B8E50C", Offset = "0x4B8E50C", VA = "0x4B8E50C")]
    private void SortieAllUnit()
    {
    }

    [Token(Token = "0x600EA34")]
    [Address(RVA = "0x4B8E788", Offset = "0x4B8E788", VA = "0x4B8E788")]
    public void OnSelectUnit(int id)
    {
    }

    [Token(Token = "0x600EA35")]
    [Address(RVA = "0x4B8E978", Offset = "0x4B8E978", VA = "0x4B8E978")]
    public void OnUnSelectUnit()
    {
    }

    [Token(Token = "0x600EA36")]
    [Address(RVA = "0x4B8EA3C", Offset = "0x4B8EA3C", VA = "0x4B8EA3C")]
    public void DisableSelectGrid()
    {
    }

    [Token(Token = "0x600EA37")]
    [Address(RVA = "0x4B8EA48", Offset = "0x4B8EA48", VA = "0x4B8EA48")]
    public void EnableSelectGrid()
    {
    }

    [Token(Token = "0x600EA38")]
    [Address(RVA = "0x4B8EA50", Offset = "0x4B8EA50", VA = "0x4B8EA50", Slot = "16")]
    public void OnSelectGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600EA39")]
    [Address(RVA = "0x4B8F3C4", Offset = "0x4B8F3C4", VA = "0x4B8F3C4", Slot = "17")]
    public void OnHoldGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600EA3A")]
    [Address(RVA = "0x4B8CADC", Offset = "0x4B8CADC", VA = "0x4B8CADC")]
    private void TurnUnit(BattlePlayerData player, Actor.Direction direction)
    {
    }

    [Token(Token = "0x600EA3B")]
    [Address(RVA = "0x4B8D36C", Offset = "0x4B8D36C", VA = "0x4B8D36C")]
    private void SetupBoard()
    {
    }

    [Token(Token = "0x600EA3C")]
    [Address(RVA = "0x4B8A9E8", Offset = "0x4B8A9E8", VA = "0x4B8A9E8")]
    public BossReadyProcess()
    {
    }

    [Token(Token = "0x20025EA")]
    private class PlacementData
    {
      [Token(Token = "0x400A2F8")]
      [FieldOffset(Offset = "0x10")]
      public GridData grid;
      [Token(Token = "0x400A2F9")]
      [FieldOffset(Offset = "0x18")]
      public UnitParameterData unit;

      [Token(Token = "0x600EA3D")]
      [Address(RVA = "0x4B8E970", Offset = "0x4B8E970", VA = "0x4B8E970")]
      public PlacementData()
      {
      }
    }

    [Token(Token = "0x20025EB")]
    private enum State
    {
      [Token(Token = "0x400A2FB")] Placement,
      [Token(Token = "0x400A2FC")] End,
    }
  }
}

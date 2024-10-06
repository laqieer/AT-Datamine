// Decompiled with JetBrains decompiler
// Type: Battle.Process.Arena.PlaceUnitProcess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Data;
using Battle.Data.Board;
using Battle.Grid;
using Battle.Stage;
using Battle.UI;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Process.Arena
{
  [Token(Token = "0x20026CE")]
  public sealed class PlaceUnitProcess : 
    BattleProcessBase,
    IStageEventHandler,
    IUnitListPanelEventHandler
  {
    [Token(Token = "0x400A623")]
    [FieldOffset(Offset = "0x24")]
    private PlaceUnitProcess.State state;
    [Token(Token = "0x400A624")]
    [FieldOffset(Offset = "0x28")]
    private List<Vector2Int> placementList;
    [Token(Token = "0x400A625")]
    [FieldOffset(Offset = "0x30")]
    private List<Vector2Int> placementEnemyList;
    [Token(Token = "0x400A626")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<UnitParameterData, GridData> initialPositionDic;
    [Token(Token = "0x400A627")]
    [FieldOffset(Offset = "0x40")]
    private UnitParameterData selectUnit;
    [Token(Token = "0x400A628")]
    [FieldOffset(Offset = "0x48")]
    private GridData prevGrid;

    [Token(Token = "0x170032B7")]
    private ArenaPlaceConfig config
    {
      [Token(Token = "0x600F02A"), Address(RVA = "0x40E5CB4", Offset = "0x40E5CB4", VA = "0x40E5CB4")] get
      {
        return (ArenaPlaceConfig) null;
      }
    }

    [Token(Token = "0x600F02B")]
    [Address(RVA = "0x40E5D38", Offset = "0x40E5D38", VA = "0x40E5D38", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600F02C")]
    [Address(RVA = "0x40E79F4", Offset = "0x40E79F4", VA = "0x40E79F4", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600F02D")]
    [Address(RVA = "0x40E7B80", Offset = "0x40E7B80", VA = "0x40E7B80", Slot = "17")]
    public void OnHoldGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600F02E")]
    [Address(RVA = "0x40E7B84", Offset = "0x40E7B84", VA = "0x40E7B84", Slot = "18")]
    public void OnSelectUnitEvent(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F02F")]
    [Address(RVA = "0x40E7E9C", Offset = "0x40E7E9C", VA = "0x40E7E9C", Slot = "16")]
    public void OnSelectGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600F030")]
    [Address(RVA = "0x40E94FC", Offset = "0x40E94FC", VA = "0x40E94FC")]
    private void PlayEffect(Vector3 position)
    {
    }

    [Token(Token = "0x600F031")]
    [Address(RVA = "0x40E9678", Offset = "0x40E9678", VA = "0x40E9678")]
    private void PlayInitialPlacementEffect(
      GridData toGrid,
      GridData fromGrid,
      bool enableFromGrid = false)
    {
    }

    [Token(Token = "0x600F032")]
    [Address(RVA = "0x40E923C", Offset = "0x40E923C", VA = "0x40E923C")]
    private void ChangePlacement(GridData toGrid, GridData fromGrid, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600F033")]
    [Address(RVA = "0x40E8D8C", Offset = "0x40E8D8C", VA = "0x40E8D8C")]
    private void ChangePlacement(
      GridData toGrid,
      GridData fromGrid,
      UnitParameterData unit,
      UnitParameterData changeUnit)
    {
    }

    [Token(Token = "0x600F034")]
    [Address(RVA = "0x40E8C18", Offset = "0x40E8C18", VA = "0x40E8C18")]
    private void ShowSimpleStatus(
      UnitParameterData unit,
      BattlePlayerData owner,
      GridData grid,
      bool isAlly)
    {
    }

    [Token(Token = "0x600F035")]
    [Address(RVA = "0x40E73CC", Offset = "0x40E73CC", VA = "0x40E73CC")]
    private void TurnAlliesToEnemy()
    {
    }

    [Token(Token = "0x600F036")]
    [Address(RVA = "0x40E98C0", Offset = "0x40E98C0", VA = "0x40E98C0")]
    private void OnPushBackButton()
    {
    }

    [Token(Token = "0x600F037")]
    [Address(RVA = "0x40E9BC8", Offset = "0x40E9BC8", VA = "0x40E9BC8")]
    private void OnPushFinish()
    {
    }

    [Token(Token = "0x600F038")]
    [Address(RVA = "0x40E7864", Offset = "0x40E7864", VA = "0x40E7864")]
    private void ShowInitializePlacementSelectArea(List<Vector2Int> pos)
    {
    }

    [Token(Token = "0x600F039")]
    [Address(RVA = "0x40E792C", Offset = "0x40E792C", VA = "0x40E792C")]
    private void ShowInitializePlacementEnemyArea(List<Vector2Int> pos)
    {
    }

    [Token(Token = "0x600F03A")]
    [Address(RVA = "0x40EA408", Offset = "0x40EA408", VA = "0x40EA408")]
    private void ShowUnitDetail(UnitParameterData unit, int barrierIndex)
    {
    }

    [Token(Token = "0x600F03B")]
    [Address(RVA = "0x40DF41C", Offset = "0x40DF41C", VA = "0x40DF41C")]
    public PlaceUnitProcess()
    {
    }

    [Token(Token = "0x20026CF")]
    private enum State
    {
      [Token(Token = "0x400A62A")] Init,
      [Token(Token = "0x400A62B")] SelectUnit,
      [Token(Token = "0x400A62C")] SelectPos,
      [Token(Token = "0x400A62D")] Finish,
    }
  }
}

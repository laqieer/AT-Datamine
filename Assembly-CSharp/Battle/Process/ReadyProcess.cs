// Decompiled with JetBrains decompiler
// Type: Battle.Process.ReadyProcess
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
namespace Battle.Process
{
  [Token(Token = "0x200267A")]
  public sealed class ReadyProcess : 
    BattleProcessBase,
    IStageEventHandler,
    IUnitListPanelEventHandler
  {
    [Token(Token = "0x400A50B")]
    [FieldOffset(Offset = "0x24")]
    private ReadyProcess.State state;
    [Token(Token = "0x400A50C")]
    [FieldOffset(Offset = "0x28")]
    private List<Vector2Int> placementList;
    [Token(Token = "0x400A50D")]
    [FieldOffset(Offset = "0x30")]
    private Dictionary<UnitParameterData, GridData> initialPositionDic;
    [Token(Token = "0x400A50E")]
    [FieldOffset(Offset = "0x38")]
    private UnitParameterData selectUnit;
    [Token(Token = "0x400A50F")]
    [FieldOffset(Offset = "0x40")]
    private GridData prevGrid;

    [Token(Token = "0x1700328D")]
    private StoryBattleConfig config
    {
      [Token(Token = "0x600EE2B"), Address(RVA = "0x443E29C", Offset = "0x443E29C", VA = "0x443E29C")] get
      {
        return (StoryBattleConfig) null;
      }
    }

    [Token(Token = "0x600EE2C")]
    [Address(RVA = "0x443E320", Offset = "0x443E320", VA = "0x443E320", Slot = "10")]
    public override void Initialize(IProcessOwner<ProcessCode> ownerBehaviour, BattleCore core)
    {
    }

    [Token(Token = "0x600EE2D")]
    [Address(RVA = "0x4440158", Offset = "0x4440158", VA = "0x4440158", Slot = "17")]
    public void OnHoldGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600EE2E")]
    [Address(RVA = "0x444015C", Offset = "0x444015C", VA = "0x444015C", Slot = "18")]
    public void OnSelectUnitEvent(UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EE2F")]
    [Address(RVA = "0x4440474", Offset = "0x4440474", VA = "0x4440474", Slot = "16")]
    public void OnSelectGrid(GridObject targetGrid)
    {
    }

    [Token(Token = "0x600EE30")]
    [Address(RVA = "0x4441AD8", Offset = "0x4441AD8", VA = "0x4441AD8")]
    private void PlayEffect(Vector3 position)
    {
    }

    [Token(Token = "0x600EE31")]
    [Address(RVA = "0x4441C54", Offset = "0x4441C54", VA = "0x4441C54")]
    private void PlayInitialPlacementEffect(
      GridData toGrid,
      GridData fromGrid,
      bool enableFromGrid = false)
    {
    }

    [Token(Token = "0x600EE32")]
    [Address(RVA = "0x4441818", Offset = "0x4441818", VA = "0x4441818")]
    private void ChangePlacement(GridData toGrid, GridData fromGrid, UnitParameterData unit)
    {
    }

    [Token(Token = "0x600EE33")]
    [Address(RVA = "0x4441368", Offset = "0x4441368", VA = "0x4441368")]
    private void ChangePlacement(
      GridData toGrid,
      GridData fromGrid,
      UnitParameterData unit,
      UnitParameterData changeUnit)
    {
    }

    [Token(Token = "0x600EE34")]
    [Address(RVA = "0x44411F4", Offset = "0x44411F4", VA = "0x44411F4")]
    private void ShowSimpleStatus(
      UnitParameterData unit,
      BattlePlayerData owner,
      GridData grid,
      bool isAlly)
    {
    }

    [Token(Token = "0x600EE35")]
    [Address(RVA = "0x443F728", Offset = "0x443F728", VA = "0x443F728")]
    private void TurnAlliesToEnemy()
    {
    }

    [Token(Token = "0x600EE36")]
    [Address(RVA = "0x443FBC0", Offset = "0x443FBC0", VA = "0x443FBC0")]
    private void TurnEnemiesToAlly()
    {
    }

    [Token(Token = "0x600EE37")]
    [Address(RVA = "0x4441E9C", Offset = "0x4441E9C", VA = "0x4441E9C")]
    private void OnPushBackButton()
    {
    }

    [Token(Token = "0x600EE38")]
    [Address(RVA = "0x44421A4", Offset = "0x44421A4", VA = "0x44421A4")]
    private void OnPushFinish()
    {
    }

    [Token(Token = "0x600EE39")]
    [Address(RVA = "0x4440090", Offset = "0x4440090", VA = "0x4440090")]
    private void ShowInitializePlacementSelectArea(List<Vector2Int> pos)
    {
    }

    [Token(Token = "0x600EE3A")]
    [Address(RVA = "0x4442A0C", Offset = "0x4442A0C", VA = "0x4442A0C", Slot = "13")]
    public override void Step(float delta)
    {
    }

    [Token(Token = "0x600EE3B")]
    [Address(RVA = "0x4442BB0", Offset = "0x4442BB0", VA = "0x4442BB0")]
    private void AddSecurityLog()
    {
    }

    [Token(Token = "0x600EE3C")]
    [Address(RVA = "0x444315C", Offset = "0x444315C", VA = "0x444315C")]
    private void ShowUnitDetail(UnitParameterData unit, int barrierIndex)
    {
    }

    [Token(Token = "0x600EE3D")]
    [Address(RVA = "0x444349C", Offset = "0x444349C", VA = "0x444349C")]
    public ReadyProcess()
    {
    }

    [Token(Token = "0x200267B")]
    private enum State
    {
      [Token(Token = "0x400A511")] Init,
      [Token(Token = "0x400A512")] SelectUnit,
      [Token(Token = "0x400A513")] SelectPos,
      [Token(Token = "0x400A514")] Finish,
    }
  }
}

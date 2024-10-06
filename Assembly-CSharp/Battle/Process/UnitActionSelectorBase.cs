// Decompiled with JetBrains decompiler
// Type: Battle.Process.UnitActionSelectorBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Command;
using Battle.Data.Board;
using Battle.RouteSearch;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Battle.Process
{
  [Token(Token = "0x200262D")]
  public abstract class UnitActionSelectorBase : IUnitActionSelector
  {
    [Token(Token = "0x400A404")]
    [FieldOffset(Offset = "0x18")]
    private int _actionUnit;
    [Token(Token = "0x400A406")]
    [FieldOffset(Offset = "0x28")]
    protected Vector2Int _actionTargetGrid;
    [Token(Token = "0x400A408")]
    [FieldOffset(Offset = "0x38")]
    protected BattleCore core;
    [Token(Token = "0x400A409")]
    [FieldOffset(Offset = "0x40")]
    public MovableAreaSearcher movableAreaSearcher;
    [Token(Token = "0x400A40A")]
    [FieldOffset(Offset = "0x48")]
    public AttackableAreaSearcher attackableAreaSearcher;
    [Token(Token = "0x400A40B")]
    [FieldOffset(Offset = "0x50")]
    protected AttackableAreaSearcher effectiveAreaSearcher;
    [Token(Token = "0x400A40C")]
    [FieldOffset(Offset = "0x58")]
    protected Action<bool> onSelected;

    [Token(Token = "0x1700324F")]
    public Queue<UnitCommandBase> ActionCommand
    {
      [Token(Token = "0x600EC29"), Address(RVA = "0x4482A40", Offset = "0x4482A40", VA = "0x4482A40", Slot = "4")] get
      {
        return (Queue<UnitCommandBase>) null;
      }
      [Token(Token = "0x600EC2A"), Address(RVA = "0x4482A48", Offset = "0x4482A48", VA = "0x4482A48")] protected set
      {
      }
    }

    [Token(Token = "0x17003250")]
    public UnitParameterData ActionUnit
    {
      [Token(Token = "0x600EC2B"), Address(RVA = "0x44826C0", Offset = "0x44826C0", VA = "0x44826C0", Slot = "6")] get
      {
        return (UnitParameterData) null;
      }
      [Token(Token = "0x600EC2C"), Address(RVA = "0x4482A50", Offset = "0x4482A50", VA = "0x4482A50")] protected set
      {
      }
    }

    [Token(Token = "0x17003251")]
    public GridData PrevOwnerGrid
    {
      [Token(Token = "0x600EC2D"), Address(RVA = "0x4482A7C", Offset = "0x4482A7C", VA = "0x4482A7C", Slot = "7")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600EC2E"), Address(RVA = "0x4482A84", Offset = "0x4482A84", VA = "0x4482A84")] protected set
      {
      }
    }

    [Token(Token = "0x17003252")]
    public GridData ActionTargetGrid
    {
      [Token(Token = "0x600EC2F"), Address(RVA = "0x448289C", Offset = "0x448289C", VA = "0x448289C", Slot = "8")] get
      {
        return (GridData) null;
      }
      [Token(Token = "0x600EC30"), Address(RVA = "0x44826A8", Offset = "0x44826A8", VA = "0x44826A8")] protected set
      {
      }
    }

    [Token(Token = "0x17003253")]
    public CommandType CommandType
    {
      [Token(Token = "0x600EC31"), Address(RVA = "0x4482A8C", Offset = "0x4482A8C", VA = "0x4482A8C", Slot = "5")] get
      {
        return new CommandType();
      }
      [Token(Token = "0x600EC32"), Address(RVA = "0x4482A94", Offset = "0x4482A94", VA = "0x4482A94")] protected set
      {
      }
    }

    [Token(Token = "0x17003254")]
    protected BoardData board
    {
      [Token(Token = "0x600EC33"), Address(RVA = "0x4482880", Offset = "0x4482880", VA = "0x4482880")] get
      {
        return (BoardData) null;
      }
    }

    [Token(Token = "0x17003255")]
    public bool IsCanceled
    {
      [Token(Token = "0x600EC34"), Address(RVA = "0x4482A9C", Offset = "0x4482A9C", VA = "0x4482A9C")] get
      {
        return new bool();
      }
      [Token(Token = "0x600EC35"), Address(RVA = "0x4482AA4", Offset = "0x4482AA4", VA = "0x4482AA4")] private set
      {
      }
    }

    [Token(Token = "0x17003256")]
    public BoardData OrgBoard
    {
      [Token(Token = "0x600EC36"), Address(RVA = "0x4482AB0", Offset = "0x4482AB0", VA = "0x4482AB0")] get
      {
        return (BoardData) null;
      }
      [Token(Token = "0x600EC37"), Address(RVA = "0x4482AB8", Offset = "0x4482AB8", VA = "0x4482AB8")] protected set
      {
      }
    }

    [Token(Token = "0x600EC38")]
    [Address(RVA = "0x4482AC0", Offset = "0x4482AC0", VA = "0x4482AC0")]
    protected UnitActionSelectorBase(BattleCore core)
    {
    }

    [Token(Token = "0x600EC39")]
    [Address(RVA = "0x4482BD4", Offset = "0x4482BD4", VA = "0x4482BD4", Slot = "11")]
    public virtual void Finish()
    {
    }

    [Token(Token = "0x600EC3A")]
    [Address(RVA = "0x4482BDC", Offset = "0x4482BDC", VA = "0x4482BDC", Slot = "12")]
    public virtual void SetParam(
      UnitParameterData actionUnit,
      GridData prevGrid,
      Action<bool> onSelected)
    {
    }

    [Token(Token = "0x600EC3B")]
    [Address(RVA = "0x4482C34", Offset = "0x4482C34", VA = "0x4482C34", Slot = "13")]
    protected virtual void ResetPathSearcher()
    {
    }

    [Token(Token = "0x600EC3C")]
    [Address(RVA = "0x4482D58", Offset = "0x4482D58", VA = "0x4482D58", Slot = "14")]
    protected virtual void SwitchBoard(BoardData targetBoard)
    {
    }

    [Token(Token = "0x600EC3D")]
    [Address(RVA = "0x4482F44", Offset = "0x4482F44", VA = "0x4482F44", Slot = "15")]
    public virtual void CancelSelection()
    {
    }

    [Token(Token = "0x600EC3E")]
    [Address(RVA = "0x4482F54", Offset = "0x4482F54", VA = "0x4482F54", Slot = "16")]
    public virtual void OnSelectUnit(UnitParameterData unit, GridData selectGrid)
    {
    }

    [Token(Token = "0x600EC3F")]
    public abstract void OnSelectGrid(GridData grid);

    [Token(Token = "0x600EC40")]
    [Address(RVA = "0x4482FB4", Offset = "0x4482FB4", VA = "0x4482FB4", Slot = "18")]
    protected virtual void OnSelectTargettableUnit(UnitParameterData unit, GridData selectGrid)
    {
    }

    [Token(Token = "0x600EC41")]
    [Address(RVA = "0x4482FB8", Offset = "0x4482FB8", VA = "0x4482FB8", Slot = "19")]
    protected virtual void OnSelectNotTargettableUnit(UnitParameterData unit, GridData selectGrid)
    {
    }

    [Token(Token = "0x600EC42")]
    [Address(RVA = "0x4482FBC", Offset = "0x4482FBC", VA = "0x4482FBC", Slot = "20")]
    protected virtual void OnSelectUnknownTargetStateUnit(
      UnitParameterData unit,
      GridData selectGrid)
    {
    }

    [Token(Token = "0x600EC43")]
    [Address(RVA = "0x44828C8", Offset = "0x44828C8", VA = "0x44828C8")]
    protected void DispatchSelected(Queue<UnitCommandBase> command)
    {
    }

    [Token(Token = "0x600EC44")]
    [Address(RVA = "0x4482FC0", Offset = "0x4482FC0", VA = "0x4482FC0", Slot = "21")]
    protected virtual void OnDispatchInternal(Queue<UnitCommandBase> command)
    {
    }

    [Token(Token = "0x600EC45")]
    [Address(RVA = "0x4482FC4", Offset = "0x4482FC4", VA = "0x4482FC4")]
    protected bool SwitchWeaponAt(UnitParameterData unit, int weaponIndex) => new bool();
  }
}

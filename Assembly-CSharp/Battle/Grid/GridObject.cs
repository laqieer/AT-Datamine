// Decompiled with JetBrains decompiler
// Type: Battle.Grid.GridObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Unit;
using Il2CppDummyDll;
using System;
using UnityEngine.EventSystems;

#nullable disable
namespace Battle.Grid
{
  [Token(Token = "0x200252F")]
  public sealed class GridObject : IDisposable, IGridEventDispatcher
  {
    [Token(Token = "0x4009FD0")]
    [FieldOffset(Offset = "0x18")]
    private GridParameter parameter;

    [Token(Token = "0x17003150")]
    public GridBehaviour Behaviour
    {
      [Token(Token = "0x600E59E"), Address(RVA = "0x48698A8", Offset = "0x48698A8", VA = "0x48698A8")] get
      {
        return (GridBehaviour) null;
      }
      [Token(Token = "0x600E59F"), Address(RVA = "0x48698B0", Offset = "0x48698B0", VA = "0x48698B0")] private set
      {
      }
    }

    [Token(Token = "0x17003151")]
    public IGridView Parameter
    {
      [Token(Token = "0x600E5A0"), Address(RVA = "0x48698B8", Offset = "0x48698B8", VA = "0x48698B8")] get
      {
        return (IGridView) null;
      }
    }

    [Token(Token = "0x17003152")]
    public FacilityView Facility
    {
      [Token(Token = "0x600E5A1"), Address(RVA = "0x48698C0", Offset = "0x48698C0", VA = "0x48698C0")] get
      {
        return (FacilityView) null;
      }
      [Token(Token = "0x600E5A2"), Address(RVA = "0x48698C8", Offset = "0x48698C8", VA = "0x48698C8")] private set
      {
      }
    }

    [Token(Token = "0x17003153")]
    public float[] Heights
    {
      [Token(Token = "0x600E5A3"), Address(RVA = "0x48698D0", Offset = "0x48698D0", VA = "0x48698D0")] get
      {
        return (float[]) null;
      }
    }

    [Token(Token = "0x17003154")]
    public IGridEventHandler GridEventHandler
    {
      [Token(Token = "0x600E5A4"), Address(RVA = "0x48699D4", Offset = "0x48699D4", VA = "0x48699D4")] get
      {
        return (IGridEventHandler) null;
      }
      [Token(Token = "0x600E5A5"), Address(RVA = "0x48699DC", Offset = "0x48699DC", VA = "0x48699DC")] set
      {
      }
    }

    [Token(Token = "0x600E5A6")]
    [Address(RVA = "0x48699E4", Offset = "0x48699E4", VA = "0x48699E4")]
    public void Initialize(GridParameter parameter)
    {
    }

    [Token(Token = "0x600E5A7")]
    [Address(RVA = "0x48699EC", Offset = "0x48699EC", VA = "0x48699EC", Slot = "4")]
    public void Dispose()
    {
    }

    [Token(Token = "0x600E5A8")]
    [Address(RVA = "0x48690D0", Offset = "0x48690D0", VA = "0x48690D0")]
    public void RegisterGridBehaviour(GridBehaviour behaviour)
    {
    }

    [Token(Token = "0x600E5A9")]
    [Address(RVA = "0x48699F0", Offset = "0x48699F0", VA = "0x48699F0")]
    public void SetFacilityView(FacilityView facility)
    {
    }

    [Token(Token = "0x600E5AA")]
    [Address(RVA = "0x4869A20", Offset = "0x4869A20", VA = "0x4869A20")]
    private void SetGridHeightOffset(float offset)
    {
    }

    [Token(Token = "0x600E5AB")]
    [Address(RVA = "0x4869A38", Offset = "0x4869A38", VA = "0x4869A38")]
    public void AddGridView(GridViewType type)
    {
    }

    [Token(Token = "0x600E5AC")]
    [Address(RVA = "0x4869A5C", Offset = "0x4869A5C", VA = "0x4869A5C")]
    public void RemoveGridView(GridViewType type)
    {
    }

    [Token(Token = "0x600E5AD")]
    [Address(RVA = "0x4869A80", Offset = "0x4869A80", VA = "0x4869A80")]
    public void ResetGridView()
    {
    }

    [Token(Token = "0x600E5AE")]
    [Address(RVA = "0x4869A9C", Offset = "0x4869A9C", VA = "0x4869A9C")]
    public void MarkAsDanger()
    {
    }

    [Token(Token = "0x600E5AF")]
    [Address(RVA = "0x4869ABC", Offset = "0x4869ABC", VA = "0x4869ABC")]
    public void UnmarkAsDanger()
    {
    }

    [Token(Token = "0x600E5B0")]
    [Address(RVA = "0x4869B00", Offset = "0x4869B00", VA = "0x4869B00")]
    public void MarkAsFierceDanger()
    {
    }

    [Token(Token = "0x600E5B1")]
    [Address(RVA = "0x4869B24", Offset = "0x4869B24", VA = "0x4869B24")]
    public void MarkAsFierceTargetUnit()
    {
    }

    [Token(Token = "0x600E5B2")]
    [Address(RVA = "0x4869B4C", Offset = "0x4869B4C", VA = "0x4869B4C")]
    public void UnmarkAsFierce()
    {
    }

    [Token(Token = "0x600E5B3")]
    [Address(RVA = "0x4869B6C", Offset = "0x4869B6C", VA = "0x4869B6C")]
    public void AddAdjoiningDangerDir(AdjoiningDirection direction)
    {
    }

    [Token(Token = "0x600E5B4")]
    [Address(RVA = "0x4869AD8", Offset = "0x4869AD8", VA = "0x4869AD8")]
    public void ClearAdjoiningDangerDir()
    {
    }

    [Token(Token = "0x600E5B5")]
    [Address(RVA = "0x4869B90", Offset = "0x4869B90", VA = "0x4869B90")]
    public void AddAdjoiningPredictionMoveViewType(PredictionMoveViewType viewType)
    {
    }

    [Token(Token = "0x600E5B6")]
    [Address(RVA = "0x4869BB4", Offset = "0x4869BB4", VA = "0x4869BB4")]
    public void AddAdjoiningPredictionMove(AdjoiningDirection direction)
    {
    }

    [Token(Token = "0x600E5B7")]
    [Address(RVA = "0x4869BE0", Offset = "0x4869BE0", VA = "0x4869BE0")]
    public void ClearAdjoiningPredictionMove()
    {
    }

    [Token(Token = "0x600E5B8")]
    [Address(RVA = "0x4869C04", Offset = "0x4869C04", VA = "0x4869C04", Slot = "5")]
    public void DispatchPointerDownGrid(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600E5B9")]
    [Address(RVA = "0x4869CB8", Offset = "0x4869CB8", VA = "0x4869CB8", Slot = "6")]
    public void DispatchPointerUpGrid(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600E5BA")]
    [Address(RVA = "0x4869D70", Offset = "0x4869D70", VA = "0x4869D70", Slot = "7")]
    public void DispatchPointerExitGrid(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600E5BB")]
    [Address(RVA = "0x4869E28", Offset = "0x4869E28", VA = "0x4869E28")]
    public GridObject()
    {
    }
  }
}

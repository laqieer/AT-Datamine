// Decompiled with JetBrains decompiler
// Type: Battle.Stage.StageEventManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Battle.Grid;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Battle.Stage
{
  [Token(Token = "0x200246F")]
  public sealed class StageEventManager : MonoBehaviour, IGridEventHandler, IStepUpdate
  {
    [Token(Token = "0x4009C41")]
    [FieldOffset(Offset = "0x18")]
    private float TouchPositionDeadZoneDistance;
    [Token(Token = "0x4009C42")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Range(0.01f, 3f)]
    private float holdEventThresholdInterval;
    [Token(Token = "0x4009C43")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string seSelectGrid;
    [Token(Token = "0x4009C44")]
    [FieldOffset(Offset = "0x28")]
    private float holdGridPassedTimes;
    [Token(Token = "0x4009C45")]
    [FieldOffset(Offset = "0x30")]
    private GridObject currentHoldGrid;
    [Token(Token = "0x4009C46")]
    [FieldOffset(Offset = "0x38")]
    private Vector2 downPosition;
    [Token(Token = "0x4009C47")]
    [FieldOffset(Offset = "0x40")]
    private int holdFingerId;

    [Token(Token = "0x17002FE5")]
    public IStageEventHandler StageEventHandler
    {
      [Token(Token = "0x600DF5B"), Address(RVA = "0x201A148", Offset = "0x201A148", VA = "0x201A148")] get
      {
        return (IStageEventHandler) null;
      }
      [Token(Token = "0x600DF5C"), Address(RVA = "0x201A150", Offset = "0x201A150", VA = "0x201A150")] set
      {
      }
    }

    [Token(Token = "0x600DF5D")]
    [Address(RVA = "0x201A158", Offset = "0x201A158", VA = "0x201A158")]
    private void Awake()
    {
    }

    [Token(Token = "0x600DF5E")]
    [Address(RVA = "0x201A174", Offset = "0x201A174", VA = "0x201A174")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600DF5F")]
    [Address(RVA = "0x201A190", Offset = "0x201A190", VA = "0x201A190")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600DF60")]
    [Address(RVA = "0x201A1C4", Offset = "0x201A1C4", VA = "0x201A1C4")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600DF61")]
    [Address(RVA = "0x201A1B8", Offset = "0x201A1B8", VA = "0x201A1B8")]
    public void ResetGridEvent()
    {
    }

    [Token(Token = "0x600DF62")]
    [Address(RVA = "0x201A1D0", Offset = "0x201A1D0", VA = "0x201A1D0", Slot = "4")]
    public void OnPointerDownGrid(GridObject grid, PointerEventData eventData)
    {
    }

    [Token(Token = "0x600DF63")]
    [Address(RVA = "0x201A378", Offset = "0x201A378", VA = "0x201A378", Slot = "5")]
    public void OnPointerUpGrid(GridObject grid, PointerEventData eventData)
    {
    }

    [Token(Token = "0x600DF64")]
    [Address(RVA = "0x201A37C", Offset = "0x201A37C", VA = "0x201A37C", Slot = "6")]
    public void OnPointerExitGrid(GridObject grid, PointerEventData eventData)
    {
    }

    [Token(Token = "0x600DF65")]
    [Address(RVA = "0x201A380", Offset = "0x201A380", VA = "0x201A380", Slot = "7")]
    public void Step(float delta)
    {
    }

    [Token(Token = "0x600DF66")]
    [Address(RVA = "0x201A754", Offset = "0x201A754", VA = "0x201A754")]
    private bool ContainsDZ(Vector2 vector) => new bool();

    [Token(Token = "0x600DF67")]
    [Address(RVA = "0x201A228", Offset = "0x201A228", VA = "0x201A228")]
    private int GetSelectFingerId(Vector2 touchPointer) => new int();

    [Token(Token = "0x600DF68")]
    [Address(RVA = "0x201A530", Offset = "0x201A530", VA = "0x201A530")]
    private TouchPhase GetTouchPhase(int fingerID) => new TouchPhase();

    [Token(Token = "0x600DF69")]
    [Address(RVA = "0x201A644", Offset = "0x201A644", VA = "0x201A644")]
    private Vector2 GetTouchPosition(int fingerID) => new Vector2();

    [Token(Token = "0x600DF6A")]
    [Address(RVA = "0x201A774", Offset = "0x201A774", VA = "0x201A774")]
    public StageEventManager()
    {
    }
  }
}

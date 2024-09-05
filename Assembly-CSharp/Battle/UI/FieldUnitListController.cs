// Decompiled with JetBrains decompiler
// Type: Battle.UI.FieldUnitListController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace Battle.UI
{
  [Token(Token = "0x2002405")]
  public sealed class FieldUnitListController : MonoBehaviour
  {
    [Token(Token = "0x40099F7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Range(0.0f, 2f)]
    private float _focusSpeed;
    [Token(Token = "0x40099F8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [Token(Token = "0x40099F9")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform _scrollViewContent;
    [Token(Token = "0x40099FA")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ScrollRect _scrollRect;
    [Token(Token = "0x40099FB")]
    [FieldOffset(Offset = "0x38")]
    private FieldUnitListManager _fieldUnitListManager;
    [Token(Token = "0x40099FC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button _upScrollButton;
    [Token(Token = "0x40099FD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button _downScrollButton;
    [Token(Token = "0x40099FE")]
    [FieldOffset(Offset = "0x50")]
    private UnityAction[] _prevPressEvent;
    [Token(Token = "0x40099FF")]
    [FieldOffset(Offset = "0x58")]
    private bool isArena;

    [Token(Token = "0x17002F6E")]
    public float FocusSpeed
    {
      [Token(Token = "0x600DCB6"), Address(RVA = "0x1E2187C", Offset = "0x1E2187C", VA = "0x1E2187C")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17002F6F")]
    public Transform ScrollViewContentTransform
    {
      [Token(Token = "0x600DCB7"), Address(RVA = "0x1E21884", Offset = "0x1E21884", VA = "0x1E21884")] get
      {
        return (Transform) null;
      }
    }

    [Token(Token = "0x17002F70")]
    public FieldUnitListManager FieldUnitListManager
    {
      [Token(Token = "0x600DCB8"), Address(RVA = "0x1E2188C", Offset = "0x1E2188C", VA = "0x1E2188C")] get
      {
        return (FieldUnitListManager) null;
      }
    }

    [Token(Token = "0x17002F71")]
    public float Spacing
    {
      [Token(Token = "0x600DCB9"), Address(RVA = "0x1E21894", Offset = "0x1E21894", VA = "0x1E21894")] get
      {
        return new float();
      }
      [Token(Token = "0x600DCBA"), Address(RVA = "0x1E2189C", Offset = "0x1E2189C", VA = "0x1E2189C")] private set
      {
      }
    }

    [Token(Token = "0x600DCBB")]
    [Address(RVA = "0x1E218A4", Offset = "0x1E218A4", VA = "0x1E218A4")]
    private void Awake()
    {
    }

    [Token(Token = "0x600DCBC")]
    [Address(RVA = "0x1E21A20", Offset = "0x1E21A20", VA = "0x1E21A20")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600DCBD")]
    [Address(RVA = "0x1E21954", Offset = "0x1E21954", VA = "0x1E21954")]
    public void Initialize(bool isArena = false)
    {
    }

    [Token(Token = "0x600DCBE")]
    [Address(RVA = "0x1E21D2C", Offset = "0x1E21D2C", VA = "0x1E21D2C")]
    public bool IsDisplayed() => new bool();

    [Token(Token = "0x600DCBF")]
    [Address(RVA = "0x1E21D58", Offset = "0x1E21D58", VA = "0x1E21D58")]
    public void Show()
    {
    }

    [Token(Token = "0x600DCC0")]
    [Address(RVA = "0x1E219E8", Offset = "0x1E219E8", VA = "0x1E219E8")]
    public void Hide()
    {
    }

    [Token(Token = "0x600DCC1")]
    [Address(RVA = "0x1E21DA0", Offset = "0x1E21DA0", VA = "0x1E21DA0")]
    public Rect GetScrollViewportRect() => new Rect();

    [Token(Token = "0x600DCC2")]
    [Address(RVA = "0x1E21DC4", Offset = "0x1E21DC4", VA = "0x1E21DC4")]
    public float GetScrollViewportHeight() => new float();

    [Token(Token = "0x600DCC3")]
    [Address(RVA = "0x1E21E0C", Offset = "0x1E21E0C", VA = "0x1E21E0C")]
    public void SetScrollArea(Vector2 size)
    {
    }

    [Token(Token = "0x600DCC4")]
    [Address(RVA = "0x1E21E30", Offset = "0x1E21E30", VA = "0x1E21E30")]
    public void SetScrollNormalizedPositionY(float y)
    {
    }

    [Token(Token = "0x600DCC5")]
    [Address(RVA = "0x1E21E54", Offset = "0x1E21E54", VA = "0x1E21E54")]
    public float GetScrollNormalizedPositionY() => new float();

    [Token(Token = "0x600DCC6")]
    [Address(RVA = "0x1E21E78", Offset = "0x1E21E78", VA = "0x1E21E78")]
    public void SetActiveScrollButton(bool display)
    {
    }

    [Token(Token = "0x600DCC7")]
    [Address(RVA = "0x1E21ED4", Offset = "0x1E21ED4", VA = "0x1E21ED4")]
    public void SetScrollButtonEvent(
      FieldUnitListController.ScrollDirection type,
      UnityAction pressEvent)
    {
    }

    [Token(Token = "0x600DCC8")]
    [Address(RVA = "0x1E21FAC", Offset = "0x1E21FAC", VA = "0x1E21FAC")]
    public FieldUnitListController()
    {
    }

    [Token(Token = "0x2002406")]
    public enum ScrollDirection
    {
      [Token(Token = "0x4009A02")] Up,
      [Token(Token = "0x4009A03")] Down,
    }
  }
}

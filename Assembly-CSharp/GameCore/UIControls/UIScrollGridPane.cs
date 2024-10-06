// Decompiled with JetBrains decompiler
// Type: GameCore.UIControls.UIScrollGridPane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace GameCore.UIControls
{
  [Token(Token = "0x2000C1F")]
  public class UIScrollGridPane : MonoBehaviour
  {
    [Token(Token = "0x4003700")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    protected ScrollRect scrollRect;
    [Token(Token = "0x4003701")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    protected UIScrollGridItem itemOriginal;
    [Token(Token = "0x4003702")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    protected Vector2 cellSize;
    [Token(Token = "0x4003703")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    protected Vector2 spacing;
    [Token(Token = "0x4003704")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    protected UIScrollGridPane.RectSize padding;
    [Token(Token = "0x4003705")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    protected UIScrollGridPane.ExtendDirection extendDirection;
    [Token(Token = "0x4003706")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int itemsCount;
    [Token(Token = "0x4003707")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int constraintCount;
    [Token(Token = "0x4003708")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private bool uniqueName;
    [Token(Token = "0x4003709")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<int, UIScrollGridItem> enabledItems;
    [Token(Token = "0x400370A")]
    [FieldOffset(Offset = "0x60")]
    private List<UIScrollGridItem> disabledItems;
    [Token(Token = "0x400370B")]
    [FieldOffset(Offset = "0x68")]
    private Rect scrollViewArea;
    [Token(Token = "0x400370C")]
    [FieldOffset(Offset = "0x78")]
    private Vector2 unitSize;
    [Token(Token = "0x400370D")]
    [FieldOffset(Offset = "0x80")]
    private bool isDirty;

    [Token(Token = "0x17000A0B")]
    public Vector2 CellSize
    {
      [Token(Token = "0x6004563"), Address(RVA = "0x350FFC8", Offset = "0x350FFC8", VA = "0x350FFC8")] get
      {
        return new Vector2();
      }
      [Token(Token = "0x6004564"), Address(RVA = "0x350FFD0", Offset = "0x350FFD0", VA = "0x350FFD0")] set
      {
      }
    }

    [Token(Token = "0x17000A0C")]
    public int ItemsCount
    {
      [Token(Token = "0x6004565"), Address(RVA = "0x3510388", Offset = "0x3510388", VA = "0x3510388")] get
      {
        return new int();
      }
      [Token(Token = "0x6004566"), Address(RVA = "0x3510390", Offset = "0x3510390", VA = "0x3510390")] set
      {
      }
    }

    [Token(Token = "0x17000A0D")]
    public int ConstraintCount
    {
      [Token(Token = "0x6004567"), Address(RVA = "0x3510398", Offset = "0x3510398", VA = "0x3510398")] get
      {
        return new int();
      }
      [Token(Token = "0x6004568"), Address(RVA = "0x35103A0", Offset = "0x35103A0", VA = "0x35103A0")] set
      {
      }
    }

    [Token(Token = "0x17000A0E")]
    public Rect ScrollViewRect
    {
      [Token(Token = "0x6004569"), Address(RVA = "0x35103BC", Offset = "0x35103BC", VA = "0x35103BC")] get
      {
        return new Rect();
      }
    }

    [Token(Token = "0x600456A")]
    protected void ModifyEnableItems<TScrollGridItem>(Action<TScrollGridItem> modifyEnableItem) where TScrollGridItem : UIScrollGridItem
    {
    }

    [Token(Token = "0x600456B")]
    [Address(RVA = "0x3510478", Offset = "0x3510478", VA = "0x3510478")]
    private UIScrollGridItem CreateItem(int index) => (UIScrollGridItem) null;

    [Token(Token = "0x600456C")]
    [Address(RVA = "0x35105B0", Offset = "0x35105B0", VA = "0x35105B0")]
    private void AlignItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x600456D")]
    [Address(RVA = "0x3510714", Offset = "0x3510714", VA = "0x3510714")]
    private void EnableItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x600456E")]
    [Address(RVA = "0x3510794", Offset = "0x3510794", VA = "0x3510794")]
    private void DisableItem(UIScrollGridItem item)
    {
    }

    [Token(Token = "0x600456F")]
    [Address(RVA = "0x3510848", Offset = "0x3510848", VA = "0x3510848")]
    private bool IsItemContains(UIScrollGridItem item, Rect area) => new bool();

    [Token(Token = "0x6004570")]
    [Address(RVA = "0x351090C", Offset = "0x351090C", VA = "0x351090C")]
    private bool NeedsModifyScrollViewArea() => new bool();

    [Token(Token = "0x6004571")]
    [Address(RVA = "0x351098C", Offset = "0x351098C", VA = "0x351098C")]
    public void ModifyScrollViewArea()
    {
    }

    [Token(Token = "0x6004572")]
    [Address(RVA = "0x35101BC", Offset = "0x35101BC", VA = "0x35101BC")]
    public void ModifyGrid()
    {
    }

    [Token(Token = "0x6004573")]
    [Address(RVA = "0x35109E4", Offset = "0x35109E4", VA = "0x35109E4")]
    public void ModifyGridItems()
    {
    }

    [Token(Token = "0x6004574")]
    [Address(RVA = "0x35110CC", Offset = "0x35110CC", VA = "0x35110CC")]
    private void ModifyGridItem(int index)
    {
    }

    [Token(Token = "0x6004575")]
    [Address(RVA = "0x351121C", Offset = "0x351121C", VA = "0x351121C")]
    public void RefreshItems()
    {
    }

    [Token(Token = "0x6004576")]
    [Address(RVA = "0x3511374", Offset = "0x3511374", VA = "0x3511374")]
    public void RefreshItemsAll()
    {
    }

    [Token(Token = "0x6004577")]
    [Address(RVA = "0x3511378", Offset = "0x3511378", VA = "0x3511378")]
    public void ResetGridItems()
    {
    }

    [Token(Token = "0x6004578")]
    [Address(RVA = "0x350FFFC", Offset = "0x350FFFC", VA = "0x350FFFC")]
    private void DisableGridItems()
    {
    }

    [Token(Token = "0x6004579")]
    [Address(RVA = "0x3510680", Offset = "0x3510680", VA = "0x3510680")]
    private Vector2 GetGridItemPosition(int index) => new Vector2();

    [Token(Token = "0x600457A")]
    [Address(RVA = "0x3511394", Offset = "0x3511394", VA = "0x3511394")]
    public void SetScrollPosition(float normalizedPosition)
    {
    }

    [Token(Token = "0x600457B")]
    [Address(RVA = "0x351141C", Offset = "0x351141C", VA = "0x351141C")]
    private void OnValidate()
    {
    }

    [Token(Token = "0x600457C")]
    [Address(RVA = "0x3511438", Offset = "0x3511438", VA = "0x3511438")]
    private void Start()
    {
    }

    [Token(Token = "0x600457D")]
    [Address(RVA = "0x35115A4", Offset = "0x35115A4", VA = "0x35115A4")]
    private void Update()
    {
    }

    [Token(Token = "0x600457E")]
    [Address(RVA = "0x35115E0", Offset = "0x35115E0", VA = "0x35115E0", Slot = "4")]
    protected virtual void OnStart()
    {
    }

    [Token(Token = "0x600457F")]
    [Address(RVA = "0x35115E4", Offset = "0x35115E4", VA = "0x35115E4", Slot = "5")]
    protected virtual void OnScroll(Vector2 value)
    {
    }

    [Token(Token = "0x6004580")]
    [Address(RVA = "0x3511870", Offset = "0x3511870", VA = "0x3511870", Slot = "6")]
    protected virtual void OnModifyGrid()
    {
    }

    [Token(Token = "0x6004581")]
    [Address(RVA = "0x3511874", Offset = "0x3511874", VA = "0x3511874", Slot = "7")]
    protected virtual void OnModifyItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x6004582")]
    [Address(RVA = "0x351189C", Offset = "0x351189C", VA = "0x351189C", Slot = "8")]
    protected virtual void OnEnableItem(UIScrollGridItem item, int index)
    {
    }

    [Token(Token = "0x6004583")]
    [Address(RVA = "0x35118C8", Offset = "0x35118C8", VA = "0x35118C8", Slot = "9")]
    protected virtual void OnDisableItem(UIScrollGridItem item)
    {
    }

    [Token(Token = "0x6004584")]
    [Address(RVA = "0x35118F4", Offset = "0x35118F4", VA = "0x35118F4")]
    public UIScrollGridPane()
    {
    }

    [Token(Token = "0x2000C20")]
    public enum ExtendDirection
    {
      [Token(Token = "0x400370F")] Down,
      [Token(Token = "0x4003710")] Right,
    }

    [Token(Token = "0x2000C21")]
    [Serializable]
    public struct RectSize
    {
      [Token(Token = "0x4003711")]
      [FieldOffset(Offset = "0x0")]
      public Vector2 UpperLeft;
      [Token(Token = "0x4003712")]
      [FieldOffset(Offset = "0x8")]
      public Vector2 LowerRight;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: InfiniteScrollView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002D5")]
[RequireComponent(typeof (ScrollRect))]
public abstract class InfiniteScrollView : UIBehaviour
{
  [Token(Token = "0x4001079")]
  [FieldOffset(Offset = "0x18")]
  public int cellPoolSize;
  [Token(Token = "0x400107A")]
  [FieldOffset(Offset = "0x1C")]
  public float spacing;
  [Token(Token = "0x400107B")]
  [FieldOffset(Offset = "0x20")]
  [SerializeField]
  protected Vector2 padding;
  [Token(Token = "0x400107C")]
  [FieldOffset(Offset = "0x28")]
  public float extendVisibleRange;
  [Token(Token = "0x400107D")]
  [FieldOffset(Offset = "0x30")]
  public InfiniteCellBase cellPrefab;
  [Token(Token = "0x400107E")]
  [FieldOffset(Offset = "0x38")]
  public float cellScale;
  [Token(Token = "0x400107F")]
  [FieldOffset(Offset = "0x40")]
  public ScrollRect scrollRect;
  [Token(Token = "0x4001080")]
  [FieldOffset(Offset = "0x48")]
  public InfiniteScrollView.Anchor anchor;
  [Token(Token = "0x4001081")]
  [FieldOffset(Offset = "0x50")]
  protected List<InfiniteCellData> dataList;
  [Token(Token = "0x4001082")]
  [FieldOffset(Offset = "0x58")]
  protected List<InfiniteCellBase> cellList;
  [Token(Token = "0x4001083")]
  [FieldOffset(Offset = "0x60")]
  protected Queue<InfiniteCellBase> cellPool;
  [Token(Token = "0x4001084")]
  [FieldOffset(Offset = "0x68")]
  protected YieldInstruction waitEndOfFrame;
  [Token(Token = "0x4001085")]
  [FieldOffset(Offset = "0x70")]
  private Coroutine snappingProcesser;
  [Token(Token = "0x4001087")]
  [FieldOffset(Offset = "0x80")]
  public Action onRefresh;

  [Token(Token = "0x170001C1")]
  public Vector2 Spacing
  {
    [Token(Token = "0x60011B5"), Address(RVA = "0x27D750C", Offset = "0x27D750C", VA = "0x27D750C")] get
    {
      return new Vector2();
    }
  }

  [Token(Token = "0x140000E1")]
  public event Action onRectTransformUpdate
  {
    [Token(Token = "0x60011B6"), Address(RVA = "0x27D7514", Offset = "0x27D7514", VA = "0x27D7514")] add
    {
    }
    [Token(Token = "0x60011B7"), Address(RVA = "0x27D75B0", Offset = "0x27D75B0", VA = "0x27D75B0")] remove
    {
    }
  }

  [Token(Token = "0x170001C2")]
  public Vector2 Padding
  {
    [Token(Token = "0x60011B8"), Address(RVA = "0x27D764C", Offset = "0x27D764C", VA = "0x27D764C")] get
    {
      return new Vector2();
    }
  }

  [Token(Token = "0x170001C3")]
  public bool IsInitialized
  {
    [Token(Token = "0x60011B9"), Address(RVA = "0x27D7654", Offset = "0x27D7654", VA = "0x27D7654")] get
    {
      return new bool();
    }
    [Token(Token = "0x60011BA"), Address(RVA = "0x27D765C", Offset = "0x27D765C", VA = "0x27D765C")] protected set
    {
    }
  }

  [Token(Token = "0x60011BB")]
  [Address(RVA = "0x27D7668", Offset = "0x27D7668", VA = "0x27D7668", Slot = "17")]
  public virtual void Initialize()
  {
  }

  [Token(Token = "0x60011BC")]
  protected abstract void OnValueChanged(Vector2 normalizedPosition);

  [Token(Token = "0x60011BD")]
  public abstract void Refresh();

  [Token(Token = "0x60011BE")]
  [Address(RVA = "0x27D7838", Offset = "0x27D7838", VA = "0x27D7838", Slot = "20")]
  public virtual void Add(InfiniteCellData data)
  {
  }

  [Token(Token = "0x60011BF")]
  [Address(RVA = "0x27D7984", Offset = "0x27D7984", VA = "0x27D7984", Slot = "21")]
  public virtual void Remove(int index)
  {
  }

  [Token(Token = "0x60011C0")]
  public abstract void Snap(int index, float duration);

  [Token(Token = "0x60011C1")]
  [Address(RVA = "0x27D7A2C", Offset = "0x27D7A2C", VA = "0x27D7A2C")]
  public void SnapLast(float duration)
  {
  }

  [Token(Token = "0x60011C2")]
  [Address(RVA = "0x27D7A98", Offset = "0x27D7A98", VA = "0x27D7A98")]
  protected void DoSnapping(Vector2 target, float duration)
  {
  }

  [Token(Token = "0x60011C3")]
  [Address(RVA = "0x27D7B20", Offset = "0x27D7B20", VA = "0x27D7B20")]
  public void StopSnapping()
  {
  }

  [Token(Token = "0x60011C4")]
  [Address(RVA = "0x27D7B44", Offset = "0x27D7B44", VA = "0x27D7B44")]
  private IEnumerator ProcessSnapping(Vector2 target, float duration) => (IEnumerator) null;

  [Token(Token = "0x60011C5")]
  [Address(RVA = "0x27D7BF8", Offset = "0x27D7BF8", VA = "0x27D7BF8")]
  protected bool SetupCell(int index, Vector2 pos) => new bool();

  [Token(Token = "0x60011C6")]
  [Address(RVA = "0x27D7E8C", Offset = "0x27D7E8C", VA = "0x27D7E8C")]
  protected void RecycleCell(int index)
  {
  }

  [Token(Token = "0x60011C7")]
  [Address(RVA = "0x27D7FCC", Offset = "0x27D7FCC", VA = "0x27D7FCC", Slot = "23")]
  public virtual void Clear()
  {
  }

  [Token(Token = "0x60011C8")]
  [Address(RVA = "0x27D812C", Offset = "0x27D812C", VA = "0x27D812C")]
  public void ResetData(IEnumerable<InfiniteCellData> datas)
  {
  }

  [Token(Token = "0x60011C9")]
  [Address(RVA = "0x27D8530", Offset = "0x27D8530", VA = "0x27D8530", Slot = "10")]
  protected override void OnRectTransformDimensionsChange()
  {
  }

  [Token(Token = "0x60011CA")]
  [Address(RVA = "0x27D85C0", Offset = "0x27D85C0", VA = "0x27D85C0")]
  protected void UpdateCellScale()
  {
  }

  [Token(Token = "0x60011CB")]
  [Address(RVA = "0x27D7E24", Offset = "0x27D7E24", VA = "0x27D7E24")]
  private static bool TryGetOverrideAnchorVec2(
    InfiniteScrollView.Anchor anchor,
    out Vector2 anchorVec2)
  {
    return new bool();
  }

  [Token(Token = "0x60011CC")]
  [Address(RVA = "0x27D88D4", Offset = "0x27D88D4", VA = "0x27D88D4")]
  private static Vector2 ToAnchorVec2(InfiniteScrollView.Anchor anchor) => new Vector2();

  [Token(Token = "0x60011CD")]
  [Address(RVA = "0x27D8928", Offset = "0x27D8928", VA = "0x27D8928")]
  protected InfiniteScrollView()
  {
  }

  [Token(Token = "0x20002D6")]
  public enum Anchor
  {
    [Token(Token = "0x400108A")] Default,
    [Token(Token = "0x400108B")] UpperLeft,
  }
}

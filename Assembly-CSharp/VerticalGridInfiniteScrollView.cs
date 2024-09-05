// Decompiled with JetBrains decompiler
// Type: VerticalGridInfiniteScrollView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D8")]
public class VerticalGridInfiniteScrollView : InfiniteScrollView
{
  [Token(Token = "0x4001093")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  protected RectOffset m_Padding;
  [Token(Token = "0x4001094")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  protected Vector2 m_Spacing;
  [Token(Token = "0x4001095")]
  [FieldOffset(Offset = "0xA0")]
  public bool isAtTop;
  [Token(Token = "0x4001096")]
  [FieldOffset(Offset = "0xA1")]
  public bool isAtBottom;
  [Token(Token = "0x4001097")]
  [FieldOffset(Offset = "0xA4")]
  public int columnCount;

  [Token(Token = "0x170001C6")]
  public new Vector2 Spacing
  {
    [Token(Token = "0x60011D4"), Address(RVA = "0x27D8C7C", Offset = "0x27D8C7C", VA = "0x27D8C7C")] get
    {
      return new Vector2();
    }
    [Token(Token = "0x60011D5"), Address(RVA = "0x27D8C84", Offset = "0x27D8C84", VA = "0x27D8C84")] set
    {
    }
  }

  [Token(Token = "0x170001C7")]
  public RectOffset Padding
  {
    [Token(Token = "0x60011D6"), Address(RVA = "0x27D8C8C", Offset = "0x27D8C8C", VA = "0x27D8C8C")] get
    {
      return (RectOffset) null;
    }
    [Token(Token = "0x60011D7"), Address(RVA = "0x27D8C94", Offset = "0x27D8C94", VA = "0x27D8C94")] set
    {
    }
  }

  [Token(Token = "0x60011D8")]
  [Address(RVA = "0x27D8C9C", Offset = "0x27D8C9C", VA = "0x27D8C9C", Slot = "18")]
  protected override void OnValueChanged(Vector2 normalizedPosition)
  {
  }

  [Token(Token = "0x60011D9")]
  [Address(RVA = "0x27D908C", Offset = "0x27D908C", VA = "0x27D908C", Slot = "19")]
  public override sealed void Refresh()
  {
  }

  [Token(Token = "0x60011DA")]
  [Address(RVA = "0x27D9188", Offset = "0x27D9188", VA = "0x27D9188")]
  private void DoRefresh()
  {
  }

  [Token(Token = "0x60011DB")]
  [Address(RVA = "0x27D9120", Offset = "0x27D9120", VA = "0x27D9120")]
  private IEnumerator DelayToRefresh() => (IEnumerator) null;

  [Token(Token = "0x60011DC")]
  [Address(RVA = "0x27D9354", Offset = "0x27D9354", VA = "0x27D9354", Slot = "22")]
  public override void Snap(int index, float duration)
  {
  }

  [Token(Token = "0x60011DD")]
  [Address(RVA = "0x27D94DC", Offset = "0x27D94DC", VA = "0x27D94DC")]
  public void SetPoolSizeByItemSize(Vector2 itemSize)
  {
  }

  [Token(Token = "0x60011DE")]
  [Address(RVA = "0x27D95FC", Offset = "0x27D95FC", VA = "0x27D95FC")]
  public VerticalGridInfiniteScrollView()
  {
  }
}

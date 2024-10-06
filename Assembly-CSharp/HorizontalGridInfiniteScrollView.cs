// Decompiled with JetBrains decompiler
// Type: HorizontalGridInfiniteScrollView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D1")]
public class HorizontalGridInfiniteScrollView : InfiniteScrollView
{
  [Token(Token = "0x400106B")]
  [FieldOffset(Offset = "0x90")]
  [SerializeField]
  protected RectOffset m_Padding;
  [Token(Token = "0x400106C")]
  [FieldOffset(Offset = "0x98")]
  [SerializeField]
  protected Vector2 m_Spacing;
  [Token(Token = "0x400106D")]
  [FieldOffset(Offset = "0xA0")]
  public int rowCount;
  [Token(Token = "0x400106E")]
  [FieldOffset(Offset = "0xA4")]
  public bool isAtLeft;
  [Token(Token = "0x400106F")]
  [FieldOffset(Offset = "0xA5")]
  public bool isAtRight;
  [Token(Token = "0x4001070")]
  [FieldOffset(Offset = "0xA8")]
  private int prefabCount;

  [Token(Token = "0x170001BB")]
  public new Vector2 Spacing
  {
    [Token(Token = "0x6001196"), Address(RVA = "0x1BF3F54", Offset = "0x1BF3F54", VA = "0x1BF3F54")] get
    {
      return new Vector2();
    }
    [Token(Token = "0x6001197"), Address(RVA = "0x1BF3F5C", Offset = "0x1BF3F5C", VA = "0x1BF3F5C")] set
    {
    }
  }

  [Token(Token = "0x170001BC")]
  public RectOffset Padding
  {
    [Token(Token = "0x6001198"), Address(RVA = "0x1BF3F64", Offset = "0x1BF3F64", VA = "0x1BF3F64")] get
    {
      return (RectOffset) null;
    }
    [Token(Token = "0x6001199"), Address(RVA = "0x1BF3F6C", Offset = "0x1BF3F6C", VA = "0x1BF3F6C")] set
    {
    }
  }

  [Token(Token = "0x600119A")]
  [Address(RVA = "0x1BF3F74", Offset = "0x1BF3F74", VA = "0x1BF3F74", Slot = "18")]
  protected override void OnValueChanged(Vector2 normalizedPosition)
  {
  }

  [Token(Token = "0x600119B")]
  [Address(RVA = "0x1BF436C", Offset = "0x1BF436C", VA = "0x1BF436C")]
  public Vector2 CalcAnchoredPosition(int index) => new Vector2();

  [Token(Token = "0x600119C")]
  [Address(RVA = "0x1BF44CC", Offset = "0x1BF44CC", VA = "0x1BF44CC", Slot = "19")]
  public override sealed void Refresh()
  {
  }

  [Token(Token = "0x600119D")]
  [Address(RVA = "0x1BF476C", Offset = "0x1BF476C", VA = "0x1BF476C")]
  public int GetAnchoredPositionToItemIndex(out float normalizedOffset) => new int();

  [Token(Token = "0x600119E")]
  [Address(RVA = "0x1BF45C8", Offset = "0x1BF45C8", VA = "0x1BF45C8")]
  private void DoRefresh()
  {
  }

  [Token(Token = "0x600119F")]
  [Address(RVA = "0x1BF4560", Offset = "0x1BF4560", VA = "0x1BF4560")]
  private IEnumerator DelayToRefresh() => (IEnumerator) null;

  [Token(Token = "0x60011A0")]
  [Address(RVA = "0x1BF48D8", Offset = "0x1BF48D8", VA = "0x1BF48D8", Slot = "22")]
  public override void Snap(int index, float duration)
  {
  }

  [Token(Token = "0x60011A1")]
  [Address(RVA = "0x1BF4A74", Offset = "0x1BF4A74", VA = "0x1BF4A74")]
  public void SetPoolSizeByItemSize(Vector2 itemSize)
  {
  }

  [Token(Token = "0x60011A2")]
  [Address(RVA = "0x1BF4B9C", Offset = "0x1BF4B9C", VA = "0x1BF4B9C")]
  public void SetPadding(RectOffset rectOffset)
  {
  }

  [Token(Token = "0x60011A3")]
  [Address(RVA = "0x1BF4BA4", Offset = "0x1BF4BA4", VA = "0x1BF4BA4")]
  public void ScrollReSetting(
    SettingHorizontalInfiniteScrollViewProperty setting)
  {
  }

  [Token(Token = "0x60011A4")]
  [Address(RVA = "0x1BF4E18", Offset = "0x1BF4E18", VA = "0x1BF4E18")]
  public HorizontalGridInfiniteScrollView()
  {
  }
}

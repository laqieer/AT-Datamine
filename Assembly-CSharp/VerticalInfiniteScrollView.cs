// Decompiled with JetBrains decompiler
// Type: VerticalInfiniteScrollView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002DA")]
public class VerticalInfiniteScrollView : InfiniteScrollView
{
  [Token(Token = "0x400109B")]
  [FieldOffset(Offset = "0x89")]
  [Tooltip("Cell のX 座標をゼロクリアしない")]
  [SerializeField]
  private bool isLockXPosition;
  [Token(Token = "0x400109C")]
  [FieldOffset(Offset = "0x8A")]
  private bool isAtTop;
  [Token(Token = "0x400109D")]
  [FieldOffset(Offset = "0x8B")]
  private bool isAtBottom;

  [Token(Token = "0x60011E5")]
  [Address(RVA = "0x27D9720", Offset = "0x27D9720", VA = "0x27D9720", Slot = "17")]
  public override void Initialize()
  {
  }

  [Token(Token = "0x60011E6")]
  [Address(RVA = "0x27D973C", Offset = "0x27D973C", VA = "0x27D973C", Slot = "18")]
  protected override void OnValueChanged(Vector2 normalizedPosition)
  {
  }

  [Token(Token = "0x60011E7")]
  [Address(RVA = "0x27D9A24", Offset = "0x27D9A24", VA = "0x27D9A24", Slot = "19")]
  public override sealed void Refresh()
  {
  }

  [Token(Token = "0x60011E8")]
  [Address(RVA = "0x27D9B20", Offset = "0x27D9B20", VA = "0x27D9B20")]
  private void DoRefresh()
  {
  }

  [Token(Token = "0x60011E9")]
  [Address(RVA = "0x27D9AB8", Offset = "0x27D9AB8", VA = "0x27D9AB8")]
  private IEnumerator DelayToRefresh() => (IEnumerator) null;

  [Token(Token = "0x60011EA")]
  [Address(RVA = "0x27D9CA8", Offset = "0x27D9CA8", VA = "0x27D9CA8", Slot = "22")]
  public override void Snap(int index, float duration)
  {
  }

  [Token(Token = "0x60011EB")]
  [Address(RVA = "0x27D9E98", Offset = "0x27D9E98", VA = "0x27D9E98", Slot = "21")]
  public override void Remove(int index)
  {
  }

  [Token(Token = "0x60011EC")]
  [Address(RVA = "0x27D9F3C", Offset = "0x27D9F3C", VA = "0x27D9F3C")]
  public VerticalInfiniteScrollView()
  {
  }
}

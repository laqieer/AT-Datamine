// Decompiled with JetBrains decompiler
// Type: UI.Scroll.HVScrollRectChild
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace UI.Scroll
{
  [Token(Token = "0x20008AC")]
  [AddComponentMenu("UI/Scroll/HVScrollRect - Child")]
  public class HVScrollRectChild : CommonScrollRect
  {
    [Token(Token = "0x40028B5")]
    [FieldOffset(Offset = "0x138")]
    private ScrollRect parentScroll;
    [Token(Token = "0x40028B6")]
    [FieldOffset(Offset = "0x140")]
    private Vector2 startPosition;
    [Token(Token = "0x40028B7")]
    [FieldOffset(Offset = "0x148")]
    private HVScrollRectChild.ScrollMode parentMode;
    [Token(Token = "0x40028B8")]
    [FieldOffset(Offset = "0x14C")]
    private HVScrollRectChild.ScrollMode nowMode;

    [Token(Token = "0x6003154")]
    [Address(RVA = "0x3C16918", Offset = "0x3C16918", VA = "0x3C16918", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6003155")]
    [Address(RVA = "0x3C169D8", Offset = "0x3C169D8", VA = "0x3C169D8", Slot = "43")]
    public override void OnInitializePotentialDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6003156")]
    [Address(RVA = "0x3C169F8", Offset = "0x3C169F8", VA = "0x3C169F8", Slot = "46")]
    public override void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6003157")]
    [Address(RVA = "0x3C16AF4", Offset = "0x3C16AF4", VA = "0x3C16AF4", Slot = "45")]
    public override void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6003158")]
    [Address(RVA = "0x3C16B44", Offset = "0x3C16B44", VA = "0x3C16B44")]
    public HVScrollRectChild()
    {
    }

    [Token(Token = "0x20008AD")]
    private enum ScrollMode
    {
      [Token(Token = "0x40028BA")] Unknown = -1, // 0xFFFFFFFF
      [Token(Token = "0x40028BB")] None = 0,
      [Token(Token = "0x40028BC")] Horizontal = 1,
      [Token(Token = "0x40028BD")] Vertical = 2,
    }
  }
}

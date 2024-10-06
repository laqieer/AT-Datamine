// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.FreeMapUICanvas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI
{
  [Token(Token = "0x20015F7")]
  public class FreeMapUICanvas
  {
    [Token(Token = "0x4006429")]
    [FieldOffset(Offset = "0x18")]
    private Vector3[] canvasCorner;
    [Token(Token = "0x400642A")]
    [FieldOffset(Offset = "0x20")]
    private Rect canvasWorldRect;
    [Token(Token = "0x400642C")]
    [FieldOffset(Offset = "0x38")]
    private Vector3[] worldCornerBuffer;

    [Token(Token = "0x17001323")]
    public RectTransform CanvasRectTransform
    {
      [Token(Token = "0x6007C4B"), Address(RVA = "0x21A0590", Offset = "0x21A0590", VA = "0x21A0590")] get
      {
        return (RectTransform) null;
      }
      [Token(Token = "0x6007C4C"), Address(RVA = "0x21A0598", Offset = "0x21A0598", VA = "0x21A0598")] private set
      {
      }
    }

    [Token(Token = "0x17001324")]
    public Canvas RenderCanvas
    {
      [Token(Token = "0x6007C4D"), Address(RVA = "0x21A05A0", Offset = "0x21A05A0", VA = "0x21A05A0")] get
      {
        return (Canvas) null;
      }
      [Token(Token = "0x6007C4E"), Address(RVA = "0x21A05A8", Offset = "0x21A05A8", VA = "0x21A05A8")] private set
      {
      }
    }

    [Token(Token = "0x6007C4F")]
    [Address(RVA = "0x21A05B0", Offset = "0x21A05B0", VA = "0x21A05B0")]
    public FreeMapUICanvas(RectTransform canvasRectTransform)
    {
    }

    [Token(Token = "0x6007C50")]
    [Address(RVA = "0x21A06B0", Offset = "0x21A06B0", VA = "0x21A06B0")]
    public bool TryGetDirection(RectTransform target, out FreeMapUIDirection direction)
    {
      return new bool();
    }

    [Token(Token = "0x6007C51")]
    [Address(RVA = "0x21A0834", Offset = "0x21A0834", VA = "0x21A0834")]
    public FreeMapUIDirection CalculateDirection(RectTransform target) => new FreeMapUIDirection();
  }
}

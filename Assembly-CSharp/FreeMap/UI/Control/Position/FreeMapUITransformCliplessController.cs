// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.FreeMapUITransformCliplessController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016AB")]
  public class FreeMapUITransformCliplessController : IFreeMapUIPositionController
  {
    [Token(Token = "0x40065AB")]
    [FieldOffset(Offset = "0x10")]
    protected RectTransform uiPrefabRectTransform;
    [Token(Token = "0x40065AC")]
    [FieldOffset(Offset = "0x18")]
    protected FreeMapUITransformHolder uiHolder;

    [Token(Token = "0x170013E1")]
    public FreeMapUIDirection CurrentDirection
    {
      [Token(Token = "0x600804B"), Address(RVA = "0x41F22F0", Offset = "0x41F22F0", VA = "0x41F22F0", Slot = "4")] get
      {
        return new FreeMapUIDirection();
      }
    }

    [Token(Token = "0x170013E2")]
    public RectTransform OverlapRectTransform
    {
      [Token(Token = "0x600804C"), Address(RVA = "0x41F22F8", Offset = "0x41F22F8", VA = "0x41F22F8", Slot = "6")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x170013E3")]
    public RectTransform ControlRectTransform
    {
      [Token(Token = "0x600804D"), Address(RVA = "0x41F2300", Offset = "0x41F2300", VA = "0x41F2300", Slot = "7")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x600804E")]
    [Address(RVA = "0x41F2308", Offset = "0x41F2308", VA = "0x41F2308")]
    public FreeMapUITransformCliplessController(
      GameObject uiPrefab,
      FreeMapUITransformHolder uiHolder)
    {
    }

    [Token(Token = "0x600804F")]
    [Address(RVA = "0x41F23D0", Offset = "0x41F23D0", VA = "0x41F23D0", Slot = "5")]
    public void UpdateRectTransform(
      Camera usingCamera,
      Canvas renderCanvas,
      RectTransform canvasRectTransform,
      UITransformAvoidHandler avoidHandler)
    {
    }

    [Token(Token = "0x6008050")]
    [Address(RVA = "0x41F2688", Offset = "0x41F2688", VA = "0x41F2688", Slot = "9")]
    public void DirectionUpdate(FreeMapUICanvas uiCanvas)
    {
    }

    [Token(Token = "0x6008051")]
    [Address(RVA = "0x41F268C", Offset = "0x41F268C", VA = "0x41F268C", Slot = "8")]
    public bool CheckOverlaps(
      RectTransform canvasRectTransform,
      UITransformAvoidHandler avoidHandler)
    {
      return new bool();
    }

    [Token(Token = "0x6008052")]
    [Address(RVA = "0x41F2694", Offset = "0x41F2694", VA = "0x41F2694", Slot = "10")]
    public void AvoidedDirectionUpdate(FreeMapUICanvas uiCanvas)
    {
    }

    [Token(Token = "0x6008053")]
    [Address(RVA = "0x41F2698", Offset = "0x41F2698", VA = "0x41F2698", Slot = "11")]
    public void SetDirection(FreeMapUIDirection direction)
    {
    }
  }
}

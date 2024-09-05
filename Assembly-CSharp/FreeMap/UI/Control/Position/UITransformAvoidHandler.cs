// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.UITransformAvoidHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016B3")]
  public class UITransformAvoidHandler
  {
    [Token(Token = "0x40065BB")]
    [FieldOffset(Offset = "0x10")]
    private List<UITransfromAvoidElementBase> avoidRectElementList;
    [Token(Token = "0x40065BC")]
    [FieldOffset(Offset = "0x18")]
    private List<UITransformIconAvoidElementContainer> iconAvoidElementList;

    [Token(Token = "0x6008073")]
    [Address(RVA = "0x41F3768", Offset = "0x41F3768", VA = "0x41F3768")]
    public void RegistAvoidRectTransform(List<UITransfromAvoidElementBase> list)
    {
    }

    [Token(Token = "0x6008074")]
    [Address(RVA = "0x41F3914", Offset = "0x41F3914", VA = "0x41F3914")]
    public void RegistIconAvoidHandler(IEnumerable<FreeMapUIBase> uiList)
    {
    }

    [Token(Token = "0x6008075")]
    [Address(RVA = "0x41F3BEC", Offset = "0x41F3BEC", VA = "0x41F3BEC")]
    public void RegistIconAvoidHandler(FreeMapUIBase icon)
    {
    }

    [Token(Token = "0x6008076")]
    [Address(RVA = "0x41F3EA4", Offset = "0x41F3EA4", VA = "0x41F3EA4")]
    public void RemoveIconAvoidHandler(FreeMapUIBase removeIcon)
    {
    }

    [Token(Token = "0x6008077")]
    [Address(RVA = "0x41F3FDC", Offset = "0x41F3FDC", VA = "0x41F3FDC")]
    public void ResetIconAvoidHandler()
    {
    }

    [Token(Token = "0x6008078")]
    [Address(RVA = "0x41F404C", Offset = "0x41F404C", VA = "0x41F404C")]
    public void Update()
    {
    }

    [Token(Token = "0x6008079")]
    [Address(RVA = "0x41F32F4", Offset = "0x41F32F4", VA = "0x41F32F4")]
    public bool CheckOverlaps(
      RectTransform parentRectTransform,
      Rect targetRect,
      RectTransform canvasRectTransform,
      out FreeMapUIDirection direction)
    {
      return new bool();
    }

    [Token(Token = "0x600807A")]
    [Address(RVA = "0x41F43BC", Offset = "0x41F43BC", VA = "0x41F43BC")]
    public UITransformAvoidHandler()
    {
    }
  }
}

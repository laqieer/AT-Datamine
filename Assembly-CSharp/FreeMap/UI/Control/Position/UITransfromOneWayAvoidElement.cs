// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.UITransfromOneWayAvoidElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016B7")]
  public class UITransfromOneWayAvoidElement : UITransfromAvoidElementBase
  {
    [Token(Token = "0x40065C7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private FreeMapUIRectDirection oneWayAvoidDirection;

    [Token(Token = "0x600808D")]
    [Address(RVA = "0x41F53D8", Offset = "0x41F53D8", VA = "0x41F53D8", Slot = "4")]
    public override void CalcAvoidPosition(
      RectTransform parentRectTransform,
      Rect targetRect,
      RectTransform canvasRectTransform,
      out FreeMapUIDirection direction)
    {
    }

    [Token(Token = "0x600808E")]
    [Address(RVA = "0x41F55B0", Offset = "0x41F55B0", VA = "0x41F55B0")]
    public UITransfromOneWayAvoidElement()
    {
    }
  }
}

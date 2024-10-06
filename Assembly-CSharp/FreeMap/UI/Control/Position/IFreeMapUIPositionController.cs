// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.IFreeMapUIPositionController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016AC")]
  public interface IFreeMapUIPositionController
  {
    [Token(Token = "0x170013E4")]
    FreeMapUIDirection CurrentDirection { [Token(Token = "0x6008054")] get; }

    [Token(Token = "0x6008055")]
    void UpdateRectTransform(
      Camera usingCamera,
      Canvas renderCanvas,
      RectTransform canvasRectTransform,
      UITransformAvoidHandler avoidHandler);

    [Token(Token = "0x170013E5")]
    RectTransform OverlapRectTransform { [Token(Token = "0x6008056")] get; }

    [Token(Token = "0x170013E6")]
    RectTransform ControlRectTransform { [Token(Token = "0x6008057")] get; }

    [Token(Token = "0x6008058")]
    bool CheckOverlaps(RectTransform canvasRectTransform, UITransformAvoidHandler avoidHandler);

    [Token(Token = "0x6008059")]
    void DirectionUpdate(FreeMapUICanvas uiCanvas);

    [Token(Token = "0x600805A")]
    void AvoidedDirectionUpdate(FreeMapUICanvas uiCanvas);

    [Token(Token = "0x600805B")]
    void SetDirection(FreeMapUIDirection direction);
  }
}

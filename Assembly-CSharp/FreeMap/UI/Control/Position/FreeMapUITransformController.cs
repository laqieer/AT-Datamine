// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.FreeMapUITransformController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using FreeMap.UI.Control.Animation;
using FreeMap.UI.Entity;
using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016AD")]
  public class FreeMapUITransformController : IFreeMapUIPositionController
  {
    [Token(Token = "0x40065AD")]
    [FieldOffset(Offset = "0x10")]
    private FreeMapUIBase owner;
    [Token(Token = "0x40065AF")]
    [FieldOffset(Offset = "0x20")]
    protected RectTransform prefabRectTransform;
    [Token(Token = "0x40065B0")]
    [FieldOffset(Offset = "0x28")]
    protected FreeMapUITransformHolder uiHolder;
    [Token(Token = "0x40065B2")]
    [FieldOffset(Offset = "0x38")]
    private Vector3 originOverlapRectLocalPosition;

    [Token(Token = "0x170013E7")]
    public FreeMapUIDirection CurrentDirection
    {
      [Token(Token = "0x600805C"), Address(RVA = "0x41F269C", Offset = "0x41F269C", VA = "0x41F269C", Slot = "4")] get
      {
        return new FreeMapUIDirection();
      }
      [Token(Token = "0x600805D"), Address(RVA = "0x41F26A4", Offset = "0x41F26A4", VA = "0x41F26A4")] private set
      {
      }
    }

    [Token(Token = "0x170013E8")]
    public RectTransform OverlapRectTransform
    {
      [Token(Token = "0x600805E"), Address(RVA = "0x41F26AC", Offset = "0x41F26AC", VA = "0x41F26AC", Slot = "6")] get
      {
        return (RectTransform) null;
      }
      [Token(Token = "0x600805F"), Address(RVA = "0x41F26B4", Offset = "0x41F26B4", VA = "0x41F26B4")] private set
      {
      }
    }

    [Token(Token = "0x170013E9")]
    public RectTransform ControlRectTransform
    {
      [Token(Token = "0x6008060"), Address(RVA = "0x41F26BC", Offset = "0x41F26BC", VA = "0x41F26BC", Slot = "7")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x6008061")]
    [Address(RVA = "0x41F26C4", Offset = "0x41F26C4", VA = "0x41F26C4")]
    public FreeMapUITransformController(
      FreeMapUIBase owner,
      GameObject iconPrefab,
      FreeMapUITransformHolder iconHolder,
      string iconRectTransformName)
    {
    }

    [Token(Token = "0x6008062")]
    [Address(RVA = "0x41F2830", Offset = "0x41F2830", VA = "0x41F2830", Slot = "5")]
    public void UpdateRectTransform(
      Camera usingCamera,
      Canvas renderCanvas,
      RectTransform canvasRectTransform,
      UITransformAvoidHandler avoidHandler)
    {
    }

    [Token(Token = "0x6008063")]
    [Address(RVA = "0x41F3090", Offset = "0x41F3090", VA = "0x41F3090", Slot = "8")]
    public bool CheckOverlaps(
      RectTransform canvasRectTransform,
      UITransformAvoidHandler avoidHandler)
    {
      return new bool();
    }

    [Token(Token = "0x6008064")]
    [Address(RVA = "0x41F34C8", Offset = "0x41F34C8", VA = "0x41F34C8", Slot = "11")]
    public void SetDirection(FreeMapUIDirection direction)
    {
    }

    [Token(Token = "0x6008065")]
    [Address(RVA = "0x41F34D0", Offset = "0x41F34D0", VA = "0x41F34D0", Slot = "9")]
    public void DirectionUpdate(FreeMapUICanvas uiCanvas)
    {
    }

    [Token(Token = "0x6008066")]
    [Address(RVA = "0x41F3500", Offset = "0x41F3500", VA = "0x41F3500", Slot = "10")]
    public void AvoidedDirectionUpdate(FreeMapUICanvas uiCanvas)
    {
    }
  }
}

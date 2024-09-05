// Decompiled with JetBrains decompiler
// Type: FreeMap.UI.Control.Position.UITransformControllUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace FreeMap.UI.Control.Position
{
  [Token(Token = "0x20016B0")]
  public static class UITransformControllUtility
  {
    [Token(Token = "0x40065B9")]
    [FieldOffset(Offset = "0x0")]
    private static Vector3[] cornerBuffer;

    [Token(Token = "0x6008069")]
    [Address(RVA = "0x41F24FC", Offset = "0x41F24FC", VA = "0x41F24FC")]
    public static Vector3 WorldToScreenPoint(Camera usingCamera, Vector3 positionInWorldS)
    {
      return new Vector3();
    }

    [Token(Token = "0x600806A")]
    [Address(RVA = "0x41F2BB0", Offset = "0x41F2BB0", VA = "0x41F2BB0")]
    public static Vector2 FixInnerRectTransform(
      Camera canvasCamera,
      RectTransform canvasRectTransform,
      Vector2 screenPosition)
    {
      return new Vector2();
    }

    [Token(Token = "0x600806B")]
    [Address(RVA = "0x41F35CC", Offset = "0x41F35CC", VA = "0x41F35CC")]
    public static bool IsCrossingVector2(
      Vector2 vectorStartA,
      Vector2 vectorEndA,
      Vector2 vectorStartB,
      Vector2 vectorEndB,
      out Vector2 intersection)
    {
      return new bool();
    }

    [Token(Token = "0x600806C")]
    [Address(RVA = "0x41F3074", Offset = "0x41F3074", VA = "0x41F3074")]
    public static float ReapInRange(float currentRange, float min, float max) => new float();

    [Token(Token = "0x600806D")]
    [Address(RVA = "0x41F3230", Offset = "0x41F3230", VA = "0x41F3230")]
    public static Rect GetWorldRect(RectTransform target) => new Rect();

    [Token(Token = "0x600806E")]
    [Address(RVA = "0x41F36F0", Offset = "0x41F36F0", VA = "0x41F36F0")]
    static UITransformControllUtility()
    {
    }
  }
}

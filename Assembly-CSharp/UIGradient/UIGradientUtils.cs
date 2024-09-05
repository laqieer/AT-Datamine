// Decompiled with JetBrains decompiler
// Type: UIGradient.UIGradientUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace UIGradient
{
  [Token(Token = "0x2000373")]
  public static class UIGradientUtils
  {
    [Token(Token = "0x400143C")]
    [FieldOffset(Offset = "0x0")]
    private static Vector2[] ms_verticesPositions;

    [Token(Token = "0x60013D1")]
    [Address(RVA = "0x286E650", Offset = "0x286E650", VA = "0x286E650")]
    public static UIGradientUtils.Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir)
    {
      return new UIGradientUtils.Matrix2x3();
    }

    [Token(Token = "0x170001EE")]
    public static Vector2[] VerticePositions
    {
      [Token(Token = "0x60013D2"), Address(RVA = "0x286EE54", Offset = "0x286EE54", VA = "0x286EE54")] get
      {
        return (Vector2[]) null;
      }
    }

    [Token(Token = "0x60013D3")]
    [Address(RVA = "0x286ED14", Offset = "0x286ED14", VA = "0x286ED14")]
    public static Vector2 RotationDir(float angle) => new Vector2();

    [Token(Token = "0x60013D4")]
    [Address(RVA = "0x286ED3C", Offset = "0x286ED3C", VA = "0x286ED3C")]
    public static Vector2 CompensateAspectRatio(Rect rect, Vector2 dir) => new Vector2();

    [Token(Token = "0x60013D5")]
    [Address(RVA = "0x286EEAC", Offset = "0x286EEAC", VA = "0x286EEAC")]
    public static float InverseLerp(float a, float b, float v) => new float();

    [Token(Token = "0x60013D6")]
    [Address(RVA = "0x286E734", Offset = "0x286E734", VA = "0x286E734")]
    public static Color Bilerp(Color a1, Color a2, Color b1, Color b2, Vector2 t) => new Color();

    [Token(Token = "0x60013D7")]
    [Address(RVA = "0x286EECC", Offset = "0x286EECC", VA = "0x286EECC")]
    public static void Lerp(UIVertex a, UIVertex b, float t, ref UIVertex c)
    {
    }

    [Token(Token = "0x60013D8")]
    [Address(RVA = "0x286F098", Offset = "0x286F098", VA = "0x286F098")]
    static UIGradientUtils()
    {
    }

    [Token(Token = "0x2000374")]
    public struct Matrix2x3
    {
      [Token(Token = "0x400143D")]
      [FieldOffset(Offset = "0x0")]
      public float m00;
      [Token(Token = "0x400143E")]
      [FieldOffset(Offset = "0x4")]
      public float m01;
      [Token(Token = "0x400143F")]
      [FieldOffset(Offset = "0x8")]
      public float m02;
      [Token(Token = "0x4001440")]
      [FieldOffset(Offset = "0xC")]
      public float m10;
      [Token(Token = "0x4001441")]
      [FieldOffset(Offset = "0x10")]
      public float m11;
      [Token(Token = "0x4001442")]
      [FieldOffset(Offset = "0x14")]
      public float m12;

      [Token(Token = "0x60013D9")]
      [Address(RVA = "0x286EE44", Offset = "0x286EE44", VA = "0x286EE44")]
      public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12)
      {
      }

      [Token(Token = "0x60013DA")]
      [Address(RVA = "0x286E704", Offset = "0x286E704", VA = "0x286E704")]
      public static Vector2 operator *(UIGradientUtils.Matrix2x3 m, Vector2 v) => new Vector2();
    }
  }
}

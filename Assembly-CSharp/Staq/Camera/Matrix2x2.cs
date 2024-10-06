// Decompiled with JetBrains decompiler
// Type: staq.Camera.Matrix2x2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace staq.Camera
{
  [Token(Token = "0x2003D64")]
  public struct Matrix2x2
  {
    [Token(Token = "0x4010DC3")]
    [FieldOffset(Offset = "0x0")]
    public float m00;
    [Token(Token = "0x4010DC4")]
    [FieldOffset(Offset = "0x4")]
    public float m01;
    [Token(Token = "0x4010DC5")]
    [FieldOffset(Offset = "0x8")]
    public float m10;
    [Token(Token = "0x4010DC6")]
    [FieldOffset(Offset = "0xC")]
    public float m11;

    [Token(Token = "0x6018B37")]
    [Address(RVA = "0x2643068", Offset = "0x2643068", VA = "0x2643068", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x6018B38")]
    [Address(RVA = "0x2643148", Offset = "0x2643148", VA = "0x2643148", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6018B39")]
    [Address(RVA = "0x26431AC", Offset = "0x26431AC", VA = "0x26431AC")]
    public bool Equals(Matrix2x2 other) => new bool();

    [Token(Token = "0x6018B3A")]
    [Address(RVA = "0x26431E8", Offset = "0x26431E8", VA = "0x26431E8")]
    public static Matrix2x2 Scale(float scaler) => new Matrix2x2();

    [Token(Token = "0x6018B3B")]
    [Address(RVA = "0x26431F8", Offset = "0x26431F8", VA = "0x26431F8")]
    public static Matrix2x2 Translate(float scaler) => new Matrix2x2();

    [Token(Token = "0x6018B3C")]
    [Address(RVA = "0x264320C", Offset = "0x264320C", VA = "0x264320C")]
    public static Vector2 operator *(Matrix2x2 lhs, Vector2 vector) => new Vector2();

    [Token(Token = "0x6018B3D")]
    [Address(RVA = "0x2643228", Offset = "0x2643228", VA = "0x2643228")]
    public static Matrix2x2 operator *(Matrix2x2 l, Matrix2x2 r) => new Matrix2x2();

    [Token(Token = "0x6018B3E")]
    [Address(RVA = "0x2643120", Offset = "0x2643120", VA = "0x2643120")]
    public static bool operator ==(Matrix2x2 lhs, Matrix2x2 rhs) => new bool();

    [Token(Token = "0x6018B3F")]
    [Address(RVA = "0x264325C", Offset = "0x264325C", VA = "0x264325C")]
    public static bool operator !=(Matrix2x2 lhs, Matrix2x2 rhs) => new bool();
  }
}

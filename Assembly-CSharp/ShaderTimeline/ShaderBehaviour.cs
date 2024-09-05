// Decompiled with JetBrains decompiler
// Type: ShaderTimeline.ShaderBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace ShaderTimeline
{
  [Token(Token = "0x200076A")]
  [Serializable]
  public class ShaderBehaviour : PlayableBehaviour
  {
    [Token(Token = "0x40021E1")]
    [FieldOffset(Offset = "0x10")]
    public string objectName;
    [Token(Token = "0x40021E2")]
    [FieldOffset(Offset = "0x18")]
    public string propertyName;
    [Token(Token = "0x40021E3")]
    [FieldOffset(Offset = "0x20")]
    public AnimationCurve animationCurve;
    [Token(Token = "0x40021E4")]
    [FieldOffset(Offset = "0x28")]
    public bool isEndReset;
    [Token(Token = "0x40021E5")]
    [FieldOffset(Offset = "0x2C")]
    public ShaderBehaviour.PropertyType propertyType;
    [Token(Token = "0x40021E6")]
    [FieldOffset(Offset = "0x30")]
    public int startInt;
    [Token(Token = "0x40021E7")]
    [FieldOffset(Offset = "0x34")]
    public int endInt;
    [Token(Token = "0x40021E8")]
    [FieldOffset(Offset = "0x38")]
    public float startFloat;
    [Token(Token = "0x40021E9")]
    [FieldOffset(Offset = "0x3C")]
    public float endFloat;
    [Token(Token = "0x40021EA")]
    [FieldOffset(Offset = "0x40")]
    public Color startColor;
    [Token(Token = "0x40021EB")]
    [FieldOffset(Offset = "0x50")]
    public Color endColor;
    [Token(Token = "0x40021EC")]
    [FieldOffset(Offset = "0x60")]
    public Vector4 startVector;
    [Token(Token = "0x40021ED")]
    [FieldOffset(Offset = "0x70")]
    public Vector4 endVector;

    [Token(Token = "0x6002978")]
    [Address(RVA = "0x3680D7C", Offset = "0x3680D7C", VA = "0x3680D7C")]
    public ShaderBehaviour()
    {
    }

    [Token(Token = "0x200076B")]
    public enum PropertyType
    {
      [Token(Token = "0x40021EF")] Int,
      [Token(Token = "0x40021F0")] Float,
      [Token(Token = "0x40021F1")] Color,
      [Token(Token = "0x40021F2")] Vector4,
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: CustomVignette
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000322")]
[VolumeComponentMenu("Staq Post-processing/CustomVignette")]
[Serializable]
public class CustomVignette : VolumeComponent
{
  [Token(Token = "0x40012A7")]
  [FieldOffset(Offset = "0x30")]
  public ColorParameter Color;
  [Token(Token = "0x40012A8")]
  [FieldOffset(Offset = "0x38")]
  public Vector4Parameter DrawCorner;
  [Token(Token = "0x40012A9")]
  [FieldOffset(Offset = "0x40")]
  public Vector2Parameter Center;
  [Token(Token = "0x40012AA")]
  [FieldOffset(Offset = "0x48")]
  public MinFloatParameter Intensity;
  [Token(Token = "0x40012AB")]
  [FieldOffset(Offset = "0x50")]
  public ClampedFloatParameter Smoothness;
  [Token(Token = "0x40012AC")]
  [FieldOffset(Offset = "0x58")]
  public BoolParameter Roundness;
  [Token(Token = "0x40012AD")]
  [FieldOffset(Offset = "0x60")]
  public IntParameter BlendMode;

  [Token(Token = "0x60012C1")]
  [Address(RVA = "0x285DA38", Offset = "0x285DA38", VA = "0x285DA38")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012C2")]
  [Address(RVA = "0x285DAB0", Offset = "0x285DAB0", VA = "0x285DAB0")]
  public CustomVignette()
  {
  }

  [Token(Token = "0x2000323")]
  public enum CustomVignetteBlendMode
  {
    [Token(Token = "0x40012AF")] Blend,
    [Token(Token = "0x40012B0")] Add,
    [Token(Token = "0x40012B1")] Mul,
    [Token(Token = "0x40012B2")] Sub,
  }
}

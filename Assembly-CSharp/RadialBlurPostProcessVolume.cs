// Decompiled with JetBrains decompiler
// Type: RadialBlurPostProcessVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000197")]
[VolumeComponentMenu("Staq Post-processing/Radial Blur Effect")]
[Serializable]
public class RadialBlurPostProcessVolume : VolumeComponent
{
  [Token(Token = "0x4000A50")]
  [FieldOffset(Offset = "0x30")]
  [Tooltip("Blur center.")]
  public Vector2Parameter center;
  [Token(Token = "0x4000A51")]
  [FieldOffset(Offset = "0x38")]
  [Tooltip("Blur radius.")]
  public ClampedFloatParameter radius;
  [Token(Token = "0x4000A52")]
  [FieldOffset(Offset = "0x40")]
  [Tooltip("Iteration count.")]
  public ClampedIntParameter iterationCount;
  [Token(Token = "0x4000A53")]
  [FieldOffset(Offset = "0x48")]
  [Tooltip("Additional render target.")]
  public TextureParameter outputRT;

  [Token(Token = "0x6000AD4")]
  [Address(RVA = "0x4BBBF54", Offset = "0x4BBBF54", VA = "0x4BBBF54")]
  public bool IsActive() => new bool();

  [Token(Token = "0x6000AD5")]
  [Address(RVA = "0x4BBBFD8", Offset = "0x4BBBFD8", VA = "0x4BBBFD8")]
  public RadialBlurPostProcessVolume()
  {
  }
}

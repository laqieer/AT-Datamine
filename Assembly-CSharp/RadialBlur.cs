// Decompiled with JetBrains decompiler
// Type: RadialBlur
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

#nullable disable
[Token(Token = "0x2000191")]
[PostProcess(typeof (RadialBlurRenderer), PostProcessEvent.AfterStack, "Custom/RadialBlur", true)]
[Serializable]
public sealed class RadialBlur : PostProcessEffectSettings
{
  [Token(Token = "0x4000A37")]
  [FieldOffset(Offset = "0x30")]
  [Tooltip("Blur center.")]
  public Vector2Parameter center;
  [Token(Token = "0x4000A38")]
  [FieldOffset(Offset = "0x38")]
  [Range(0.0f, 0.05f)]
  [Tooltip("Blur radius.")]
  public FloatParameter radius;
  [Token(Token = "0x4000A39")]
  [FieldOffset(Offset = "0x40")]
  [Range(0.0f, 20f)]
  [Tooltip("Iteration count.")]
  public IntParameter iterationCount;
  [Token(Token = "0x4000A3A")]
  [FieldOffset(Offset = "0x48")]
  [Tooltip("Additional render target.")]
  public TextureParameter outputRT;

  [Token(Token = "0x6000AC4")]
  [Address(RVA = "0x4BBABD0", Offset = "0x4BBABD0", VA = "0x4BBABD0")]
  public RadialBlur()
  {
  }
}

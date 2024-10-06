// Decompiled with JetBrains decompiler
// Type: DiffusionVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002EE")]
[ExecuteInEditMode]
public class DiffusionVolumeComponentController : BaseVolumeComponentController<Diffusion>
{
  [Token(Token = "0x400112A")]
  [FieldOffset(Offset = "0x29")]
  public bool intensityOverrideState;
  [Token(Token = "0x400112B")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 1f)]
  public float Intensity;
  [Token(Token = "0x400112C")]
  [FieldOffset(Offset = "0x30")]
  public bool contrastOverrideState;
  [Token(Token = "0x400112D")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 20f)]
  public float Contrast;
  [Token(Token = "0x400112E")]
  [FieldOffset(Offset = "0x38")]
  public bool blurIntensityOverrideState;
  [Token(Token = "0x400112F")]
  [FieldOffset(Offset = "0x3C")]
  [Range(10f, 1000f)]
  public float BlurIntensity;
  [Token(Token = "0x4001130")]
  [FieldOffset(Offset = "0x40")]
  public bool diffusionMaskOverrideState;
  [Token(Token = "0x4001131")]
  [FieldOffset(Offset = "0x48")]
  public Texture2D DiffusionMask;

  [Token(Token = "0x6001233")]
  [Address(RVA = "0x27DDE9C", Offset = "0x27DDE9C", VA = "0x27DDE9C", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001234")]
  [Address(RVA = "0x27DDFF8", Offset = "0x27DDFF8", VA = "0x27DDFF8")]
  public DiffusionVolumeComponentController()
  {
  }
}

// Decompiled with JetBrains decompiler
// Type: DepthOfFieldVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002ED")]
[ExecuteInEditMode]
public class DepthOfFieldVolumeComponentController : BaseVolumeComponentController<DepthOfField>
{
  [Token(Token = "0x4001114")]
  [FieldOffset(Offset = "0x29")]
  public bool modeOverrideState;
  [Token(Token = "0x4001115")]
  [FieldOffset(Offset = "0x2C")]
  public DepthOfFieldMode mode;
  [Token(Token = "0x4001116")]
  [FieldOffset(Offset = "0x30")]
  public bool gaussianStartOverrideState;
  [Token(Token = "0x4001117")]
  [FieldOffset(Offset = "0x34")]
  [Min(0.0f)]
  public float gaussianStart;
  [Token(Token = "0x4001118")]
  [FieldOffset(Offset = "0x38")]
  public bool gaussianEndOverrideState;
  [Token(Token = "0x4001119")]
  [FieldOffset(Offset = "0x3C")]
  [Min(0.0f)]
  public float gaussianEnd;
  [Token(Token = "0x400111A")]
  [FieldOffset(Offset = "0x40")]
  public bool gaussianMaxRadiusOverrideState;
  [Token(Token = "0x400111B")]
  [FieldOffset(Offset = "0x44")]
  [Range(0.5f, 1.5f)]
  public float gaussianMaxRadius;
  [Token(Token = "0x400111C")]
  [FieldOffset(Offset = "0x48")]
  public bool highQualitySamplingOverrideState;
  [Token(Token = "0x400111D")]
  [FieldOffset(Offset = "0x49")]
  public bool highQualitySampling;
  [Token(Token = "0x400111E")]
  [FieldOffset(Offset = "0x4A")]
  public bool focusDistanceOverrideState;
  [Token(Token = "0x400111F")]
  [FieldOffset(Offset = "0x4C")]
  [Min(0.1f)]
  public float focusDistance;
  [Token(Token = "0x4001120")]
  [FieldOffset(Offset = "0x50")]
  public bool focalLengthOverrideState;
  [Token(Token = "0x4001121")]
  [FieldOffset(Offset = "0x54")]
  [Range(1f, 300f)]
  public float focalLength;
  [Token(Token = "0x4001122")]
  [FieldOffset(Offset = "0x58")]
  public bool apertureOverrideState;
  [Token(Token = "0x4001123")]
  [FieldOffset(Offset = "0x5C")]
  [Range(1f, 32f)]
  public float aperture;
  [Token(Token = "0x4001124")]
  [FieldOffset(Offset = "0x60")]
  public bool bladeCountOverrideState;
  [Token(Token = "0x4001125")]
  [FieldOffset(Offset = "0x64")]
  [Range(3f, 9f)]
  public int bladeCount;
  [Token(Token = "0x4001126")]
  [FieldOffset(Offset = "0x68")]
  public bool bladeCurvatureOverrideState;
  [Token(Token = "0x4001127")]
  [FieldOffset(Offset = "0x6C")]
  [Range(0.0f, 1f)]
  public float bladeCurvature;
  [Token(Token = "0x4001128")]
  [FieldOffset(Offset = "0x70")]
  public bool bladeRotationOverrideState;
  [Token(Token = "0x4001129")]
  [FieldOffset(Offset = "0x74")]
  [Range(-180f, 180f)]
  public float bladeRotation;

  [Token(Token = "0x6001231")]
  [Address(RVA = "0x27DDAE0", Offset = "0x27DDAE0", VA = "0x27DDAE0", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001232")]
  [Address(RVA = "0x27DDE18", Offset = "0x27DDE18", VA = "0x27DDE18")]
  public DepthOfFieldVolumeComponentController()
  {
  }
}

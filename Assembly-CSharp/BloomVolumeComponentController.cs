// Decompiled with JetBrains decompiler
// Type: BloomVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002E5")]
[ExecuteInEditMode]
public class BloomVolumeComponentController : BaseVolumeComponentController<Bloom>
{
  [Token(Token = "0x40010BE")]
  [FieldOffset(Offset = "0x29")]
  public bool thresholdOverrideState;
  [Token(Token = "0x40010BF")]
  [FieldOffset(Offset = "0x2C")]
  [Min(0.0f)]
  public float threshold;
  [Token(Token = "0x40010C0")]
  [FieldOffset(Offset = "0x30")]
  public bool intensityOverrideState;
  [Token(Token = "0x40010C1")]
  [FieldOffset(Offset = "0x34")]
  [Min(0.0f)]
  public float intensity;
  [Token(Token = "0x40010C2")]
  [FieldOffset(Offset = "0x38")]
  public bool scatterOverrideState;
  [Token(Token = "0x40010C3")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 1f)]
  public float scatter;
  [Token(Token = "0x40010C4")]
  [FieldOffset(Offset = "0x40")]
  public bool clampOverrideState;
  [Token(Token = "0x40010C5")]
  [FieldOffset(Offset = "0x44")]
  [Min(0.0f)]
  public float clamp;
  [Token(Token = "0x40010C6")]
  [FieldOffset(Offset = "0x48")]
  public bool tintOverrideState;
  [Token(Token = "0x40010C7")]
  [FieldOffset(Offset = "0x4C")]
  [ColorUsage(false, false)]
  public Color tint;
  [Token(Token = "0x40010C8")]
  [FieldOffset(Offset = "0x5C")]
  public bool highQualityFilteringOverrideState;
  [Token(Token = "0x40010C9")]
  [FieldOffset(Offset = "0x5D")]
  public bool highQualityFiltering;
  [Token(Token = "0x40010CA")]
  [FieldOffset(Offset = "0x5E")]
  public bool skipIterationsOverrideState;
  [Token(Token = "0x40010CB")]
  [FieldOffset(Offset = "0x60")]
  [Range(0.0f, 16f)]
  public int skipIterations;
  [Token(Token = "0x40010CC")]
  [FieldOffset(Offset = "0x64")]
  public bool dirtTextureOverrideState;
  [Token(Token = "0x40010CD")]
  [FieldOffset(Offset = "0x68")]
  public Texture dirtTexture;
  [Token(Token = "0x40010CE")]
  [FieldOffset(Offset = "0x70")]
  public bool dirtIntensityOverrideState;
  [Token(Token = "0x40010CF")]
  [FieldOffset(Offset = "0x74")]
  [Min(0.0f)]
  public float dirtIntensity;

  [Token(Token = "0x6001221")]
  [Address(RVA = "0x27DC9D8", Offset = "0x27DC9D8", VA = "0x27DC9D8", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001222")]
  [Address(RVA = "0x27DCC8C", Offset = "0x27DCC8C", VA = "0x27DCC8C")]
  public BloomVolumeComponentController()
  {
  }
}

// Decompiled with JetBrains decompiler
// Type: LensDistortionVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002F1")]
[ExecuteInEditMode]
public class LensDistortionVolumeComponentController : BaseVolumeComponentController<LensDistortion>
{
  [Token(Token = "0x400114A")]
  [FieldOffset(Offset = "0x29")]
  public bool intensityOverrideState;
  [Token(Token = "0x400114B")]
  [FieldOffset(Offset = "0x2C")]
  [Range(-1f, 1f)]
  public float intensity;
  [Token(Token = "0x400114C")]
  [FieldOffset(Offset = "0x30")]
  public bool xMultiplierOverrideState;
  [Token(Token = "0x400114D")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 1f)]
  public float xMultiplier;
  [Token(Token = "0x400114E")]
  [FieldOffset(Offset = "0x38")]
  public bool yMultiplierOverrideState;
  [Token(Token = "0x400114F")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 1f)]
  public float yMultiplier;
  [Token(Token = "0x4001150")]
  [FieldOffset(Offset = "0x40")]
  public bool centerOverrideState;
  [Token(Token = "0x4001151")]
  [FieldOffset(Offset = "0x44")]
  public Vector2 center;
  [Token(Token = "0x4001152")]
  [FieldOffset(Offset = "0x4C")]
  public bool scaleOverrideState;
  [Token(Token = "0x4001153")]
  [FieldOffset(Offset = "0x50")]
  [Range(0.01f, 5f)]
  public float scale;

  [Token(Token = "0x6001239")]
  [Address(RVA = "0x27DE4CC", Offset = "0x27DE4CC", VA = "0x27DE4CC", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600123A")]
  [Address(RVA = "0x27DE66C", Offset = "0x27DE66C", VA = "0x27DE66C")]
  public LensDistortionVolumeComponentController()
  {
  }
}

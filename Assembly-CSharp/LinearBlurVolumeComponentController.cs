// Decompiled with JetBrains decompiler
// Type: LinearBlurVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002F3")]
[ExecuteInEditMode]
public class LinearBlurVolumeComponentController : BaseVolumeComponentController<LinearBlur>
{
  [Token(Token = "0x400115A")]
  [FieldOffset(Offset = "0x29")]
  public bool intensityOverrideState;
  [Token(Token = "0x400115B")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 10f)]
  public float intensity;
  [Token(Token = "0x400115C")]
  [FieldOffset(Offset = "0x30")]
  public bool directionOverrideState;
  [Token(Token = "0x400115D")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 360f)]
  public float direction;
  [Token(Token = "0x400115E")]
  [FieldOffset(Offset = "0x38")]
  public bool frequencyOverrideState;
  [Token(Token = "0x400115F")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 100f)]
  public float frequency;
  [Token(Token = "0x4001160")]
  [FieldOffset(Offset = "0x40")]
  public bool densityOverrideState;
  [Token(Token = "0x4001161")]
  [FieldOffset(Offset = "0x44")]
  [Range(0.0f, 1f)]
  public float density;

  [Token(Token = "0x600123D")]
  [Address(RVA = "0x27DE84C", Offset = "0x27DE84C", VA = "0x27DE84C", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600123E")]
  [Address(RVA = "0x27DE9A8", Offset = "0x27DE9A8", VA = "0x27DE9A8")]
  public LinearBlurVolumeComponentController()
  {
  }
}

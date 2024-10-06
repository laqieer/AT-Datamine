// Decompiled with JetBrains decompiler
// Type: MotionBlurVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002F4")]
[ExecuteInEditMode]
public class MotionBlurVolumeComponentController : BaseVolumeComponentController<MotionBlur>
{
  [Token(Token = "0x4001162")]
  [FieldOffset(Offset = "0x29")]
  public bool qualityOverrideState;
  [Token(Token = "0x4001163")]
  [FieldOffset(Offset = "0x2C")]
  public MotionBlurQuality quality;
  [Token(Token = "0x4001164")]
  [FieldOffset(Offset = "0x30")]
  public bool intensityOverrideState;
  [Token(Token = "0x4001165")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 1f)]
  public float intensity;
  [Token(Token = "0x4001166")]
  [FieldOffset(Offset = "0x38")]
  public bool clampOverrideState;
  [Token(Token = "0x4001167")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 0.2f)]
  public float clamp;

  [Token(Token = "0x600123F")]
  [Address(RVA = "0x27DEA00", Offset = "0x27DEA00", VA = "0x27DEA00", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001240")]
  [Address(RVA = "0x27DEB18", Offset = "0x27DEB18", VA = "0x27DEB18")]
  public MotionBlurVolumeComponentController()
  {
  }
}

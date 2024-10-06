// Decompiled with JetBrains decompiler
// Type: ColorAdjustmentsVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002E8")]
[ExecuteInEditMode]
public class ColorAdjustmentsVolumeComponentController : 
  BaseVolumeComponentController<ColorAdjustments>
{
  [Token(Token = "0x40010E4")]
  [FieldOffset(Offset = "0x29")]
  public bool postExposureOverrideState;
  [Token(Token = "0x40010E5")]
  [FieldOffset(Offset = "0x2C")]
  public float postExposure;
  [Token(Token = "0x40010E6")]
  [FieldOffset(Offset = "0x30")]
  public bool contrastOverrideState;
  [Token(Token = "0x40010E7")]
  [FieldOffset(Offset = "0x34")]
  [Range(-100f, 100f)]
  public float contrast;
  [Token(Token = "0x40010E8")]
  [FieldOffset(Offset = "0x38")]
  public bool colorFilterOverrideState;
  [Token(Token = "0x40010E9")]
  [FieldOffset(Offset = "0x3C")]
  [ColorUsage(false, true)]
  public Color colorFilter;
  [Token(Token = "0x40010EA")]
  [FieldOffset(Offset = "0x4C")]
  public bool hueShiftOverrideState;
  [Token(Token = "0x40010EB")]
  [FieldOffset(Offset = "0x50")]
  [Range(-180f, 180f)]
  public float hueShift;
  [Token(Token = "0x40010EC")]
  [FieldOffset(Offset = "0x54")]
  public bool saturationOverrideState;
  [Token(Token = "0x40010ED")]
  [FieldOffset(Offset = "0x58")]
  [Range(-100f, 100f)]
  public float saturation;

  [Token(Token = "0x6001227")]
  [Address(RVA = "0x27DD0E8", Offset = "0x27DD0E8", VA = "0x27DD0E8", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001228")]
  [Address(RVA = "0x27DD28C", Offset = "0x27DD28C", VA = "0x27DD28C")]
  public ColorAdjustmentsVolumeComponentController()
  {
  }
}

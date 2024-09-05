// Decompiled with JetBrains decompiler
// Type: VignetteVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002FE")]
[ExecuteInEditMode]
public class VignetteVolumeComponentController : BaseVolumeComponentController<Vignette>
{
  [Token(Token = "0x40011B4")]
  [FieldOffset(Offset = "0x29")]
  public bool colorOverrideState;
  [Token(Token = "0x40011B5")]
  [FieldOffset(Offset = "0x2C")]
  [ColorUsage(false, false)]
  public Color color;
  [Token(Token = "0x40011B6")]
  [FieldOffset(Offset = "0x3C")]
  public bool centerOverrideState;
  [Token(Token = "0x40011B7")]
  [FieldOffset(Offset = "0x40")]
  public Vector2 center;
  [Token(Token = "0x40011B8")]
  [FieldOffset(Offset = "0x48")]
  public bool intensityOverrideState;
  [Token(Token = "0x40011B9")]
  [FieldOffset(Offset = "0x4C")]
  [Range(0.0f, 1f)]
  public float intensity;
  [Token(Token = "0x40011BA")]
  [FieldOffset(Offset = "0x50")]
  public bool smoothnessOverrideState;
  [Token(Token = "0x40011BB")]
  [FieldOffset(Offset = "0x54")]
  [Range(0.01f, 1f)]
  public float smoothness;
  [Token(Token = "0x40011BC")]
  [FieldOffset(Offset = "0x58")]
  public bool roundedOverrideState;
  [Token(Token = "0x40011BD")]
  [FieldOffset(Offset = "0x59")]
  public bool rounded;

  [Token(Token = "0x6001253")]
  [Address(RVA = "0x27DFC08", Offset = "0x27DFC08", VA = "0x27DFC08", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001254")]
  [Address(RVA = "0x27DFDAC", Offset = "0x27DFDAC", VA = "0x27DFDAC")]
  public VignetteVolumeComponentController()
  {
  }
}

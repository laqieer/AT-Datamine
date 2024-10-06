// Decompiled with JetBrains decompiler
// Type: RadialBlurVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002F6")]
[ExecuteInEditMode]
public class RadialBlurVolumeComponentController : 
  BaseVolumeComponentController<RadialBlurPostProcessVolume>
{
  [Token(Token = "0x400116C")]
  [FieldOffset(Offset = "0x29")]
  public bool centerOverrideState;
  [Token(Token = "0x400116D")]
  [FieldOffset(Offset = "0x2C")]
  public Vector2 center;
  [Token(Token = "0x400116E")]
  [FieldOffset(Offset = "0x34")]
  public bool radiusOverrideState;
  [Token(Token = "0x400116F")]
  [FieldOffset(Offset = "0x38")]
  [Range(0.0f, 0.05f)]
  public float radius;
  [Token(Token = "0x4001170")]
  [FieldOffset(Offset = "0x3C")]
  public bool iterationCountOverrideState;
  [Token(Token = "0x4001171")]
  [FieldOffset(Offset = "0x40")]
  [Range(0.0f, 20f)]
  public int iterationCount;

  [Token(Token = "0x6001243")]
  [Address(RVA = "0x27DEC90", Offset = "0x27DEC90", VA = "0x27DEC90", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001244")]
  [Address(RVA = "0x27DEDA8", Offset = "0x27DEDA8", VA = "0x27DEDA8")]
  public RadialBlurVolumeComponentController()
  {
  }
}

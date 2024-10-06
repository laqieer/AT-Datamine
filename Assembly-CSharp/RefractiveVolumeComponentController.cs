// Decompiled with JetBrains decompiler
// Type: RefractiveVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002F7")]
[ExecuteInEditMode]
public class RefractiveVolumeComponentController : BaseVolumeComponentController<Refractive>
{
  [Token(Token = "0x4001172")]
  [FieldOffset(Offset = "0x29")]
  public bool mainTexOverrideState;
  [Token(Token = "0x4001173")]
  [FieldOffset(Offset = "0x30")]
  public Texture mainTex;
  [Token(Token = "0x4001174")]
  [FieldOffset(Offset = "0x38")]
  public bool tilingOverrideState;
  [Token(Token = "0x4001175")]
  [FieldOffset(Offset = "0x3C")]
  public Vector2 tiling;
  [Token(Token = "0x4001176")]
  [FieldOffset(Offset = "0x44")]
  public bool offsetOverrideState;
  [Token(Token = "0x4001177")]
  [FieldOffset(Offset = "0x48")]
  public Vector2 offset;
  [Token(Token = "0x4001178")]
  [FieldOffset(Offset = "0x50")]
  public bool bumpScaleOverrideState;
  [Token(Token = "0x4001179")]
  [FieldOffset(Offset = "0x54")]
  public float bumpScale;
  [Token(Token = "0x400117A")]
  [FieldOffset(Offset = "0x58")]
  public bool useUVScrollOverrideState;
  [Token(Token = "0x400117B")]
  [FieldOffset(Offset = "0x59")]
  public bool useUVScroll;
  [Token(Token = "0x400117C")]
  [FieldOffset(Offset = "0x5A")]
  public bool useUVRotationOverrideState;
  [Token(Token = "0x400117D")]
  [FieldOffset(Offset = "0x5B")]
  public bool useUVRotation;
  [Token(Token = "0x400117E")]
  [FieldOffset(Offset = "0x5C")]
  public bool useAgePercentOverrideState;
  [Token(Token = "0x400117F")]
  [FieldOffset(Offset = "0x5D")]
  public bool useAgePercent;
  [Token(Token = "0x4001180")]
  [FieldOffset(Offset = "0x5E")]
  public bool agePercentOverrideState;
  [Token(Token = "0x4001181")]
  [FieldOffset(Offset = "0x60")]
  public float agePercent;
  [Token(Token = "0x4001182")]
  [FieldOffset(Offset = "0x64")]
  public bool uvSpeedOverrideState;
  [Token(Token = "0x4001183")]
  [FieldOffset(Offset = "0x68")]
  public Vector3 uvSpeed;

  [Token(Token = "0x6001245")]
  [Address(RVA = "0x27DEDF8", Offset = "0x27DEDF8", VA = "0x27DEDF8", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001246")]
  [Address(RVA = "0x27DF0AC", Offset = "0x27DF0AC", VA = "0x27DF0AC")]
  public RefractiveVolumeComponentController()
  {
  }
}

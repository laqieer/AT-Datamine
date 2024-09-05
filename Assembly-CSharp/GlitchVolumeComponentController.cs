// Decompiled with JetBrains decompiler
// Type: GlitchVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002F0")]
[ExecuteInEditMode]
public class GlitchVolumeComponentController : BaseVolumeComponentController<Glitch>
{
  [Token(Token = "0x400113A")]
  [FieldOffset(Offset = "0x29")]
  public bool linesOverrideState;
  [Token(Token = "0x400113B")]
  [FieldOffset(Offset = "0x2C")]
  [Range(1f, 4f)]
  public int lines;
  [Token(Token = "0x400113C")]
  [FieldOffset(Offset = "0x30")]
  public bool rotationOverrideState;
  [Token(Token = "0x400113D")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 360f)]
  public float rotation;
  [Token(Token = "0x400113E")]
  [FieldOffset(Offset = "0x38")]
  public bool offsetOverrideState;
  [Token(Token = "0x400113F")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 1f)]
  public float offset;
  [Token(Token = "0x4001140")]
  [FieldOffset(Offset = "0x40")]
  public bool thicknessOverrideState;
  [Token(Token = "0x4001141")]
  [FieldOffset(Offset = "0x44")]
  [Range(0.0f, 1f)]
  public float thickness;
  [Token(Token = "0x4001142")]
  [FieldOffset(Offset = "0x48")]
  public bool useColorOverrideState;
  [Token(Token = "0x4001143")]
  [FieldOffset(Offset = "0x49")]
  public bool useColor;
  [Token(Token = "0x4001144")]
  [FieldOffset(Offset = "0x4A")]
  public bool useAgePercentOverrideState;
  [Token(Token = "0x4001145")]
  [FieldOffset(Offset = "0x4B")]
  public bool useAgePercent;
  [Token(Token = "0x4001146")]
  [FieldOffset(Offset = "0x4C")]
  public bool agePercentOverrideState;
  [Token(Token = "0x4001147")]
  [FieldOffset(Offset = "0x50")]
  public float agePercent;
  [Token(Token = "0x4001148")]
  [FieldOffset(Offset = "0x54")]
  public bool speedOverrideState;
  [Token(Token = "0x4001149")]
  [FieldOffset(Offset = "0x58")]
  public float speed;

  [Token(Token = "0x6001237")]
  [Address(RVA = "0x27DE200", Offset = "0x27DE200", VA = "0x27DE200", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001238")]
  [Address(RVA = "0x27DE46C", Offset = "0x27DE46C", VA = "0x27DE46C")]
  public GlitchVolumeComponentController()
  {
  }
}

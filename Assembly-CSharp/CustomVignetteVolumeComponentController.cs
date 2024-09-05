// Decompiled with JetBrains decompiler
// Type: CustomVignetteVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002EC")]
[ExecuteInEditMode]
public class CustomVignetteVolumeComponentController : BaseVolumeComponentController<CustomVignette>
{
  [Token(Token = "0x4001106")]
  [FieldOffset(Offset = "0x29")]
  public bool colorOverrideState;
  [Token(Token = "0x4001107")]
  [FieldOffset(Offset = "0x2C")]
  public Color Color;
  [Token(Token = "0x4001108")]
  [FieldOffset(Offset = "0x3C")]
  public bool drawCornerOverrideState;
  [Token(Token = "0x4001109")]
  [FieldOffset(Offset = "0x40")]
  public Vector4 DrawCorner;
  [Token(Token = "0x400110A")]
  [FieldOffset(Offset = "0x50")]
  public bool modeOverrideCenter;
  [Token(Token = "0x400110B")]
  [FieldOffset(Offset = "0x54")]
  public Vector2 Center;
  [Token(Token = "0x400110C")]
  [FieldOffset(Offset = "0x5C")]
  public bool intensityOverrideState;
  [Token(Token = "0x400110D")]
  [FieldOffset(Offset = "0x60")]
  [Min(0.0f)]
  public float Intensity;
  [Token(Token = "0x400110E")]
  [FieldOffset(Offset = "0x64")]
  public bool smoothnessOverrideState;
  [Token(Token = "0x400110F")]
  [FieldOffset(Offset = "0x68")]
  [Range(0.001f, 1f)]
  public float Smoothness;
  [Token(Token = "0x4001110")]
  [FieldOffset(Offset = "0x6C")]
  public bool roundnessOverrideState;
  [Token(Token = "0x4001111")]
  [FieldOffset(Offset = "0x6D")]
  public bool Roundness;
  [Token(Token = "0x4001112")]
  [FieldOffset(Offset = "0x6E")]
  public bool blendModeOverrideState;
  [Token(Token = "0x4001113")]
  [FieldOffset(Offset = "0x70")]
  [Range(0.0f, 3f)]
  public int BlendMode;

  [Token(Token = "0x600122F")]
  [Address(RVA = "0x27DD814", Offset = "0x27DD814", VA = "0x27DD814", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001230")]
  [Address(RVA = "0x27DDA44", Offset = "0x27DDA44", VA = "0x27DDA44")]
  public CustomVignetteVolumeComponentController()
  {
  }
}

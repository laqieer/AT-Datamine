// Decompiled with JetBrains decompiler
// Type: ColorFrameVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002EA")]
[ExecuteInEditMode]
public class ColorFrameVolumeComponentController : BaseVolumeComponentController<ColorFrame>
{
  [Token(Token = "0x40010F6")]
  [FieldOffset(Offset = "0x29")]
  public bool frameColorOverrideState;
  [Token(Token = "0x40010F7")]
  [FieldOffset(Offset = "0x2C")]
  public Color FrameColor;
  [Token(Token = "0x40010F8")]
  [FieldOffset(Offset = "0x3C")]
  public bool drawEdgeOverrideState;
  [Token(Token = "0x40010F9")]
  [FieldOffset(Offset = "0x40")]
  public Vector4 DrawEdge;
  [Token(Token = "0x40010FA")]
  [FieldOffset(Offset = "0x50")]
  public bool widthOverrideState;
  [Token(Token = "0x40010FB")]
  [FieldOffset(Offset = "0x54")]
  [Range(0.0f, 1334f)]
  public float Width;
  [Token(Token = "0x40010FC")]
  [FieldOffset(Offset = "0x58")]
  public bool heightOverrideState;
  [Token(Token = "0x40010FD")]
  [FieldOffset(Offset = "0x5C")]
  [Range(0.0f, 750f)]
  public float Height;
  [Token(Token = "0x40010FE")]
  [FieldOffset(Offset = "0x60")]
  public bool smoothnessOverrideState;
  [Token(Token = "0x40010FF")]
  [FieldOffset(Offset = "0x64")]
  [Range(0.001f, 1f)]
  public float Smoothness;
  [Token(Token = "0x4001100")]
  [FieldOffset(Offset = "0x68")]
  public bool blendModeOverrideState;
  [Token(Token = "0x4001101")]
  [FieldOffset(Offset = "0x6C")]
  [Range(0.0f, 3f)]
  public int BlendMode;

  [Token(Token = "0x600122B")]
  [Address(RVA = "0x27DD470", Offset = "0x27DD470", VA = "0x27DD470", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600122C")]
  [Address(RVA = "0x27DD65C", Offset = "0x27DD65C", VA = "0x27DD65C")]
  public ColorFrameVolumeComponentController()
  {
  }
}

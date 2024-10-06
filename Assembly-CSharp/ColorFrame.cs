// Decompiled with JetBrains decompiler
// Type: ColorFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000320")]
[VolumeComponentMenu("Staq Post-processing/ColorFrame")]
[Serializable]
public class ColorFrame : VolumeComponent
{
  [Token(Token = "0x400129C")]
  [FieldOffset(Offset = "0x30")]
  public ColorParameter FrameColor;
  [Token(Token = "0x400129D")]
  [FieldOffset(Offset = "0x38")]
  public Vector4Parameter DrawEdge;
  [Token(Token = "0x400129E")]
  [FieldOffset(Offset = "0x40")]
  public ClampedFloatParameter Width;
  [Token(Token = "0x400129F")]
  [FieldOffset(Offset = "0x48")]
  public ClampedFloatParameter Height;
  [Token(Token = "0x40012A0")]
  [FieldOffset(Offset = "0x50")]
  public ClampedFloatParameter Smoothness;
  [Token(Token = "0x40012A1")]
  [FieldOffset(Offset = "0x58")]
  public IntParameter BlendMode;

  [Token(Token = "0x60012BF")]
  [Address(RVA = "0x285D7C0", Offset = "0x285D7C0", VA = "0x285D7C0")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012C0")]
  [Address(RVA = "0x285D854", Offset = "0x285D854", VA = "0x285D854")]
  public ColorFrame()
  {
  }

  [Token(Token = "0x2000321")]
  public enum ColorFrameBlendMode
  {
    [Token(Token = "0x40012A3")] Blend,
    [Token(Token = "0x40012A4")] Add,
    [Token(Token = "0x40012A5")] Mul,
    [Token(Token = "0x40012A6")] Sub,
  }
}

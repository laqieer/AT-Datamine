// Decompiled with JetBrains decompiler
// Type: LiftGammaGainVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002F2")]
[ExecuteInEditMode]
public class LiftGammaGainVolumeComponentController : BaseVolumeComponentController<LiftGammaGain>
{
  [Token(Token = "0x4001154")]
  [FieldOffset(Offset = "0x29")]
  public bool liftOverrideState;
  [Token(Token = "0x4001155")]
  [FieldOffset(Offset = "0x2C")]
  public Vector4 lift;
  [Token(Token = "0x4001156")]
  [FieldOffset(Offset = "0x3C")]
  public bool gammaOverrideState;
  [Token(Token = "0x4001157")]
  [FieldOffset(Offset = "0x40")]
  public Vector4 gamma;
  [Token(Token = "0x4001158")]
  [FieldOffset(Offset = "0x50")]
  public bool gainOverrideState;
  [Token(Token = "0x4001159")]
  [FieldOffset(Offset = "0x54")]
  public Vector4 gain;

  [Token(Token = "0x600123B")]
  [Address(RVA = "0x27DE6CC", Offset = "0x27DE6CC", VA = "0x27DE6CC", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600123C")]
  [Address(RVA = "0x27DE7F0", Offset = "0x27DE7F0", VA = "0x27DE7F0")]
  public LiftGammaGainVolumeComponentController()
  {
  }
}

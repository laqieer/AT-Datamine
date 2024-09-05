// Decompiled with JetBrains decompiler
// Type: ColorCurvesVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002E9")]
[ExecuteInEditMode]
public class ColorCurvesVolumeComponentController : BaseVolumeComponentController<ColorCurves>
{
  [Token(Token = "0x40010EE")]
  [FieldOffset(Offset = "0x29")]
  public bool masterOverrideState;
  [Token(Token = "0x40010EF")]
  [FieldOffset(Offset = "0x2A")]
  public bool redOverrideState;
  [Token(Token = "0x40010F0")]
  [FieldOffset(Offset = "0x2B")]
  public bool greenOverrideState;
  [Token(Token = "0x40010F1")]
  [FieldOffset(Offset = "0x2C")]
  public bool blueOverrideState;
  [Token(Token = "0x40010F2")]
  [FieldOffset(Offset = "0x2D")]
  public bool hueVsHueOverrideState;
  [Token(Token = "0x40010F3")]
  [FieldOffset(Offset = "0x2E")]
  public bool hueVsSatOverrideState;
  [Token(Token = "0x40010F4")]
  [FieldOffset(Offset = "0x2F")]
  public bool satVsSatOverrideState;
  [Token(Token = "0x40010F5")]
  [FieldOffset(Offset = "0x30")]
  public bool lumVsSatOverrideState;

  [Token(Token = "0x6001229")]
  [Address(RVA = "0x27DD2DC", Offset = "0x27DD2DC", VA = "0x27DD2DC", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600122A")]
  [Address(RVA = "0x27DD428", Offset = "0x27DD428", VA = "0x27DD428")]
  public ColorCurvesVolumeComponentController()
  {
  }
}

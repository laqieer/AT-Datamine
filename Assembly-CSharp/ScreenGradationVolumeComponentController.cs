// Decompiled with JetBrains decompiler
// Type: ScreenGradationVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002F8")]
[ExecuteInEditMode]
public class ScreenGradationVolumeComponentController : 
  BaseVolumeComponentController<ScreenGradation>
{
  [Token(Token = "0x4001184")]
  [FieldOffset(Offset = "0x29")]
  public bool checkScreenGradationOverrideState;
  [Token(Token = "0x4001185")]
  [FieldOffset(Offset = "0x2A")]
  public bool checkScreenGradation;
  [Token(Token = "0x4001186")]
  [FieldOffset(Offset = "0x2B")]
  public bool angleOverrideState;
  [Token(Token = "0x4001187")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 360f)]
  public float angle;
  [Token(Token = "0x4001188")]
  [FieldOffset(Offset = "0x30")]
  public bool offsetOverrideState;
  [Token(Token = "0x4001189")]
  [FieldOffset(Offset = "0x34")]
  [Range(-1f, 1f)]
  public float offset;
  [Token(Token = "0x400118A")]
  [FieldOffset(Offset = "0x38")]
  public bool thresholdOverrideState;
  [Token(Token = "0x400118B")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 2f)]
  public float threshold;
  [Token(Token = "0x400118C")]
  [FieldOffset(Offset = "0x40")]
  public bool intensityOverrideState;
  [Token(Token = "0x400118D")]
  [FieldOffset(Offset = "0x44")]
  [Range(0.0f, 1f)]
  public float intensity;
  [Token(Token = "0x400118E")]
  [FieldOffset(Offset = "0x48")]
  public bool colorAOverrideState;
  [Token(Token = "0x400118F")]
  [FieldOffset(Offset = "0x4C")]
  [ColorUsage(false, false)]
  public Color colorA;
  [Token(Token = "0x4001190")]
  [FieldOffset(Offset = "0x5C")]
  public bool colorBOverrideState;
  [Token(Token = "0x4001191")]
  [FieldOffset(Offset = "0x60")]
  [ColorUsage(false, false)]
  public Color colorB;

  [Token(Token = "0x6001247")]
  [Address(RVA = "0x27DF1A0", Offset = "0x27DF1A0", VA = "0x27DF1A0", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001248")]
  [Address(RVA = "0x27DF3D0", Offset = "0x27DF3D0", VA = "0x27DF3D0")]
  public ScreenGradationVolumeComponentController()
  {
  }
}

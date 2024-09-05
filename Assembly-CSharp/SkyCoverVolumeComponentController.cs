// Decompiled with JetBrains decompiler
// Type: SkyCoverVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002FA")]
[ExecuteInEditMode]
public class SkyCoverVolumeComponentController : BaseVolumeComponentController<SkyCover>
{
  [Token(Token = "0x40011A0")]
  [FieldOffset(Offset = "0x29")]
  public bool check_skyMaskOverrideState;
  [Token(Token = "0x40011A1")]
  [FieldOffset(Offset = "0x2A")]
  public bool check_skyMask;
  [Token(Token = "0x40011A2")]
  [FieldOffset(Offset = "0x2B")]
  public bool addOverrideState;
  [Token(Token = "0x40011A3")]
  [FieldOffset(Offset = "0x2C")]
  public bool add;
  [Token(Token = "0x40011A4")]
  [FieldOffset(Offset = "0x2D")]
  public bool boostOverrideState;
  [Token(Token = "0x40011A5")]
  [FieldOffset(Offset = "0x30")]
  [Range(0.0f, 2f)]
  public float boost;
  [Token(Token = "0x40011A6")]
  [FieldOffset(Offset = "0x34")]
  public bool blurSizeOverrideState;
  [Token(Token = "0x40011A7")]
  [FieldOffset(Offset = "0x38")]
  [Range(0.0f, 1f)]
  public float blurSize;
  [Token(Token = "0x40011A8")]
  [FieldOffset(Offset = "0x3C")]
  public bool depthSliderOverrideState;
  [Token(Token = "0x40011A9")]
  [FieldOffset(Offset = "0x40")]
  [Range(0.0f, 1f)]
  public float depthSlider;

  [Token(Token = "0x600124B")]
  [Address(RVA = "0x27DF6E4", Offset = "0x27DF6E4", VA = "0x27DF6E4", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600124C")]
  [Address(RVA = "0x27DF884", Offset = "0x27DF884", VA = "0x27DF884")]
  public SkyCoverVolumeComponentController()
  {
  }
}

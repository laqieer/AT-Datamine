// Decompiled with JetBrains decompiler
// Type: WhiteBalanceVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002FF")]
[ExecuteInEditMode]
public class WhiteBalanceVolumeComponentController : BaseVolumeComponentController<WhiteBalance>
{
  [Token(Token = "0x40011BE")]
  [FieldOffset(Offset = "0x29")]
  public bool temperatureOverrideState;
  [Token(Token = "0x40011BF")]
  [FieldOffset(Offset = "0x2C")]
  [Range(-100f, 100f)]
  public float temperature;
  [Token(Token = "0x40011C0")]
  [FieldOffset(Offset = "0x30")]
  public bool tintOverrideState;
  [Token(Token = "0x40011C1")]
  [FieldOffset(Offset = "0x34")]
  [Range(-100f, 100f)]
  public float tint;

  [Token(Token = "0x6001255")]
  [Address(RVA = "0x27DFE14", Offset = "0x27DFE14", VA = "0x27DFE14", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001256")]
  [Address(RVA = "0x27DFEE8", Offset = "0x27DFEE8", VA = "0x27DFEE8")]
  public WhiteBalanceVolumeComponentController()
  {
  }
}

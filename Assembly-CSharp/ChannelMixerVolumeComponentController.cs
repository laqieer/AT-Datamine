// Decompiled with JetBrains decompiler
// Type: ChannelMixerVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002E6")]
[ExecuteInEditMode]
public class ChannelMixerVolumeComponentController : BaseVolumeComponentController<ChannelMixer>
{
  [Token(Token = "0x40010D0")]
  [FieldOffset(Offset = "0x29")]
  public bool redOutRedInOverrideState;
  [Token(Token = "0x40010D1")]
  [FieldOffset(Offset = "0x2C")]
  [Range(-200f, 200f)]
  public float redOutRedIn;
  [Token(Token = "0x40010D2")]
  [FieldOffset(Offset = "0x30")]
  public bool redOutGreenInOverrideState;
  [Token(Token = "0x40010D3")]
  [FieldOffset(Offset = "0x34")]
  [Range(-200f, 200f)]
  public float redOutGreenIn;
  [Token(Token = "0x40010D4")]
  [FieldOffset(Offset = "0x38")]
  public bool redOutBlueInOverrideState;
  [Token(Token = "0x40010D5")]
  [FieldOffset(Offset = "0x3C")]
  [Range(-200f, 200f)]
  public float redOutBlueIn;
  [Token(Token = "0x40010D6")]
  [FieldOffset(Offset = "0x40")]
  public bool greenOutRedInOverrideState;
  [Token(Token = "0x40010D7")]
  [FieldOffset(Offset = "0x44")]
  [Range(-200f, 200f)]
  public float greenOutRedIn;
  [Token(Token = "0x40010D8")]
  [FieldOffset(Offset = "0x48")]
  public bool greenOutGreenInOverrideState;
  [Token(Token = "0x40010D9")]
  [FieldOffset(Offset = "0x4C")]
  [Range(-200f, 200f)]
  public float greenOutGreenIn;
  [Token(Token = "0x40010DA")]
  [FieldOffset(Offset = "0x50")]
  public bool greenOutBlueInOverrideState;
  [Token(Token = "0x40010DB")]
  [FieldOffset(Offset = "0x54")]
  [Range(-200f, 200f)]
  public float greenOutBlueIn;
  [Token(Token = "0x40010DC")]
  [FieldOffset(Offset = "0x58")]
  public bool blueOutRedInOverrideState;
  [Token(Token = "0x40010DD")]
  [FieldOffset(Offset = "0x5C")]
  [Range(-200f, 200f)]
  public float blueOutRedIn;
  [Token(Token = "0x40010DE")]
  [FieldOffset(Offset = "0x60")]
  public bool blueOutGreenInOverrideState;
  [Token(Token = "0x40010DF")]
  [FieldOffset(Offset = "0x64")]
  [Range(-200f, 200f)]
  public float blueOutGreenIn;
  [Token(Token = "0x40010E0")]
  [FieldOffset(Offset = "0x68")]
  public bool blueOutBlueInOverrideState;
  [Token(Token = "0x40010E1")]
  [FieldOffset(Offset = "0x6C")]
  [Range(-200f, 200f)]
  public float blueOutBlueIn;

  [Token(Token = "0x6001223")]
  [Address(RVA = "0x27DCD08", Offset = "0x27DCD08", VA = "0x27DCD08", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001224")]
  [Address(RVA = "0x27DCFB8", Offset = "0x27DCFB8", VA = "0x27DCFB8")]
  public ChannelMixerVolumeComponentController()
  {
  }
}

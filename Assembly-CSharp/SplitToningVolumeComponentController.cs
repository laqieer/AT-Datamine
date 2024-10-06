// Decompiled with JetBrains decompiler
// Type: SplitToningVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002FB")]
[ExecuteInEditMode]
public class SplitToningVolumeComponentController : BaseVolumeComponentController<SplitToning>
{
  [Token(Token = "0x40011AA")]
  [FieldOffset(Offset = "0x29")]
  public bool shadowsOverrideState;
  [Token(Token = "0x40011AB")]
  [FieldOffset(Offset = "0x2C")]
  [ColorUsage(false, false)]
  public Color shadows;
  [Token(Token = "0x40011AC")]
  [FieldOffset(Offset = "0x3C")]
  public bool highlightsOverrideState;
  [Token(Token = "0x40011AD")]
  [FieldOffset(Offset = "0x40")]
  [ColorUsage(false, false)]
  public Color highlights;
  [Token(Token = "0x40011AE")]
  [FieldOffset(Offset = "0x50")]
  public bool balanceOverrideState;
  [Token(Token = "0x40011AF")]
  [FieldOffset(Offset = "0x54")]
  [Range(-100f, 100f)]
  public float balance;

  [Token(Token = "0x600124D")]
  [Address(RVA = "0x27DF8E0", Offset = "0x27DF8E0", VA = "0x27DF8E0", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600124E")]
  [Address(RVA = "0x27DFA00", Offset = "0x27DFA00", VA = "0x27DFA00")]
  public SplitToningVolumeComponentController()
  {
  }
}

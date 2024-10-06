// Decompiled with JetBrains decompiler
// Type: TonemappingVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002FD")]
[ExecuteInEditMode]
public class TonemappingVolumeComponentController : BaseVolumeComponentController<Tonemapping>
{
  [Token(Token = "0x40011B2")]
  [FieldOffset(Offset = "0x29")]
  public bool modeOverrideState;
  [Token(Token = "0x40011B3")]
  [FieldOffset(Offset = "0x2C")]
  public TonemappingMode mode;

  [Token(Token = "0x6001251")]
  [Address(RVA = "0x27DFB30", Offset = "0x27DFB30", VA = "0x27DFB30", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001252")]
  [Address(RVA = "0x27DFBC0", Offset = "0x27DFBC0", VA = "0x27DFBC0")]
  public TonemappingVolumeComponentController()
  {
  }
}

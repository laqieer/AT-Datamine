// Decompiled with JetBrains decompiler
// Type: ChromaticAberrationVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002E7")]
[ExecuteInEditMode]
public class ChromaticAberrationVolumeComponentController : 
  BaseVolumeComponentController<ChromaticAberration>
{
  [Token(Token = "0x40010E2")]
  [FieldOffset(Offset = "0x29")]
  public bool intensityOverrideState;
  [Token(Token = "0x40010E3")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 1f)]
  public float intensity;

  [Token(Token = "0x6001225")]
  [Address(RVA = "0x27DD010", Offset = "0x27DD010", VA = "0x27DD010", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001226")]
  [Address(RVA = "0x27DD0A0", Offset = "0x27DD0A0", VA = "0x27DD0A0")]
  public ChromaticAberrationVolumeComponentController()
  {
  }
}

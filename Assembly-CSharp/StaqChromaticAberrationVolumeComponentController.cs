// Decompiled with JetBrains decompiler
// Type: StaqChromaticAberrationVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UniversalRenderPipeline.Volumes;

#nullable disable
[Token(Token = "0x20002FC")]
[ExecuteInEditMode]
public class StaqChromaticAberrationVolumeComponentController : 
  BaseVolumeComponentController<ChromaticAberrationVolume>
{
  [Token(Token = "0x40011B0")]
  [FieldOffset(Offset = "0x29")]
  public bool sizeOverrideState;
  [Token(Token = "0x40011B1")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 1f)]
  public float size;

  [Token(Token = "0x600124F")]
  [Address(RVA = "0x27DFA58", Offset = "0x27DFA58", VA = "0x27DFA58", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001250")]
  [Address(RVA = "0x27DFAE8", Offset = "0x27DFAE8", VA = "0x27DFAE8")]
  public StaqChromaticAberrationVolumeComponentController()
  {
  }
}

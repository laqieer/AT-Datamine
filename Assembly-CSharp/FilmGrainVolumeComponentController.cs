// Decompiled with JetBrains decompiler
// Type: FilmGrainVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002EF")]
[ExecuteInEditMode]
public class FilmGrainVolumeComponentController : BaseVolumeComponentController<FilmGrain>
{
  [Token(Token = "0x4001132")]
  [FieldOffset(Offset = "0x29")]
  public bool typeOverrideState;
  [Token(Token = "0x4001133")]
  [FieldOffset(Offset = "0x2C")]
  public FilmGrainLookup type;
  [Token(Token = "0x4001134")]
  [FieldOffset(Offset = "0x30")]
  public bool intensityOverrideState;
  [Token(Token = "0x4001135")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.0f, 1f)]
  public float intensity;
  [Token(Token = "0x4001136")]
  [FieldOffset(Offset = "0x38")]
  public bool responseOverrideState;
  [Token(Token = "0x4001137")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 1f)]
  public float response;
  [Token(Token = "0x4001138")]
  [FieldOffset(Offset = "0x40")]
  public bool textureOverrideState;
  [Token(Token = "0x4001139")]
  [FieldOffset(Offset = "0x48")]
  public Texture texture;

  [Token(Token = "0x6001235")]
  [Address(RVA = "0x27DE050", Offset = "0x27DE050", VA = "0x27DE050", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x6001236")]
  [Address(RVA = "0x27DE1AC", Offset = "0x27DE1AC", VA = "0x27DE1AC")]
  public FilmGrainVolumeComponentController()
  {
  }
}

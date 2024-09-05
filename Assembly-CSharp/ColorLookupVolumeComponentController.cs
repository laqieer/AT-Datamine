// Decompiled with JetBrains decompiler
// Type: ColorLookupVolumeComponentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
[Token(Token = "0x20002EB")]
[ExecuteInEditMode]
public class ColorLookupVolumeComponentController : BaseVolumeComponentController<ColorLookup>
{
  [Token(Token = "0x4001102")]
  [FieldOffset(Offset = "0x29")]
  public bool textureOverrideState;
  [Token(Token = "0x4001103")]
  [FieldOffset(Offset = "0x30")]
  public Texture texture;
  [Token(Token = "0x4001104")]
  [FieldOffset(Offset = "0x38")]
  public bool contributionOverrideState;
  [Token(Token = "0x4001105")]
  [FieldOffset(Offset = "0x3C")]
  [Range(0.0f, 1f)]
  public float contribution;

  [Token(Token = "0x600122D")]
  [Address(RVA = "0x27DD6F0", Offset = "0x27DD6F0", VA = "0x27DD6F0", Slot = "4")]
  public override void UpdateVolumeComponent()
  {
  }

  [Token(Token = "0x600122E")]
  [Address(RVA = "0x27DD7C4", Offset = "0x27DD7C4", VA = "0x27DD7C4")]
  public ColorLookupVolumeComponentController()
  {
  }
}

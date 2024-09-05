// Decompiled with JetBrains decompiler
// Type: Diffusion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000324")]
[VolumeComponentMenu("Staq Post-processing/Diffusion")]
[Serializable]
public class Diffusion : VolumeComponent
{
  [Token(Token = "0x40012B3")]
  [FieldOffset(Offset = "0x30")]
  public ClampedFloatParameter Intensity;
  [Token(Token = "0x40012B4")]
  [FieldOffset(Offset = "0x38")]
  public ClampedFloatParameter Contrast;
  [Token(Token = "0x40012B5")]
  [FieldOffset(Offset = "0x40")]
  public ClampedFloatParameter BlurIntensity;
  [Token(Token = "0x40012B6")]
  [FieldOffset(Offset = "0x48")]
  public TextureParameter DiffusionMask;
  [Token(Token = "0x40012B7")]
  [FieldOffset(Offset = "0x50")]
  private float _weightCreateBlur;
  [Token(Token = "0x40012B8")]
  [FieldOffset(Offset = "0x58")]
  private float[] _blurWeight;

  [Token(Token = "0x170001D6")]
  public float[] BlurWeights
  {
    [Token(Token = "0x60012C3"), Address(RVA = "0x285DCE4", Offset = "0x285DCE4", VA = "0x285DCE4")] get
    {
      return (float[]) null;
    }
  }

  [Token(Token = "0x170001D7")]
  public Texture DiffusuinMaskTexture
  {
    [Token(Token = "0x60012C4"), Address(RVA = "0x285DE18", Offset = "0x285DE18", VA = "0x285DE18")] get
    {
      return (Texture) null;
    }
  }

  [Token(Token = "0x60012C5")]
  [Address(RVA = "0x285DD24", Offset = "0x285DD24", VA = "0x285DD24")]
  private void UpdateWeight()
  {
  }

  [Token(Token = "0x60012C6")]
  [Address(RVA = "0x285DEBC", Offset = "0x285DEBC", VA = "0x285DEBC")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012C7")]
  [Address(RVA = "0x285DEF8", Offset = "0x285DEF8", VA = "0x285DEF8")]
  public Diffusion()
  {
  }
}

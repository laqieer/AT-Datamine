// Decompiled with JetBrains decompiler
// Type: SkyCover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x200032C")]
[VolumeComponentMenu("Staq Post-processing/SkyCover")]
[Serializable]
public class SkyCover : VolumeComponent
{
  [Token(Token = "0x40012E1")]
  [FieldOffset(Offset = "0x30")]
  public BoolParameter check_skyMask;
  [Token(Token = "0x40012E2")]
  [FieldOffset(Offset = "0x38")]
  public BoolParameter add;
  [Token(Token = "0x40012E3")]
  [FieldOffset(Offset = "0x40")]
  public ClampedFloatParameter boost;
  [Token(Token = "0x40012E4")]
  [FieldOffset(Offset = "0x48")]
  public ClampedFloatParameter blurSize;
  [Token(Token = "0x40012E5")]
  [FieldOffset(Offset = "0x50")]
  public ClampedFloatParameter depthSlider;

  [Token(Token = "0x60012D3")]
  [Address(RVA = "0x285EAD0", Offset = "0x285EAD0", VA = "0x285EAD0")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012D4")]
  [Address(RVA = "0x285EAFC", Offset = "0x285EAFC", VA = "0x285EAFC")]
  public SkyCover()
  {
  }
}

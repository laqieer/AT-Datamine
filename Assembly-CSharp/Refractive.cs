// Decompiled with JetBrains decompiler
// Type: Refractive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x200032A")]
[VolumeComponentMenu("Staq Post-processing/Refractive")]
[Serializable]
public class Refractive : VolumeComponent
{
  [Token(Token = "0x40012D1")]
  [FieldOffset(Offset = "0x30")]
  public TextureParameter mainTex;
  [Token(Token = "0x40012D2")]
  [FieldOffset(Offset = "0x38")]
  public NoInterpVector2Parameter tiling;
  [Token(Token = "0x40012D3")]
  [FieldOffset(Offset = "0x40")]
  public NoInterpVector2Parameter offset;
  [Token(Token = "0x40012D4")]
  [FieldOffset(Offset = "0x48")]
  public NoInterpFloatParameter bumpScale;
  [Token(Token = "0x40012D5")]
  [FieldOffset(Offset = "0x50")]
  public BoolParameter useUVScroll;
  [Token(Token = "0x40012D6")]
  [FieldOffset(Offset = "0x58")]
  public BoolParameter useUVRotation;
  [Token(Token = "0x40012D7")]
  [FieldOffset(Offset = "0x60")]
  public BoolParameter useAgePercent;
  [Token(Token = "0x40012D8")]
  [FieldOffset(Offset = "0x68")]
  public NoInterpFloatParameter agePercent;
  [Token(Token = "0x40012D9")]
  [FieldOffset(Offset = "0x70")]
  public NoInterpVector3Parameter uvSpeed;

  [Token(Token = "0x60012CF")]
  [Address(RVA = "0x285E5C4", Offset = "0x285E5C4", VA = "0x285E5C4")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012D0")]
  [Address(RVA = "0x285E640", Offset = "0x285E640", VA = "0x285E640")]
  public Refractive()
  {
  }
}

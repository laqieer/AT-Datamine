// Decompiled with JetBrains decompiler
// Type: Glare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000327")]
[VolumeComponentMenu("Staq Post-processing/Glare")]
[Serializable]
public class Glare : VolumeComponent
{
  [Token(Token = "0x40012BD")]
  [FieldOffset(Offset = "0x30")]
  public GlareQualityParameter quality;
  [Token(Token = "0x40012BE")]
  [FieldOffset(Offset = "0x38")]
  public BoolParameter crossing;
  [Token(Token = "0x40012BF")]
  [FieldOffset(Offset = "0x40")]
  public ClampedFloatParameter angle1;
  [Token(Token = "0x40012C0")]
  [FieldOffset(Offset = "0x48")]
  public ClampedFloatParameter angle2;
  [Token(Token = "0x40012C1")]
  [FieldOffset(Offset = "0x50")]
  public MinFloatParameter threshold;
  [Token(Token = "0x40012C2")]
  [FieldOffset(Offset = "0x58")]
  public MinFloatParameter intensity;
  [Token(Token = "0x40012C3")]
  [FieldOffset(Offset = "0x60")]
  public ClampedFloatParameter scatter;
  [Token(Token = "0x40012C4")]
  [FieldOffset(Offset = "0x68")]
  public MinFloatParameter clamp;

  [Token(Token = "0x60012C9")]
  [Address(RVA = "0x285E08C", Offset = "0x285E08C", VA = "0x285E08C")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012CA")]
  [Address(RVA = "0x285E0B8", Offset = "0x285E0B8", VA = "0x285E0B8")]
  public Glare()
  {
  }
}

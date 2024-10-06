// Decompiled with JetBrains decompiler
// Type: Glitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000328")]
[VolumeComponentMenu("Staq Post-processing/Glitch")]
[Serializable]
public class Glitch : VolumeComponent
{
  [Token(Token = "0x40012C5")]
  [FieldOffset(Offset = "0x30")]
  public NoInterpClampedIntParameter lines;
  [Token(Token = "0x40012C6")]
  [FieldOffset(Offset = "0x38")]
  public ClampedFloatParameter rotation;
  [Token(Token = "0x40012C7")]
  [FieldOffset(Offset = "0x40")]
  public ClampedFloatParameter offset;
  [Token(Token = "0x40012C8")]
  [FieldOffset(Offset = "0x48")]
  public ClampedFloatParameter thickness;
  [Token(Token = "0x40012C9")]
  [FieldOffset(Offset = "0x50")]
  public BoolParameter useColor;
  [Token(Token = "0x40012CA")]
  [FieldOffset(Offset = "0x58")]
  public BoolParameter useAgePercent;
  [Token(Token = "0x40012CB")]
  [FieldOffset(Offset = "0x60")]
  public NoInterpFloatParameter agePercent;
  [Token(Token = "0x40012CC")]
  [FieldOffset(Offset = "0x68")]
  public NoInterpFloatParameter speed;

  [Token(Token = "0x60012CB")]
  [Address(RVA = "0x285E298", Offset = "0x285E298", VA = "0x285E298")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012CC")]
  [Address(RVA = "0x285E2C4", Offset = "0x285E2C4", VA = "0x285E2C4")]
  public Glitch()
  {
  }
}

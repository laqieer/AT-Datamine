// Decompiled with JetBrains decompiler
// Type: ScreenGradation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x200032B")]
[VolumeComponentMenu("Staq Post-processing/ScreenGradation")]
[Serializable]
public class ScreenGradation : VolumeComponent
{
  [Token(Token = "0x40012DA")]
  [FieldOffset(Offset = "0x30")]
  public BoolParameter checkScreenGradation;
  [Token(Token = "0x40012DB")]
  [FieldOffset(Offset = "0x38")]
  public ClampedFloatParameter angle;
  [Token(Token = "0x40012DC")]
  [FieldOffset(Offset = "0x40")]
  public ClampedFloatParameter offset;
  [Token(Token = "0x40012DD")]
  [FieldOffset(Offset = "0x48")]
  public ClampedFloatParameter threshold;
  [Token(Token = "0x40012DE")]
  [FieldOffset(Offset = "0x50")]
  public ClampedFloatParameter intensity;
  [Token(Token = "0x40012DF")]
  [FieldOffset(Offset = "0x58")]
  public ColorParameter colorA;
  [Token(Token = "0x40012E0")]
  [FieldOffset(Offset = "0x60")]
  public ColorParameter colorB;

  [Token(Token = "0x60012D1")]
  [Address(RVA = "0x285E8E0", Offset = "0x285E8E0", VA = "0x285E8E0")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012D2")]
  [Address(RVA = "0x285E90C", Offset = "0x285E90C", VA = "0x285E90C")]
  public ScreenGradation()
  {
  }
}

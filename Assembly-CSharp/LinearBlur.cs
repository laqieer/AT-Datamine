// Decompiled with JetBrains decompiler
// Type: LinearBlur
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine.Rendering;

#nullable disable
[Token(Token = "0x2000329")]
[VolumeComponentMenu("Staq Post-processing/LinearBlur")]
[Serializable]
public class LinearBlur : VolumeComponent
{
  [Token(Token = "0x40012CD")]
  [FieldOffset(Offset = "0x30")]
  public NoInterpClampedFloatParameter intensity;
  [Token(Token = "0x40012CE")]
  [FieldOffset(Offset = "0x38")]
  public NoInterpClampedFloatParameter direction;
  [Token(Token = "0x40012CF")]
  [FieldOffset(Offset = "0x40")]
  public NoInterpClampedFloatParameter frequency;
  [Token(Token = "0x40012D0")]
  [FieldOffset(Offset = "0x48")]
  public NoInterpClampedFloatParameter density;

  [Token(Token = "0x60012CD")]
  [Address(RVA = "0x285E490", Offset = "0x285E490", VA = "0x285E490")]
  public bool IsActive() => new bool();

  [Token(Token = "0x60012CE")]
  [Address(RVA = "0x285E4BC", Offset = "0x285E4BC", VA = "0x285E4BC")]
  public LinearBlur()
  {
  }
}

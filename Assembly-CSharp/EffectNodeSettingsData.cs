// Decompiled with JetBrains decompiler
// Type: EffectNodeSettingsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010B")]
[Serializable]
public class EffectNodeSettingsData
{
  [Token(Token = "0x4000579")]
  [FieldOffset(Offset = "0x10")]
  public string EffectNodeName;
  [Token(Token = "0x400057A")]
  [FieldOffset(Offset = "0x18")]
  public string attachTargetName;
  [Token(Token = "0x400057B")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 localPosition;
  [Token(Token = "0x400057C")]
  [FieldOffset(Offset = "0x2C")]
  public Vector3 localRotation;
  [Token(Token = "0x400057D")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 localScale;

  [Token(Token = "0x600075F")]
  [Address(RVA = "0x4854BA8", Offset = "0x4854BA8", VA = "0x4854BA8")]
  public EffectNodeSettingsData()
  {
  }
}

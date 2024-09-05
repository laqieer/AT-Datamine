// Decompiled with JetBrains decompiler
// Type: WindAnimation.WindPowerParameterRange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace WindAnimation
{
  [Token(Token = "0x2003F1B")]
  [Serializable]
  public class WindPowerParameterRange
  {
    [Token(Token = "0x40114A5")]
    [FieldOffset(Offset = "0x10")]
    [Range(0.0f, 1f)]
    [SerializeField]
    public float minPower;
    [Token(Token = "0x40114A6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Range(0.0f, 1f)]
    public float maxPower;
    [Token(Token = "0x40114A7")]
    [FieldOffset(Offset = "0x18")]
    [Range(0.0f, 1f)]
    [SerializeField]
    public float minFluPower;
    [Token(Token = "0x40114A8")]
    [FieldOffset(Offset = "0x1C")]
    [Range(0.0f, 1f)]
    [SerializeField]
    public float maxFluPower;
    [Token(Token = "0x40114A9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Range(0.0f, 4f)]
    public float minFluFrequency;
    [Token(Token = "0x40114AA")]
    [FieldOffset(Offset = "0x24")]
    [Range(0.0f, 4f)]
    [SerializeField]
    public float maxFluFrequency;

    [Token(Token = "0x60197F3")]
    [Address(RVA = "0x3744A80", Offset = "0x3744A80", VA = "0x3744A80")]
    public WindPowerParameterRange()
    {
    }
  }
}

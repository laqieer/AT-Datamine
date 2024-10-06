// Decompiled with JetBrains decompiler
// Type: LightControlBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
[Token(Token = "0x2000341")]
[Serializable]
public class LightControlBehaviour : PlayableBehaviour
{
  [Token(Token = "0x40013A1")]
  [FieldOffset(Offset = "0x10")]
  public Color color;
  [Token(Token = "0x40013A2")]
  [FieldOffset(Offset = "0x20")]
  public float intensity;
  [Token(Token = "0x40013A3")]
  [FieldOffset(Offset = "0x24")]
  public float bounceIntensity;
  [Token(Token = "0x40013A4")]
  [FieldOffset(Offset = "0x28")]
  public float range;

  [Token(Token = "0x6001309")]
  [Address(RVA = "0x2865994", Offset = "0x2865994", VA = "0x2865994")]
  public LightControlBehaviour()
  {
  }
}

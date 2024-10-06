// Decompiled with JetBrains decompiler
// Type: BGSceneEffectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000ED")]
[Serializable]
public class BGSceneEffectData
{
  [Token(Token = "0x400043F")]
  [FieldOffset(Offset = "0x10")]
  [Header("BG Color Collect")]
  public float collectBlend;
  [Token(Token = "0x4000440")]
  [FieldOffset(Offset = "0x14")]
  public Color collectColor;
  [Token(Token = "0x4000441")]
  [FieldOffset(Offset = "0x24")]
  public BGColorCollect.CollectMode mode;
  [Token(Token = "0x4000442")]
  [FieldOffset(Offset = "0x28")]
  public Color fogColor;
  [Token(Token = "0x4000443")]
  [FieldOffset(Offset = "0x38")]
  public float fogStart;
  [Token(Token = "0x4000444")]
  [FieldOffset(Offset = "0x3C")]
  public float fogEnd;
  [Token(Token = "0x4000445")]
  [FieldOffset(Offset = "0x40")]
  [Header("Screen Gradation")]
  public float angle;
  [Token(Token = "0x4000446")]
  [FieldOffset(Offset = "0x44")]
  public float offset;
  [Token(Token = "0x4000447")]
  [FieldOffset(Offset = "0x48")]
  public float threshold;
  [Token(Token = "0x4000448")]
  [FieldOffset(Offset = "0x4C")]
  public float intensity;
  [Token(Token = "0x4000449")]
  [FieldOffset(Offset = "0x50")]
  public Color colorA;
  [Token(Token = "0x400044A")]
  [FieldOffset(Offset = "0x60")]
  public Color colorB;
  [Token(Token = "0x400044B")]
  [FieldOffset(Offset = "0x70")]
  [Header("Sky Renderer Material")]
  public Material skyRendererMaterial;
  [Token(Token = "0x400044C")]
  [FieldOffset(Offset = "0x78")]
  [Header("Effect Objects")]
  public List<GameObject> effectObjects;
  [Token(Token = "0x400044D")]
  [FieldOffset(Offset = "0x80")]
  [Header("Directional Light")]
  public Color lightColor;
  [Token(Token = "0x400044E")]
  [FieldOffset(Offset = "0x90")]
  public float lightIntensity;

  [Token(Token = "0x60006C9")]
  [Address(RVA = "0x4187AB8", Offset = "0x4187AB8", VA = "0x4187AB8")]
  public BGSceneEffectData()
  {
  }
}

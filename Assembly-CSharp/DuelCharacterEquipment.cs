// Decompiled with JetBrains decompiler
// Type: DuelCharacterEquipment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
[Token(Token = "0x200015B")]
[Serializable]
public class DuelCharacterEquipment
{
  [Token(Token = "0x40008B1")]
  [FieldOffset(Offset = "0x10")]
  public string parentName;
  [Token(Token = "0x40008B2")]
  [FieldOffset(Offset = "0x18")]
  public GameObject prefab;
  [Token(Token = "0x40008B3")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 localPosition;
  [Token(Token = "0x40008B4")]
  [FieldOffset(Offset = "0x2C")]
  public Vector3 localScale;
  [Token(Token = "0x40008B5")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 localRotation;
  [Token(Token = "0x40008B6")]
  [FieldOffset(Offset = "0x48")]
  public TimelineAsset animationTimeline;

  [Token(Token = "0x60009D0")]
  [Address(RVA = "0x4775F1C", Offset = "0x4775F1C", VA = "0x4775F1C")]
  public DuelCharacterEquipment()
  {
  }
}

// Decompiled with JetBrains decompiler
// Type: EquipmentSettingsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000106")]
[Serializable]
public class EquipmentSettingsData
{
  [Token(Token = "0x4000530")]
  [FieldOffset(Offset = "0x10")]
  public string parentName;
  [Token(Token = "0x4000531")]
  [FieldOffset(Offset = "0x18")]
  public GameObject prefab;
  [Token(Token = "0x4000532")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 localPosition;
  [Token(Token = "0x4000533")]
  [FieldOffset(Offset = "0x2C")]
  public Vector3 localScale;
  [Token(Token = "0x4000534")]
  [FieldOffset(Offset = "0x38")]
  public Vector3 localRotation;
  [Token(Token = "0x4000535")]
  [FieldOffset(Offset = "0x48")]
  public EquipmentModelInverseKinematicsLocator equipmentModelInverseKinematicsLocator;

  [Token(Token = "0x6000750")]
  [Address(RVA = "0x4852618", Offset = "0x4852618", VA = "0x4852618")]
  public EquipmentSettingsData()
  {
  }
}

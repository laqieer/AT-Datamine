// Decompiled with JetBrains decompiler
// Type: SingleSkillSceneSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200019D")]
[CreateAssetMenu(menuName = "Duel/Single Skill Scene Settings Asset")]
public class SingleSkillSceneSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000A65")]
  [FieldOffset(Offset = "0x18")]
  public GameObject oBGModelPrefab;
  [Token(Token = "0x4000A66")]
  [FieldOffset(Offset = "0x20")]
  public DuelCharacterModelSettingsAsset actorModelSettingsAsset;
  [Token(Token = "0x4000A67")]
  [FieldOffset(Offset = "0x28")]
  public DuelVehicleModelSettingsAsset actorVehicleModelSettingsAsset;
  [Token(Token = "0x4000A68")]
  [FieldOffset(Offset = "0x30")]
  public DuelCharacterEquipmentSettingsAsset actorWeaponSettingsAsset;
  [Token(Token = "0x4000A69")]
  [FieldOffset(Offset = "0x38")]
  public DuelCharacterModelSettingsAsset targetModelSettingsAsset;
  [Token(Token = "0x4000A6A")]
  [FieldOffset(Offset = "0x40")]
  public DuelVehicleModelSettingsAsset targetVehicleModelSettingsAsset;
  [Token(Token = "0x4000A6B")]
  [FieldOffset(Offset = "0x48")]
  public DuelCharacterEquipmentSettingsAsset targetWeaponSettingsAsset;

  [Token(Token = "0x6000AF4")]
  [Address(RVA = "0x4BBCDEC", Offset = "0x4BBCDEC", VA = "0x4BBCDEC")]
  public SingleSkillSceneSettingsAsset()
  {
  }
}

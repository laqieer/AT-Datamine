// Decompiled with JetBrains decompiler
// Type: StrategemSceneSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200019E")]
[CreateAssetMenu(menuName = "Duel/Strategem Skill Scene Settings Asset")]
public class StrategemSceneSettingsAsset : ScriptableObject
{
  [Token(Token = "0x4000A6C")]
  [FieldOffset(Offset = "0x18")]
  public DuelCharacterModelSettingsAsset actorModelSettingsAsset;
  [Token(Token = "0x4000A6D")]
  [FieldOffset(Offset = "0x20")]
  public DuelVehicleModelSettingsAsset actorVehicleModelSettingsAsset;
  [Token(Token = "0x4000A6E")]
  [FieldOffset(Offset = "0x28")]
  public DuelCharacterEquipmentSettingsAsset actorWeaponSettingsAsset;

  [Token(Token = "0x6000AF5")]
  [Address(RVA = "0x4BBCDF4", Offset = "0x4BBCDF4", VA = "0x4BBCDF4")]
  public StrategemSceneSettingsAsset()
  {
  }
}

// Decompiled with JetBrains decompiler
// Type: DuelCharacterSettingsAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using GameCore.MasterData;
using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010C")]
[CreateAssetMenu(menuName = "Duel/Duel Character Settings Asset")]
public class DuelCharacterSettingsAsset : ScriptableObject
{
  [Token(Token = "0x400057E")]
  [FieldOffset(Offset = "0x18")]
  [Header("Common Timeline")]
  public DuelCharacterCommonTimelineSettingsAsset commonTimelineSettings;
  [Token(Token = "0x400057F")]
  [FieldOffset(Offset = "0x20")]
  [Header("Equipments")]
  public List<DuelCharacterEquipmentSettingsAsset> equipments;
  [Token(Token = "0x4000580")]
  [FieldOffset(Offset = "0x28")]
  [Header("Navmesh Agent")]
  public DuelCharacterAgentSettingsAsset agentSettings;
  [Token(Token = "0x4000581")]
  [FieldOffset(Offset = "0x30")]
  [Header("Virtual Camera")]
  public DuelCharacterVCSettingsAsset normalQuestVCSettings;
  [Token(Token = "0x4000582")]
  [FieldOffset(Offset = "0x38")]
  public DuelCharacterVCSettingsAsset giantBossQuestVCSettings;
  [Token(Token = "0x4000583")]
  [FieldOffset(Offset = "0x40")]
  [Header("Character Settings")]
  public DuelCharacterModelSettingsAsset characterModelSettings;
  [Token(Token = "0x4000584")]
  [FieldOffset(Offset = "0x48")]
  public RuntimeAnimatorController animatorController;
  [Token(Token = "0x4000585")]
  [FieldOffset(Offset = "0x50")]
  public RuntimeAnimatorController animatorControllerFemale;
  [Token(Token = "0x4000586")]
  [FieldOffset(Offset = "0x58")]
  public SexTypeEnum gender;
  [Token(Token = "0x4000587")]
  [FieldOffset(Offset = "0x60")]
  [Header("Vehicle Settings")]
  public DuelVehicleModelSettingsAsset vehicleModelSettings;
  [Token(Token = "0x4000588")]
  [FieldOffset(Offset = "0x68")]
  public RuntimeAnimatorController vehicleAnimatorController;
  [Token(Token = "0x4000589")]
  [FieldOffset(Offset = "0x70")]
  public string voiceId;

  [Token(Token = "0x6000760")]
  [Address(RVA = "0x4854C50", Offset = "0x4854C50", VA = "0x4854C50")]
  public DuelCharacterSettingsAsset()
  {
  }
}

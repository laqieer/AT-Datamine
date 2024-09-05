// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleEndRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DD3")]
  [Serializable]
  public class APIScenarioEventFreeQuestBattleEndRequest
  {
    [Token(Token = "0x4007F67")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x4007F68")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x4007F69")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x4007F6A")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x4007F6B")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x4007F6C")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x4007F6D")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x4007F6E")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x4007F6F")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x4007F70")]
    [FieldOffset(Offset = "0x58")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x4007F71")]
    [FieldOffset(Offset = "0x60")]
    public List<int> remain_hps;
    [Token(Token = "0x4007F72")]
    [FieldOffset(Offset = "0x68")]
    public int quest_id;

    [Token(Token = "0x600B052")]
    [Address(RVA = "0x1A53230", Offset = "0x1A53230", VA = "0x1A53230")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B053")]
    [Address(RVA = "0x1A53278", Offset = "0x1A53278", VA = "0x1A53278")]
    public APIScenarioEventFreeQuestBattleEndRequest()
    {
    }
  }
}

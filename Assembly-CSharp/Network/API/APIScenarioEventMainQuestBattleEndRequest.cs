// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventMainQuestBattleEndRequest
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
  [Token(Token = "0x2001DDF")]
  [Serializable]
  public class APIScenarioEventMainQuestBattleEndRequest
  {
    [Token(Token = "0x4007FB0")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x4007FB1")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x4007FB2")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x4007FB3")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x4007FB4")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x4007FB5")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x4007FB6")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x4007FB7")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x4007FB8")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x4007FB9")]
    [FieldOffset(Offset = "0x58")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x4007FBA")]
    [FieldOffset(Offset = "0x60")]
    public List<int> remain_hps;
    [Token(Token = "0x4007FBB")]
    [FieldOffset(Offset = "0x68")]
    public int chapter_id;
    [Token(Token = "0x4007FBC")]
    [FieldOffset(Offset = "0x6C")]
    public int quest_id;
    [Token(Token = "0x4007FBD")]
    [FieldOffset(Offset = "0x70")]
    public List<AdvRequest> adv_requests;
    [Token(Token = "0x4007FBE")]
    [FieldOffset(Offset = "0x78")]
    public List<int> achieved_story_battle_mission_ids;

    [Token(Token = "0x600B0A3")]
    [Address(RVA = "0x1A5428C", Offset = "0x1A5428C", VA = "0x1A5428C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B0A4")]
    [Address(RVA = "0x1A542D4", Offset = "0x1A542D4", VA = "0x1A542D4")]
    public APIScenarioEventMainQuestBattleEndRequest()
    {
    }
  }
}

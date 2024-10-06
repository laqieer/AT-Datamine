// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestBattleEndRequest
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
  [Token(Token = "0x2001E47")]
  [Serializable]
  public class APIStoryMainquestBattleEndRequest
  {
    [Token(Token = "0x40081C1")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x40081C2")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x40081C3")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x40081C4")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x40081C5")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x40081C6")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x40081C7")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x40081C8")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x40081C9")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x40081CA")]
    [FieldOffset(Offset = "0x58")]
    public List<PlayerBattleCharacterLp> update_character_lps;
    [Token(Token = "0x40081CB")]
    [FieldOffset(Offset = "0x60")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x40081CC")]
    [FieldOffset(Offset = "0x68")]
    public List<int> remain_hps;
    [Token(Token = "0x40081CD")]
    [FieldOffset(Offset = "0x70")]
    public int chapter_id;
    [Token(Token = "0x40081CE")]
    [FieldOffset(Offset = "0x74")]
    public int quest_id;
    [Token(Token = "0x40081CF")]
    [FieldOffset(Offset = "0x78")]
    public List<AdvRequest> adv_requests;
    [Token(Token = "0x40081D0")]
    [FieldOffset(Offset = "0x80")]
    public List<int> achieved_story_battle_mission_ids;

    [Token(Token = "0x600B367")]
    [Address(RVA = "0x22E2ED8", Offset = "0x22E2ED8", VA = "0x22E2ED8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B368")]
    [Address(RVA = "0x22E2F20", Offset = "0x22E2F20", VA = "0x22E2F20")]
    public APIStoryMainquestBattleEndRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeBattleEndRequest
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
  [Token(Token = "0x2001E5B")]
  [Serializable]
  public class APIStoryObliviaeBattleEndRequest
  {
    [Token(Token = "0x4008241")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x4008242")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x4008243")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x4008244")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x4008245")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x4008246")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x4008247")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x4008248")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x4008249")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x400824A")]
    [FieldOffset(Offset = "0x58")]
    public List<PlayerBattleCharacterLp> update_character_lps;
    [Token(Token = "0x400824B")]
    [FieldOffset(Offset = "0x60")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x400824C")]
    [FieldOffset(Offset = "0x68")]
    public List<int> remain_hps;
    [Token(Token = "0x400824D")]
    [FieldOffset(Offset = "0x70")]
    public int chapter_id;
    [Token(Token = "0x400824E")]
    [FieldOffset(Offset = "0x74")]
    public int quest_id;

    [Token(Token = "0x600B3FF")]
    [Address(RVA = "0x22E4AA4", Offset = "0x22E4AA4", VA = "0x22E4AA4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B400")]
    [Address(RVA = "0x22E4AEC", Offset = "0x22E4AEC", VA = "0x22E4AEC")]
    public APIStoryObliviaeBattleEndRequest()
    {
    }
  }
}

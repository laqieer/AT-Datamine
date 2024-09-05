// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestBattleEndRequest
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
  [Token(Token = "0x2001E73")]
  [Serializable]
  public class APIStorySubquestBattleEndRequest
  {
    [Token(Token = "0x40082C5")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x40082C6")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x40082C7")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x40082C8")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x40082C9")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x40082CA")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x40082CB")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x40082CC")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x40082CD")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x40082CE")]
    [FieldOffset(Offset = "0x58")]
    public List<PlayerBattleCharacterLp> update_character_lps;
    [Token(Token = "0x40082CF")]
    [FieldOffset(Offset = "0x60")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x40082D0")]
    [FieldOffset(Offset = "0x68")]
    public List<int> remain_hps;
    [Token(Token = "0x40082D1")]
    [FieldOffset(Offset = "0x70")]
    public int subquest_task_id;
    [Token(Token = "0x40082D2")]
    [FieldOffset(Offset = "0x74")]
    public int quest_id;

    [Token(Token = "0x600B4AA")]
    [Address(RVA = "0x22E6BA4", Offset = "0x22E6BA4", VA = "0x22E6BA4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B4AB")]
    [Address(RVA = "0x22E6BEC", Offset = "0x22E6BEC", VA = "0x22E6BEC")]
    public APIStorySubquestBattleEndRequest()
    {
    }
  }
}

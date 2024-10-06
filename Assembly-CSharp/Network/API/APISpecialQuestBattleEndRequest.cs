// Decompiled with JetBrains decompiler
// Type: Network.API.APISpecialQuestBattleEndRequest
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
  [Token(Token = "0x2001E1B")]
  [Serializable]
  public class APISpecialQuestBattleEndRequest
  {
    [Token(Token = "0x40080DB")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x40080DC")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x40080DD")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x40080DE")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x40080DF")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x40080E0")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x40080E1")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x40080E2")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x40080E3")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x40080E4")]
    [FieldOffset(Offset = "0x58")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x40080E5")]
    [FieldOffset(Offset = "0x60")]
    public List<int> remain_hps;
    [Token(Token = "0x40080E6")]
    [FieldOffset(Offset = "0x68")]
    public int quest_id;

    [Token(Token = "0x600B22F")]
    [Address(RVA = "0x22DF264", Offset = "0x22DF264", VA = "0x22DF264")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B230")]
    [Address(RVA = "0x22DF2AC", Offset = "0x22DF2AC", VA = "0x22DF2AC")]
    public APISpecialQuestBattleEndRequest()
    {
    }
  }
}

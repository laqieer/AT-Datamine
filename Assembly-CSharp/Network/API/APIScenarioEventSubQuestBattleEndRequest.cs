// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventSubQuestBattleEndRequest
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
  [Token(Token = "0x2001DE7")]
  [Serializable]
  public class APIScenarioEventSubQuestBattleEndRequest
  {
    [Token(Token = "0x4007FED")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x4007FEE")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x4007FEF")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x4007FF0")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x4007FF1")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x4007FF2")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x4007FF3")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x4007FF4")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x4007FF5")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x4007FF6")]
    [FieldOffset(Offset = "0x58")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x4007FF7")]
    [FieldOffset(Offset = "0x60")]
    public List<int> remain_hps;
    [Token(Token = "0x4007FF8")]
    [FieldOffset(Offset = "0x68")]
    public int subquest_task_id;
    [Token(Token = "0x4007FF9")]
    [FieldOffset(Offset = "0x6C")]
    public int quest_id;

    [Token(Token = "0x600B0DF")]
    [Address(RVA = "0x22DABF8", Offset = "0x22DABF8", VA = "0x22DABF8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B0E0")]
    [Address(RVA = "0x22DAC40", Offset = "0x22DAC40", VA = "0x22DAC40")]
    public APIScenarioEventSubQuestBattleEndRequest()
    {
    }
  }
}

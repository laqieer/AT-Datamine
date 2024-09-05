// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleEndRequest
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
  [Token(Token = "0x2001B6F")]
  [Serializable]
  public class APIAreaQuestBattleEndRequest
  {
    [Token(Token = "0x4007592")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x4007593")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x4007594")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x4007595")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x4007596")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x4007597")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x4007598")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x4007599")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x400759A")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x400759B")]
    [FieldOffset(Offset = "0x58")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x400759C")]
    [FieldOffset(Offset = "0x60")]
    public List<int> remain_hps;
    [Token(Token = "0x400759D")]
    [FieldOffset(Offset = "0x68")]
    public int quest_id;

    [Token(Token = "0x600A11C")]
    [Address(RVA = "0x46C6CD0", Offset = "0x46C6CD0", VA = "0x46C6CD0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A11D")]
    [Address(RVA = "0x46C6D18", Offset = "0x46C6D18", VA = "0x46C6D18")]
    public APIAreaQuestBattleEndRequest()
    {
    }
  }
}

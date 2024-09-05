// Decompiled with JetBrains decompiler
// Type: Network.API.APIFreeQuestBattleEndRequest
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
  [Token(Token = "0x2001C47")]
  [Serializable]
  public class APIFreeQuestBattleEndRequest
  {
    [Token(Token = "0x400791A")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x400791B")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x400791C")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x400791D")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x400791E")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerUnitSupportType> support_values;
    [Token(Token = "0x400791F")]
    [FieldOffset(Offset = "0x38")]
    public List<PlayerBattleWeaponGrade> battle_weapon_grades;
    [Token(Token = "0x4007920")]
    [FieldOffset(Offset = "0x40")]
    public List<PlayerBattleWeaponProficiency> weapon_proficiencies;
    [Token(Token = "0x4007921")]
    [FieldOffset(Offset = "0x48")]
    public List<int> opened_chest_ids;
    [Token(Token = "0x4007922")]
    [FieldOffset(Offset = "0x50")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x4007923")]
    [FieldOffset(Offset = "0x58")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x4007924")]
    [FieldOffset(Offset = "0x60")]
    public List<int> remain_hps;
    [Token(Token = "0x4007925")]
    [FieldOffset(Offset = "0x68")]
    public int quest_id;

    [Token(Token = "0x600A683")]
    [Address(RVA = "0x190B104", Offset = "0x190B104", VA = "0x190B104")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A684")]
    [Address(RVA = "0x190B14C", Offset = "0x190B14C", VA = "0x190B14C")]
    public APIFreeQuestBattleEndRequest()
    {
    }
  }
}

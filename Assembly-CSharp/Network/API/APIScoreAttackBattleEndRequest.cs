// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackBattleEndRequest
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
  [Token(Token = "0x2001DF3")]
  [Serializable]
  public class APIScoreAttackBattleEndRequest
  {
    [Token(Token = "0x4008039")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x400803A")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x400803B")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleUnitGrade> battle_unit_grades;
    [Token(Token = "0x400803C")]
    [FieldOffset(Offset = "0x28")]
    public None guest_unit_grades;
    [Token(Token = "0x400803D")]
    [FieldOffset(Offset = "0x30")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x400803E")]
    [FieldOffset(Offset = "0x38")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x400803F")]
    [FieldOffset(Offset = "0x40")]
    public List<int> remain_hps;
    [Token(Token = "0x4008040")]
    [FieldOffset(Offset = "0x48")]
    public PlayerScoreAttackResultType score_attack_result;
    [Token(Token = "0x4008041")]
    [FieldOffset(Offset = "0x50")]
    public PlayerScoreAttackResultScoreType score_attack_result_score;

    [Token(Token = "0x600B136")]
    [Address(RVA = "0x22DBC84", Offset = "0x22DBC84", VA = "0x22DBC84")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B137")]
    [Address(RVA = "0x22DBCCC", Offset = "0x22DBCCC", VA = "0x22DBCCC")]
    public APIScoreAttackBattleEndRequest()
    {
    }
  }
}

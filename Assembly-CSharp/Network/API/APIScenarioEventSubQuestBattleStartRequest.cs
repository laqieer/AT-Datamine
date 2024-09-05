// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventSubQuestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DEB")]
  [Serializable]
  public class APIScenarioEventSubQuestBattleStartRequest
  {
    [Token(Token = "0x400800F")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4008010")]
    [FieldOffset(Offset = "0x14")]
    public int subquest_task_id;
    [Token(Token = "0x4008011")]
    [FieldOffset(Offset = "0x18")]
    public int quest_id;
    [Token(Token = "0x4008012")]
    [FieldOffset(Offset = "0x20")]
    public string support_player_id;
    [Token(Token = "0x4008013")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4008014")]
    [FieldOffset(Offset = "0x30")]
    public int deck_type_id;
    [Token(Token = "0x4008015")]
    [FieldOffset(Offset = "0x34")]
    public int deck_number;
    [Token(Token = "0x4008016")]
    [FieldOffset(Offset = "0x38")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B0FF")]
    [Address(RVA = "0x22DB194", Offset = "0x22DB194", VA = "0x22DB194")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B100")]
    [Address(RVA = "0x22DB1DC", Offset = "0x22DB1DC", VA = "0x22DB1DC")]
    public APIScenarioEventSubQuestBattleStartRequest()
    {
    }
  }
}

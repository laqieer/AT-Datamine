// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DDB")]
  [Serializable]
  public class APIScenarioEventFreeQuestBattleStartRequest
  {
    [Token(Token = "0x4007F97")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007F98")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4007F99")]
    [FieldOffset(Offset = "0x18")]
    public string support_player_id;
    [Token(Token = "0x4007F9A")]
    [FieldOffset(Offset = "0x20")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4007F9B")]
    [FieldOffset(Offset = "0x28")]
    public int deck_type_id;
    [Token(Token = "0x4007F9C")]
    [FieldOffset(Offset = "0x2C")]
    public int deck_number;
    [Token(Token = "0x4007F9D")]
    [FieldOffset(Offset = "0x30")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B086")]
    [Address(RVA = "0x1A53D08", Offset = "0x1A53D08", VA = "0x1A53D08")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B087")]
    [Address(RVA = "0x1A53D50", Offset = "0x1A53D50", VA = "0x1A53D50")]
    public APIScenarioEventFreeQuestBattleStartRequest()
    {
    }
  }
}

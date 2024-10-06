// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventMainQuestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DE3")]
  [Serializable]
  public class APIScenarioEventMainQuestBattleStartRequest
  {
    [Token(Token = "0x4007FD3")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007FD4")]
    [FieldOffset(Offset = "0x14")]
    public int chapter_id;
    [Token(Token = "0x4007FD5")]
    [FieldOffset(Offset = "0x18")]
    public int quest_id;
    [Token(Token = "0x4007FD6")]
    [FieldOffset(Offset = "0x20")]
    public string support_player_id;
    [Token(Token = "0x4007FD7")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4007FD8")]
    [FieldOffset(Offset = "0x30")]
    public int deck_type_id;
    [Token(Token = "0x4007FD9")]
    [FieldOffset(Offset = "0x34")]
    public int deck_number;
    [Token(Token = "0x4007FDA")]
    [FieldOffset(Offset = "0x38")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B0C2")]
    [Address(RVA = "0x1A54820", Offset = "0x1A54820", VA = "0x1A54820")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B0C3")]
    [Address(RVA = "0x1A54868", Offset = "0x1A54868", VA = "0x1A54868")]
    public APIScenarioEventMainQuestBattleStartRequest()
    {
    }
  }
}

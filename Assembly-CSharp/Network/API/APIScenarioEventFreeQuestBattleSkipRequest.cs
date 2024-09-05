// Decompiled with JetBrains decompiler
// Type: Network.API.APIScenarioEventFreeQuestBattleSkipRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DD7")]
  [Serializable]
  public class APIScenarioEventFreeQuestBattleSkipRequest
  {
    [Token(Token = "0x4007F82")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007F83")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4007F84")]
    [FieldOffset(Offset = "0x18")]
    public int deck_type_id;
    [Token(Token = "0x4007F85")]
    [FieldOffset(Offset = "0x1C")]
    public int deck_number;
    [Token(Token = "0x4007F86")]
    [FieldOffset(Offset = "0x20")]
    public int skip_count;
    [Token(Token = "0x4007F87")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;

    [Token(Token = "0x600B06C")]
    [Address(RVA = "0x1A5379C", Offset = "0x1A5379C", VA = "0x1A5379C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B06D")]
    [Address(RVA = "0x1A537E4", Offset = "0x1A537E4", VA = "0x1A537E4")]
    public APIScenarioEventFreeQuestBattleSkipRequest()
    {
    }
  }
}

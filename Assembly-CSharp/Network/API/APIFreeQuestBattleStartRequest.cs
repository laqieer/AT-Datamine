// Decompiled with JetBrains decompiler
// Type: Network.API.APIFreeQuestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C4B")]
  [Serializable]
  public class APIFreeQuestBattleStartRequest
  {
    [Token(Token = "0x4007935")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007936")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4007937")]
    [FieldOffset(Offset = "0x18")]
    public string support_player_id;
    [Token(Token = "0x4007938")]
    [FieldOffset(Offset = "0x20")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4007939")]
    [FieldOffset(Offset = "0x28")]
    public int deck_type_id;
    [Token(Token = "0x400793A")]
    [FieldOffset(Offset = "0x2C")]
    public int deck_number;
    [Token(Token = "0x400793B")]
    [FieldOffset(Offset = "0x30")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600A69D")]
    [Address(RVA = "0x190B670", Offset = "0x190B670", VA = "0x190B670")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A69E")]
    [Address(RVA = "0x190B6B8", Offset = "0x190B6B8", VA = "0x190B6B8")]
    public APIFreeQuestBattleStartRequest()
    {
    }
  }
}

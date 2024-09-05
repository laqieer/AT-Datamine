// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryObliviaeBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E5F")]
  [Serializable]
  public class APIStoryObliviaeBattleStartRequest
  {
    [Token(Token = "0x4008263")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4008264")]
    [FieldOffset(Offset = "0x14")]
    public int chapter_id;
    [Token(Token = "0x4008265")]
    [FieldOffset(Offset = "0x18")]
    public int quest_id;
    [Token(Token = "0x4008266")]
    [FieldOffset(Offset = "0x1C")]
    public int deck_type_id;
    [Token(Token = "0x4008267")]
    [FieldOffset(Offset = "0x20")]
    public int deck_number;
    [Token(Token = "0x4008268")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4008269")]
    [FieldOffset(Offset = "0x30")]
    public string support_player_id;
    [Token(Token = "0x400826A")]
    [FieldOffset(Offset = "0x38")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B41E")]
    [Address(RVA = "0x22E5038", Offset = "0x22E5038", VA = "0x22E5038")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B41F")]
    [Address(RVA = "0x22E5080", Offset = "0x22E5080", VA = "0x22E5080")]
    public APIStoryObliviaeBattleStartRequest()
    {
    }
  }
}

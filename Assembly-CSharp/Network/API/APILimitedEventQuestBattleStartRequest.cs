// Decompiled with JetBrains decompiler
// Type: Network.API.APILimitedEventQuestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D47")]
  [Serializable]
  public class APILimitedEventQuestBattleStartRequest
  {
    [Token(Token = "0x4007D10")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007D11")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4007D12")]
    [FieldOffset(Offset = "0x18")]
    public string support_player_id;
    [Token(Token = "0x4007D13")]
    [FieldOffset(Offset = "0x20")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4007D14")]
    [FieldOffset(Offset = "0x28")]
    public int deck_type_id;
    [Token(Token = "0x4007D15")]
    [FieldOffset(Offset = "0x2C")]
    public int deck_number;
    [Token(Token = "0x4007D16")]
    [FieldOffset(Offset = "0x30")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600ACAD")]
    [Address(RVA = "0x1A473E4", Offset = "0x1A473E4", VA = "0x1A473E4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ACAE")]
    [Address(RVA = "0x1A4742C", Offset = "0x1A4742C", VA = "0x1A4742C")]
    public APILimitedEventQuestBattleStartRequest()
    {
    }
  }
}

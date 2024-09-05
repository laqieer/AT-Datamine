// Decompiled with JetBrains decompiler
// Type: Network.API.APISpecialQuestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E1F")]
  [Serializable]
  public class APISpecialQuestBattleStartRequest
  {
    [Token(Token = "0x40080F6")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x40080F7")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x40080F8")]
    [FieldOffset(Offset = "0x18")]
    public string support_player_id;
    [Token(Token = "0x40080F9")]
    [FieldOffset(Offset = "0x20")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x40080FA")]
    [FieldOffset(Offset = "0x28")]
    public int deck_type_id;
    [Token(Token = "0x40080FB")]
    [FieldOffset(Offset = "0x2C")]
    public int deck_number;
    [Token(Token = "0x40080FC")]
    [FieldOffset(Offset = "0x30")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B249")]
    [Address(RVA = "0x22DF7D0", Offset = "0x22DF7D0", VA = "0x22DF7D0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B24A")]
    [Address(RVA = "0x22DF818", Offset = "0x22DF818", VA = "0x22DF818")]
    public APISpecialQuestBattleStartRequest()
    {
    }
  }
}

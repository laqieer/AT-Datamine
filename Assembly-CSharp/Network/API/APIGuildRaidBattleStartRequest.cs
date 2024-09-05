// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D0B")]
  [Serializable]
  public class APIGuildRaidBattleStartRequest
  {
    [Token(Token = "0x4007C13")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007C14")]
    [FieldOffset(Offset = "0x18")]
    public string guild_id;
    [Token(Token = "0x4007C15")]
    [FieldOffset(Offset = "0x20")]
    public int lap;
    [Token(Token = "0x4007C16")]
    [FieldOffset(Offset = "0x24")]
    public int position_id;
    [Token(Token = "0x4007C17")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4007C18")]
    [FieldOffset(Offset = "0x30")]
    public int deck_type_id;
    [Token(Token = "0x4007C19")]
    [FieldOffset(Offset = "0x34")]
    public int deck_number;

    [Token(Token = "0x600AB32")]
    [Address(RVA = "0x1A422F8", Offset = "0x1A422F8", VA = "0x1A422F8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AB33")]
    [Address(RVA = "0x1A42340", Offset = "0x1A42340", VA = "0x1A42340")]
    public APIGuildRaidBattleStartRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIScoreAttackBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001DF7")]
  [Serializable]
  public class APIScoreAttackBattleStartRequest
  {
    [Token(Token = "0x4008053")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4008054")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4008055")]
    [FieldOffset(Offset = "0x18")]
    public string support_player_id;
    [Token(Token = "0x4008056")]
    [FieldOffset(Offset = "0x20")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x4008057")]
    [FieldOffset(Offset = "0x28")]
    public int deck_type_id;
    [Token(Token = "0x4008058")]
    [FieldOffset(Offset = "0x2C")]
    public int deck_number;

    [Token(Token = "0x600B152")]
    [Address(RVA = "0x22DC200", Offset = "0x22DC200", VA = "0x22DC200")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B153")]
    [Address(RVA = "0x22DC248", Offset = "0x22DC248", VA = "0x22DC248")]
    public APIScoreAttackBattleStartRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidBattleEndRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D07")]
  [Serializable]
  public class APIGuildRaidBattleEndRequest
  {
    [Token(Token = "0x4007BF9")]
    [FieldOffset(Offset = "0x10")]
    public string battle_uuid;
    [Token(Token = "0x4007BFA")]
    [FieldOffset(Offset = "0x18")]
    public List<int> achieved_mission_ids;
    [Token(Token = "0x4007BFB")]
    [FieldOffset(Offset = "0x20")]
    public List<PlayerBattleConsumedExpendable> consumed_expendables;
    [Token(Token = "0x4007BFC")]
    [FieldOffset(Offset = "0x28")]
    public BattleSettingsParameters battle_settings;
    [Token(Token = "0x4007BFD")]
    [FieldOffset(Offset = "0x30")]
    public List<int> remain_hps;
    [Token(Token = "0x4007BFE")]
    [FieldOffset(Offset = "0x38")]
    public string guild_id;
    [Token(Token = "0x4007BFF")]
    [FieldOffset(Offset = "0x40")]
    public int score;

    [Token(Token = "0x600AB14")]
    [Address(RVA = "0x1A41D6C", Offset = "0x1A41D6C", VA = "0x1A41D6C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AB15")]
    [Address(RVA = "0x1A41DB4", Offset = "0x1A41DB4", VA = "0x1A41DB4")]
    public APIGuildRaidBattleEndRequest()
    {
    }
  }
}

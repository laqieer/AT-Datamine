// Decompiled with JetBrains decompiler
// Type: Network.API.APIStorySubquestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E77")]
  [Serializable]
  public class APIStorySubquestBattleStartRequest
  {
    [Token(Token = "0x40082E8")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x40082E9")]
    [FieldOffset(Offset = "0x14")]
    public int subquest_task_id;
    [Token(Token = "0x40082EA")]
    [FieldOffset(Offset = "0x18")]
    public int quest_id;
    [Token(Token = "0x40082EB")]
    [FieldOffset(Offset = "0x20")]
    public string support_player_id;
    [Token(Token = "0x40082EC")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x40082ED")]
    [FieldOffset(Offset = "0x30")]
    public int deck_type_id;
    [Token(Token = "0x40082EE")]
    [FieldOffset(Offset = "0x34")]
    public int deck_number;
    [Token(Token = "0x40082EF")]
    [FieldOffset(Offset = "0x38")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B4CA")]
    [Address(RVA = "0x22E7140", Offset = "0x22E7140", VA = "0x22E7140")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B4CB")]
    [Address(RVA = "0x22E7188", Offset = "0x22E7188", VA = "0x22E7188")]
    public APIStorySubquestBattleStartRequest()
    {
    }
  }
}

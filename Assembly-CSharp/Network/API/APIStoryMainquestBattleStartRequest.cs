// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryMainquestBattleStartRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E4B")]
  [Serializable]
  public class APIStoryMainquestBattleStartRequest
  {
    [Token(Token = "0x40081E5")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x40081E6")]
    [FieldOffset(Offset = "0x14")]
    public int chapter_id;
    [Token(Token = "0x40081E7")]
    [FieldOffset(Offset = "0x18")]
    public int quest_id;
    [Token(Token = "0x40081E8")]
    [FieldOffset(Offset = "0x20")]
    public string support_player_id;
    [Token(Token = "0x40081E9")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;
    [Token(Token = "0x40081EA")]
    [FieldOffset(Offset = "0x30")]
    public int deck_type_id;
    [Token(Token = "0x40081EB")]
    [FieldOffset(Offset = "0x34")]
    public int deck_number;
    [Token(Token = "0x40081EC")]
    [FieldOffset(Offset = "0x38")]
    public List<string> level_up_player_unit_ids;

    [Token(Token = "0x600B386")]
    [Address(RVA = "0x22E346C", Offset = "0x22E346C", VA = "0x22E346C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B387")]
    [Address(RVA = "0x22E34B4", Offset = "0x22E34B4", VA = "0x22E34B4")]
    public APIStoryMainquestBattleStartRequest()
    {
    }
  }
}

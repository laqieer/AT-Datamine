// Decompiled with JetBrains decompiler
// Type: Network.API.APIAreaQuestBattleSkipRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B73")]
  [Serializable]
  public class APIAreaQuestBattleSkipRequest
  {
    [Token(Token = "0x40075AE")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x40075AF")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x40075B0")]
    [FieldOffset(Offset = "0x18")]
    public int deck_type_id;
    [Token(Token = "0x40075B1")]
    [FieldOffset(Offset = "0x1C")]
    public int deck_number;
    [Token(Token = "0x40075B2")]
    [FieldOffset(Offset = "0x20")]
    public int skip_count;
    [Token(Token = "0x40075B3")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;

    [Token(Token = "0x600A137")]
    [Address(RVA = "0x46C7244", Offset = "0x46C7244", VA = "0x46C7244")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A138")]
    [Address(RVA = "0x46C728C", Offset = "0x46C728C", VA = "0x46C728C")]
    public APIAreaQuestBattleSkipRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleFreequestSkipRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B9F")]
  [Serializable]
  public class APIBattleFreequestSkipRequest
  {
    [Token(Token = "0x4007670")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007671")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4007672")]
    [FieldOffset(Offset = "0x18")]
    public int deck_type_id;
    [Token(Token = "0x4007673")]
    [FieldOffset(Offset = "0x1C")]
    public int deck_number;
    [Token(Token = "0x4007674")]
    [FieldOffset(Offset = "0x20")]
    public int skip_count;
    [Token(Token = "0x4007675")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;

    [Token(Token = "0x600A255")]
    [Address(RVA = "0x46CADE8", Offset = "0x46CADE8", VA = "0x46CADE8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A256")]
    [Address(RVA = "0x46CAE30", Offset = "0x46CAE30", VA = "0x46CAE30")]
    public APIBattleFreequestSkipRequest()
    {
    }
  }
}

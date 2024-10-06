// Decompiled with JetBrains decompiler
// Type: Network.API.APIBattleLimitedeventquestSkipRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BA3")]
  [Serializable]
  public class APIBattleLimitedeventquestSkipRequest
  {
    [Token(Token = "0x4007685")]
    [FieldOffset(Offset = "0x10")]
    public int total_battle_power;
    [Token(Token = "0x4007686")]
    [FieldOffset(Offset = "0x14")]
    public int quest_id;
    [Token(Token = "0x4007687")]
    [FieldOffset(Offset = "0x18")]
    public int deck_type_id;
    [Token(Token = "0x4007688")]
    [FieldOffset(Offset = "0x1C")]
    public int deck_number;
    [Token(Token = "0x4007689")]
    [FieldOffset(Offset = "0x20")]
    public int skip_count;
    [Token(Token = "0x400768A")]
    [FieldOffset(Offset = "0x28")]
    public List<string> player_battle_unit_ids;

    [Token(Token = "0x600A26F")]
    [Address(RVA = "0x46CB354", Offset = "0x46CB354", VA = "0x46CB354")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A270")]
    [Address(RVA = "0x46CB39C", Offset = "0x46CB39C", VA = "0x46CB39C")]
    public APIBattleLimitedeventquestSkipRequest()
    {
    }
  }
}

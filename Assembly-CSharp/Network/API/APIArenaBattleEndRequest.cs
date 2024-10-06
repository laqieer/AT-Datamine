// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleEndRequest
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
  [Token(Token = "0x2001B83")]
  [Serializable]
  public class APIArenaBattleEndRequest
  {
    [Token(Token = "0x40075F7")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;
    [Token(Token = "0x40075F8")]
    [FieldOffset(Offset = "0x18")]
    public long battle_id;
    [Token(Token = "0x40075F9")]
    [FieldOffset(Offset = "0x20")]
    public bool is_win;
    [Token(Token = "0x40075FA")]
    [FieldOffset(Offset = "0x28")]
    public List<RequestArenaDeckUnitDamageType> deck_unit_damages;
    [Token(Token = "0x40075FB")]
    [FieldOffset(Offset = "0x30")]
    public List<RequestArenaDeckUnitDamageType> enemy_deck_unit_damages;

    [Token(Token = "0x600A19C")]
    [Address(RVA = "0x46C87DC", Offset = "0x46C87DC", VA = "0x46C87DC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A19D")]
    [Address(RVA = "0x46C8824", Offset = "0x46C8824", VA = "0x46C8824")]
    public APIArenaBattleEndRequest()
    {
    }
  }
}

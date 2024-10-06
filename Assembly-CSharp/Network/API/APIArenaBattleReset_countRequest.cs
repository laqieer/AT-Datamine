// Decompiled with JetBrains decompiler
// Type: Network.API.APIArenaBattleReset_countRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001B8B")]
  [Serializable]
  public class APIArenaBattleReset_countRequest
  {
    [Token(Token = "0x400761C")]
    [FieldOffset(Offset = "0x10")]
    public long arena_id;
    [Token(Token = "0x400761D")]
    [FieldOffset(Offset = "0x18")]
    public int arena_battle_count_reset_type_id;

    [Token(Token = "0x600A1D1")]
    [Address(RVA = "0x46C92BC", Offset = "0x46C92BC", VA = "0x46C92BC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A1D2")]
    [Address(RVA = "0x46C9304", Offset = "0x46C9304", VA = "0x46C9304")]
    public APIArenaBattleReset_countRequest()
    {
    }
  }
}

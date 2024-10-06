// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftSendRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CCF")]
  [Serializable]
  public class APIGuildGiftSendRequest
  {
    [Token(Token = "0x4007B28")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007B29")]
    [FieldOffset(Offset = "0x18")]
    public List<string> player_ids;

    [Token(Token = "0x600A9C6")]
    [Address(RVA = "0x19167C4", Offset = "0x19167C4", VA = "0x19167C4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A9C7")]
    [Address(RVA = "0x191680C", Offset = "0x191680C", VA = "0x191680C")]
    public APIGuildGiftSendRequest()
    {
    }
  }
}

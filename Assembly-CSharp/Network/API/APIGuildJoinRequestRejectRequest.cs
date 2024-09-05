// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestRejectRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CF3")]
  [Serializable]
  public class APIGuildJoinRequestRejectRequest
  {
    [Token(Token = "0x4007BB5")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007BB6")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x600AAA0")]
    [Address(RVA = "0x1919810", Offset = "0x1919810", VA = "0x1919810")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AAA1")]
    [Address(RVA = "0x1919858", Offset = "0x1919858", VA = "0x1919858")]
    public APIGuildJoinRequestRejectRequest()
    {
    }
  }
}

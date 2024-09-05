// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestApproveRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CE3")]
  [Serializable]
  public class APIGuildJoinRequestApproveRequest
  {
    [Token(Token = "0x4007B7E")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007B7F")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x600AA42")]
    [Address(RVA = "0x19182B0", Offset = "0x19182B0", VA = "0x19182B0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AA43")]
    [Address(RVA = "0x19182F8", Offset = "0x19182F8", VA = "0x19182F8")]
    public APIGuildJoinRequestApproveRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildKickRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CFB")]
  [Serializable]
  public class APIGuildKickRequest
  {
    [Token(Token = "0x4007BD0")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007BD1")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x600AACE")]
    [Address(RVA = "0x1A40D68", Offset = "0x1A40D68", VA = "0x1A40D68")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AACF")]
    [Address(RVA = "0x1A40DB0", Offset = "0x1A40DB0", VA = "0x1A40DB0")]
    public APIGuildKickRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestAutoJoinRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CE7")]
  [Serializable]
  public class APIGuildJoinRequestAutoJoinRequest
  {
    [Token(Token = "0x4007B8D")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AA5A")]
    [Address(RVA = "0x191880C", Offset = "0x191880C", VA = "0x191880C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AA5B")]
    [Address(RVA = "0x1918854", Offset = "0x1918854", VA = "0x1918854")]
    public APIGuildJoinRequestAutoJoinRequest()
    {
    }
  }
}

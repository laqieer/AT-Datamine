// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CEF")]
  [Serializable]
  public class APIGuildJoinRequestListRequest
  {
    [Token(Token = "0x4007BA8")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AA89")]
    [Address(RVA = "0x19192BC", Offset = "0x19192BC", VA = "0x19192BC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AA8A")]
    [Address(RVA = "0x1919304", Offset = "0x1919304", VA = "0x1919304")]
    public APIGuildJoinRequestListRequest()
    {
    }
  }
}

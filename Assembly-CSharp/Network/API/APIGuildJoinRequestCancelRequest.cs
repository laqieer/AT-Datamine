// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildJoinRequestCancelRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CEB")]
  [Serializable]
  public class APIGuildJoinRequestCancelRequest
  {
    [Token(Token = "0x4007B9C")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AA73")]
    [Address(RVA = "0x1918D70", Offset = "0x1918D70", VA = "0x1918D70")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AA74")]
    [Address(RVA = "0x1918DB8", Offset = "0x1918DB8", VA = "0x1918DB8")]
    public APIGuildJoinRequestCancelRequest()
    {
    }
  }
}

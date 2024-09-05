// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildMemberListRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D03")]
  [Serializable]
  public class APIGuildMemberListRequest
  {
    [Token(Token = "0x4007BEC")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AAFD")]
    [Address(RVA = "0x1A41818", Offset = "0x1A41818", VA = "0x1A41818")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AAFE")]
    [Address(RVA = "0x1A41860", Offset = "0x1A41860", VA = "0x1A41860")]
    public APIGuildMemberListRequest()
    {
    }
  }
}

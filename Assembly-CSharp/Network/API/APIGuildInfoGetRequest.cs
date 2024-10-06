// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildInfoGetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CDB")]
  [Serializable]
  public class APIGuildInfoGetRequest
  {
    [Token(Token = "0x4007B57")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600AA12")]
    [Address(RVA = "0x19177F8", Offset = "0x19177F8", VA = "0x19177F8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AA13")]
    [Address(RVA = "0x1917840", Offset = "0x1917840", VA = "0x1917840")]
    public APIGuildInfoGetRequest()
    {
    }
  }
}

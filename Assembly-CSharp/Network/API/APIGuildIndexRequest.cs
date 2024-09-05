// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildIndexRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CD7")]
  [Serializable]
  public class APIGuildIndexRequest
  {
    [Token(Token = "0x4007B42")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600A9F3")]
    [Address(RVA = "0x1917264", Offset = "0x1917264", VA = "0x1917264")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A9F4")]
    [Address(RVA = "0x19172AC", Offset = "0x19172AC", VA = "0x19172AC")]
    public APIGuildIndexRequest()
    {
    }
  }
}

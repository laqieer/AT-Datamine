// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildDeleteRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CBB")]
  [Serializable]
  public class APIGuildDeleteRequest
  {
    [Token(Token = "0x4007AD8")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600A948")]
    [Address(RVA = "0x1914CC8", Offset = "0x1914CC8", VA = "0x1914CC8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A949")]
    [Address(RVA = "0x1914D10", Offset = "0x1914D10", VA = "0x1914D10")]
    public APIGuildDeleteRequest()
    {
    }
  }
}

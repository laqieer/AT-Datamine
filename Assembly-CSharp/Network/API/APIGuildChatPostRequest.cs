// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildChatPostRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CB3")]
  [Serializable]
  public class APIGuildChatPostRequest
  {
    [Token(Token = "0x4007AB9")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007ABA")]
    [FieldOffset(Offset = "0x18")]
    public string latest_message_id;
    [Token(Token = "0x4007ABB")]
    [FieldOffset(Offset = "0x20")]
    public int message_type_id;
    [Token(Token = "0x4007ABC")]
    [FieldOffset(Offset = "0x28")]
    public string content;

    [Token(Token = "0x600A917")]
    [Address(RVA = "0x1914218", Offset = "0x1914218", VA = "0x1914218")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A918")]
    [Address(RVA = "0x1914260", Offset = "0x1914260", VA = "0x1914260")]
    public APIGuildChatPostRequest()
    {
    }
  }
}

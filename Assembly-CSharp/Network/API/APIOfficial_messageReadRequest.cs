// Decompiled with JetBrains decompiler
// Type: Network.API.APIOfficial_messageReadRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D7B")]
  [Serializable]
  public class APIOfficial_messageReadRequest
  {
    [Token(Token = "0x4007DED")]
    [FieldOffset(Offset = "0x10")]
    public int official_message_article_id;

    [Token(Token = "0x600AE03")]
    [Address(RVA = "0x1A4BA60", Offset = "0x1A4BA60", VA = "0x1A4BA60")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AE04")]
    [Address(RVA = "0x1A4BAA8", Offset = "0x1A4BAA8", VA = "0x1A4BAA8")]
    public APIOfficial_messageReadRequest()
    {
    }
  }
}

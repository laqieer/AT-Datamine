// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftIndexRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC7")]
  [Serializable]
  public class APIGuildGiftIndexRequest
  {
    [Token(Token = "0x4007B09")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600A994")]
    [Address(RVA = "0x1915CFC", Offset = "0x1915CFC", VA = "0x1915CFC")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A995")]
    [Address(RVA = "0x1915D44", Offset = "0x1915D44", VA = "0x1915D44")]
    public APIGuildGiftIndexRequest()
    {
    }
  }
}

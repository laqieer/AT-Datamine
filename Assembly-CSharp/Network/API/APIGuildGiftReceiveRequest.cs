// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftReceiveRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CCB")]
  [Serializable]
  public class APIGuildGiftReceiveRequest
  {
    [Token(Token = "0x4007B19")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007B1A")]
    [FieldOffset(Offset = "0x18")]
    public List<string> gift_ids;

    [Token(Token = "0x600A9AE")]
    [Address(RVA = "0x1916268", Offset = "0x1916268", VA = "0x1916268")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A9AF")]
    [Address(RVA = "0x19162B0", Offset = "0x19162B0", VA = "0x19162B0")]
    public APIGuildGiftReceiveRequest()
    {
    }
  }
}

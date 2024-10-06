// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartyEditRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C1F")]
  [Serializable]
  public class APIExpeditionPartyEditRequest
  {
    [Token(Token = "0x400785C")]
    [FieldOffset(Offset = "0x10")]
    public List<RequestPlayerExpeditionPartyCharacter> player_expedition_party_characters;

    [Token(Token = "0x600A566")]
    [Address(RVA = "0x1907A04", Offset = "0x1907A04", VA = "0x1907A04")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A567")]
    [Address(RVA = "0x1907A4C", Offset = "0x1907A4C", VA = "0x1907A4C")]
    public APIExpeditionPartyEditRequest()
    {
    }
  }
}

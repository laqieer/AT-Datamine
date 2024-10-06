// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartySlotReleaseRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C23")]
  [Serializable]
  public class APIExpeditionPartySlotReleaseRequest
  {
    [Token(Token = "0x4007873")]
    [FieldOffset(Offset = "0x10")]
    public string player_expedition_party_id;

    [Token(Token = "0x600A587")]
    [Address(RVA = "0x1907FA8", Offset = "0x1907FA8", VA = "0x1907FA8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A588")]
    [Address(RVA = "0x1907FF0", Offset = "0x1907FF0", VA = "0x1907FF0")]
    public APIExpeditionPartySlotReleaseRequest()
    {
    }
  }
}

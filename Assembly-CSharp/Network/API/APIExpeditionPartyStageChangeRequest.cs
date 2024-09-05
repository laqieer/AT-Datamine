// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionPartyStageChangeRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C27")]
  [Serializable]
  public class APIExpeditionPartyStageChangeRequest
  {
    [Token(Token = "0x4007883")]
    [FieldOffset(Offset = "0x10")]
    public int stage_id;
    [Token(Token = "0x4007884")]
    [FieldOffset(Offset = "0x18")]
    public string player_expedition_party_id;

    [Token(Token = "0x600A5A1")]
    [Address(RVA = "0x1908514", Offset = "0x1908514", VA = "0x1908514")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A5A2")]
    [Address(RVA = "0x190855C", Offset = "0x190855C", VA = "0x190855C")]
    public APIExpeditionPartyStageChangeRequest()
    {
    }
  }
}

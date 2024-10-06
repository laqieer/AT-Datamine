// Decompiled with JetBrains decompiler
// Type: Network.API.APIExpeditionRapidRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C2B")]
  [Serializable]
  public class APIExpeditionRapidRequest
  {
    [Token(Token = "0x4007899")]
    [FieldOffset(Offset = "0x10")]
    public int expedition_rapid_type_id;
    [Token(Token = "0x400789A")]
    [FieldOffset(Offset = "0x14")]
    public int expedition_rapid_ticket_id;
    [Token(Token = "0x400789B")]
    [FieldOffset(Offset = "0x18")]
    public string player_expedition_party_id;

    [Token(Token = "0x600A5C0")]
    [Address(RVA = "0x1908AA8", Offset = "0x1908AA8", VA = "0x1908AA8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A5C1")]
    [Address(RVA = "0x1908AF0", Offset = "0x1908AF0", VA = "0x1908AF0")]
    public APIExpeditionRapidRequest()
    {
    }
  }
}

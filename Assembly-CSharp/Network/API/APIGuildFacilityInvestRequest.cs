// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildFacilityInvestRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CC3")]
  [Serializable]
  public class APIGuildFacilityInvestRequest
  {
    [Token(Token = "0x4007AF5")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007AF6")]
    [FieldOffset(Offset = "0x18")]
    public int facility_id;
    [Token(Token = "0x4007AF7")]
    [FieldOffset(Offset = "0x1C")]
    public int invest_resource_id;
    [Token(Token = "0x4007AF8")]
    [FieldOffset(Offset = "0x20")]
    public int invest_rate_id;

    [Token(Token = "0x600A979")]
    [Address(RVA = "0x1915788", Offset = "0x1915788", VA = "0x1915788")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A97A")]
    [Address(RVA = "0x19157D0", Offset = "0x19157D0", VA = "0x19157D0")]
    public APIGuildFacilityInvestRequest()
    {
    }
  }
}

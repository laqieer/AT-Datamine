// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAppointSubMasterRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C9F")]
  [Serializable]
  public class APIGuildAppointSubMasterRequest
  {
    [Token(Token = "0x4007A62")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007A63")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x600A898")]
    [Address(RVA = "0x1912714", Offset = "0x1912714", VA = "0x1912714")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A899")]
    [Address(RVA = "0x191275C", Offset = "0x191275C", VA = "0x191275C")]
    public APIGuildAppointSubMasterRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAppointGeneralRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001C9B")]
  [Serializable]
  public class APIGuildAppointGeneralRequest
  {
    [Token(Token = "0x4007A54")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007A55")]
    [FieldOffset(Offset = "0x18")]
    public string player_id;

    [Token(Token = "0x600A881")]
    [Address(RVA = "0x19121C0", Offset = "0x19121C0", VA = "0x19121C0")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A882")]
    [Address(RVA = "0x1912208", Offset = "0x1912208", VA = "0x1912208")]
    public APIGuildAppointGeneralRequest()
    {
    }
  }
}

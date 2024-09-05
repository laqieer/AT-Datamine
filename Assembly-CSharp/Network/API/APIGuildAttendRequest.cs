// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildAttendRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CA3")]
  [Serializable]
  public class APIGuildAttendRequest
  {
    [Token(Token = "0x4007A70")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;

    [Token(Token = "0x600A8AF")]
    [Address(RVA = "0x1912C68", Offset = "0x1912C68", VA = "0x1912C68")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A8B0")]
    [Address(RVA = "0x1912CB0", Offset = "0x1912CB0", VA = "0x1912CB0")]
    public APIGuildAttendRequest()
    {
    }
  }
}

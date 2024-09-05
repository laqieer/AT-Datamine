// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildRaidDetailRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D0F")]
  [Serializable]
  public class APIGuildRaidDetailRequest
  {
    [Token(Token = "0x4007C2A")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007C2B")]
    [FieldOffset(Offset = "0x18")]
    public int lap;
    [Token(Token = "0x4007C2C")]
    [FieldOffset(Offset = "0x1C")]
    public int position_id;

    [Token(Token = "0x600AB4D")]
    [Address(RVA = "0x1A4286C", Offset = "0x1A4286C", VA = "0x1A4286C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600AB4E")]
    [Address(RVA = "0x1A428B4", Offset = "0x1A428B4", VA = "0x1A428B4")]
    public APIGuildRaidDetailRequest()
    {
    }
  }
}

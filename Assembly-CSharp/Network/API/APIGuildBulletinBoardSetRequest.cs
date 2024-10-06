// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildBulletinBoardSetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CAB")]
  [Serializable]
  public class APIGuildBulletinBoardSetRequest
  {
    [Token(Token = "0x4007A99")]
    [FieldOffset(Offset = "0x10")]
    public string guild_id;
    [Token(Token = "0x4007A9A")]
    [FieldOffset(Offset = "0x18")]
    public string bulletin_board_text;

    [Token(Token = "0x600A8E5")]
    [Address(RVA = "0x1913750", Offset = "0x1913750", VA = "0x1913750")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A8E6")]
    [Address(RVA = "0x1913798", Offset = "0x1913798", VA = "0x1913798")]
    public APIGuildBulletinBoardSetRequest()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.API.APIGuildGiftWishSetRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001CD3")]
  [Serializable]
  public class APIGuildGiftWishSetRequest
  {
    [Token(Token = "0x4007B36")]
    [FieldOffset(Offset = "0x10")]
    public int wish_id;

    [Token(Token = "0x600A9DD")]
    [Address(RVA = "0x1916D18", Offset = "0x1916D18", VA = "0x1916D18")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600A9DE")]
    [Address(RVA = "0x1916D60", Offset = "0x1916D60", VA = "0x1916D60")]
    public APIGuildGiftWishSetRequest()
    {
    }
  }
}

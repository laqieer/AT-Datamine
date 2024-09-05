// Decompiled with JetBrains decompiler
// Type: Network.API.APIShopPurchaseRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E13")]
  [Serializable]
  public class APIShopPurchaseRequest
  {
    [Token(Token = "0x40080B7")]
    [FieldOffset(Offset = "0x10")]
    public int article_id;
    [Token(Token = "0x40080B8")]
    [FieldOffset(Offset = "0x14")]
    public int purchase_count;

    [Token(Token = "0x600B1F8")]
    [Address(RVA = "0x22DE774", Offset = "0x22DE774", VA = "0x22DE774")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B1F9")]
    [Address(RVA = "0x22DE7BC", Offset = "0x22DE7BC", VA = "0x22DE7BC")]
    public APIShopPurchaseRequest()
    {
    }
  }
}

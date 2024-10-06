// Decompiled with JetBrains decompiler
// Type: Network.API.APIStoryShopPurchaseRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001E6B")]
  [Serializable]
  public class APIStoryShopPurchaseRequest
  {
    [Token(Token = "0x400829F")]
    [FieldOffset(Offset = "0x10")]
    public int article_id;
    [Token(Token = "0x40082A0")]
    [FieldOffset(Offset = "0x14")]
    public int purchase_count;

    [Token(Token = "0x600B471")]
    [Address(RVA = "0x22E60A4", Offset = "0x22E60A4", VA = "0x22E60A4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600B472")]
    [Address(RVA = "0x22E60EC", Offset = "0x22E60EC", VA = "0x22E60EC")]
    public APIStoryShopPurchaseRequest()
    {
    }
  }
}

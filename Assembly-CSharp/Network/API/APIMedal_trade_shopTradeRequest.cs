// Decompiled with JetBrains decompiler
// Type: Network.API.APIMedal_trade_shopTradeRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D53")]
  [Serializable]
  public class APIMedal_trade_shopTradeRequest
  {
    [Token(Token = "0x4007D45")]
    [FieldOffset(Offset = "0x10")]
    public int prize_id;
    [Token(Token = "0x4007D46")]
    [FieldOffset(Offset = "0x14")]
    public int trade_count;

    [Token(Token = "0x600ACFB")]
    [Address(RVA = "0x1A48418", Offset = "0x1A48418", VA = "0x1A48418")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ACFC")]
    [Address(RVA = "0x1A48460", Offset = "0x1A48460", VA = "0x1A48460")]
    public APIMedal_trade_shopTradeRequest()
    {
    }
  }
}

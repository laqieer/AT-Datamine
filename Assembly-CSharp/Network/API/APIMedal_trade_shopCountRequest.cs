// Decompiled with JetBrains decompiler
// Type: Network.API.APIMedal_trade_shopCountRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001D4F")]
  [Serializable]
  public class APIMedal_trade_shopCountRequest
  {
    [Token(Token = "0x4007D38")]
    [FieldOffset(Offset = "0x10")]
    public int shop_id;

    [Token(Token = "0x600ACE4")]
    [Address(RVA = "0x1A47EC4", Offset = "0x1A47EC4", VA = "0x1A47EC4")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x600ACE5")]
    [Address(RVA = "0x1A47F0C", Offset = "0x1A47F0C", VA = "0x1A47F0C")]
    public APIMedal_trade_shopCountRequest()
    {
    }
  }
}

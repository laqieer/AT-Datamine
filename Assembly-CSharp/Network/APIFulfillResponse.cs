// Decompiled with JetBrains decompiler
// Type: Network.APIFulfillResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A26")]
  [Serializable]
  public class APIFulfillResponse
  {
    [Token(Token = "0x4006FF2")]
    [FieldOffset(Offset = "0x10")]
    public int current_common_coin;
    [Token(Token = "0x4006FF3")]
    [FieldOffset(Offset = "0x14")]
    public int current_free_coin;
    [Token(Token = "0x4006FF4")]
    [FieldOffset(Offset = "0x18")]
    public int current_paid_coin;
    [Token(Token = "0x4006FF5")]
    [FieldOffset(Offset = "0x20")]
    public APIFulfillResponse.OrderInfo[] succeeded_orders;
    [Token(Token = "0x4006FF6")]
    [FieldOffset(Offset = "0x28")]
    public APIFulfillResponse.OrderInfo[] duplicated_orders;

    [Token(Token = "0x6009546")]
    [Address(RVA = "0x48ED3C8", Offset = "0x48ED3C8", VA = "0x48ED3C8")]
    public APIFulfillResponse()
    {
    }

    [Token(Token = "0x2001A27")]
    [Serializable]
    public class OrderInfo
    {
      [Token(Token = "0x4006FF7")]
      [FieldOffset(Offset = "0x10")]
      public int free_coin;
      [Token(Token = "0x4006FF8")]
      [FieldOffset(Offset = "0x18")]
      public string order_id;
      [Token(Token = "0x4006FF9")]
      [FieldOffset(Offset = "0x20")]
      public int paid_coin;
      [Token(Token = "0x4006FFA")]
      [FieldOffset(Offset = "0x28")]
      public string product_id;

      [Token(Token = "0x6009547")]
      [Address(RVA = "0x48ED3D0", Offset = "0x48ED3D0", VA = "0x48ED3D0")]
      public OrderInfo()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.APIDmmGamesPlayerFulfillResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A30")]
  [Serializable]
  public class APIDmmGamesPlayerFulfillResponse
  {
    [Token(Token = "0x4007010")]
    [FieldOffset(Offset = "0x10")]
    public int current_free_coin;
    [Token(Token = "0x4007011")]
    [FieldOffset(Offset = "0x14")]
    public int current_paid_coin;
    [Token(Token = "0x4007012")]
    [FieldOffset(Offset = "0x18")]
    public int current_common_coin;
    [Token(Token = "0x4007013")]
    [FieldOffset(Offset = "0x20")]
    public APIDmmGamesPlayerFulfillResponse.Order[] succeeded_orders;
    [Token(Token = "0x4007014")]
    [FieldOffset(Offset = "0x28")]
    public APIDmmGamesPlayerFulfillResponse.Order[] duplicated_orders;

    [Token(Token = "0x6009563")]
    [Address(RVA = "0x48ED990", Offset = "0x48ED990", VA = "0x48ED990")]
    public APIDmmGamesPlayerFulfillResponse()
    {
    }

    [Token(Token = "0x2001A31")]
    [Serializable]
    public class Order
    {
      [Token(Token = "0x4007015")]
      [FieldOffset(Offset = "0x10")]
      public int free_coin;
      [Token(Token = "0x4007016")]
      [FieldOffset(Offset = "0x14")]
      public int paid_coin;
      [Token(Token = "0x4007017")]
      [FieldOffset(Offset = "0x18")]
      public string product_id;
      [Token(Token = "0x4007018")]
      [FieldOffset(Offset = "0x20")]
      public string order_id;

      [Token(Token = "0x6009564")]
      [Address(RVA = "0x48ED998", Offset = "0x48ED998", VA = "0x48ED998")]
      public Order()
      {
      }
    }
  }
}

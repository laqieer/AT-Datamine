// Decompiled with JetBrains decompiler
// Type: Network.APIAppStoreFulfillRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A21")]
  [Serializable]
  public class APIAppStoreFulfillRequest
  {
    [Token(Token = "0x4006FE5")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006FE6")]
    [FieldOffset(Offset = "0x18")]
    public APIAppStoreFulfillRequest.Receipts receipt;

    [Token(Token = "0x6009534")]
    [Address(RVA = "0x48ED02C", Offset = "0x48ED02C", VA = "0x48ED02C")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009535")]
    [Address(RVA = "0x48ED074", Offset = "0x48ED074", VA = "0x48ED074")]
    public APIAppStoreFulfillRequest()
    {
    }

    [Token(Token = "0x2001A22")]
    [Serializable]
    public class Receipts
    {
      [Token(Token = "0x4006FE7")]
      [FieldOffset(Offset = "0x10")]
      public APIAppStoreFulfillRequest.Receipt[] receipts;
      [Token(Token = "0x4006FE8")]
      [FieldOffset(Offset = "0x18")]
      public string receipt_data;

      [Token(Token = "0x6009536")]
      [Address(RVA = "0x48ED07C", Offset = "0x48ED07C", VA = "0x48ED07C")]
      public Receipts()
      {
      }
    }

    [Token(Token = "0x2001A23")]
    [Serializable]
    public class Receipt
    {
      [Token(Token = "0x4006FE9")]
      [FieldOffset(Offset = "0x10")]
      public string currency;
      [Token(Token = "0x4006FEA")]
      [FieldOffset(Offset = "0x18")]
      public double price;
      [Token(Token = "0x4006FEB")]
      [FieldOffset(Offset = "0x20")]
      public string transaction_id;

      [Token(Token = "0x6009537")]
      [Address(RVA = "0x48ED084", Offset = "0x48ED084", VA = "0x48ED084")]
      public Receipt()
      {
      }
    }
  }
}

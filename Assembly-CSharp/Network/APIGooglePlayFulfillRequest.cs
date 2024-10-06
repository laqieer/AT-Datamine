// Decompiled with JetBrains decompiler
// Type: Network.APIGooglePlayFulfillRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A28")]
  [Serializable]
  public class APIGooglePlayFulfillRequest
  {
    [Token(Token = "0x4006FFB")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x4006FFC")]
    [FieldOffset(Offset = "0x18")]
    public APIGooglePlayFulfillRequest.Receipt[] receipts;

    [Token(Token = "0x6009548")]
    [Address(RVA = "0x48ED3D8", Offset = "0x48ED3D8", VA = "0x48ED3D8")]
    public string GetQuery() => (string) null;

    [Token(Token = "0x6009549")]
    [Address(RVA = "0x48ED420", Offset = "0x48ED420", VA = "0x48ED420")]
    public APIGooglePlayFulfillRequest()
    {
    }

    [Token(Token = "0x2001A29")]
    [Serializable]
    public class Receipt
    {
      [Token(Token = "0x4006FFD")]
      [FieldOffset(Offset = "0x10")]
      public string currency;
      [Token(Token = "0x4006FFE")]
      [FieldOffset(Offset = "0x18")]
      public double price;
      [Token(Token = "0x4006FFF")]
      [FieldOffset(Offset = "0x20")]
      public string signature;
      [Token(Token = "0x4007000")]
      [FieldOffset(Offset = "0x28")]
      public string signed_data;

      [Token(Token = "0x600954A")]
      [Address(RVA = "0x48ED428", Offset = "0x48ED428", VA = "0x48ED428")]
      public Receipt()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Network.APIDmmGamesPlayerFulfillRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Network
{
  [Token(Token = "0x2001A2E")]
  [Serializable]
  public class APIDmmGamesPlayerFulfillRequest
  {
    [Token(Token = "0x400700C")]
    [FieldOffset(Offset = "0x10")]
    public string device_id;
    [Token(Token = "0x400700D")]
    [FieldOffset(Offset = "0x18")]
    public APIDmmGamesPlayerFulfillRequest.Receipt[] receipts;

    [Token(Token = "0x6009561")]
    [Address(RVA = "0x48ED980", Offset = "0x48ED980", VA = "0x48ED980")]
    public APIDmmGamesPlayerFulfillRequest()
    {
    }

    [Token(Token = "0x2001A2F")]
    [Serializable]
    public class Receipt
    {
      [Token(Token = "0x400700E")]
      [FieldOffset(Offset = "0x10")]
      public string in_app_purchase_data;
      [Token(Token = "0x400700F")]
      [FieldOffset(Offset = "0x18")]
      public string in_app_data_signature;

      [Token(Token = "0x6009562")]
      [Address(RVA = "0x48ED988", Offset = "0x48ED988", VA = "0x48ED988")]
      public Receipt()
      {
      }
    }
  }
}

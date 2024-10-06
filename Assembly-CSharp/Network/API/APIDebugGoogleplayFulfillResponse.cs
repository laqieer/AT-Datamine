// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugGoogleplayFulfillResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Network.Param;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BF0")]
  [Serializable]
  public class APIDebugGoogleplayFulfillResponse
  {
    [Token(Token = "0x40077A1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int current_free_coin;
    [Token(Token = "0x40077A2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int current_paid_coin;
    [Token(Token = "0x40077A3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int current_common_coin;
    [Token(Token = "0x40077A4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<DebugFulfillCoins> succeeded_orders;
    [Token(Token = "0x40077A5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<DebugFulfillCoins> duplicated_orders;

    [Token(Token = "0x17001E93")]
    public int CurrentFreeCoin
    {
      [Token(Token = "0x600A43C"), Address(RVA = "0x46D1990", Offset = "0x46D1990", VA = "0x46D1990")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E94")]
    public int CurrentPaidCoin
    {
      [Token(Token = "0x600A43D"), Address(RVA = "0x46D1998", Offset = "0x46D1998", VA = "0x46D1998")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E95")]
    public int CurrentCommonCoin
    {
      [Token(Token = "0x600A43E"), Address(RVA = "0x46D19A0", Offset = "0x46D19A0", VA = "0x46D19A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E96")]
    public List<DebugFulfillCoins> SucceededOrders
    {
      [Token(Token = "0x600A43F"), Address(RVA = "0x46D19A8", Offset = "0x46D19A8", VA = "0x46D19A8")] get
      {
        return (List<DebugFulfillCoins>) null;
      }
    }

    [Token(Token = "0x17001E97")]
    public List<DebugFulfillCoins> DuplicatedOrders
    {
      [Token(Token = "0x600A440"), Address(RVA = "0x46D19B0", Offset = "0x46D19B0", VA = "0x46D19B0")] get
      {
        return (List<DebugFulfillCoins>) null;
      }
    }

    [Token(Token = "0x600A441")]
    [Address(RVA = "0x46D19B8", Offset = "0x46D19B8", VA = "0x46D19B8")]
    public APIDebugGoogleplayFulfillResponse()
    {
    }
  }
}

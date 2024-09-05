// Decompiled with JetBrains decompiler
// Type: Network.API.APIDebugAppstoreFulfillResponse
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
  [Token(Token = "0x2001BEC")]
  [Serializable]
  public class APIDebugAppstoreFulfillResponse
  {
    [Token(Token = "0x4007790")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int current_free_coin;
    [Token(Token = "0x4007791")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int current_paid_coin;
    [Token(Token = "0x4007792")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int current_common_coin;
    [Token(Token = "0x4007793")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<DebugFulfillCoins> succeeded_orders;
    [Token(Token = "0x4007794")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<DebugFulfillCoins> duplicated_orders;

    [Token(Token = "0x17001E88")]
    public int CurrentFreeCoin
    {
      [Token(Token = "0x600A421"), Address(RVA = "0x46D141C", Offset = "0x46D141C", VA = "0x46D141C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E89")]
    public int CurrentPaidCoin
    {
      [Token(Token = "0x600A422"), Address(RVA = "0x46D1424", Offset = "0x46D1424", VA = "0x46D1424")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E8A")]
    public int CurrentCommonCoin
    {
      [Token(Token = "0x600A423"), Address(RVA = "0x46D142C", Offset = "0x46D142C", VA = "0x46D142C")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001E8B")]
    public List<DebugFulfillCoins> SucceededOrders
    {
      [Token(Token = "0x600A424"), Address(RVA = "0x46D1434", Offset = "0x46D1434", VA = "0x46D1434")] get
      {
        return (List<DebugFulfillCoins>) null;
      }
    }

    [Token(Token = "0x17001E8C")]
    public List<DebugFulfillCoins> DuplicatedOrders
    {
      [Token(Token = "0x600A425"), Address(RVA = "0x46D143C", Offset = "0x46D143C", VA = "0x46D143C")] get
      {
        return (List<DebugFulfillCoins>) null;
      }
    }

    [Token(Token = "0x600A426")]
    [Address(RVA = "0x46D1444", Offset = "0x46D1444", VA = "0x46D1444")]
    public APIDebugAppstoreFulfillResponse()
    {
    }
  }
}

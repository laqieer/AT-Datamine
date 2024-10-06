// Decompiled with JetBrains decompiler
// Type: Network.API.APIChargeAmountByMonthResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.API
{
  [Token(Token = "0x2001BC0")]
  [Serializable]
  public class APIChargeAmountByMonthResponse
  {
    [Token(Token = "0x40076EF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private float total_amount;
    [Token(Token = "0x40076F0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private bool is_charge_limited;
    [Token(Token = "0x40076F1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private float charge_limit;

    [Token(Token = "0x17001E30")]
    public float TotalAmount
    {
      [Token(Token = "0x600A319"), Address(RVA = "0x46CD928", Offset = "0x46CD928", VA = "0x46CD928")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001E31")]
    public bool IsChargeLimited
    {
      [Token(Token = "0x600A31A"), Address(RVA = "0x46CD930", Offset = "0x46CD930", VA = "0x46CD930")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E32")]
    public float ChargeLimit
    {
      [Token(Token = "0x600A31B"), Address(RVA = "0x46CD938", Offset = "0x46CD938", VA = "0x46CD938")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x600A31C")]
    [Address(RVA = "0x46CD940", Offset = "0x46CD940", VA = "0x46CD940")]
    public APIChargeAmountByMonthResponse()
    {
    }
  }
}

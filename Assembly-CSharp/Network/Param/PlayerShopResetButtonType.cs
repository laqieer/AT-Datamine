// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerShopResetButtonType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001ADF")]
  [Serializable]
  public class PlayerShopResetButtonType
  {
    [Token(Token = "0x400733F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private string next_at;
    [Token(Token = "0x4007340")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ShopPaymentType cost;
    [Token(Token = "0x4007341")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private int remaining_count;
    [Token(Token = "0x4007342")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private int remaining_no_cost_count;

    [Token(Token = "0x17001BA1")]
    public string NextAt
    {
      [Token(Token = "0x6009C8C"), Address(RVA = "0x48F24F8", Offset = "0x48F24F8", VA = "0x48F24F8")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6009C8D"), Address(RVA = "0x48F2500", Offset = "0x48F2500", VA = "0x48F2500")] set
      {
      }
    }

    [Token(Token = "0x17001BA2")]
    public ShopPaymentType Cost
    {
      [Token(Token = "0x6009C8E"), Address(RVA = "0x48F2508", Offset = "0x48F2508", VA = "0x48F2508")] get
      {
        return (ShopPaymentType) null;
      }
      [Token(Token = "0x6009C8F"), Address(RVA = "0x48F2510", Offset = "0x48F2510", VA = "0x48F2510")] set
      {
      }
    }

    [Token(Token = "0x17001BA3")]
    public int RemainingCount
    {
      [Token(Token = "0x6009C90"), Address(RVA = "0x48F2518", Offset = "0x48F2518", VA = "0x48F2518")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C91"), Address(RVA = "0x48F2520", Offset = "0x48F2520", VA = "0x48F2520")] set
      {
      }
    }

    [Token(Token = "0x17001BA4")]
    public int RemainingNoCostCount
    {
      [Token(Token = "0x6009C92"), Address(RVA = "0x48F2528", Offset = "0x48F2528", VA = "0x48F2528")] get
      {
        return new int();
      }
      [Token(Token = "0x6009C93"), Address(RVA = "0x48F2530", Offset = "0x48F2530", VA = "0x48F2530")] set
      {
      }
    }

    [Token(Token = "0x6009C94")]
    [Address(RVA = "0x48F2538", Offset = "0x48F2538", VA = "0x48F2538")]
    public PlayerShopResetButtonType()
    {
    }
  }
}

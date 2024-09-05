// Decompiled with JetBrains decompiler
// Type: Network.Param.ShopPaymentType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B0F")]
  [Serializable]
  public class ShopPaymentType
  {
    [Token(Token = "0x400743B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int payment_type_id;
    [Token(Token = "0x400743C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int payment_id;
    [Token(Token = "0x400743D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int payment_amount;

    [Token(Token = "0x17001C9D")]
    public int PaymentTypeId
    {
      [Token(Token = "0x6009EB4"), Address(RVA = "0x48F3680", Offset = "0x48F3680", VA = "0x48F3680")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EB5"), Address(RVA = "0x48F3688", Offset = "0x48F3688", VA = "0x48F3688")] set
      {
      }
    }

    [Token(Token = "0x17001C9E")]
    public int PaymentId
    {
      [Token(Token = "0x6009EB6"), Address(RVA = "0x48F3690", Offset = "0x48F3690", VA = "0x48F3690")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EB7"), Address(RVA = "0x48F3698", Offset = "0x48F3698", VA = "0x48F3698")] set
      {
      }
    }

    [Token(Token = "0x17001C9F")]
    public int PaymentAmount
    {
      [Token(Token = "0x6009EB8"), Address(RVA = "0x48F36A0", Offset = "0x48F36A0", VA = "0x48F36A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009EB9"), Address(RVA = "0x48F36A8", Offset = "0x48F36A8", VA = "0x48F36A8")] set
      {
      }
    }

    [Token(Token = "0x6009EBA")]
    [Address(RVA = "0x48F36B0", Offset = "0x48F36B0", VA = "0x48F36B0")]
    public ShopPaymentType()
    {
    }
  }
}

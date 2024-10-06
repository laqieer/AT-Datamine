// Decompiled with JetBrains decompiler
// Type: Network.Param.RequestPaymentType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001B09")]
  [Serializable]
  public class RequestPaymentType
  {
    [Token(Token = "0x400742B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int payment_table_id;
    [Token(Token = "0x400742C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int amount;

    [Token(Token = "0x17001C8D")]
    public int PaymentTableId
    {
      [Token(Token = "0x6009E8E"), Address(RVA = "0x48F354C", Offset = "0x48F354C", VA = "0x48F354C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E8F"), Address(RVA = "0x48F3554", Offset = "0x48F3554", VA = "0x48F3554")] set
      {
      }
    }

    [Token(Token = "0x17001C8E")]
    public int Amount
    {
      [Token(Token = "0x6009E90"), Address(RVA = "0x48F355C", Offset = "0x48F355C", VA = "0x48F355C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009E91"), Address(RVA = "0x48F3564", Offset = "0x48F3564", VA = "0x48F3564")] set
      {
      }
    }

    [Token(Token = "0x6009E92")]
    [Address(RVA = "0x48F356C", Offset = "0x48F356C", VA = "0x48F356C")]
    public RequestPaymentType()
    {
    }
  }
}

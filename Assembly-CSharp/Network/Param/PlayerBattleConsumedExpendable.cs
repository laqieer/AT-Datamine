// Decompiled with JetBrains decompiler
// Type: Network.Param.PlayerBattleConsumedExpendable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace Network.Param
{
  [Token(Token = "0x2001A8B")]
  [Serializable]
  public class PlayerBattleConsumedExpendable
  {
    [Token(Token = "0x40071C1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int payment_type_id;
    [Token(Token = "0x40071C2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int payment_id;
    [Token(Token = "0x40071C3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int payment_amount;

    [Token(Token = "0x17001A05")]
    public int PaymentTypeId
    {
      [Token(Token = "0x600991E"), Address(RVA = "0x48F06EC", Offset = "0x48F06EC", VA = "0x48F06EC")] get
      {
        return new int();
      }
      [Token(Token = "0x600991F"), Address(RVA = "0x48F06F4", Offset = "0x48F06F4", VA = "0x48F06F4")] set
      {
      }
    }

    [Token(Token = "0x17001A06")]
    public int PaymentId
    {
      [Token(Token = "0x6009920"), Address(RVA = "0x48F06FC", Offset = "0x48F06FC", VA = "0x48F06FC")] get
      {
        return new int();
      }
      [Token(Token = "0x6009921"), Address(RVA = "0x48F0704", Offset = "0x48F0704", VA = "0x48F0704")] set
      {
      }
    }

    [Token(Token = "0x17001A07")]
    public int PaymentAmount
    {
      [Token(Token = "0x6009922"), Address(RVA = "0x48F070C", Offset = "0x48F070C", VA = "0x48F070C")] get
      {
        return new int();
      }
      [Token(Token = "0x6009923"), Address(RVA = "0x48F0714", Offset = "0x48F0714", VA = "0x48F0714")] set
      {
      }
    }

    [Token(Token = "0x6009924")]
    [Address(RVA = "0x48F071C", Offset = "0x48F071C", VA = "0x48F071C")]
    public PlayerBattleConsumedExpendable()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.LpRecoveryPaymentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200136F")]
  [Serializable]
  public sealed class LpRecoveryPaymentData : IMasterDataEntity
  {
    [Token(Token = "0x4005B21")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005B22")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public PaymentTypeEnum paymentTypeId;
    [Token(Token = "0x4005B23")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int paymentId;
    [Token(Token = "0x4005B24")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17001079")]
    public int Key
    {
      [Token(Token = "0x6006D66"), Address(RVA = "0x46FC638", Offset = "0x46FC638", VA = "0x46FC638", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006D67")]
    [Address(RVA = "0x46FC640", Offset = "0x46FC640", VA = "0x46FC640", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006D68")]
    [Address(RVA = "0x46FC80C", Offset = "0x46FC80C", VA = "0x46FC80C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006D69")]
    [Address(RVA = "0x46FC8B0", Offset = "0x46FC8B0", VA = "0x46FC8B0")]
    public LpRecoveryPaymentData()
    {
    }
  }
}

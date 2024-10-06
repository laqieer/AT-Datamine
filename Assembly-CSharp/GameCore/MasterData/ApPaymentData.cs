// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ApPaymentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20010B9")]
  [Serializable]
  public sealed class ApPaymentData : IMasterDataEntity
  {
    [Token(Token = "0x4005236")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005237")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public PaymentTypeEnum paymentTypeId;
    [Token(Token = "0x4005238")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int paymentId;
    [Token(Token = "0x4005239")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17000E67")]
    public int Key
    {
      [Token(Token = "0x60060B4"), Address(RVA = "0x28D9C6C", Offset = "0x28D9C6C", VA = "0x28D9C6C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60060B5")]
    [Address(RVA = "0x28D9C74", Offset = "0x28D9C74", VA = "0x28D9C74", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x60060B6")]
    [Address(RVA = "0x28D9E40", Offset = "0x28D9E40", VA = "0x28D9E40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x60060B7")]
    [Address(RVA = "0x28D9EE4", Offset = "0x28D9EE4", VA = "0x28D9EE4")]
    public ApPaymentData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionSoulSpotExpData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA8")]
  [Serializable]
  public sealed class ExpeditionSoulSpotExpData : IMasterDataEntity
  {
    [Token(Token = "0x4004EDA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004EDB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int level;
    [Token(Token = "0x4004EDC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int from;
    [Token(Token = "0x4004EDD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int to;
    [Token(Token = "0x4004EDE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int soulType;
    [Token(Token = "0x4004EDF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public PaymentTypeEnum paymentTypeId;
    [Token(Token = "0x4004EE0")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int paymentId;
    [Token(Token = "0x4004EE1")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17000D92")]
    public int Key
    {
      [Token(Token = "0x6005BE9"), Address(RVA = "0x278721C", Offset = "0x278721C", VA = "0x278721C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BEA")]
    [Address(RVA = "0x2787224", Offset = "0x2787224", VA = "0x2787224", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BEB")]
    [Address(RVA = "0x2787570", Offset = "0x2787570", VA = "0x2787570", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BEC")]
    [Address(RVA = "0x2787654", Offset = "0x2787654", VA = "0x2787654")]
    public ExpeditionSoulSpotExpData()
    {
    }
  }
}

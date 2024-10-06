// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionPartySlotReleaseData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FA4")]
  [Serializable]
  public sealed class ExpeditionPartySlotReleaseData : IMasterDataEntity
  {
    [Token(Token = "0x4004ED3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004ED4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int partyNo;
    [Token(Token = "0x4004ED5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int slotReleaseCount;
    [Token(Token = "0x4004ED6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17000D90")]
    public int Key
    {
      [Token(Token = "0x6005BD9"), Address(RVA = "0x2786B7C", Offset = "0x2786B7C", VA = "0x2786B7C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005BDA")]
    [Address(RVA = "0x2786B84", Offset = "0x2786B84", VA = "0x2786B84", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005BDB")]
    [Address(RVA = "0x2786D50", Offset = "0x2786D50", VA = "0x2786D50", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005BDC")]
    [Address(RVA = "0x2786DF4", Offset = "0x2786DF4", VA = "0x2786DF4")]
    public ExpeditionPartySlotReleaseData()
    {
    }
  }
}

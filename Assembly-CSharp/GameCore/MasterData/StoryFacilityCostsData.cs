// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityCostsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200121D")]
  [Serializable]
  public sealed class StoryFacilityCostsData : IMasterDataEntity
  {
    [Token(Token = "0x40056B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40056B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int label;
    [Token(Token = "0x40056B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public PaymentTypeEnum paymentType;
    [Token(Token = "0x40056B3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int paymentID;
    [Token(Token = "0x40056B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000F8E")]
    public int Key
    {
      [Token(Token = "0x600673B"), Address(RVA = "0x4D2D76C", Offset = "0x4D2D76C", VA = "0x4D2D76C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600673C")]
    [Address(RVA = "0x4D2D774", Offset = "0x4D2D774", VA = "0x4D2D774", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600673D")]
    [Address(RVA = "0x4D2D9A0", Offset = "0x4D2D9A0", VA = "0x4D2D9A0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600673E")]
    [Address(RVA = "0x4D2DA54", Offset = "0x4D2DA54", VA = "0x4D2DA54")]
    public StoryFacilityCostsData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StyleAwakeMaterialData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x20013AD")]
  [Serializable]
  public sealed class StyleAwakeMaterialData : IMasterDataEntity
  {
    [Token(Token = "0x4005BAC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4005BAD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int initialRarityStar;
    [Token(Token = "0x4005BAE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public ElementTypeEnum element;
    [Token(Token = "0x4005BAF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int styleId;
    [Token(Token = "0x4005BB0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int awakeCount;
    [Token(Token = "0x4005BB1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public PaymentTypeEnum paymentTypeId;
    [Token(Token = "0x4005BB2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int paymentId;
    [Token(Token = "0x4005BB3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int paymentAmount;

    [Token(Token = "0x17001097")]
    public int Key
    {
      [Token(Token = "0x6006E82"), Address(RVA = "0x47067F0", Offset = "0x47067F0", VA = "0x47067F0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E83")]
    [Address(RVA = "0x47067F8", Offset = "0x47067F8", VA = "0x47067F8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006E84")]
    [Address(RVA = "0x4706B44", Offset = "0x4706B44", VA = "0x4706B44", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006E85")]
    [Address(RVA = "0x4706C28", Offset = "0x4706C28", VA = "0x4706C28")]
    public StyleAwakeMaterialData()
    {
    }
  }
}

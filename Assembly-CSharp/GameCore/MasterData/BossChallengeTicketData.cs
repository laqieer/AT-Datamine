// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BossChallengeTicketData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001041")]
  [Serializable]
  public sealed class BossChallengeTicketData : IMasterDataEntity
  {
    [Token(Token = "0x400508A")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x400508B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x400508C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string flavor;
    [Token(Token = "0x400508D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x400508E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x400508F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public string image;
    [Token(Token = "0x4005090")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x4005091")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public bool isSellable;

    [Token(Token = "0x17000DED")]
    public int Key
    {
      [Token(Token = "0x6005E6D"), Address(RVA = "0x28C35A0", Offset = "0x28C35A0", VA = "0x28C35A0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005E6E")]
    [Address(RVA = "0x28C35A8", Offset = "0x28C35A8", VA = "0x28C35A8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005E6F")]
    [Address(RVA = "0x28C38F8", Offset = "0x28C38F8", VA = "0x28C38F8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005E70")]
    [Address(RVA = "0x28C39E8", Offset = "0x28C39E8", VA = "0x28C39E8")]
    public BossChallengeTicketData()
    {
    }
  }
}

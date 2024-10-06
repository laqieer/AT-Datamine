// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.EnergyRecoveryData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200104E")]
  [Serializable]
  public sealed class EnergyRecoveryData : IMasterDataEntity
  {
    [Token(Token = "0x40050C6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40050C7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public RarityTypeEnum rarity;
    [Token(Token = "0x40050C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int pictureNumber;
    [Token(Token = "0x40050C9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string image;
    [Token(Token = "0x40050CA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public ItemTypeEnum itemType;
    [Token(Token = "0x40050CB")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public DateTime endAt;
    [Token(Token = "0x40050CC")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public bool isSellable;
    [Token(Token = "0x40050CD")]
    [FieldOffset(Offset = "0x40")]
    private DateTime zeroTime;

    [Token(Token = "0x17000DFB")]
    public int Key
    {
      [Token(Token = "0x6005EAF"), Address(RVA = "0x28C6454", Offset = "0x28C6454", VA = "0x28C6454", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005EB0")]
    [Address(RVA = "0x28C645C", Offset = "0x28C645C", VA = "0x28C645C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005EB1")]
    [Address(RVA = "0x28C674C", Offset = "0x28C674C", VA = "0x28C674C", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DFC")]
    public bool TimeLimit
    {
      [Token(Token = "0x6005EB2"), Address(RVA = "0x28C685C", Offset = "0x28C685C", VA = "0x28C685C")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000DFD")]
    public string Name
    {
      [Token(Token = "0x6005EB3"), Address(RVA = "0x28C68C0", Offset = "0x28C68C0", VA = "0x28C68C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000DFE")]
    public string Flavor
    {
      [Token(Token = "0x6005EB4"), Address(RVA = "0x28C699C", Offset = "0x28C699C", VA = "0x28C699C")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6005EB5")]
    [Address(RVA = "0x28C6A78", Offset = "0x28C6A78", VA = "0x28C6A78")]
    public EnergyRecoveryData()
    {
    }
  }
}

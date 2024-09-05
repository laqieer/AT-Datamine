// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildGiftData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FF5")]
  [Serializable]
  public sealed class GuildGiftData : IMasterDataEntity
  {
    [Token(Token = "0x4004FB6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FB7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x4004FB8")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int requiredContributionPoint;
    [Token(Token = "0x4004FB9")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4004FBA")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4004FBB")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000DBC")]
    public int Key
    {
      [Token(Token = "0x6005D24"), Address(RVA = "0x2791224", Offset = "0x2791224", VA = "0x2791224", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D25")]
    [Address(RVA = "0x279122C", Offset = "0x279122C", VA = "0x279122C", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D26")]
    [Address(RVA = "0x27914B8", Offset = "0x27914B8", VA = "0x27914B8", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005D27")]
    [Address(RVA = "0x2791580", Offset = "0x2791580", VA = "0x2791580")]
    public GuildGiftData()
    {
    }
  }
}

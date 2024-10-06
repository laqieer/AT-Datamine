// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildFacilityInvestRewardDescriptionData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FDA")]
  [Serializable]
  public sealed class GuildFacilityInvestRewardDescriptionData : IMasterDataEntity
  {
    [Token(Token = "0x4004F72")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004F73")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int rewardSetId;
    [Token(Token = "0x4004F74")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x4004F75")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardId;
    [Token(Token = "0x4004F76")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int quantity;

    [Token(Token = "0x17000DAF")]
    public int Key
    {
      [Token(Token = "0x6005CB3"), Address(RVA = "0x278DC0C", Offset = "0x278DC0C", VA = "0x278DC0C", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005CB4")]
    [Address(RVA = "0x278DC14", Offset = "0x278DC14", VA = "0x278DC14", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005CB5")]
    [Address(RVA = "0x278DE40", Offset = "0x278DE40", VA = "0x278DE40", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6005CB6")]
    [Address(RVA = "0x278DEF4", Offset = "0x278DEF4", VA = "0x278DEF4")]
    public GuildFacilityInvestRewardDescriptionData()
    {
    }
  }
}

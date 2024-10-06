// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.GuildRaidRewardSuppressDetailData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001007")]
  [Serializable]
  public sealed class GuildRaidRewardSuppressDetailData : IMasterDataEntity
  {
    [Token(Token = "0x4004FDA")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x4004FDB")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int suppressRewardID;
    [Token(Token = "0x4004FDC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public int ratio;
    [Token(Token = "0x4004FDD")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardType;
    [Token(Token = "0x4004FDE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x4004FDF")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000DC1")]
    public int Key
    {
      [Token(Token = "0x6005D69"), Address(RVA = "0x27935C4", Offset = "0x27935C4", VA = "0x27935C4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005D6A")]
    [Address(RVA = "0x27935CC", Offset = "0x27935CC", VA = "0x27935CC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6005D6B")]
    [Address(RVA = "0x2793858", Offset = "0x2793858", VA = "0x2793858", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x17000DC2")]
    public bool IsRewardDefeatBoss
    {
      [Token(Token = "0x6005D6C"), Address(RVA = "0x27934B8", Offset = "0x27934B8", VA = "0x27934B8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6005D6D")]
    [Address(RVA = "0x279391C", Offset = "0x279391C", VA = "0x279391C")]
    public GuildRaidRewardSuppressDetailData()
    {
    }
  }
}

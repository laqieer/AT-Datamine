// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackRankingRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200113F")]
  [Serializable]
  public sealed class ScoreAttackRankingRewardData : IMasterDataEntity
  {
    [Token(Token = "0x40053D6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053D7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int scoreAttackRankingRewardSet;
    [Token(Token = "0x40053D8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40053D9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40053DA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int amount;

    [Token(Token = "0x17000EE2")]
    public int Key
    {
      [Token(Token = "0x6006331"), Address(RVA = "0x4AE5EAC", Offset = "0x4AE5EAC", VA = "0x4AE5EAC", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006332")]
    [Address(RVA = "0x4AE5EB4", Offset = "0x4AE5EB4", VA = "0x4AE5EB4", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006333")]
    [Address(RVA = "0x4AE60E0", Offset = "0x4AE60E0", VA = "0x4AE60E0", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006334")]
    [Address(RVA = "0x4AE6194", Offset = "0x4AE6194", VA = "0x4AE6194")]
    public ScoreAttackRankingRewardData()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackScoreRewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001143")]
  [Serializable]
  public sealed class ScoreAttackScoreRewardData : IMasterDataEntity
  {
    [Token(Token = "0x40053E0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053E1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int scoreAttackScoreRewardSet;
    [Token(Token = "0x40053E2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public RewardTypeEnum rewardType;
    [Token(Token = "0x40053E3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public int rewardID;
    [Token(Token = "0x40053E4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int rewardQuantity;
    [Token(Token = "0x40053E5")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public string rewardMessage;

    [Token(Token = "0x17000EE4")]
    public int Key
    {
      [Token(Token = "0x6006341"), Address(RVA = "0x4AE66A4", Offset = "0x4AE66A4", VA = "0x4AE66A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006342")]
    [Address(RVA = "0x4AE66AC", Offset = "0x4AE66AC", VA = "0x4AE66AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x6006343")]
    [Address(RVA = "0x4AE6938", Offset = "0x4AE6938", VA = "0x4AE6938", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x6006344")]
    [Address(RVA = "0x4AE6A00", Offset = "0x4AE6A00", VA = "0x4AE6A00")]
    public ScoreAttackScoreRewardData()
    {
    }
  }
}

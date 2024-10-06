// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackRankingRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200113D")]
  [Serializable]
  public sealed class ScoreAttackRankingRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x40053D1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053D2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int scoreAttackRewardGroup;
    [Token(Token = "0x40053D3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40053D4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public int fromRanking;
    [Token(Token = "0x40053D5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int toRanking;

    [Token(Token = "0x17000EE1")]
    public int Key
    {
      [Token(Token = "0x6006329"), Address(RVA = "0x4AE5AB0", Offset = "0x4AE5AB0", VA = "0x4AE5AB0", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600632A")]
    [Address(RVA = "0x4AE5AB8", Offset = "0x4AE5AB8", VA = "0x4AE5AB8", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600632B")]
    [Address(RVA = "0x4AE5CE4", Offset = "0x4AE5CE4", VA = "0x4AE5CE4", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600632C")]
    [Address(RVA = "0x4AE5D9C", Offset = "0x4AE5D9C", VA = "0x4AE5D9C")]
    public ScoreAttackRankingRewardSetData()
    {
    }
  }
}

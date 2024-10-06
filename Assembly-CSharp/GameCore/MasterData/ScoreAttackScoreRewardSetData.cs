// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackScoreRewardSetData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001141")]
  [Serializable]
  public sealed class ScoreAttackScoreRewardSetData : IMasterDataEntity
  {
    [Token(Token = "0x40053DB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    public int ID;
    [Token(Token = "0x40053DC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    public int scoreAttackRewardGroup;
    [Token(Token = "0x40053DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public bool isCumulative;
    [Token(Token = "0x40053DE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public string name;
    [Token(Token = "0x40053DF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public int score;

    [Token(Token = "0x17000EE3")]
    public int Key
    {
      [Token(Token = "0x6006339"), Address(RVA = "0x4AE62A4", Offset = "0x4AE62A4", VA = "0x4AE62A4", Slot = "4")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600633A")]
    [Address(RVA = "0x4AE62AC", Offset = "0x4AE62AC", VA = "0x4AE62AC", Slot = "5")]
    public void Load(IMasterDataReader reader)
    {
    }

    [Token(Token = "0x600633B")]
    [Address(RVA = "0x4AE64DC", Offset = "0x4AE64DC", VA = "0x4AE64DC", Slot = "6")]
    public bool Compare(IMasterDataEntity entity) => new bool();

    [Token(Token = "0x600633C")]
    [Address(RVA = "0x4AE6594", Offset = "0x4AE6594", VA = "0x4AE6594")]
    public ScoreAttackScoreRewardSetData()
    {
    }
  }
}

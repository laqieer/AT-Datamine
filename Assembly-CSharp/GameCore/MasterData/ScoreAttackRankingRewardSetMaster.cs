// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackRankingRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200113C")]
  [Serializable]
  public sealed class ScoreAttackRankingRewardSetMaster : BaseMaster<ScoreAttackRankingRewardSetData>
  {
    [Token(Token = "0x6006325")]
    [Address(RVA = "0x4AE59A8", Offset = "0x4AE59A8", VA = "0x4AE59A8")]
    public IReadOnlyDictionary<int, ScoreAttackRankingRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackRankingRewardSetData>) null;
    }

    [Token(Token = "0x6006326")]
    [Address(RVA = "0x4AE59B0", Offset = "0x4AE59B0", VA = "0x4AE59B0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006327")]
    [Address(RVA = "0x4AE5A10", Offset = "0x4AE5A10", VA = "0x4AE5A10", Slot = "5")]
    protected override ScoreAttackRankingRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackRankingRewardSetData) null;
    }

    [Token(Token = "0x6006328")]
    [Address(RVA = "0x4AE5A68", Offset = "0x4AE5A68", VA = "0x4AE5A68")]
    public ScoreAttackRankingRewardSetMaster()
    {
    }
  }
}

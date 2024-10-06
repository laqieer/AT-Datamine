// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackRankingRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200113E")]
  [Serializable]
  public sealed class ScoreAttackRankingRewardMaster : BaseMaster<ScoreAttackRankingRewardData>
  {
    [Token(Token = "0x600632D")]
    [Address(RVA = "0x4AE5DA4", Offset = "0x4AE5DA4", VA = "0x4AE5DA4")]
    public IReadOnlyDictionary<int, ScoreAttackRankingRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackRankingRewardData>) null;
    }

    [Token(Token = "0x600632E")]
    [Address(RVA = "0x4AE5DAC", Offset = "0x4AE5DAC", VA = "0x4AE5DAC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600632F")]
    [Address(RVA = "0x4AE5E0C", Offset = "0x4AE5E0C", VA = "0x4AE5E0C", Slot = "5")]
    protected override ScoreAttackRankingRewardData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackRankingRewardData) null;
    }

    [Token(Token = "0x6006330")]
    [Address(RVA = "0x4AE5E64", Offset = "0x4AE5E64", VA = "0x4AE5E64")]
    public ScoreAttackRankingRewardMaster()
    {
    }
  }
}

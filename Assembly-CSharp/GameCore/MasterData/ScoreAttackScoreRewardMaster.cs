// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackScoreRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001142")]
  [Serializable]
  public sealed class ScoreAttackScoreRewardMaster : BaseMaster<ScoreAttackScoreRewardData>
  {
    [Token(Token = "0x600633D")]
    [Address(RVA = "0x4AE659C", Offset = "0x4AE659C", VA = "0x4AE659C")]
    public IReadOnlyDictionary<int, ScoreAttackScoreRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackScoreRewardData>) null;
    }

    [Token(Token = "0x600633E")]
    [Address(RVA = "0x4AE65A4", Offset = "0x4AE65A4", VA = "0x4AE65A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600633F")]
    [Address(RVA = "0x4AE6604", Offset = "0x4AE6604", VA = "0x4AE6604", Slot = "5")]
    protected override ScoreAttackScoreRewardData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackScoreRewardData) null;
    }

    [Token(Token = "0x6006340")]
    [Address(RVA = "0x4AE665C", Offset = "0x4AE665C", VA = "0x4AE665C")]
    public ScoreAttackScoreRewardMaster()
    {
    }
  }
}

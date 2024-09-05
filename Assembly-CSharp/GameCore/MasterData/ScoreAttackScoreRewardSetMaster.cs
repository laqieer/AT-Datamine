// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackScoreRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001140")]
  [Serializable]
  public sealed class ScoreAttackScoreRewardSetMaster : BaseMaster<ScoreAttackScoreRewardSetData>
  {
    [Token(Token = "0x6006335")]
    [Address(RVA = "0x4AE619C", Offset = "0x4AE619C", VA = "0x4AE619C")]
    public IReadOnlyDictionary<int, ScoreAttackScoreRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackScoreRewardSetData>) null;
    }

    [Token(Token = "0x6006336")]
    [Address(RVA = "0x4AE61A4", Offset = "0x4AE61A4", VA = "0x4AE61A4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006337")]
    [Address(RVA = "0x4AE6204", Offset = "0x4AE6204", VA = "0x4AE6204", Slot = "5")]
    protected override ScoreAttackScoreRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackScoreRewardSetData) null;
    }

    [Token(Token = "0x6006338")]
    [Address(RVA = "0x4AE625C", Offset = "0x4AE625C", VA = "0x4AE625C")]
    public ScoreAttackScoreRewardSetMaster()
    {
    }
  }
}

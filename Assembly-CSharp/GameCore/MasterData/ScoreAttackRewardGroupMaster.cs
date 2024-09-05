// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ScoreAttackRewardGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x200110D")]
  [Serializable]
  public sealed class ScoreAttackRewardGroupMaster : BaseMaster<ScoreAttackRewardGroupData>
  {
    [Token(Token = "0x600623C")]
    [Address(RVA = "0x4ADDC20", Offset = "0x4ADDC20", VA = "0x4ADDC20")]
    public IReadOnlyDictionary<int, ScoreAttackRewardGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ScoreAttackRewardGroupData>) null;
    }

    [Token(Token = "0x600623D")]
    [Address(RVA = "0x4ADDC28", Offset = "0x4ADDC28", VA = "0x4ADDC28", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600623E")]
    [Address(RVA = "0x4ADDC88", Offset = "0x4ADDC88", VA = "0x4ADDC88", Slot = "5")]
    protected override ScoreAttackRewardGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ScoreAttackRewardGroupData) null;
    }

    [Token(Token = "0x600623F")]
    [Address(RVA = "0x4ADDCE0", Offset = "0x4ADDCE0", VA = "0x4ADDCE0")]
    public ScoreAttackRewardGroupMaster()
    {
    }
  }
}

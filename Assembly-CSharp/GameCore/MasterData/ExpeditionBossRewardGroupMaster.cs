// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossRewardGroupMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F99")]
  [Serializable]
  public sealed class ExpeditionBossRewardGroupMaster : BaseMaster<ExpeditionBossRewardGroupData>
  {
    [Token(Token = "0x6005BA9")]
    [Address(RVA = "0x2785584", Offset = "0x2785584", VA = "0x2785584")]
    public IReadOnlyDictionary<int, ExpeditionBossRewardGroupData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBossRewardGroupData>) null;
    }

    [Token(Token = "0x6005BAA")]
    [Address(RVA = "0x278558C", Offset = "0x278558C", VA = "0x278558C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BAB")]
    [Address(RVA = "0x27855EC", Offset = "0x27855EC", VA = "0x27855EC", Slot = "5")]
    protected override ExpeditionBossRewardGroupData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBossRewardGroupData) null;
    }

    [Token(Token = "0x6005BAC")]
    [Address(RVA = "0x2785644", Offset = "0x2785644", VA = "0x2785644")]
    public ExpeditionBossRewardGroupMaster()
    {
    }
  }
}

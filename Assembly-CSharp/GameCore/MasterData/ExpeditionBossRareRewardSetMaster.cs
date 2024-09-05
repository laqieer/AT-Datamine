// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossRareRewardSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F95")]
  [Serializable]
  public sealed class ExpeditionBossRareRewardSetMaster : BaseMaster<ExpeditionBossRareRewardSetData>
  {
    [Token(Token = "0x4004EB3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionBossRareRewardSetData>> bossRewardTable;

    [Token(Token = "0x6005B92")]
    [Address(RVA = "0x27849A4", Offset = "0x27849A4", VA = "0x27849A4")]
    public IReadOnlyDictionary<int, ExpeditionBossRareRewardSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBossRareRewardSetData>) null;
    }

    [Token(Token = "0x6005B93")]
    [Address(RVA = "0x27849AC", Offset = "0x27849AC", VA = "0x27849AC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B94")]
    [Address(RVA = "0x2784A0C", Offset = "0x2784A0C", VA = "0x2784A0C", Slot = "5")]
    protected override ExpeditionBossRareRewardSetData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBossRareRewardSetData) null;
    }

    [Token(Token = "0x6005B95")]
    [Address(RVA = "0x2784A7C", Offset = "0x2784A7C", VA = "0x2784A7C")]
    private void OnLoadEntity(ExpeditionBossRareRewardSetData entity)
    {
    }

    [Token(Token = "0x6005B96")]
    [Address(RVA = "0x2784A80", Offset = "0x2784A80", VA = "0x2784A80")]
    private void GroupingByBossRewardID(ExpeditionBossRareRewardSetData entity)
    {
    }

    [Token(Token = "0x6005B97")]
    [Address(RVA = "0x27833DC", Offset = "0x27833DC", VA = "0x27833DC")]
    public IReadOnlyCollection<ExpeditionBossRareRewardSetData> GetRewardSet(int bossRewardID)
    {
      return (IReadOnlyCollection<ExpeditionBossRareRewardSetData>) null;
    }

    [Token(Token = "0x6005B98")]
    [Address(RVA = "0x2783960", Offset = "0x2783960", VA = "0x2783960")]
    public IReadOnlyCollection<ExpeditionBossRareRewardData> GetRewardData(int bossRewardID)
    {
      return (IReadOnlyCollection<ExpeditionBossRareRewardData>) null;
    }

    [Token(Token = "0x6005B99")]
    [Address(RVA = "0x2784C50", Offset = "0x2784C50", VA = "0x2784C50")]
    public ExpeditionBossRareRewardSetMaster()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossRareRewardMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F97")]
  [Serializable]
  public sealed class ExpeditionBossRareRewardMaster : BaseMaster<ExpeditionBossRareRewardData>
  {
    [Token(Token = "0x4004EB8")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionBossRareRewardData>> bossFixRewardTable;

    [Token(Token = "0x6005B9E")]
    [Address(RVA = "0x2784F60", Offset = "0x2784F60", VA = "0x2784F60")]
    public IReadOnlyDictionary<int, ExpeditionBossRareRewardData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBossRareRewardData>) null;
    }

    [Token(Token = "0x6005B9F")]
    [Address(RVA = "0x2784F68", Offset = "0x2784F68", VA = "0x2784F68", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005BA0")]
    [Address(RVA = "0x2784FC8", Offset = "0x2784FC8", VA = "0x2784FC8", Slot = "5")]
    protected override ExpeditionBossRareRewardData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBossRareRewardData) null;
    }

    [Token(Token = "0x6005BA1")]
    [Address(RVA = "0x2785038", Offset = "0x2785038", VA = "0x2785038")]
    private void OnLoadEntity(ExpeditionBossRareRewardData entity)
    {
    }

    [Token(Token = "0x6005BA2")]
    [Address(RVA = "0x278503C", Offset = "0x278503C", VA = "0x278503C")]
    private void GroupingByBossReward(ExpeditionBossRareRewardData entity)
    {
    }

    [Token(Token = "0x6005BA3")]
    [Address(RVA = "0x2784BD8", Offset = "0x2784BD8", VA = "0x2784BD8")]
    public IReadOnlyCollection<ExpeditionBossRareRewardData> GetList(
      int bossRareRewardSetDescriptionID)
    {
      return (IReadOnlyCollection<ExpeditionBossRareRewardData>) null;
    }

    [Token(Token = "0x6005BA4")]
    [Address(RVA = "0x2785194", Offset = "0x2785194", VA = "0x2785194")]
    public ExpeditionBossRareRewardMaster()
    {
    }
  }
}

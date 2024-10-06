// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossEnemyDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F91")]
  [Serializable]
  public sealed class ExpeditionBossEnemyDescriptionMaster : 
    BaseMaster<ExpeditionBossEnemyDescriptionData>
  {
    [Token(Token = "0x4004EA4")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionBossEnemyDescriptionData>> bossEnemyTable;

    [Token(Token = "0x6005B7B")]
    [Address(RVA = "0x2783C50", Offset = "0x2783C50", VA = "0x2783C50")]
    public IReadOnlyDictionary<int, ExpeditionBossEnemyDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBossEnemyDescriptionData>) null;
    }

    [Token(Token = "0x6005B7C")]
    [Address(RVA = "0x2783C58", Offset = "0x2783C58", VA = "0x2783C58", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B7D")]
    [Address(RVA = "0x2783CB8", Offset = "0x2783CB8", VA = "0x2783CB8", Slot = "5")]
    protected override ExpeditionBossEnemyDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBossEnemyDescriptionData) null;
    }

    [Token(Token = "0x6005B7E")]
    [Address(RVA = "0x2783D28", Offset = "0x2783D28", VA = "0x2783D28")]
    private void OnLoadEntity(ExpeditionBossEnemyDescriptionData entity)
    {
    }

    [Token(Token = "0x6005B7F")]
    [Address(RVA = "0x2783D2C", Offset = "0x2783D2C", VA = "0x2783D2C")]
    private void GroupingByEnemyID(ExpeditionBossEnemyDescriptionData entity)
    {
    }

    [Token(Token = "0x6005B80")]
    [Address(RVA = "0x2782EE4", Offset = "0x2782EE4", VA = "0x2782EE4")]
    public IReadOnlyCollection<ExpeditionBossEnemyDescriptionData> GetList(int bossEnemy)
    {
      return (IReadOnlyCollection<ExpeditionBossEnemyDescriptionData>) null;
    }

    [Token(Token = "0x6005B81")]
    [Address(RVA = "0x2783E84", Offset = "0x2783E84", VA = "0x2783E84")]
    public ExpeditionBossEnemyDescriptionMaster()
    {
    }
  }
}

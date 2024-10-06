// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionBossOwnPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000F93")]
  [Serializable]
  public sealed class ExpeditionBossOwnPlacementDescriptionMaster : 
    BaseMaster<ExpeditionBossOwnPlacementDescriptionData>
  {
    [Token(Token = "0x4004EAD")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionBossOwnPlacementDescriptionData>> bossEnemyTable;

    [Token(Token = "0x6005B87")]
    [Address(RVA = "0x27843F0", Offset = "0x27843F0", VA = "0x27843F0")]
    public IReadOnlyDictionary<int, ExpeditionBossOwnPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionBossOwnPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005B88")]
    [Address(RVA = "0x27843F8", Offset = "0x27843F8", VA = "0x27843F8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005B89")]
    [Address(RVA = "0x2784458", Offset = "0x2784458", VA = "0x2784458", Slot = "5")]
    protected override ExpeditionBossOwnPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (ExpeditionBossOwnPlacementDescriptionData) null;
    }

    [Token(Token = "0x6005B8A")]
    [Address(RVA = "0x27844C8", Offset = "0x27844C8", VA = "0x27844C8")]
    private void OnLoadEntity(ExpeditionBossOwnPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x6005B8B")]
    [Address(RVA = "0x27844CC", Offset = "0x27844CC", VA = "0x27844CC")]
    private void GroupingByPlacementID(ExpeditionBossOwnPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x6005B8C")]
    [Address(RVA = "0x2782DE8", Offset = "0x2782DE8", VA = "0x2782DE8")]
    public IReadOnlyCollection<ExpeditionBossOwnPlacementDescriptionData> GetList(int placementID)
    {
      return (IReadOnlyCollection<ExpeditionBossOwnPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005B8D")]
    [Address(RVA = "0x2784624", Offset = "0x2784624", VA = "0x2784624")]
    public ExpeditionBossOwnPlacementDescriptionMaster()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleRaidEnemyPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E3E")]
  [Serializable]
  public sealed class BattleRaidEnemyPlacementDescriptionMaster : 
    BaseMaster<BattleRaidEnemyPlacementDescriptionData>
  {
    [Token(Token = "0x4004405")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleRaidEnemyPlacementDescriptionData>> mapData;

    [Token(Token = "0x60056C5")]
    [Address(RVA = "0x3E395DC", Offset = "0x3E395DC", VA = "0x3E395DC")]
    public IReadOnlyDictionary<int, BattleRaidEnemyPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleRaidEnemyPlacementDescriptionData>) null;
    }

    [Token(Token = "0x60056C6")]
    [Address(RVA = "0x3E395E4", Offset = "0x3E395E4", VA = "0x3E395E4", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60056C7")]
    [Address(RVA = "0x3E39644", Offset = "0x3E39644", VA = "0x3E39644", Slot = "5")]
    protected override BattleRaidEnemyPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleRaidEnemyPlacementDescriptionData) null;
    }

    [Token(Token = "0x60056C8")]
    [Address(RVA = "0x3E396B4", Offset = "0x3E396B4", VA = "0x3E396B4")]
    private void OnLoadEntity(BattleRaidEnemyPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x60056C9")]
    [Address(RVA = "0x3E39808", Offset = "0x3E39808", VA = "0x3E39808")]
    public IReadOnlyList<BattleRaidEnemyPlacementDescriptionData> GetById(int placementId)
    {
      return (IReadOnlyList<BattleRaidEnemyPlacementDescriptionData>) null;
    }

    [Token(Token = "0x60056CA")]
    [Address(RVA = "0x3E398C4", Offset = "0x3E398C4", VA = "0x3E398C4")]
    public BattleRaidEnemyPlacementDescriptionMaster()
    {
    }
  }
}

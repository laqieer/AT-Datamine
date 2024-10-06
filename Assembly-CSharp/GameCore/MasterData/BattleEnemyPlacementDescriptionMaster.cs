// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEnemyPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E38")]
  [Serializable]
  public sealed class BattleEnemyPlacementDescriptionMaster : 
    BaseMaster<BattleEnemyPlacementDescriptionData>
  {
    [Token(Token = "0x40043E3")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleEnemyPlacementDescriptionData>> mapData;

    [Token(Token = "0x6005692")]
    [Address(RVA = "0x3E37CF4", Offset = "0x3E37CF4", VA = "0x3E37CF4")]
    public IReadOnlyDictionary<int, BattleEnemyPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleEnemyPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005693")]
    [Address(RVA = "0x3E37CFC", Offset = "0x3E37CFC", VA = "0x3E37CFC", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005694")]
    [Address(RVA = "0x3E37D5C", Offset = "0x3E37D5C", VA = "0x3E37D5C", Slot = "5")]
    protected override BattleEnemyPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleEnemyPlacementDescriptionData) null;
    }

    [Token(Token = "0x6005695")]
    [Address(RVA = "0x3E37DCC", Offset = "0x3E37DCC", VA = "0x3E37DCC")]
    private void OnLoadEntity(BattleEnemyPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x6005696")]
    [Address(RVA = "0x3E37F20", Offset = "0x3E37F20", VA = "0x3E37F20")]
    public IReadOnlyList<BattleEnemyPlacementDescriptionData> GetById(int placementId)
    {
      return (IReadOnlyList<BattleEnemyPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005697")]
    [Address(RVA = "0x3E37FDC", Offset = "0x3E37FDC", VA = "0x3E37FDC")]
    public BattleEnemyPlacementDescriptionMaster()
    {
    }
  }
}

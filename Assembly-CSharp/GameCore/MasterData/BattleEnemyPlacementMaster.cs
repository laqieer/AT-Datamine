// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEnemyPlacementMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E3A")]
  [Serializable]
  public sealed class BattleEnemyPlacementMaster : BaseMaster<BattleEnemyPlacementData>
  {
    [Token(Token = "0x60056B0")]
    [Address(RVA = "0x3E38CA8", Offset = "0x3E38CA8", VA = "0x3E38CA8")]
    public IReadOnlyDictionary<int, BattleEnemyPlacementData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleEnemyPlacementData>) null;
    }

    [Token(Token = "0x60056B1")]
    [Address(RVA = "0x3E38CB0", Offset = "0x3E38CB0", VA = "0x3E38CB0", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60056B2")]
    [Address(RVA = "0x3E38D10", Offset = "0x3E38D10", VA = "0x3E38D10", Slot = "5")]
    protected override BattleEnemyPlacementData LoadEntity(IMasterDataReader reader)
    {
      return (BattleEnemyPlacementData) null;
    }

    [Token(Token = "0x60056B3")]
    [Address(RVA = "0x3E38D68", Offset = "0x3E38D68", VA = "0x3E38D68")]
    public BattleEnemyPlacementMaster()
    {
    }
  }
}

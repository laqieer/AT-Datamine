// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleEnemyTroopsMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E3C")]
  [Serializable]
  public sealed class BattleEnemyTroopsMaster : BaseMaster<BattleEnemyTroopsData>, ITroopsMaster
  {
    [Token(Token = "0x40043FF")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleEnemyTroopsData>> mapData;

    [Token(Token = "0x60056B8")]
    [Address(RVA = "0x3E38F54", Offset = "0x3E38F54", VA = "0x3E38F54")]
    public IReadOnlyDictionary<int, BattleEnemyTroopsData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleEnemyTroopsData>) null;
    }

    [Token(Token = "0x60056B9")]
    [Address(RVA = "0x3E38F5C", Offset = "0x3E38F5C", VA = "0x3E38F5C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x60056BA")]
    [Address(RVA = "0x3E38FBC", Offset = "0x3E38FBC", VA = "0x3E38FBC", Slot = "5")]
    protected override BattleEnemyTroopsData LoadEntity(IMasterDataReader reader)
    {
      return (BattleEnemyTroopsData) null;
    }

    [Token(Token = "0x60056BB")]
    [Address(RVA = "0x3E3902C", Offset = "0x3E3902C", VA = "0x3E3902C")]
    private void OnLoadEntity(BattleEnemyTroopsData entity)
    {
    }

    [Token(Token = "0x60056BC")]
    [Address(RVA = "0x3E39180", Offset = "0x3E39180", VA = "0x3E39180", Slot = "6")]
    public IReadOnlyList<ITroopsData> GetTroops(int placementId)
    {
      return (IReadOnlyList<ITroopsData>) null;
    }

    [Token(Token = "0x60056BD")]
    [Address(RVA = "0x3E3923C", Offset = "0x3E3923C", VA = "0x3E3923C")]
    public BattleEnemyTroopsMaster()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleDropSetMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E36")]
  [Serializable]
  public sealed class BattleDropSetMaster : BaseMaster<BattleDropSetData>
  {
    [Token(Token = "0x40043DD")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleDropSetData>> dropTable;

    [Token(Token = "0x6005687")]
    [Address(RVA = "0x3E3761C", Offset = "0x3E3761C", VA = "0x3E3761C")]
    public IReadOnlyDictionary<int, BattleDropSetData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleDropSetData>) null;
    }

    [Token(Token = "0x6005688")]
    [Address(RVA = "0x3E37624", Offset = "0x3E37624", VA = "0x3E37624", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005689")]
    [Address(RVA = "0x3E37684", Offset = "0x3E37684", VA = "0x3E37684", Slot = "5")]
    protected override BattleDropSetData LoadEntity(IMasterDataReader reader)
    {
      return (BattleDropSetData) null;
    }

    [Token(Token = "0x600568A")]
    [Address(RVA = "0x3E376F4", Offset = "0x3E376F4", VA = "0x3E376F4")]
    private void OnLoadEntity(BattleDropSetData entity)
    {
    }

    [Token(Token = "0x600568B")]
    [Address(RVA = "0x3E376F8", Offset = "0x3E376F8", VA = "0x3E376F8")]
    private void GroupingByDrop(BattleDropSetData entity)
    {
    }

    [Token(Token = "0x600568C")]
    [Address(RVA = "0x3E378B4", Offset = "0x3E378B4", VA = "0x3E378B4")]
    public List<BattleDropSetData> GetListByDrop(int drop) => (List<BattleDropSetData>) null;

    [Token(Token = "0x600568D")]
    [Address(RVA = "0x3E37970", Offset = "0x3E37970", VA = "0x3E37970")]
    public BattleDropSetMaster()
    {
    }
  }
}

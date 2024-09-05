// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ArenaFacilityPlacementMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000DDA")]
  [Serializable]
  public sealed class ArenaFacilityPlacementMaster : BaseMaster<ArenaFacilityPlacementData>
  {
    [Token(Token = "0x4004256")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ArenaFacilityPlacementData>> mapData;

    [Token(Token = "0x6005498")]
    [Address(RVA = "0x3AA677C", Offset = "0x3AA677C", VA = "0x3AA677C")]
    public IReadOnlyDictionary<int, ArenaFacilityPlacementData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ArenaFacilityPlacementData>) null;
    }

    [Token(Token = "0x6005499")]
    [Address(RVA = "0x3AA6784", Offset = "0x3AA6784", VA = "0x3AA6784", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x600549A")]
    [Address(RVA = "0x3AA67E4", Offset = "0x3AA67E4", VA = "0x3AA67E4", Slot = "5")]
    protected override ArenaFacilityPlacementData LoadEntity(IMasterDataReader reader)
    {
      return (ArenaFacilityPlacementData) null;
    }

    [Token(Token = "0x600549B")]
    [Address(RVA = "0x3AA6854", Offset = "0x3AA6854", VA = "0x3AA6854")]
    private void OnLoadEntity(ArenaFacilityPlacementData entity)
    {
    }

    [Token(Token = "0x600549C")]
    [Address(RVA = "0x3AA69A8", Offset = "0x3AA69A8", VA = "0x3AA69A8")]
    public IReadOnlyList<ArenaFacilityPlacementData> GetById(int placementGroup)
    {
      return (IReadOnlyList<ArenaFacilityPlacementData>) null;
    }

    [Token(Token = "0x600549D")]
    [Address(RVA = "0x3AA6A64", Offset = "0x3AA6A64", VA = "0x3AA6A64")]
    public ArenaFacilityPlacementMaster()
    {
    }
  }
}

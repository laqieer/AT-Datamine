// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.ExpeditionStageOwnPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000FB3")]
  [Serializable]
  public sealed class ExpeditionStageOwnPlacementDescriptionMaster : 
    BaseMaster<ExpeditionStageOwnPlacementDescriptionData>
  {
    [Token(Token = "0x4004F06")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<ExpeditionStageOwnPlacementDescriptionData>> placementTable;

    [Token(Token = "0x6005C1F")]
    [Address(RVA = "0x278952C", Offset = "0x278952C", VA = "0x278952C")]
    public IReadOnlyDictionary<int, ExpeditionStageOwnPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, ExpeditionStageOwnPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005C20")]
    [Address(RVA = "0x2789534", Offset = "0x2789534", VA = "0x2789534", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005C21")]
    [Address(RVA = "0x2789594", Offset = "0x2789594", VA = "0x2789594", Slot = "5")]
    protected override ExpeditionStageOwnPlacementDescriptionData LoadEntity(
      IMasterDataReader reader)
    {
      return (ExpeditionStageOwnPlacementDescriptionData) null;
    }

    [Token(Token = "0x6005C22")]
    [Address(RVA = "0x2789604", Offset = "0x2789604", VA = "0x2789604")]
    private void OnLoadEntity(ExpeditionStageOwnPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x6005C23")]
    [Address(RVA = "0x2789608", Offset = "0x2789608", VA = "0x2789608")]
    private void GroupingByPlacementID(ExpeditionStageOwnPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x6005C24")]
    [Address(RVA = "0x278881C", Offset = "0x278881C", VA = "0x278881C")]
    public IReadOnlyCollection<ExpeditionStageOwnPlacementDescriptionData> GetList(int placement)
    {
      return (IReadOnlyCollection<ExpeditionStageOwnPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005C25")]
    [Address(RVA = "0x2789760", Offset = "0x2789760", VA = "0x2789760")]
    public ExpeditionStageOwnPlacementDescriptionMaster()
    {
    }
  }
}

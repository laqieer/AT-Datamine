// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.BattleFacilityPlacementDescriptionMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2000E5C")]
  [Serializable]
  public sealed class BattleFacilityPlacementDescriptionMaster : 
    BaseMaster<BattleFacilityPlacementDescriptionData>
  {
    [Token(Token = "0x400457B")]
    public const string TEXT_AB = "text_masterdata_battle";
    [Token(Token = "0x400457C")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<BattleFacilityPlacementDescriptionData>> mapData;

    [Token(Token = "0x6005786")]
    [Address(RVA = "0x3E412E0", Offset = "0x3E412E0", VA = "0x3E412E0")]
    public IReadOnlyDictionary<int, BattleFacilityPlacementDescriptionData> GetEntities()
    {
      return (IReadOnlyDictionary<int, BattleFacilityPlacementDescriptionData>) null;
    }

    [Token(Token = "0x6005787")]
    [Address(RVA = "0x3E412E8", Offset = "0x3E412E8", VA = "0x3E412E8", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6005788")]
    [Address(RVA = "0x3E41348", Offset = "0x3E41348", VA = "0x3E41348", Slot = "5")]
    protected override BattleFacilityPlacementDescriptionData LoadEntity(IMasterDataReader reader)
    {
      return (BattleFacilityPlacementDescriptionData) null;
    }

    [Token(Token = "0x6005789")]
    [Address(RVA = "0x3E413B8", Offset = "0x3E413B8", VA = "0x3E413B8")]
    private void OnLoadEntity(BattleFacilityPlacementDescriptionData entity)
    {
    }

    [Token(Token = "0x600578A")]
    [Address(RVA = "0x3E4150C", Offset = "0x3E4150C", VA = "0x3E4150C")]
    public IReadOnlyList<BattleFacilityPlacementDescriptionData> GetById(int placementId)
    {
      return (IReadOnlyList<BattleFacilityPlacementDescriptionData>) null;
    }

    [Token(Token = "0x600578B")]
    [Address(RVA = "0x3E415C8", Offset = "0x3E415C8", VA = "0x3E415C8")]
    public BattleFacilityPlacementDescriptionMaster()
    {
    }
  }
}

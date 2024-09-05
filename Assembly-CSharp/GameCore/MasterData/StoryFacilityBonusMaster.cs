// Decompiled with JetBrains decompiler
// Type: GameCore.MasterData.StoryFacilityBonusMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 815152EA-6EB1-4874-BFD7-95E0AD7F491D
// Assembly location: C:\r\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace GameCore.MasterData
{
  [Token(Token = "0x2001216")]
  [Serializable]
  public sealed class StoryFacilityBonusMaster : BaseMaster<StoryFacilityBonusData>
  {
    [Token(Token = "0x4005699")]
    [FieldOffset(Offset = "0x18")]
    private Dictionary<int, List<StoryFacilityBonusData>> groupingTable;

    [Token(Token = "0x6006717")]
    [Address(RVA = "0x4D2C394", Offset = "0x4D2C394", VA = "0x4D2C394")]
    public IReadOnlyDictionary<int, StoryFacilityBonusData> GetEntities()
    {
      return (IReadOnlyDictionary<int, StoryFacilityBonusData>) null;
    }

    [Token(Token = "0x6006718")]
    [Address(RVA = "0x4D2C39C", Offset = "0x4D2C39C", VA = "0x4D2C39C", Slot = "4")]
    public override void Load(IMasterDataReader reader, int count)
    {
    }

    [Token(Token = "0x6006719")]
    [Address(RVA = "0x4D2C460", Offset = "0x4D2C460", VA = "0x4D2C460", Slot = "5")]
    protected override StoryFacilityBonusData LoadEntity(IMasterDataReader reader)
    {
      return (StoryFacilityBonusData) null;
    }

    [Token(Token = "0x600671A")]
    [Address(RVA = "0x4D2C404", Offset = "0x4D2C404", VA = "0x4D2C404")]
    private void OnAwakeLoading()
    {
    }

    [Token(Token = "0x600671B")]
    [Address(RVA = "0x4D2C4D0", Offset = "0x4D2C4D0", VA = "0x4D2C4D0")]
    private void OnLoadEntity(StoryFacilityBonusData entity)
    {
    }

    [Token(Token = "0x600671C")]
    [Address(RVA = "0x4D2C4D4", Offset = "0x4D2C4D4", VA = "0x4D2C4D4")]
    private void Grouping(StoryFacilityBonusData entity)
    {
    }

    [Token(Token = "0x600671D")]
    [Address(RVA = "0x4D2C650", Offset = "0x4D2C650", VA = "0x4D2C650")]
    public IReadOnlyCollection<StoryFacilityBonusData> GetByFacilityAttachID(int facilityAttachID)
    {
      return (IReadOnlyCollection<StoryFacilityBonusData>) null;
    }

    [Token(Token = "0x600671E")]
    [Address(RVA = "0x4D2C70C", Offset = "0x4D2C70C", VA = "0x4D2C70C")]
    public StoryFacilityBonusMaster()
    {
    }
  }
}
